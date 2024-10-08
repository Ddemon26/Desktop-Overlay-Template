using System.Collections.Generic;
using UnityEngine;
namespace TCS.OverlayCore.OverlayWizard {
    [CreateAssetMenu(menuName = "Create SpriteConfig", fileName = "SpriteConfig", order = 0)]
    public class SpriteConfig : ScriptableObject {
        public List<Sprite> m_allSprites = new();
        public List<Sprite> m_useSprites = new();

        public void AddSprite(int key) {
            m_useSprites.Add(m_allSprites[key]);
        }

        public void RemoveSprite(int key) {
            m_useSprites.RemoveAt(key);
        }
        

        [ContextMenu("Add Random Sprite")]
        public void AddRandomSprite() {
            int randomIndex = Random.Range(0, m_allSprites.Count);
            AddSprite(randomIndex);
        }
        
        public void ClearSprites() {
            for (var i = 0; i < m_useSprites.Count; i++) {
                m_useSprites[i] = null;
            }
        }
    }
}