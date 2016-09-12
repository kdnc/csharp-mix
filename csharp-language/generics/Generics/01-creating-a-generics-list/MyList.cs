using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_generics_new_constraint
{
    internal class MyList<T>
    {
        private int m_count = 0;
        private T[] m_values;

        public MyList(int capacity)
        {
            m_values = new T[capacity];
        }

        public void Add(T value)
        {
            m_values[m_count] = value;
            m_count++;
        }

        public T this[int index]
        {
            get { return m_values[index]; }
            set { m_values[index] = value; }
        }

        public int Count
        {
            get { return m_count; }
        }

        public delegate void ItemAdded(T newItem);
    }
}