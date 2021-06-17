using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructure.Sorting
{
    public class SelectionSort
    {
        public string excercise(String input)
        {
            int[] xInputs = input.Split(" ").Select(input => Convert.ToInt32(input)).ToArray();

            int min;

            for (int i = 0; i < xInputs.Length -1; i++)
            {
                min = i;

                for(int j = i+1; j < xInputs.Length; j++)
                {
                    if(xInputs[j] < xInputs[min])
                    {
                        // Swap
                        min = j;
                    }
                }

                int org = xInputs[i];
                xInputs[i] = xInputs[min];
                xInputs[min] = org;
            }

            return string.Join(" ", xInputs.Select(x => x));
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
