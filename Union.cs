using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Union
    {


    }

    public class QuickFind : IUnionFind
    {
        private int componentCount;
        private int[] dots;

        public QuickFind(int N)
        {
            this.componentCount = N;
            dots = new int[N];

            for (int i = 0; i < N; i++)
            {
                dots[i] = i;
            }
        }
        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public int Count()
        {
            return componentCount;
        }

        public int Find(int p)
        {
            return dots[p];
        }

        public void Union(int p, int q)
        {
            int pComponent = Find(p);
            int qComponent = Find(q);

            if (pComponent == qComponent) return;

            for (int i = 0; i < dots.Length; i++)
            {
                if (dots[i] == qComponent) dots[i] = pComponent;
            }
            componentCount--;
        }
    }

    public class QuickUnion : IUnionFind
    {
        public int componentCount;
        public int[] dots;

        public QuickUnion(int N)
        {
            componentCount = N;
            dots = new int[N];
            for (int i = 0; i < N; i++)
            {
                dots[i] = i;
            }
        }
        public bool Connected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public int Count()
        {
            return componentCount;
        }

        public int Find(int p)
        {
            while (p != dots[p])
            {
                p = dots[p];
            }

            return p;
        }

        public void Union(int p, int q)
        {
            int pComponent = Find(p);
            int qComponent = Find(q);

            if (pComponent == qComponent) return;

            dots[pComponent] = qComponent;

            componentCount--;
        }
    }

    public interface IUnionFind
    {
        //return the number of disjoint components
        int Count();

        //return true if two objects are connected, or return false if not connected
        bool Connected(int p, int q);

        //return the id of disjoint component that an object belongs to
        int Find(int p);

        //connect two objects if not connected 
        void Union(int p, int q);
    }
}
