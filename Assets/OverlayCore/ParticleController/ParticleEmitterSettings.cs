using System;
using UnityEngine;
namespace TCS {
    public class ParticleEmitterSettings {
        ParticleSystem.EmissionModule m_emission;
        WizardConfig m_wizardConfig;
        
        public ParticleEmitterSettings(ParticleSystem emission, WizardConfig wizardConfig) {   
            m_emission = emission.emission;
            m_wizardConfig = wizardConfig;
        }       
        
        public void SetEmission(BurstSettings[] burstSettings) {
            // Set rate over time
            var rateOverTime = m_emission.rateOverTime;
            rateOverTime.constant = m_wizardConfig.m_emissionRateOverTime;
            m_emission.rateOverTime = rateOverTime;

            // Set rate over distance
            var rateOverDistance = m_emission.rateOverDistance;
            rateOverDistance.constant = m_wizardConfig.m_emissionRateOverDistance;
            m_emission.rateOverDistance = rateOverDistance;
            
            if (burstSettings is { Length: > 0 }) {
                ParticleSystem.Burst[] bursts = new ParticleSystem.Burst[burstSettings.Length];
                for (var i = 0; i < burstSettings.Length; i++) {
                    bursts[i] = new ParticleSystem.Burst
                    (
                        burstSettings[i].m_time,
                        burstSettings[i].m_minCount,
                        burstSettings[i].m_maxCount,
                        burstSettings[i].m_cycleCount,
                        burstSettings[i].m_repeatInterval
                    );
                }

                m_emission.SetBursts(bursts);
            }
            else {
                m_emission.SetBursts(Array.Empty<ParticleSystem.Burst>());
            }
        }
        
        public void UpdateEmissionSettings() {
            var rateOverTime = m_emission.rateOverTime;
            rateOverTime.constant = m_wizardConfig.m_emissionRateOverTime;
            m_emission.rateOverTime = rateOverTime;

            var rateOverDistance = m_emission.rateOverDistance;
            rateOverDistance.constant = m_wizardConfig.m_emissionRateOverDistance;
            m_emission.rateOverDistance = rateOverDistance;
        }
    }
}