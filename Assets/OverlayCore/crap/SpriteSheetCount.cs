using UnityEngine;

namespace TCS
{
    public class SpriteSheetCount : MonoBehaviour
    {
        [SerializeField] ParticleSystem m_particleSystem;
        ParticleSystem.TextureSheetAnimationModule m_textureSheetAnimationModule;
        [ContextMenu("sdfsdf")]
        void Crap() {
            m_textureSheetAnimationModule = m_particleSystem.textureSheetAnimation;
            Debug.Log($"Sprite Count : {m_textureSheetAnimationModule.spriteCount}");
        }
    }
}
