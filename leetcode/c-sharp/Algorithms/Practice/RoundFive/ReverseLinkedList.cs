using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Util;

namespace Algorithms.Practice.RoundFive
{
    public static class ReverseLinkedList
    {
        public static Node? Do(Node? root)
        {
            if (root is null || root.Next is null)
                return root;

            Node? current = root;
            Node? last = null;

            while (current != null)
            {
                var tmp = current.Next;
                current.Next = last;
                last = current;
                current = tmp;
            }

            return last;
        }
    }
}
