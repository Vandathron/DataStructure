using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Leetcode.Medium
{
    public static class AvoidFloodInTheCity
    {
        public static int[] Solution(int[] rains)
        {
            int[] ans = new int[rains.Length];
            HashSet<int> fullLakes = new HashSet<int>();

            for (int i = 0; i < rains.Length; i++)
            {
                if(rains[i] > 0)
                {
                    if (fullLakes.Contains(rains[i])) return new int[] { };


                } else
                {

                }
            }



            return ans;
        }
    }
}
