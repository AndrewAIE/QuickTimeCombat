//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Player/Inputs/PlayerInputs.inputactions
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

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""4683e64d-c5f8-4dba-af37-f124ec6b02f8"",
            ""actions"": [
                {
                    ""name"": ""Direction"",
                    ""type"": ""Value"",
                    ""id"": ""20c6c692-ad9c-4852-8d11-7eb532d83ea2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""473d4083-4515-4a8f-92cd-1d1026a4551a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""42853464-badb-4ca3-a0fe-9bb34298a423"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""79f59598-f429-4f10-9b43-805b22c394b5"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dd7bbb9b-7e61-4ea8-b71c-bf5d62c26c51"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d574b12c-56a8-42ca-a3a7-459cf5a91583"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""262bfd08-5268-4e86-926c-f3e37b4c4aad"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""24fa8546-dbf1-439e-b724-7ef50beb7d29"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""QTE"",
            ""id"": ""c7d8a9e5-ea80-4279-914c-353e46fc31fc"",
            ""actions"": [
                {
                    ""name"": ""North"",
                    ""type"": ""Value"",
                    ""id"": ""cf4c8fd2-3574-4eb3-9503-950e21347213"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""68855ac7-bb0e-4e66-a95f-6e99ae4ba5a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""f95f21fd-46df-421f-83b3-5cc95667ad13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""45bd537c-9e8f-4955-9bc1-87de928f9ddb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c3648a85-55eb-4d65-bce2-a3948a1c9f65"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c60b3b2-9a3e-48a4-a781-04372ef5fcd5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5286993-4cfa-4f54-95ab-f61ec9ede02c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""025ae21b-bc0e-4aae-a19a-a3e91b11813e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b894225e-a603-492a-bdcc-66e2f4106751"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9876cd9-66ce-47a3-b0ec-ce11f248b84b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b1c62cc-d100-45b7-bbc5-7e782a888a4a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8d65bf0-ceda-44b3-8559-9ae6d1644658"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Direction = m_Movement.FindAction("Direction", throwIfNotFound: true);
        m_Movement_Look = m_Movement.FindAction("Look", throwIfNotFound: true);
        // QTE
        m_QTE = asset.FindActionMap("QTE", throwIfNotFound: true);
        m_QTE_North = m_QTE.FindAction("North", throwIfNotFound: true);
        m_QTE_South = m_QTE.FindAction("South", throwIfNotFound: true);
        m_QTE_East = m_QTE.FindAction("East", throwIfNotFound: true);
        m_QTE_West = m_QTE.FindAction("West", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Direction;
    private readonly InputAction m_Movement_Look;
    public struct MovementActions
    {
        private @PlayerInputs m_Wrapper;
        public MovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Direction => m_Wrapper.m_Movement_Direction;
        public InputAction @Look => m_Wrapper.m_Movement_Look;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Direction.started += instance.OnDirection;
            @Direction.performed += instance.OnDirection;
            @Direction.canceled += instance.OnDirection;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Direction.started -= instance.OnDirection;
            @Direction.performed -= instance.OnDirection;
            @Direction.canceled -= instance.OnDirection;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // QTE
    private readonly InputActionMap m_QTE;
    private List<IQTEActions> m_QTEActionsCallbackInterfaces = new List<IQTEActions>();
    private readonly InputAction m_QTE_North;
    private readonly InputAction m_QTE_South;
    private readonly InputAction m_QTE_East;
    private readonly InputAction m_QTE_West;
    public struct QTEActions
    {
        private @PlayerInputs m_Wrapper;
        public QTEActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @North => m_Wrapper.m_QTE_North;
        public InputAction @South => m_Wrapper.m_QTE_South;
        public InputAction @East => m_Wrapper.m_QTE_East;
        public InputAction @West => m_Wrapper.m_QTE_West;
        public InputActionMap Get() { return m_Wrapper.m_QTE; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(QTEActions set) { return set.Get(); }
        public void AddCallbacks(IQTEActions instance)
        {
            if (instance == null || m_Wrapper.m_QTEActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_QTEActionsCallbackInterfaces.Add(instance);
            @North.started += instance.OnNorth;
            @North.performed += instance.OnNorth;
            @North.canceled += instance.OnNorth;
            @South.started += instance.OnSouth;
            @South.performed += instance.OnSouth;
            @South.canceled += instance.OnSouth;
            @East.started += instance.OnEast;
            @East.performed += instance.OnEast;
            @East.canceled += instance.OnEast;
            @West.started += instance.OnWest;
            @West.performed += instance.OnWest;
            @West.canceled += instance.OnWest;
        }

        private void UnregisterCallbacks(IQTEActions instance)
        {
            @North.started -= instance.OnNorth;
            @North.performed -= instance.OnNorth;
            @North.canceled -= instance.OnNorth;
            @South.started -= instance.OnSouth;
            @South.performed -= instance.OnSouth;
            @South.canceled -= instance.OnSouth;
            @East.started -= instance.OnEast;
            @East.performed -= instance.OnEast;
            @East.canceled -= instance.OnEast;
            @West.started -= instance.OnWest;
            @West.performed -= instance.OnWest;
            @West.canceled -= instance.OnWest;
        }

        public void RemoveCallbacks(IQTEActions instance)
        {
            if (m_Wrapper.m_QTEActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IQTEActions instance)
        {
            foreach (var item in m_Wrapper.m_QTEActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_QTEActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public QTEActions @QTE => new QTEActions(this);
    public interface IMovementActions
    {
        void OnDirection(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IQTEActions
    {
        void OnNorth(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
    }
}
