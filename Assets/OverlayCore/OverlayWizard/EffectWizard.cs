using System;
using System.Collections.Generic;
using UnityEngine;

namespace TCS {
    [Serializable]
    public class EffectWizard {
        public List<EffectHandler> m_particleEffects;
        public GameObject m_enableClickBurst;
        public List<GameObject> m_objectEffects;
        public List<EffectHandler> m_waterfallEffects;
        
        WizardConfig m_wizardConfig;

        public void Init(WizardConfig wizardConfig) {
            m_wizardConfig = wizardConfig;
            m_enableClickBurst.SetActive(!m_wizardConfig.m_isSingleBurst);

            InitializeEffects(m_particleEffects);
            InitializeEffects(m_waterfallEffects);
        }

        void InitializeEffects(List<EffectHandler> effects) {
            foreach (var effect in effects) {
                effect.ParticleController.Init(m_wizardConfig);
            }
        }

        public void SetEffects() {
            m_enableClickBurst.SetActive(!m_wizardConfig.m_isSingleBurst);
            SetActiveEffectHandlers(m_particleEffects, m_wizardConfig.m_activeParticleEffect, m_wizardConfig.m_enableParticleEffect);
            SetActiveGameObjects(m_objectEffects, m_wizardConfig.m_activeObjectEffect, m_wizardConfig.m_enableObjectEffect);
            SetActiveEffectHandlers(m_waterfallEffects, m_wizardConfig.m_activeWaterfallEffect, m_wizardConfig.m_enableWaterfallEffect);
        }

        void SetActiveEffectHandlers(List<EffectHandler> effects, int activeIndex, bool isEffectEnabled) {
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