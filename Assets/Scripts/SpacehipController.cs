using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
using Cinemachine;

public class SpacehipController : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private Rigidbody rigidBody;

    [SerializeField]
    private GameObject debugSpawnObject;
    [SerializeField]
    private GameObject targetGizmo;
    public GameObject Target { get; private set; } = null;

    public bool[] Weapons{ get; private set; } = { false, false, false, false };

    private float thrust;
    private float rollZAxis;
    private float throttle;

    private bool realign;
    private bool spaceBreak;

    private Vector2 strafeDirection;
    private Vector2 mousePosition;

    private const float turnSpeed = 100;

    private void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);

    }

    private void Update()
    {

        // Get inputs from input manager singleton instance
        thrust = InputManager.Instance.ThrustMove;
        rollZAxis = InputManager.Instance.RollMove;
        realign = InputManager.Instance.Realign;
        strafeDirection = InputManager.Instance.StrafeMove;
        spaceBreak = InputManager.Instance.SpaceBreak;
        mousePosition = InputManager.Instance.MousePosition;

        ToggleWeaponGroup(InputManager.Instance.ToggleWeapon1, 1);

        ChangeThrottle(thrust);

        Debug.DrawLine(transform.localPosition, transform.forward * 100);    // works perfect. Delete when done
        
        
        transform.Translate(Vector3.forward * throttle * Time.deltaTime); 
        
        if (InputManager.Instance.Select) { SelectTarget();}
        if (spaceBreak) { SpaceBreak(); }
    }

    private void LateUpdate()
    {
        if (realign) { RotateTowardsPoint(); }
    }



    private void ChangeThrottle(float thrust)
    {
        throttle += thrust;
    }

    private void SpaceBreak()
    {
        throttle = 0.0f;
    }

    private void ToggleWeaponGroup(bool toggle, int num)
    {
        if (toggle) 
        {
            Weapons[num] = !Weapons[num];
        }
    }

    private void SelectTarget()  //  makes a raycast and sets the target if it his
    {
        Ray ray = Camera.main.ScreenPointToRay(InputManager.Instance.MousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity)) 
        {
            if (hit.collider.CompareTag("Ship") == true) 
            {
                Debug.Log($"Selected {hit.collider.gameObject.name}");// casts a ray into the distance and rturns the target. 
                SetTarget( hit.collider.gameObject) ;
            }
        }
    }

    private Vector3 MouseScreencastToRange(int range) 
    {
        // grabs a point in the far distance in the direction of the mouse click  so I can do a lookAt towards that point.   
        Ray ray = Camera.main.ScreenPointToRay(InputManager.Instance.MousePosition);
        return (ray.origin + (ray.direction * range));   
    }

    private void SetTarget(GameObject target)   
    {
        targetGizmo.SetActive(false);
        Target = target;
        targetGizmo.transform.position = target.transform.position;
        targetGizmo.transform.parent = target.transform;
        targetGizmo.SetActive(true);
    }

    private void RotateTowardsPoint() 
    // Rotate the ship to look towards a raycast that creates a point in the distance.
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //shoots ray from the camera to the center of the viewport.
        Vector3 pointInDistance = (ray.origin + (ray.direction * 1000)); 
        transform.DOLookAt(pointInDistance, turnSpeed * Time.deltaTime);
        rigidBody.DOLookAt(pointInDistance, turnSpeed * Time.deltaTime);
    }


}
