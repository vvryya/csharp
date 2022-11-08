using System;

namespace Inheritance
{
    public class MyIntArray
    {
        private int[] _innerArray;
        
        public MyIntArray(int size)
        {
            _innerArray = new int[size];
        }

        public void SetAtIndex(int i, int value)
        {
            _innerArray[i] = value;
        }

        public int GetAtIndex(int i)
        {
            return _innerArray[i];
        }

        public override string ToString()
        {
            string res = "[ ";
            for(int i = 0; i < _innerArray.Length; i++)
            {
                if (i != _innerArray.Length - 1)
                    res += $"{_innerArray[i]}, ";
                else
                    res += $"{_innerArray[i]}";
            }

            res += " ]";

            return res;
        }
    }

    public class ArrayToString
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            var array = new MyIntArray(arraySize);

            for (int i = 0; i < arraySize; i++)
            {
                array.SetAtIndex(i, int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(array.ToString()); // You can omit .ToString()
        }
    }
}