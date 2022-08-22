using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    // The Input Manager just reads the inputs and process them if need be, then they can be used by other classes as needed.


    public InputActionAsset actionAsset;

    public Vector2 MouseDeltaLook { get; private set; }
    public Vector2 MousePosition { get; private set; }

    public Vector2 StrafeMove { get; private set; }

    public bool Realign { get; private set; }
    public bool SpaceBreak { get; private set; }
    public bool CameraRotateToggle { get; private set; }
    public bool ToggleWeapon1 { get; private set; }
    public bool Select { get; private set; }


    public float RollMove { get; private set; }
    public float ThrustMove { get; private set; }
    public float ScrollMouse { get; private set; }

    #region Singleton
    public static InputManager Instance { get; private set; }
    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


    }
    #endregion

    void OnEnable()
    {
        actionAsset.Enable();
    }

    void OnDisable()
    {
        actionAsset.Disable();
    }

    private void Update()
    {
        InputActionMap actionMap = actionAsset.actionMaps[0];

        MouseDeltaLook = actionMap.FindAction("Look").ReadValue<Vector2>();
        MousePosition = actionMap.FindAction("MousePosition").ReadValue<Vector2>();
        StrafeMove = actionMap.FindAction("Strafe").ReadValue<Vector2>();

        Select = actionMap.FindAction("Select").IsPressed();
        Realign = actionMap.FindAction("Realign").IsPressed();
        SpaceBreak = actionMap.FindAction("SpaceBreak").IsPressed();
        CameraRotateToggle= actionMap.FindAction("CameraRotationMod").IsPressed();
        ToggleWeapon1 = actionMap.FindAction("ActivateWeapon1").IsPressed();

        RollMove = actionMap.FindAction("Roll").ReadValue<float>();
        ThrustMove = actionMap.FindAction("Thrust").ReadValue<float>();
        ScrollMouse = actionMap.FindAction("MouseScroll").ReadValue<float>();

    }

}
