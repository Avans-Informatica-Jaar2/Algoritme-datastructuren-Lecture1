using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstNumberSort
{
    internal class UnsortedArray : SearchableArray
    {
        private int[] numbers;

        public UnsortedArray(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void Add(int element)
        {
            int[] newNumbers = new int[numbers.Length + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = numbers[i];
            }

            newNumbers[numbers.Length] = element;

            this.numbers = newNumbers;
        }

        public void Remove(int element)
        {
            int[] newNumbers = new int[numbers.Length - 1];

            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (i == IndexOf(element))
                {
                    continue;
                }

                newNumbers[j++] = numbers[i];
            }

            this.numbers = newNumbers;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == element)
                {
                    return i;
                }
            }

            return -1; // Target niet gevonden
        }
    }
}
