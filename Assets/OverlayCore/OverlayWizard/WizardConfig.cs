using UnityEngine;
namespace TCS {
    public enum EffectType {
        Particle,
        Waterfall
    }
    public class WizardConfig : ScriptableObject {
        [Header("Effect Type")]
        public EffectType m_effectType;
        [Header("Effect Settings")]
        public bool m_enableParticleEffect = true;
        [Range(0,10)] public int m_activeParticleEffect;
        [Header("Object Settings")]
        public bool m_enableObjectEffect;
        [Range(0,10)] public int m_activeObjectEffect;
        [Header("Waterfall Settings")]
        public bool m_enableWaterfallEffect;
        [Range(0,10)] public int m_activeWaterfallEffect;
        [Header("Particle System Settings")]
        public bool m_isSingleBurst;
        public bool m_playOnAwake;
        public float m_gravityModifier;
        [Range(0,100)] public float m_emissionRateOverTime;
        [Range(0,100)] public float m_emissionRateOverDistance;
        [Range(0,100)] public float m_startLifetime = 5;
        [Range(0,10000)] public int m_maxParticles = 1000;

        void OnValidate() {
            if (m_effectType == EffectType.Particle) {
                m_enableParticleEffect = true;
                m_enableWaterfallEffect = false;
            }
            else {
                m_enableParticleEffect = false;
                m_enableWaterfallEffect = true;
            }
        }
        
        public void SetEffectType(EffectType effectType) {
            m_effectType = effectType;
            if (m_effectType == EffectType.Particle) {
                m_enableParticleEffect = true;
                m_enableWaterfallEffect = false;
            }
            else {
                m_enableParticleEffect = false;
                m_enableWaterfallEffect = true;
            }
        }
    }
}   