using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Result
    {
        public static List<int> meanderingArray(List<int> unsorted)
        {

            // sorting with bubble sort
            int n = unsorted.Count;
            int temp;
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = 0; i < n - k - 1; i++)
                {
                    if (unsorted[i] > unsorted[i + 1])
                    {
                        //here you swap positions
                        temp = unsorted[i];
                        unsorted[i] = unsorted[i + 1];
                        unsorted[i + 1] = temp;
                    }
                }
            }
            // At this point, unsorted is sorted

            List<int> meanderingArr = new List<int>() { };
            int lastIdx = unsorted.Count - 1;
            int firstIdx = 0;
            while (meanderingArr.Count < unsorted.Count)
            {
                meanderingArr.Add(unsorted[lastIdx]);
                meanderingArr.Add(unsorted[firstIdx]);
                lastIdx--;
                firstIdx++;
            }
            return meanderingArr;
        }
    }


    public class BalancingParent
    {
        public static string getMin(string s)
        {
            string balancedS = s;
            Stack<char> p = new Stack<char>();
            int minNumOfChar = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    p.Push(s[i]);
                }
                else
                {
                    try
                    {
                        char x = p.Pop();
                    }
                    catch (Exception e)
                    {
                        minNumOfChar++;
                        balancedS = $"({balancedS}";
                    }

                }
            }

            for(int i = 0; i < p.Count; i++)
            {
                balancedS +=")";
            }

            return balancedS;
        }
    }
}
