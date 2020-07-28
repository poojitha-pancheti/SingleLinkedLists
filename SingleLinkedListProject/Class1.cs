using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedListProject
{

    class Node
    {
        public int info;
        public Node link;
        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}
