using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }

        public void Add(Node<T> node)
        {
            node.Next = Head;
            Head = node;
        }

        //O(1) space
        //O(n) processing time
        public Node<T> Midpoint()
        {   
            Node<T> mid = Head;
            Node<T> last = mid;

            while (last != null && last.Next != null)
            {
                last = last.Next.Next;
                mid = mid.Next;
            }

            return mid;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> last = Head;
            while (last != null)
            {
                yield return last.Data;
                last = last.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Node<T>
    {
        public Node(T value)
        {
            Data = value;
        }

        public T Data { get; set; }

        public Node<T> Next { get; set; }
    }

}
