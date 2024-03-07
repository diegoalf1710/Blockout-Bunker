//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scenes/MisInputs.inputactions
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

public partial class @MisInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MisInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MisInputs"",
    ""maps"": [
        {
            ""name"": ""Juego"",
            ""id"": ""327746ef-9a9e-47d6-b0d5-a4688aa61d05"",
            ""actions"": [
                {
                    ""name"": ""Control"",
                    ""type"": ""Value"",
                    ""id"": ""16539249-5b8a-483f-b528-86577a03cac7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""89801d0e-bf43-45ab-9fa5-936584ae9242"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cc2e2c9d-f272-416c-a116-b57db6795227"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Control"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ef78da43-3579-4e48-b690-8983e6e65a0c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""002ea0db-71aa-47cf-b447-929e6b44e01f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ad4b701e-7f84-4e4a-be3d-ceb0e97455cd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb86a44b-7da8-440e-b2a3-c41bc9437695"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""daf7ae57-0c11-4bac-9584-56660c0670c7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Juego
        m_Juego = asset.FindActionMap("Juego", throwIfNotFound: true);
        m_Juego_Control = m_Juego.FindAction("Control", throwIfNotFound: true);
        m_Juego_Jump = m_Juego.FindAction("Jump", throwIfNotFound: true);
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

    // Juego
    private readonly InputActionMap m_Juego;
    private List<IJuegoActions> m_JuegoActionsCallbackInterfaces = new List<IJuegoActions>();
    private readonly InputAction m_Juego_Control;
    private readonly InputAction m_Juego_Jump;
    public struct JuegoActions
    {
        private @MisInputs m_Wrapper;
        public JuegoActions(@MisInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Control => m_Wrapper.m_Juego_Control;
        public InputAction @Jump => m_Wrapper.m_Juego_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Juego; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JuegoActions set) { return set.Get(); }
        public void AddCallbacks(IJuegoActions instance)
        {
            if (instance == null || m_Wrapper.m_JuegoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JuegoActionsCallbackInterfaces.Add(instance);
            @Control.started += instance.OnControl;
            @Control.performed += instance.OnControl;
            @Control.canceled += instance.OnControl;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IJuegoActions instance)
        {
            @Control.started -= instance.OnControl;
            @Control.performed -= instance.OnControl;
            @Control.canceled -= instance.OnControl;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IJuegoActions instance)
        {
            if (m_Wrapper.m_JuegoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJuegoActions instance)
        {
            foreach (var item in m_Wrapper.m_JuegoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JuegoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JuegoActions @Juego => new JuegoActions(this);
    public interface IJuegoActions
    {
        void OnControl(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}