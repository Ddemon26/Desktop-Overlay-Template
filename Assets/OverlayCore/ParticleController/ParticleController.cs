using System;
using TCS.OverlayCore.OverlayWizard;
using UnityEngine;

namespace TCS {
    [RequireComponent(typeof(ParticleSystem))]
    public class ParticleController : MonoBehaviour {
        public bool m_updateDynamically;
        ParticleMainSettings m_particleMainSettings;
        ParticleEmitterSettings m_emissionSettings;
        ParticleTextureSheetSettings m_textureSheetSettings;
        
        [SerializeField] BurstSettings m_singleBurstSettings = new(0.2f, 1, 1);
        [SerializeField] BurstSettings[] m_burstSettings;
        
        [SerializeField] bool m_forceLoop; // New setting to force loop

        ParticleSystem m_particleSystem;
        WizardConfig m_wizardConfig;
        SpriteConfig m_spriteConfig;
        bool m_previousIsSingleBurst;

        public void Init(WizardConfig wizardConfig, SpriteConfig spriteConfig) {    
            m_particleSystem = GetComponent<ParticleSystem>();
            m_wizardConfig = wizardConfig;
            m_spriteConfig = spriteConfig;
            m_particleMainSettings = new ParticleMainSettings(m_particleSystem, m_wizardConfig);
            m_emissionSettings = new ParticleEmitterSettings(m_particleSystem, m_wizardConfig);
            m_textureSheetSettings = new ParticleTextureSheetSettings(m_particleSystem, m_spriteConfig);
            m_previousIsSingleBurst = m_wizardConfig.m_isSingleBurst;

            if (m_forceLoop) {
                m_wizardConfig.m_isSingleBurst = false; // Force loop
            }

            UpdateBurstSettings();

            if (m_previousIsSingleBurst && !m_forceLoop) {
                TransparentWindowEvents.OffscreenClick += ParticlePlay;
            }
        }

        void Update() {
            if (!m_updateDynamically) return;
            m_emissionSettings.UpdateEmissionSettings();
            m_particleMainSettings.UpdateMainSettings();
            m_textureSheetSettings.UpdateTextureSheetSettings();
            UpdateBurstSettings();
        }

        void OnDestroy() {
            if (m_previousIsSingleBurst && !m_forceLoop) {
                TransparentWindowEvents.OffscreenClick -= ParticlePlay;
            }
        }

        void ParticlePlay() => m_particleSystem.Play();

        void UpdateBurstSettings() {
            if (m_forceLoop) {
                if (m_burstSettings.Length > 0) {
                    m_burstSettings = Array.Empty<BurstSettings>();
                }
                TransparentWindowEvents.OffscreenClick -= ParticlePlay;
                ParticlePlay();
            } else {
                if (m_previousIsSingleBurst) {
                    m_burstSettings = new[] { m_singleBurstSettings };
                    TransparentWindowEvents.OffscreenClick += ParticlePlay;
                } else {
                    m_burstSettings = Array.Empty<BurstSettings>();
                    TransparentWindowEvents.OffscreenClick -= ParticlePlay;
                    ParticlePlay();
                }
            }
            m_emissionSettings.SetEmission(m_burstSettings);
            m_previousIsSingleBurst = m_wizardConfig.m_isSingleBurst;
        }
    }
}