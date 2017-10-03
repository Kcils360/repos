using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        public Leaf root;
        public Leaf right;
        public Leaf left;

        public Tree(int data)
        {
            root = new Leaf(data);
            left = null;
            right = null;
        }
        public void AddRight(int data)
        {
            Leaf newLeaf = new Leaf(data);
            right.right = newLeaf;
        }
    }
}
