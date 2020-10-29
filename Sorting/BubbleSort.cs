using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure.Sorting
{
    public class BubbleSort
    {
        public void bubble_sort(int[] A, int n)
        {
            int temp;
            for (int k = 0; k < n-1; k++)
            {
                for (int i = 0; i < n-k-1; i++)
                {
                    if(A[i] > A[i + 1])
                    {
                        //here you swap positions
                        temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
        }

        public void practice()
        {
            int N = int.Parse(Console.ReadLine());

            int[] elements = Console.ReadLine().Split(" ").Select(v => Convert.ToInt32(v)).ToArray();
            int swapCounter = 0;
            int temp;
            for (int i = 0; i < N-1; i++)
            {
                for (int j = 0; j < N-i-1; j++)
                {
                    if (elements[j] > elements[j+1])
                    {
                        swapCounter++;
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }


            Console.WriteLine(swapCounter);
        }

        public void CSortItOut()
        {
            int N = int.Parse(Console.ReadLine());

            int[] elements = Console.ReadLine().Split(" ").Select(v => Convert.ToInt32(v)).ToArray();
            int[] indices = new int[elements.Length];
            int temp;

            for (int i = 0; i < elements.Length-1; i++)
            {
                for (int j = 0; j < elements.Length-i-1; j++)
                {
                    if(elements[j] > elements[j + 1])
                    {
                       // indices[i] = [i + 1];
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                    
                }
            }

            for (int i = 0; i < elements.Length; i++)
            {

            }
        }
    }
}
