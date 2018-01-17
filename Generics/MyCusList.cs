using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    public class ListProperties<T> //: IEnumerable
    {
        int count;
        int volume;
        T[] mainArray;
        T[] secondaryArray;

        public ListProperties()
        {
            volume = 5;
            mainArray = new T[volume];
            secondaryArray = new T[0];


        }
        public int VolumeIndex
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T things)
        {
            if (count == VolumeIndex)
            {

            }
            mainArray[count] = things;
            count++;
        }

        //why did you use action? 
        public static ListProperties<T> operator +(ListProperties<T> propertiesOne, ListProperties<T> propertiesTwo)
        {
            ListProperties<T> addBothList = new ListProperties<T>();
            addBothList = propertiesOne + propertiesTwo;
            return addBothList;
        }
        public static ListProperties<T> operator -(ListProperties<T> propertiesOne, ListProperties<T> propertiesTwo)
        {
            ListProperties<T> reduceThings = new ListProperties<T>();
            reduceThings = propertiesOne - propertiesTwo;
            return reduceThings;
        }
        public void MakeBigArray()
        {
            T[] secondaryArray = new T[volume * 2];
            for (int i = 0; i < count; i++)
            {
                secondaryArray[i] = mainArray[i];
            }
            volume = volume * 2;
            mainArray = secondaryArray;
        }
        public bool Remove(T thing)
        {
            for (int i = 0; i < count; i++)
            {
                if (mainArray[i].Equals(thing))
                {
                    mainArray[i] = mainArray[i + 1];
                    count++;
                    return true;
                }
            }
            return false;
        }
        public IEnumerator<T> GetEnuerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return mainArray[i];
            }

        }
        IEnumerator<T> GetEnumerator()
        {
            return this.GetEnuerator();
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

    }
}





