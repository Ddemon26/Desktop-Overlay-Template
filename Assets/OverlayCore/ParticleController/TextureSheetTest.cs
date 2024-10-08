using TCS.OverlayCore.OverlayWizard;
using UnityEngine;
namespace TCS {
    public class TextureSheetTest : MonoBehaviour {
        [SerializeField] SpriteConfig m_spriteConfig;
        [SerializeField] ParticleSystem m_particleSystem;
        ParticleTextureSheetSettings m_textureSheetSettings;
        
        void Start() {
            m_textureSheetSettings = new ParticleTextureSheetSettings(m_particleSystem, m_spriteConfig);
        }
        
        [ContextMenu("Set Texture Sheet")]
        void TryToSetTextureSheet() {
            m_textureSheetSettings.UpdateTextureSheetSettings();
        }
    }
}