using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LinkedList
{
    public class LinkedList
    {
        private Node head;

        private int size;

        public LinkedList()
        {

            this.head = null;
            this.size = 0;

        }

        public bool empty
        {

            get { return this.size == 0; }

        }

        public int count
        {
            get { return this.size; }
        }

        public object Add(int index, object o)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);

            }
            else if (index > size)
            {
                index = size;

            }

            Node current = this.head;

            if (this.empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;


                }
                current.Next = new Node(o, current.Next);

            }
            size++;
            return o;
        }
        
        public object Add(object o)
        {

            return this.Add(size, o);
        }

        public object Remove(int index)
        {

            if (index < 0)
            {

                throw new ArgumentOutOfRangeException("Index :" + index);

            }
            if (this.empty)
            {
                return null;
            }
            if (index >= this.size)
            {
                index = size - 1;
            }
            Node current = this.head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }

            size--;
            return result;
        }

        public void Clear()
        {
            this.head = null;
            this.size = 0;
        }

        public int IndexOf(object o)
        {
            Node current = this.head;

            for (int i = 0; i < this.size; i++)
            {
                if (current.Data.Equals(o))
                {
                    return i;
                }
                current = current.Next;
            }

            return -1;
        }

        public bool Contains(object o)
        {
            return this.IndexOf(o) >= -1;

        }

        public void display()
        {
            Node current = this.head;
            for (int i = 0; i < size; i++)
            {
                Console.Write(current.Data + ",");
                current = current.Next;


            }
        }

        public object Get(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }
            if (this.empty)
            {
                return null;
            }
            if (index >= this.size)
            {
                index = this.size - 1;
            }
            Node current = this.head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;

            }

            return current.Data;
        }

        public object this[int index]
        {
            get { return this.Get(index); }
        }
    }
}
