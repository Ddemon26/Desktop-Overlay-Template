using System;
namespace TCS {
    [Serializable]
    public struct BurstSettings {
        public float m_time;
        public short m_minCount;
        public short m_maxCount;
        public int m_cycleCount;
        public float m_repeatInterval;

        public BurstSettings(float time, short minCount, short maxCount, int cycleCount = 1, float repeatInterval = 0f) {
            m_time = time;
            m_minCount = minCount;
            m_maxCount = maxCount;
            m_cycleCount = cycleCount;
            m_repeatInterval = repeatInterval;
        }
    }
}