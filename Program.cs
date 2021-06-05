using System;
using System.Collections.Generic;
using System.Xml.Schema;
using DataStructure.Searching;
using System.Linq;
using DataStructure.Sorting;
using DataStructure.Hackerank.Medium;
using DataStructure.DesignPattern.Singleton;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkList<int> numbers = new CustomLinkList<int>();

            BFS.Node source = new BFS.Node(1);
            source.neighbours.AddFirst(new BFS.Node(2));
            source.neighbours.AddFirst(new BFS.Node(3));
            source.neighbours.First.Value.neighbours.AddFirst(new BFS.Node(8));
            source.neighbours.First.Value.neighbours.AddFirst(new BFS.Node(4));
            source.neighbours.First.Value.neighbours.AddFirst(new BFS.Node(5));
            source.neighbours.Last.Value.neighbours.AddFirst(new BFS.Node(11));
            source.neighbours.Last.Value.neighbours.AddFirst(new BFS.Node(10));

            BFS bf = new BFS();
           // Console.WriteLine(bf.hasPathBFS(source, new BFS.Node(1)));

            int[,] pixels = new int[,]
            {
                {1, 2, 3, 4, 2, 3, 2, 6 },
                {2, 4, 5, 6, 7, 3, 4, 8 },
                {1, 1, 4, 1, 1, 1, 8, 9 },
                {5, 6, 5, 3, 1, 1, 3, 6 },
                {5, 6, 7, 8, 1, 1, 4, 3 },
                {1, 3, 2, 1, 1, 1, 5, 6 },
                {1, 1, 1, 5, 1, 1, 1, 1 },
                {3, 5, 6, 7, 9, 3, 2, 2 }
            };

            int[,] p = new int[,]
            {
                {1, 3, 4, 4, 4, 4 },
                {1, 3, 4, 4, 4, 4 },
                {1, 3, 4, 4, 4, 4 }
            };

            // Singleton pattern
            Logger loggerObj = Logger.GetInstance();

            Logger loggerObj2 = Logger.GetInstance();

            Console.WriteLine(loggerObj.GetHashCode());
            Console.WriteLine(loggerObj2.GetHashCode());

        }
    }
}
