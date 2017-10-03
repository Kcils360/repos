using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Leaf
    {
        public int Value;
        public Leaf left;
        public Leaf right;
        public Leaf(int data)
        {
            Value = data;
            left = null;
            right = null;
        }
    }
}
