using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf root = new Leaf(1);
            Tree tree = new Tree(root);
            root.right = new Leaf(2);
            root.left = new Leaf(3);
            root.right.right = new Leaf(4);
            root.right.left = new Leaf(5);
            root.left.left = new Leaf(6);
            root.left.right = new Leaf(7);

            string startString = "";
            tree.PrintTree(root, ref startString);
            Console.Read();
        }
    }
}
