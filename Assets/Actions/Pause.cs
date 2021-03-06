//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Actions/Pause.inputactions
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

public partial class @Pause : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Pause()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Pause"",
    ""maps"": [
        {
            ""name"": ""PauseMap"",
            ""id"": ""2f850ff9-30d3-4104-97fd-8afa884c7002"",
            ""actions"": [
                {
                    ""name"": ""LaunchPause"",
                    ""type"": ""Value"",
                    ""id"": ""56e20828-7369-4da9-ba15-70a4c01eab83"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""adfe6047-fb18-49ae-92c2-dae1ed6c4cff"",
                    ""path"": ""<XRController>{RightHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""847b3f50-5e51-4d91-be12-f90feedfcbb2"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PauseMap
        m_PauseMap = asset.FindActionMap("PauseMap", throwIfNotFound: true);
        m_PauseMap_LaunchPause = m_PauseMap.FindAction("LaunchPause", throwIfNotFound: true);
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

    // PauseMap
    private readonly InputActionMap m_PauseMap;
    private IPauseMapActions m_PauseMapActionsCallbackInterface;
    private readonly InputAction m_PauseMap_LaunchPause;
    public struct PauseMapActions
    {
        private @Pause m_Wrapper;
        public PauseMapActions(@Pause wrapper) { m_Wrapper = wrapper; }
        public InputAction @LaunchPause => m_Wrapper.m_PauseMap_LaunchPause;
        public InputActionMap Get() { return m_Wrapper.m_PauseMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMapActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMapActions instance)
        {
            if (m_Wrapper.m_PauseMapActionsCallbackInterface != null)
            {
                @LaunchPause.started -= m_Wrapper.m_PauseMapActionsCallbackInterface.OnLaunchPause;
                @LaunchPause.performed -= m_Wrapper.m_PauseMapActionsCallbackInterface.OnLaunchPause;
                @LaunchPause.canceled -= m_Wrapper.m_PauseMapActionsCallbackInterface.OnLaunchPause;
            }
            m_Wrapper.m_PauseMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LaunchPause.started += instance.OnLaunchPause;
                @LaunchPause.performed += instance.OnLaunchPause;
                @LaunchPause.canceled += instance.OnLaunchPause;
            }
        }
    }
    public PauseMapActions @PauseMap => new PauseMapActions(this);
    public interface IPauseMapActions
    {
        void OnLaunchPause(InputAction.CallbackContext context);
    }
}
