using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        public Leaf root;

        public Tree(Leaf data)
        {
            root = data;
        }

        public void PrintTree(Leaf L, ref string s)
        {
            if (L.left != null)
            {
                PrintTree(L.left, ref s);
                s = s + L.Value.ToString().PadLeft(3);
            }
            else
            {
                s = s + L.Value.ToString().PadLeft(3);
            }
            if (L.right != null)
            {
                PrintTree(L.right, ref s);
            }
            Console.WriteLine(s);
        }

    }
}
