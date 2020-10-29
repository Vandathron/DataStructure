using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Palantir
    {

        public static void findHighPoints(List<List<int>> elevations)
        {
             HashSet<int> visited = new HashSet<int>();

             Queue<Elevation> nodesToVisit = new Queue<Elevation>();

            bool[,] matrix = new bool[elevations.Count, elevations[0].Count];


            for (int i = 0; i < elevations.Count; i++)
            {
                for (int j = 0; j < elevations[i].Count; j++)
                {
                    Queue<int> neighbours = new Queue<int>();

                    
                }
                Console.WriteLine();
            }

            int counter = 0;

            while (matrix.GetLength(0) <= elevations.Count || matrix.GetLength(1) <= elevations[0].Count)
            {
               
                Queue<int> neighbours = new Queue<int>();


                Elevation node = nodesToVisit.Dequeue();
                
                if (visited.Contains(node.id))
                {
                    Console.WriteLine("Added");
                    continue;
                }
                visited.Add(node.id);

                
            }

            //nodesToVisit.Enqueue(source);


        }

        public class Elevation
        {
            public int id;
            public LinkedList<Elevation> neighbours = new LinkedList<Elevation>();
            public Elevation(int id)
            {
                this.id = id;
            }
        }
    }
}
