using UnityEngine;
namespace TCS {
    public class ParticleMainSettings {
        readonly ParticleSystem m_particleSystem;
        readonly WizardConfig m_wizardConfig;
        
        public ParticleMainSettings(ParticleSystem particleSystem, WizardConfig wizardConfig) {
            m_particleSystem = particleSystem;
            m_wizardConfig = wizardConfig;
            bool playOnAwake = m_wizardConfig.m_playOnAwake;

            var particleSystemMain = m_particleSystem.main;
            SetMain(particleSystemMain);

            if (!playOnAwake) return;
            m_particleSystem.Play();
        }

        public void UpdateMainSettings() {
            var particleSystemMain = m_particleSystem.main;
            SetMain(particleSystemMain);
        }
        
        void SetMain(ParticleSystem.MainModule particleSystemMain) {
            particleSystemMain.loop = !m_wizardConfig.m_isSingleBurst;
            particleSystemMain.gravityModifier = m_wizardConfig.m_gravityModifier;
            particleSystemMain.startLifetime = m_wizardConfig.m_startLifetime;
            particleSystemMain.maxParticles = m_wizardConfig.m_maxParticles;
        }
    }
}