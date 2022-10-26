//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Digiteknik/SceneInputs.inputactions
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

namespace Digiteknik
{
    public partial class @SceneInputs : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @SceneInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""SceneInputs"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""795776d7-6c9c-4790-bd94-e94143aea722"",
            ""actions"": [
                {
                    ""name"": ""SkubBold"",
                    ""type"": ""Value"",
                    ""id"": ""d7ec2334-a7b8-437e-84d4-500e885f01ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Skyyyd"",
                    ""type"": ""Button"",
                    ""id"": ""5aa1083c-747a-4054-bdb1-aa1bf67e4436"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlytSpiller"",
                    ""type"": ""Button"",
                    ""id"": ""72d007a7-dc97-4549-b7af-941060d69d40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RoterSpiller"",
                    ""type"": ""Button"",
                    ""id"": ""b11cbc42-7506-4aef-9cb6-9b418a42a260"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""30a644ed-f7a3-4633-bbe8-6e1ab0156b80"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fb9c4ebc-3e47-4bfd-8111-08fb7ccc3ac8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""09849e99-5bd0-4817-be8c-d90d47af681c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06698e81-9767-47b4-91a2-6c373af1683b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c97481b3-75df-4fcd-aa45-6ba036e2d2f9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkubBold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1616630d-fd5b-4cfe-8a18-47b7d4ebe0cf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skyyyd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1659be9-4f47-4f58-9c4e-f80dd88b11a0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlytSpiller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e38ad622-1a1c-4e18-ac7c-97766adf258c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RoterSpiller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_SkubBold = m_Gameplay.FindAction("SkubBold", throwIfNotFound: true);
            m_Gameplay_Skyyyd = m_Gameplay.FindAction("Skyyyd", throwIfNotFound: true);
            m_Gameplay_FlytSpiller = m_Gameplay.FindAction("FlytSpiller", throwIfNotFound: true);
            m_Gameplay_RoterSpiller = m_Gameplay.FindAction("RoterSpiller", throwIfNotFound: true);
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

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_SkubBold;
        private readonly InputAction m_Gameplay_Skyyyd;
        private readonly InputAction m_Gameplay_FlytSpiller;
        private readonly InputAction m_Gameplay_RoterSpiller;
        public struct GameplayActions
        {
            private @SceneInputs m_Wrapper;
            public GameplayActions(@SceneInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @SkubBold => m_Wrapper.m_Gameplay_SkubBold;
            public InputAction @Skyyyd => m_Wrapper.m_Gameplay_Skyyyd;
            public InputAction @FlytSpiller => m_Wrapper.m_Gameplay_FlytSpiller;
            public InputAction @RoterSpiller => m_Wrapper.m_Gameplay_RoterSpiller;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @SkubBold.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkubBold;
                    @SkubBold.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkubBold;
                    @SkubBold.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkubBold;
                    @Skyyyd.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkyyyd;
                    @Skyyyd.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkyyyd;
                    @Skyyyd.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSkyyyd;
                    @FlytSpiller.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlytSpiller;
                    @FlytSpiller.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlytSpiller;
                    @FlytSpiller.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFlytSpiller;
                    @RoterSpiller.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRoterSpiller;
                    @RoterSpiller.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRoterSpiller;
                    @RoterSpiller.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRoterSpiller;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @SkubBold.started += instance.OnSkubBold;
                    @SkubBold.performed += instance.OnSkubBold;
                    @SkubBold.canceled += instance.OnSkubBold;
                    @Skyyyd.started += instance.OnSkyyyd;
                    @Skyyyd.performed += instance.OnSkyyyd;
                    @Skyyyd.canceled += instance.OnSkyyyd;
                    @FlytSpiller.started += instance.OnFlytSpiller;
                    @FlytSpiller.performed += instance.OnFlytSpiller;
                    @FlytSpiller.canceled += instance.OnFlytSpiller;
                    @RoterSpiller.started += instance.OnRoterSpiller;
                    @RoterSpiller.performed += instance.OnRoterSpiller;
                    @RoterSpiller.canceled += instance.OnRoterSpiller;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);
        public interface IGameplayActions
        {
            void OnSkubBold(InputAction.CallbackContext context);
            void OnSkyyyd(InputAction.CallbackContext context);
            void OnFlytSpiller(InputAction.CallbackContext context);
            void OnRoterSpiller(InputAction.CallbackContext context);
        }
    }
}
