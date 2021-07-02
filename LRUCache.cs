using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace DataStructure
{
    public class LRUCache
    {
        private Hashtable Cache;
        public LinkedList<Node> Nodes = new LinkedList<Node>();
        public int CurrentCacheCapacity { get; private set; }

        public LRUCache(int cacheCapacity)
        {
            CurrentCacheCapacity = cacheCapacity;
            this.Cache = new Hashtable(capacity: cacheCapacity);
        }

        public string Get(string  key)
        {
            if (!Cache.ContainsKey(key)) return null;
            String value = (string) Cache[ key];
            Node node = new Node(key, value);
            RemoveFromList(node);
            MakeLatestNode(node);
            return value;
        }

        public void Put(String key, String value)
        {
            Node node = new Node(key, value);
            if (Cache.Contains(key))
            {
                Cache[key] = value;
                node = new Node(key, value);
                RemoveFromList(node);
            } else
            {
                if (CacheIsFull())
                {
                    RemoveOldestCache();
                }
                AddCache(key, value);
            }
            MakeLatestNode(node);
        }

        private void MakeLatestNode(Node node)
        {
            Nodes.AddFirst(node);
        }

        private void AddCache(String key, String value)
        {
            Cache.Add(key, value);
            CurrentCacheCapacity--;
        }

        private void RemoveOldestCache()
        {
            Cache.Remove(Nodes.Last.Value.Key);
            Nodes.RemoveLast();
            CurrentCacheCapacity++;
        }

        private void RemoveFromList(Node node)
        {
            Nodes.Remove(node);
        }

        private bool CacheIsFull()
        {
            return Cache.Count == CurrentCacheCapacity;
        }
    }

    public class Node
    {
        public Node Prev;
        public Node Next;

        public String Key;
        public String Value;

        public Node(String  key, String value)
        {
            this.Key = key;
            this.Value = value;
        }


    }
}
