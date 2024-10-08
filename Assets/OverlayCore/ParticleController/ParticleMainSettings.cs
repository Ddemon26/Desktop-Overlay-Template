using UnityEngine;
namespace TCS {
    public class ParticleMainSettings {
        readonly WizardConfig m_wizardConfig;
        readonly ParticleSystem.MainModule m_particleSystemMain;
        
        public ParticleMainSettings(ParticleSystem particleSystem, WizardConfig wizardConfig) {
            m_wizardConfig = wizardConfig;
            bool playOnAwake = m_wizardConfig.m_playOnAwake;

            m_particleSystemMain = particleSystem.main;
            SetMain(m_particleSystemMain);

            if (!playOnAwake) return;
            particleSystem.Play();
        }

        public void UpdateMainSettings() {
            SetMain(m_particleSystemMain);
        }
        
        void SetMain(ParticleSystem.MainModule main) {
            main.loop = !m_wizardConfig.m_isSingleBurst;
            main.gravityModifier = m_wizardConfig.m_gravityModifier;
            main.startLifetime = m_wizardConfig.m_startLifetime;
            main.maxParticles = m_wizardConfig.m_maxParticles;
        }
    }
}