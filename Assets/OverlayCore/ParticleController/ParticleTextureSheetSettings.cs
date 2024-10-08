using TCS.OverlayCore.OverlayWizard;
using UnityEngine;
namespace TCS {
    public class ParticleTextureSheetSettings {
        readonly SpriteConfig m_spriteConfig;
        readonly ParticleSystem.TextureSheetAnimationModule m_particleSystemTextureSheet;
        
        public ParticleTextureSheetSettings(ParticleSystem particleSystem, SpriteConfig spriteConfig) {
            m_particleSystemTextureSheet = particleSystem.textureSheetAnimation;
            m_spriteConfig = spriteConfig;
            
            SetTextureSheet(m_particleSystemTextureSheet);
        }
        
        public void UpdateTextureSheetSettings() {
            SetTextureSheet(m_particleSystemTextureSheet);
        }
        
        void SetTextureSheet(ParticleSystem.TextureSheetAnimationModule sheet) {
            sheet.enabled = true;
            sheet.mode = ParticleSystemAnimationMode.Sprites;
            
            //we are not aloud to add or remove array elements during Runtime,
            //instead we use a fixed array from editor settings
            //then we swap the sprites in the array
            int indexCount = sheet.spriteCount;
            int spriteCount = m_spriteConfig.m_useSprites.Count;
            
            for (var i = 0; i < indexCount; i++) {
                sheet.SetSprite(i, i < spriteCount ? m_spriteConfig.m_useSprites[i] : null);
            }
        }
    }
}