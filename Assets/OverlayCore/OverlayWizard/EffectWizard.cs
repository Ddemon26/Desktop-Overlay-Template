using System;
using System.Collections.Generic;
using TCS.OverlayCore.OverlayWizard;
using UnityEngine;
namespace TCS {
    [Serializable]
    public class EffectWizard {
        public GameObject m_enableClickBurst;
        public List<ParticleController> m_particleEffects;
        public List<ParticleController> m_waterfallEffects;
        public List<GameObject> m_forceFieldEffects;
        
        WizardConfig m_wizardConfig;

        public void Init(WizardConfig wizardConfig, SpriteConfig spriteConfig) {
            m_wizardConfig = wizardConfig;
            m_enableClickBurst.SetActive(!m_wizardConfig.m_isSingleBurst);

            InitializeEffects(m_particleEffects, spriteConfig);
            InitializeEffects(m_waterfallEffects, spriteConfig);
        }

        void InitializeEffects(List<ParticleController> effects, SpriteConfig spriteConfig) {
            foreach (var effect in effects) {
                effect.Init(m_wizardConfig, spriteConfig);
            }
        }

        public void SetEffects() {
            m_enableClickBurst.SetActive(!m_wizardConfig.m_isSingleBurst);
            SetActiveEffectHandlers(m_particleEffects, m_wizardConfig.m_activeParticleEffect, m_wizardConfig.m_enableParticleEffect);
            SetActiveGameObjects(m_forceFieldEffects, m_wizardConfig.m_activeObjectEffect, m_wizardConfig.m_enableObjectEffect);
            SetActiveEffectHandlers(m_waterfallEffects, m_wizardConfig.m_activeWaterfallEffect, m_wizardConfig.m_enableWaterfallEffect);
        }

        void SetActiveEffectHandlers(List<ParticleController> effects, int activeIndex, bool isEffectEnabled) {
            int index = Mathf.Clamp(activeIndex, 0, effects.Count - 1);
            for (var i = 0; i < effects.Count; i++) {
                bool isActive = isEffectEnabled && i == index;
                effects[i].gameObject.SetActive(isActive);
            }
        }

        void SetActiveGameObjects(List<GameObject> objects, int activeIndex, bool isEffectEnabled) {
            int index = Mathf.Clamp(activeIndex, 0, objects.Count - 1);
            for (var i = 0; i < objects.Count; i++) {
                bool isActive = isEffectEnabled && i == index;
                objects[i].SetActive(isActive);
            }
        }
    }
}