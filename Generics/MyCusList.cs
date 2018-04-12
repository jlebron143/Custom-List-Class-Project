using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    public class ListProperties<T> //: IEnumerable
    {
        int volume;
        T[] mainArray;
        T[] secondaryArray;



        // IEnumerator

        public IEnumerator<T> GetEnuerator()
        {
            for (int i = 0; i < count; i++)

                yield return mainArray[i];
        }

        // constructor
        public ListProperties()
        {
            capacity = array.Length;
        }
        // member variables
        T[] array = new T[5];
        int count = 0;
        int capacity;
        // Accessors for member variables
        public int Count
        {
            get { return count; }
        }
        // Indexer
        public T this[int i]
        {
            get
            {
                if (i < count)
                {
                    return array[i];
                }
                else
                {
                    throw new Exception();
                }
            }
            set { array[i] = value; }
        }
        // member methods        
        public void Add(T input)
        {
            count++;
            if (count * 2 >= capacity)
            {
                capacity *= 2;
            }
            T[] result = new T[capacity];
            result[count - 1] = input;
            for (int i = 0; i < count - 1; i++)
            {
                result[i] = array[i];
            }
            array = result;
        }
        public bool Remove(T input)
        {
            bool removed = false;
            T[] result = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(input) && !removed)
                {
                    removed = true;
                    count--;
                    if (i < count)
                    {
                        result[i] = array[i + 1];
                    }
                }
                else if (removed)
                {
                    result[i] = array[i + 1];
                }
                else
                {
                    result[i] = array[i];
                }
            }
            array = result;
            return removed;
        }
        public override string ToString()
        {
            string adjustToString = "";
            for (int i = 0; i < Count; i++)
            {
                adjustToString = adjustToString + mainArray[i] + "";
            }
            return adjustToString;
        }
        public static ListProperties<T> operator +(ListProperties<T> one, ListProperties<T> two)
        {
            ListProperties<T> result = new ListProperties<T>();
            for (int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                result.Add(two[i]);
            }
            return result;
        }
        public static ListProperties<T> operator -(ListProperties<T> one, ListProperties<T> two)
        {
            ListProperties<T> result = new ListProperties<T>();
            for (int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                result.Remove(two[i]);
            }
            return result;
        }
        public ListProperties<T> Zip(ListProperties<T> objectA)
        {
            ListProperties<T> newList = new ListProperties<T>();
            if (objectA.Count > this.Count || objectA.count == this.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    newList.Add(this[i]);
                    newList.Add(objectA[i]);
                }
            }
            else
            {
                for (int i = 0; i < objectA.Count; i++)
                {
                    newList.Add(objectA[i]);
                    newList.Add(this[i]);
                }
            }
            return newList;
        }
        public void Sort()
        {
            T[] result = new T[count];
            result = array;
            int i, j;
            int N = count;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (Comparer<T>.Default.Compare(result[i], result[i + 1]) > 0)
                    {
                        Swap(result, i, i + 1);
                    }
                }
            }
            array = result;
        }

        public void Swap(T[] list, int left, int right)
        {
            T temporary;
            temporary = list[left];
            list[left] = list[right];
            list[right] = temporary;
        }

    }

}






