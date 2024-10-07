using System.Collections.Generic;
using UnityEngine;

namespace TCS {
    public class SystemWizard : MonoBehaviour {
        [SerializeField] WizardConfig m_wizardConfig;
        [SerializeField] EffectWizard m_effectWizard = new();
        
        void Awake() {
            m_effectWizard.Init(m_wizardConfig);
        }
        
        void Start() {
            m_effectWizard.SetEffects();
        }

        void Update() {
            m_effectWizard.SetEffects();
        }
    }
}