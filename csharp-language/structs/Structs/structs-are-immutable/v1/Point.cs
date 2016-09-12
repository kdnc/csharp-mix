using System;

namespace Structs.v1
{
    struct Point
    {
        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1})", m_x, m_y);
        }
        public int m_x;
        public int m_y;
    }
}