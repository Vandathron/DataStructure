using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Sorting
{
   public class InsertionSort
    {
        
        public void Implementation(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int element = arr[i];

                for (int j = i-1; j >= 0; j--)
                {
                    if (arr[j] > element)
                    {
                        int temp = arr[j];
                        arr[j] = element;
                        arr[j+1] = temp;
                    }
                    else break;
                }
            }
        }

        public void First(int[] arr)
        {
            int[] unsorted =new int [arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                unsorted[i] = arr[i];
                Console.Write("{0} ", unsorted[i]);
                int element = arr[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > element)
                    {
                        int temp = arr[j];
                        arr[j] = element;
                        arr[j + 1] = temp;
                    }
                    else break;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < unsorted.Length; i++)
            {
                int low = 0;
                int high = arr.Length - 1;
                int key = unsorted[i];

                while (low <= high)
                {
                    int mid = (high + low) / 2;
                    if(arr[mid] > key)
                    {
                        high = mid- 1;
                    } else if(arr[mid] < key)
                    {
                        low = mid + 1;
                    } else
                    {
                        Console.Write(mid + 1 + " ");
                        break;
                    }
                }
            }
        }

        public static string firstRepeatedWord(string sentence)
        {
            HashSet<string> words = new HashSet<string>();
            string word = "";
            string repeatedWord = "";

            
            for (int i = 0; i < sentence.Length; i++)
            {
                string letter = sentence[i].ToString();
                if ((letter == "," || letter == ";" || letter == "-" || letter == ":" || letter == "."))
                {
                        bool wordRep = words.Add(word);
                        if (!wordRep)
                        {
                            repeatedWord = word;
                            break;
                        }
                        word = "";
                }
                else
                {
                    word += letter;
                }
            }

            return repeatedWord;
        }

        public static void goodSegment(List<int> badNumbers, int lower, int upper)
        {
            int[] bNumbers = badNumbers.ToArray();

            List<int> range = new List<int>();

            for (int i = 0; i < bNumbers.Length; i++)
            {
                while ((lower != bNumbers[i] && upper != bNumbers[i]) && lower != upper)
                {
                    range.Add(lower);
                    lower++;
                }

            }


            for (int i = 0; i < range.Count; i++)
            {
                Console.Write("{0} ", range[i]);
            }
        }
    }
}
