//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/SpaceCraft Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @SpaceCraftControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpaceCraftControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpaceCraft Controls"",
    ""maps"": [
        {
            ""name"": ""ShipControls"",
            ""id"": ""bbcead76-a74d-4381-a2d9-4d7d5016a999"",
            ""actions"": [
                {
                    ""name"": ""Strafe"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9c4bdbe9-fe03-4ba8-bea6-285dc6cef503"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""494e9b4c-1b63-41cd-a852-0265fa63d6c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Thrust"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d00ff48c-5ff9-4de5-8a1e-f89637d1188b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad86160c-fec0-4c2e-8326-4b79218de5f1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5dd831cf-e09f-4782-a43f-366c65f98209"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraRotationMod"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6d52d873-8adf-4c9e-ab97-43b80c3a769e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Realign"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f6d6fbec-5db6-4141-9f6f-1aea7bfb0701"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpaceBreak"",
                    ""type"": ""Button"",
                    ""id"": ""88a11788-e5c7-4c8a-abb3-845147e315cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseScroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fddf232a-19a3-41ac-8046-bc619856c8ad"",
                    ""expectedControlType"": """",
                    ""processors"": ""Clamp(min=-5,max=5),Invert"",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateWeapon1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""624336b8-69e5-48ea-b09f-83e3890a9659"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b2312df1-d31a-4315-9cef-942281b75ca9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""StrafeKB"",
                    ""id"": ""bcec3f52-2ab5-416d-b9cf-379eee79e427"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""9384b4d3-2710-4422-8a14-97a5533e379d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""a1db6558-9f1f-46c1-9280-eb2a9b6bf306"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""6b5cce74-6b97-4c26-889f-a277f0a033b0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""0186a322-f797-496b-9ff2-dab90945f28f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ThrustKB"",
                    ""id"": ""a573a423-1927-4499-ab51-708e84f05761"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7a1974bf-3cb5-4c08-b86d-f3b908facdd3"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""60f67e46-68e4-4491-8a86-48c8aad452da"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RollKB"",
                    ""id"": ""dc752457-e738-43ce-aaf5-60a773e206df"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f591a624-d97e-4538-bfbc-474a75fd4495"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""73f6140c-6c32-4c23-9ad4-1e3bfa69c04a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e84f9-8283-4723-bf51-fb9a352e1746"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c14c3a4-8b46-4079-8b07-0dad777caaa5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afb3b266-d807-48ca-b895-5f6e6016d274"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotationMod"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57328f53-1927-467e-94ab-b3bd063ca85b"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Realign"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c70ef74-990a-4fe9-880e-3d72cc050997"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpaceBreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b276262-ac50-4176-a3d5-813e8d60cf82"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11dbb683-8187-4e1f-a13f-25df1d2d99cb"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateWeapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78c5fe5f-2813-4b1b-b9cb-876b86a63334"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ShipControls
        m_ShipControls = asset.FindActionMap("ShipControls", throwIfNotFound: true);
        m_ShipControls_Strafe = m_ShipControls.FindAction("Strafe", throwIfNotFound: true);
        m_ShipControls_Roll = m_ShipControls.FindAction("Roll", throwIfNotFound: true);
        m_ShipControls_Thrust = m_ShipControls.FindAction("Thrust", throwIfNotFound: true);
        m_ShipControls_Look = m_ShipControls.FindAction("Look", throwIfNotFound: true);
        m_ShipControls_MousePosition = m_ShipControls.FindAction("MousePosition", throwIfNotFound: true);
        m_ShipControls_CameraRotationMod = m_ShipControls.FindAction("CameraRotationMod", throwIfNotFound: true);
        m_ShipControls_Realign = m_ShipControls.FindAction("Realign", throwIfNotFound: true);
        m_ShipControls_SpaceBreak = m_ShipControls.FindAction("SpaceBreak", throwIfNotFound: true);
        m_ShipControls_MouseScroll = m_ShipControls.FindAction("MouseScroll", throwIfNotFound: true);
        m_ShipControls_ActivateWeapon1 = m_ShipControls.FindAction("ActivateWeapon1", throwIfNotFound: true);
        m_ShipControls_Select = m_ShipControls.FindAction("Select", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ShipControls
    private readonly InputActionMap m_ShipControls;
    private IShipControlsActions m_ShipControlsActionsCallbackInterface;
    private readonly InputAction m_ShipControls_Strafe;
    private readonly InputAction m_ShipControls_Roll;
    private readonly InputAction m_ShipControls_Thrust;
    private readonly InputAction m_ShipControls_Look;
    private readonly InputAction m_ShipControls_MousePosition;
    private readonly InputAction m_ShipControls_CameraRotationMod;
    private readonly InputAction m_ShipControls_Realign;
    private readonly InputAction m_ShipControls_SpaceBreak;
    private readonly InputAction m_ShipControls_MouseScroll;
    private readonly InputAction m_ShipControls_ActivateWeapon1;
    private readonly InputAction m_ShipControls_Select;
    public struct ShipControlsActions
    {
        private @SpaceCraftControls m_Wrapper;
        public ShipControlsActions(@SpaceCraftControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Strafe => m_Wrapper.m_ShipControls_Strafe;
        public InputAction @Roll => m_Wrapper.m_ShipControls_Roll;
        public InputAction @Thrust => m_Wrapper.m_ShipControls_Thrust;
        public InputAction @Look => m_Wrapper.m_ShipControls_Look;
        public InputAction @MousePosition => m_Wrapper.m_ShipControls_MousePosition;
        public InputAction @CameraRotationMod => m_Wrapper.m_ShipControls_CameraRotationMod;
        public InputAction @Realign => m_Wrapper.m_ShipControls_Realign;
        public InputAction @SpaceBreak => m_Wrapper.m_ShipControls_SpaceBreak;
        public InputAction @MouseScroll => m_Wrapper.m_ShipControls_MouseScroll;
        public InputAction @ActivateWeapon1 => m_Wrapper.m_ShipControls_ActivateWeapon1;
        public InputAction @Select => m_Wrapper.m_ShipControls_Select;
        public InputActionMap Get() { return m_Wrapper.m_ShipControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControlsActions set) { return set.Get(); }
        public void SetCallbacks(IShipControlsActions instance)
        {
            if (m_Wrapper.m_ShipControlsActionsCallbackInterface != null)
            {
                @Strafe.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnStrafe;
                @Strafe.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnStrafe;
                @Strafe.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnStrafe;
                @Roll.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRoll;
                @Thrust.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnThrust;
                @Look.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnLook;
                @MousePosition.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMousePosition;
                @CameraRotationMod.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnCameraRotationMod;
                @CameraRotationMod.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnCameraRotationMod;
                @CameraRotationMod.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnCameraRotationMod;
                @Realign.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRealign;
                @Realign.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRealign;
                @Realign.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnRealign;
                @SpaceBreak.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnSpaceBreak;
                @SpaceBreak.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnSpaceBreak;
                @SpaceBreak.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnSpaceBreak;
                @MouseScroll.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouseScroll;
                @MouseScroll.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouseScroll;
                @MouseScroll.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnMouseScroll;
                @ActivateWeapon1.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnActivateWeapon1;
                @ActivateWeapon1.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnActivateWeapon1;
                @ActivateWeapon1.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnActivateWeapon1;
                @Select.started -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_ShipControlsActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_ShipControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Strafe.started += instance.OnStrafe;
                @Strafe.performed += instance.OnStrafe;
                @Strafe.canceled += instance.OnStrafe;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @CameraRotationMod.started += instance.OnCameraRotationMod;
                @CameraRotationMod.performed += instance.OnCameraRotationMod;
                @CameraRotationMod.canceled += instance.OnCameraRotationMod;
                @Realign.started += instance.OnRealign;
                @Realign.performed += instance.OnRealign;
                @Realign.canceled += instance.OnRealign;
                @SpaceBreak.started += instance.OnSpaceBreak;
                @SpaceBreak.performed += instance.OnSpaceBreak;
                @SpaceBreak.canceled += instance.OnSpaceBreak;
                @MouseScroll.started += instance.OnMouseScroll;
                @MouseScroll.performed += instance.OnMouseScroll;
                @MouseScroll.canceled += instance.OnMouseScroll;
                @ActivateWeapon1.started += instance.OnActivateWeapon1;
                @ActivateWeapon1.performed += instance.OnActivateWeapon1;
                @ActivateWeapon1.canceled += instance.OnActivateWeapon1;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public ShipControlsActions @ShipControls => new ShipControlsActions(this);
    public interface IShipControlsActions
    {
        void OnStrafe(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnThrust(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnCameraRotationMod(InputAction.CallbackContext context);
        void OnRealign(InputAction.CallbackContext context);
        void OnSpaceBreak(InputAction.CallbackContext context);
        void OnMouseScroll(InputAction.CallbackContext context);
        void OnActivateWeapon1(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
