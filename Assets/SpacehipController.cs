using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class SpacehipController : MonoBehaviour
{

    private PlayerInput playerInput;
    private Rigidbody rigidBody;

    private Vector2 screenSize = new Vector2(Screen.width, Screen.height);
    private Vector2 screenCenter = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f);
    private Vector2 mousePosition = new Vector2(0, 0);
    private Vector2 mousePositionClamped = new Vector2(0, 0);

    private Vector2 mouseDistanceFromCenter = new Vector2(0, 0);

    private Vector3 turnVector = new Vector3(0, 0, 0);
    private float rollZ = 0.0f;
    private Vector3 strafeMove = new Vector3(0, 0, 0);
    private Vector3 thrustMove = new Vector3(0, 0, 0);
    private float turn_accelerationX = 0.0f;
    private float turn_accelerationY = 0.0f;

    private float throttle = 0.0f;
    private float turnSpeed = 90.0f;
    private float smooth = 5.0f;

    private void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);

        rigidBody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
        playerInput.onActionTriggered += PlayerInput_onActionTriggered;
    }

    private void Update()
    {

        mouseDistanceFromCenter.x = (mousePositionClamped.x - screenCenter.x) / screenCenter.y;
        mouseDistanceFromCenter.y = (mousePositionClamped.y - screenCenter.y) / screenCenter.y; // cause for some reason its inverted.

        mouseDistanceFromCenter = Vector2.ClampMagnitude(mouseDistanceFromCenter, 1f);

        turn_accelerationX = mouseDistanceFromCenter.x * turnSpeed * Time.deltaTime;
        turn_accelerationY = -1 * mouseDistanceFromCenter.y * turnSpeed * Time.deltaTime;

        turnVector = new Vector3(turn_accelerationY, turn_accelerationX, rollZ);

        transform.DORotate(turnVector, Time.deltaTime, RotateMode.LocalAxisAdd); // <--- works great but I still want to implement simple rigid body controls.
        /* rigidBody.MoveRotation(turnHorizontal);
        rigidBody.MoveRotation(); */

        transform.Translate(strafeMove.x, strafeMove.y, throttle);
        // don't ask why but for some reason its Y , X ,Z and not X,Y Z

    }

    private void PlayerInput_onActionTriggered(InputAction.CallbackContext context)
    {
        if (context.action.name == "Strafe")
        {
            strafeMove = context.action.ReadValue<Vector2>(); // used in FixedUpdate
        }

        if (context.action.name == "MousePosition")
        {
            mousePosition = context.action.ReadValue<Vector2>(); // used in FixedUpdate
            mousePositionClamped.x = Mathf.Clamp(mousePosition.x, 0, screenSize.x);
            mousePositionClamped.y = Mathf.Clamp(mousePosition.y, 0, screenSize.y);
            //Debug.Log($"mouse pos : {mousePositionClamped.x}, y: {mousePositionClamped.y}");
        }

        if (context.action.name == "Roll")
        {
            rollZ = context.action.ReadValue<float>();
        }

        if (context.action.name == "Thrust")
        {
            ChangeThrust(context.action.ReadValue<float>());
        }
    }

    private void ChangeThrust(float acceleration)
    {
        throttle += acceleration;
    }

    private void SpaceBreak()
    {
        throttle = 0.0f;
    }

}
