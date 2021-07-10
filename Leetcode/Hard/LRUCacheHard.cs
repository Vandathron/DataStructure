using System;
using System.Collections.Generic;

namespace DataStructure.Leetcode.Hard
{
    public class LRUCacheHard
    {
        private Dictionary<int, int> Cache = new Dictionary<int, int>();
        private Dictionary<int, LinkedListNode<int>> refNodes = new Dictionary<int, LinkedListNode<int>>();
        private Dictionary<int, int> keyCounters = new Dictionary<int, int>();

        public LinkedList<int> Nodes = new LinkedList<int>();
        public int CurrentCacheCapacity = 0;
        public LRUCacheHard(int capacity)
        {
            CurrentCacheCapacity = capacity;
        }

        public int Get(int key)
        {
            if (!Cache.ContainsKey(key)) return -1;
            int value = (int)Cache[key];
            RemoveFromList(key);
            MakeLatestNode(key);
            int currentCounter = keyCounters[key];
            keyCounters.Remove(key);
            keyCounters[key] = currentCounter++;
            return value;
        }

        public void Put(int key, int value)
        {
            if (Cache.ContainsKey(key))
            {
                Cache[key] = value;
                RemoveFromList(key);
                MakeLatestNode(key);
            }
            else
            {

                if (CurrentCacheCapacity == 0)
                {
                    removeLRU();
                }
                AddCache(key, value);
                Nodes.AddFirst(key);
                refNodes[key] = Nodes.First;
            }


        }

        private void MakeLatestNode(int node)
        {
            var n = refNodes[node];
            Nodes.AddFirst(n);


        }

        private void AddCache(int key, int value)
        {
            Cache.Add(key, value);
            CurrentCacheCapacity--;
        }

        private void removeLRU()
        {
            var last = Nodes.Last;
            var lastFreq = keyCounters[last.Value];
            var beforeLast = last.Previous;
            var beforeLastFreq = keyCounters[beforeLast.Value];

            if(lastFreq <= beforeLastFreq)
            {
                keyCounters.Remove(last.Value);
                Cache.Remove(last.Value);
                refNodes.Remove(last.Value);
                Nodes.RemoveLast();
            } else
            {
                keyCounters.Remove(beforeLast.Value);
                Cache.Remove(beforeLast.Value);
                refNodes.Remove(beforeLast.Value);
                RemoveFromList(beforeLast.Value);
            }
            CurrentCacheCapacity++;
        }

        private void RemoveFromList(int node)
        {
            var n = refNodes[node];
            Nodes.Remove(n);
        }
    }
}
