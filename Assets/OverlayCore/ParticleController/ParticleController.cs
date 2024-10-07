using System;
using UnityEngine;

namespace TCS {
    [RequireComponent(typeof(ParticleSystem))]
    public class ParticleController : MonoBehaviour {
        public bool m_updateDynamically;
        ParticleMainSettings m_particleMainSettings;
        ParticleEmitterSettings m_emissionSettings;
        
        [SerializeField] BurstSettings m_singleBurstSettings = new(0.2f, 1, 1);
        [SerializeField] BurstSettings[] m_burstSettings;
        
        [SerializeField] bool m_forceLoop; // New setting to force loop

        ParticleSystem m_particleSystem;
        WizardConfig m_wizardConfig;
        bool m_previousIsSingleBurst;

        public void Init(WizardConfig wizardConfig) {
            m_particleSystem = GetComponent<ParticleSystem>();
            m_wizardConfig = wizardConfig;
            m_particleMainSettings = new ParticleMainSettings(m_particleSystem, m_wizardConfig);
            m_emissionSettings = new ParticleEmitterSettings(m_particleSystem, m_wizardConfig);
            m_previousIsSingleBurst = m_wizardConfig.m_isSingleBurst;

            if (m_forceLoop) {
                m_wizardConfig.m_isSingleBurst = false; // Force loop
            }

            UpdateBurstSettings();

            if (m_previousIsSingleBurst && !m_forceLoop) {
                OverlayGlobalEvents.OffscreenClick += ParticlePlay;
            }
        }

        void Update() {
            if (!m_updateDynamically) return;
            m_emissionSettings.UpdateEmissionSettings();
            m_particleMainSettings.UpdateMainSettings();
            UpdateBurstSettings();
        }

        void OnDestroy() {
            if (m_previousIsSingleBurst && !m_forceLoop) {
                OverlayGlobalEvents.OffscreenClick -= ParticlePlay;
            }
        }

        void ParticlePlay() => m_particleSystem.Play();

        void UpdateBurstSettings() {
            if (m_forceLoop) {
                if (m_burstSettings.Length > 0) {
                    m_burstSettings = Array.Empty<BurstSettings>();
                }
                OverlayGlobalEvents.OffscreenClick -= ParticlePlay;
                ParticlePlay();
            } else {
                if (m_previousIsSingleBurst) {
                    m_burstSettings = new[] { m_singleBurstSettings };
                    OverlayGlobalEvents.OffscreenClick += ParticlePlay;
                } else {
                    m_burstSettings = Array.Empty<BurstSettings>();
                    OverlayGlobalEvents.OffscreenClick -= ParticlePlay;
                    ParticlePlay();
                }
            }
            m_emissionSettings.SetEmission(m_burstSettings);
            m_previousIsSingleBurst = m_wizardConfig.m_isSingleBurst;
        }
    }
}