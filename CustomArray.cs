using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class CustomArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int Len = 0;
        private int Capacity = 0;

        /// <summary>
        /// Initialize the capacity with 10
        /// </summary>
        public CustomArray()
        {
            Capacity = 10;
        }

        /// <summary>
        /// Initial length of the array
        /// </summary>
        /// <param name="actualSize"></param>
        public CustomArray(int actualSize)
        {
            if (actualSize < 0) throw new ArgumentException("Illegal argument " + actualSize);
            this.Capacity = actualSize;
            array = (T[])Convert.ChangeType(new object[actualSize], typeof(T[]));
        }

        public T get(int index) { return array[index];}

        public void set(int index, T element) { array[index] = element; }

        /// <summary>
        /// Returns length of the array
        /// </summary>
        /// <returns></returns>
        public int Size { get => Len; }

        /// <summary>
        /// Checks if array is empty
        /// </summary>
        /// <returns></returns>
        public bool isEmpty() => Size == 0;

        /// <summary>
        /// Inserts a new element of type T to the array
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (Len == Capacity) Capacity += 10;
            array[Len] = element;
            Len++;
        }

        public void Remove(int index)
        {
            checkForRangeError(index);
            if(index <= Len / 2)
            {

            }

        }

        public T ElementAt(int index)
        {
            checkForRangeError(index);
            return array[index];
        }

        public void Clear()
        {

        }

        /// <summary>
        /// Throws Index exception when an index is greater than the length of the array
        /// </summary>
        /// <param name="index"></param>
        private void checkForRangeError(int index)
        {
            if (index > Len) throw new IndexOutOfRangeException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
