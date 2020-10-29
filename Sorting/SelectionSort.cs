using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructure.Sorting
{
    public class SelectionSort
    {
        public void excercise()
        {
            int[] xInputs = Console.ReadLine().Split(" ").Select(input => Convert.ToInt32(input)).ToArray();
            int[] unsortedArr = Console.ReadLine().Split(" ").Select(element => Convert.ToInt32(element)).ToArray();
            int min = 0;
            int temp;
            for (int i = 0; i < xInputs[1]; i++)
            {
                min = i;
                for (int j = i+1; j < xInputs[0]; j++)
                {
                    if(unsortedArr[min] > unsortedArr[j])
                    {
                        min = j;
                    }
                }
                temp = unsortedArr[i];
                unsortedArr[i] = unsortedArr[min];
                unsortedArr[min] = temp;
            }

            for (int i = 0; i < xInputs[0]; i++)
            {
                Console.Write("{0} ", unsortedArr[i]);
            }
        }

        public int Rob(int[] nums)
        {
            Console.WriteLine("Test");
            int firstTrial = 0;
            int secondTrial = 0;
            int[] dp = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i +=2)
            {
                firstTrial += nums[i];
            }

            for (int i = 1; i < nums.Length; i +=2)
            {
                secondTrial += nums[i];
            }

            return firstTrial > secondTrial ? firstTrial : secondTrial;
        }
    }
}
