using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataStructure.Searching
{
    public class LinearSearch
    {


        public void printLastIndex(int[] array, int element)
        {
            int lastIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == element)
                {
                    lastIndex = i;
                }
            }

            Console.WriteLine(lastIndex);
        }

        public void mannaFirstName(int testCases)
        {
            string suvo = "SUVO";
            string suvojit = "SUVOJIT";

            int suvoCounter = 0;
            int suvojitCounter = 0;
            string[] words = new string[testCases];

            for (int i = 0; i < testCases; i++)
            {
                words[i] = Console.ReadLine();
            }

            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < words.Length; i++)
            {
                string longWord = words[i];
                string word = "";
                
                for (int j = 0; j < longWord.Length; j++)
                {
                    word += longWord[j];

                    if (word.Length < 4) break;

                    if(word[j] == suvo[3])
                    {
                        suvoCounter++;
                        
                    } else if(word.Length <= suvojit.Length)
                    {
                        if (word == suvojit) suvojitCounter++;
                    }
                    else 
                    {
                        word = "";
                    }
                }

                Console.Write("SUVOJIT: {0} SUVO: {1}", suvoCounter, suvojitCounter);
            }
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        public void setSumProblem(int N, int M)
        {
            int[] A = new int[N];
            int[] C = new int[M];

            int[] B = new int[N > M ? M : N];

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Enter number for A");
                A[i] = int.Parse (Console.ReadLine());
            }

            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine("Enter number for C");
                C[i] = int.Parse(Console.ReadLine()); 
            }

            var watch = Stopwatch.StartNew();

            for (int i = 0;i< B.Length; i++)
            {
                B[i] = C[i] - A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("{0} ", B[i]);
            }
            Console.WriteLine("{0} ms",watch.ElapsedMilliseconds);
            
        }
    }
}
