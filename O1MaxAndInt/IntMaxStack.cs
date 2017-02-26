using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O1MaxAndInt
{
    public class IntMaxStack
    {
        public class Node
        {
            public int num = 0;
            public int max = 0;
        }

        LinkedList<Node> list = new LinkedList<Node>();

        public void Push(int i)
        {
            // Gets a bit unreadable in there checking for a null last value.
            Node n = new Node() { num = i, max = (list.Last?.Value?.max ?? int.MinValue) > i ? list.Last.Value.max : i };
            list.AddLast(n);
        }

        public void Remove()
        {
            if (list.Count > 0)
                list.RemoveLast();
        }

        public int GetMax()
        {
            if (list.Count > 0)
                return list.Last.Value.max;
            return -1;  // Unknown spec from assignment. Assuming -1
        }
    }
}
