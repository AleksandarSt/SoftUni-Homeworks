using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
        where T: IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;
        private int currentCapacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.currentCapacity = capacity;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (this.count == this.elements.Length)
            {
                //throw new IndexOutOfRangeException(String.Format(
                //    "The list capacity of {0} was exceeded.", this.elements.Length));

                this.Resize(currentCapacity * 2);
            }
            this.elements[this.count] = element;
            this.count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }

                T result = this.elements[index];

                return result;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }

            for (int i = index + 1; i <= this.count; i++)
            {
                this.elements[i-1] = this.elements[i];
            }

            this.count--;
        }

        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
            this.currentCapacity = newCapacity;
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }

            if (this.count == this.elements.Length-1)
            {
                this.Resize(currentCapacity * 2);
            }

            for (int i = this.count; i >= index ; i--)
            {
                this.elements[i + 1] = this.elements[i];
            }

            this.elements[index] = element;
            this.count++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.count; i++)
            {
                elements[i] = default(T);
            }

            this.count = 0;
        }

        /// <summary>
        /// Finds element index by given value (T element).If element not found returns -1
        /// </summary>
        /// <param name="element"></param>
        public int Find(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                
                if (element.CompareTo(this.elements[i])==0)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        ///If generic list contains given value (T element) returns true, if not return false
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element) 
        {
            for (int i = 0; i < this.count; i++)
            {

                if (element.CompareTo(this.elements[i]) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.elements[i].ToString()).AppendLine();
            }

            return result.ToString();
        }

        /// <summary>
        /// Returns maximal element of generic list
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                } 
            }

            return max;
        }

        /// <summary>
        /// Returns minimal element of generic list
        /// </summary>
        /// <returns></returns>
        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) <= 0)
                {
                    min = this.elements[i];
                }
            }

            return min;
        }
    }
}
