using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace SingleLinkedListProject
{
    class SingleLinkedLists
    {
        private Node start;
        public SingleLinkedLists()
        {
            start = null;

        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
                Console.WriteLine("List is :");
                p = start;
                while (p != null)
                {
                    Console.Write(p.info + " ");
                    p = p.link;
                }
            Console.WriteLine();
        }
        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine("Number of the nodes in the list=" + n);
        }
        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x) 
                    break;

                position++;
                p = p.link;

            }
            if (p == null)
            {
                 Console.WriteLine(x + "Not found in the list");
                return false;
            }
            else
            {
                Console.WriteLine(x + "is at position" + position);
                return true;

            }

        }
    }
}






