using UnityEngine;

namespace TCS
{
    public class EffectHandler : MonoBehaviour
    {
        [SerializeField] ParticleController m_particleController;
        
        public ParticleController ParticleController => m_particleController;
        
        public void Init(WizardConfig wizardConfig) {
            m_particleController.Init(wizardConfig);
        }
    }
}
