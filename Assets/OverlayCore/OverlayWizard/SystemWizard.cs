using TCS.OverlayCore.OverlayWizard;
using UnityEngine;

namespace TCS {
    public class SystemWizard : MonoBehaviour {
        [SerializeField] WizardConfig m_wizardConfig;
        [SerializeField] SpriteConfig m_spriteConfig;
        [SerializeField] EffectWizard m_effectWizard = new();
        
        void Awake() {
            m_effectWizard.Init(m_wizardConfig, m_spriteConfig);
        }
        
        void Start() {
            m_effectWizard.SetEffects();
        }

        void Update() {
            m_effectWizard.SetEffects();
        }
    }
}