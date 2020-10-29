using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace DataStructure.Searching
{
    public class BinarySearch
    {

        int binarySearch(int low, int high, int key, int[] a)
        {
            while (low<=high)
            {
                int mid = (low + high) / 2;
                if(a[mid] < key)
                {
                    low = mid + 1;
                } else if (a[mid] > key)
                {
                    high = mid - 1;
                } else
                {
                    return mid;
                }
            }
            return -1; //Key not found
        }


        public void rankBasedProblem()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(" ").Select(v => Convert.ToInt32(v)).ToArray();
            if(arr[0] > arr[arr.Length - 1])
            {
                arr = arr.Reverse().ToArray();
            }
            Console.WriteLine(arr[0]);

            int q = int.Parse(Console.ReadLine());
            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                queries[i] = int.Parse(Console.ReadLine());
            }
            var watch = Stopwatch.StartNew();
            watch.Start();
            for (int i = 0; i < queries.Length; i++)
            {
                int low = 0;
                int high = arr.Length - 1;

                while (low <= high)
                {
                    int mid = (high + low) / 2;

                    if (arr[mid] < queries[i])
                    {
                        low = mid + 1;
                    } else if(arr[mid] > queries[i])
                    {
                        high = mid - 1;
                    } 
                    else
                    {
                        Console.WriteLine(mid+1);
                        break;
                    }
                }

            }
            Console.WriteLine("Time elapsed {0}ms", watch.ElapsedMilliseconds);
        }

        public void BishuAndSoldiers()
        {
            int N = int.Parse(Console.ReadLine());
            int[] powerOfSoldiers = Console.ReadLine().Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
            
            if(powerOfSoldiers[0] > powerOfSoldiers[powerOfSoldiers.Length - 1])
            {
                powerOfSoldiers = powerOfSoldiers.Reverse().ToArray();
            }


            
            int Q = int.Parse(Console.ReadLine());
            int[] QRounds = new int[Q];

            for (int i = 0; i < Q; i++)
            {
                QRounds[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < QRounds.Length; i++)
            {
                int low = 0;
                int high = powerOfSoldiers.Length - 1;
                int sumOfPowers = 0;

                while (low <= high)
                {
                    int mid = (high + low) / 2;

                    if(QRounds[i] > powerOfSoldiers[powerOfSoldiers.Length-1])
                    {
                        for (int r = 0; r < powerOfSoldiers.Length; r++)
                        {
                            sumOfPowers += powerOfSoldiers[r];
                            
                        }
                        Console.WriteLine("{0} {1}", powerOfSoldiers.Length, sumOfPowers);
                        break;
                    }
                    if (powerOfSoldiers[mid] > QRounds[i])
                    {
                        high = mid - 1;
                    } else if(powerOfSoldiers[mid] < QRounds[i])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        for (int j = 0;j <= mid; j++)
                        {
                            sumOfPowers += powerOfSoldiers[j];
                        }
                        Console.WriteLine("{0} {1}", mid+1, sumOfPowers);
                        break;
                    }

                }
            }
        }

        public void theFuriousFive()
        {

        }

        public void CImpressEveryone()
        {
            int n = int.Parse(Console.ReadLine());

            int[] stones = Console.ReadLine().Split(" ").Select(a => Convert.ToInt32(a)).ToArray();

            int q = int.Parse(Console.ReadLine());

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                queries[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int query = queries[i];
                int total = 0;

                for (int j = stones.Length-1; j >= 0; j--)
                {
                    total += stones[j];

                    if(query <= total)
                    {
                        Console.WriteLine(j % 2 == 0 ? "A" : "B");
                        break;
                    }
                }
            }
        }
    }
}
