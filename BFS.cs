using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class BFS
    {
        public bool hasPathBFS(Node source , Node destination)
        {
            Queue<Node> nodesToVisit = new Queue<Node>();
            HashSet<int> visited = new HashSet<int>();

            nodesToVisit.Enqueue(source);

            while(nodesToVisit.Count > 0)
            {
                Node node = nodesToVisit.Dequeue();
                if(node.id == destination.id)
                {
                    Console.WriteLine("Arrived");
                    return true;
                }
                if (visited.Contains(node.id))
                {
                    Console.WriteLine("Added");
                    continue;
                }
                visited.Add(node.id);

                foreach (Node child in node.neighbours)
                {
                    Console.WriteLine(child.id);
                        nodesToVisit.Enqueue(child);
                }
            }

            return false;
        }
        public class Node
        {
            public int id;
            public LinkedList<Node> neighbours = new LinkedList<Node>();
            public Node(int id)
            {
                this.id = id;
            }
        }
    }
}
