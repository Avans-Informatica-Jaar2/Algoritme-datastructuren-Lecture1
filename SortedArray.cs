using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNumberSort
{
    internal class SortedArray : SearchableArray
    {
        private int[] numbers;

        public SortedArray(int[] numbers) 
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

            Array.Sort(newNumbers);

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
            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {

                int mid = left + (right - left) / 2;

                if (numbers[mid] == element)
                {
                    return mid; // Target gevonden
                }

                if (numbers[mid] < element)
                {
                    left = mid + 1; // Target bevindt zich in de rechterhelft
                }
                else
                {
                    right = mid - 1; // Target bevindt zich in de linkerhelft
                }
            }

            return -1; // Target niet gevonden

        }
    }
}
