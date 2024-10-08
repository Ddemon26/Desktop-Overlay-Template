using System;
using System.Collections.Generic;
using UnityEngine;
namespace TCS.OverlayCore.OverlayWizard {
    [Serializable]
    public struct SpriteKey {
        public int m_key;
        public Sprite m_sprite;
        
        public SpriteKey(int key, Sprite sprite) {
            m_key = key;
            m_sprite = sprite;
        }
        
        public bool CompareKey(int key) => m_key == key;
    }

    [CreateAssetMenu(menuName = "Create SpriteConfig", fileName = "SpriteConfig", order = 0)]
    public class SpriteConfig : ScriptableObject {
        public List<Sprite> m_allSprites = new();
        public Sprite[] m_useSprites = new Sprite[25];
        readonly Dictionary<int, Sprite> m_spriteDict = new();
        
        public List<SpriteKey> m_spriteKeys = new();

        void OnValidate() {
            m_spriteDict.Clear();
            for (var i = 0; i < m_allSprites.Count; i++) {
                m_spriteDict.Add(i, m_allSprites[i]);
            }

            m_spriteKeys.Clear();
            foreach (var sprite in m_allSprites) {
                m_spriteKeys.Add(new SpriteKey { m_key = m_allSprites.IndexOf(sprite), m_sprite = sprite });
            }

            // Ensure m_useSprites has exactly 25 elements
            if (m_useSprites.Length != 25) {
                m_useSprites = new Sprite[25];
            }
        }

        public void AddSprite(int key) {
            key = Key(key);
            for (var i = 0; i < m_useSprites.Length; i++) {
                if (m_useSprites[i]) continue;
                m_useSprites[i] = m_spriteDict[key];
                return;
            }
        }

        public void RemoveSprite(int key) {
            key = Key(key);
            for (var i = 0; i < m_useSprites.Length; i++) {
                if (m_useSprites[i] != m_spriteDict[key]) continue;
                m_useSprites[i] = null;
                return;
            }
        }

        static int Key(int key) {
            if (key >= 25) {
                key = 25;
            }
            return key;
        }

        [ContextMenu("Add Random Sprite")]
        public void AddRandomSprite() {
            int randomIndex = UnityEngine.Random.Range(0, 24);
            AddSprite(randomIndex);
        }

        public void ClearSprites() {
            for (var i = 0; i < m_useSprites.Length; i++) {
                m_useSprites[i] = null;
            }
        }

        public void AddMissingArrayElements(int count) {
            for (var i = 0; i < count; i++) {
                m_allSprites.Add(null);
            }
        }
    }
}