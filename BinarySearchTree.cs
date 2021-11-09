using System;

namespace AndoBinarySearchTree
{
    internal class Node
    {
        internal int Data;
        internal Node Left;
        internal Node Right;

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    internal class BinarySearchTree
    {
        private Node root = null;

        public void Add(int data)
        {
            AddHelper(ref root, data);
        }

        private void AddHelper(ref Node curNode, int data)
        {
            // Stopping case: found the location to add the node
            if (curNode == null)
            {
                Console.WriteLine($"Adding {data} to the tree.");
                curNode = new Node(data);
                return;
            }
            
            // Stopping case: data/node already exists
            if (curNode.Data == data)
            {
                Console.WriteLine($"Data {data} is already in the tree.");
                return;
            }

            if (data < curNode.Data)
            {
                AddHelper(ref curNode.Left, data);
            }
            else if (data > curNode.Data)
            {
                AddHelper(ref curNode.Right, data);
            }
        }

        public void Remove(int data)
        {
            return;
        }

        public void PrintTree()
        {
            if (root == null)
            {
                Console.WriteLine("The tree is empty.");
            }
            else
            {
                PrintTreeHelper(root);
            }
        }

        private void PrintTreeHelper(Node curNode)
        {
            if (curNode != null)
            {
                PrintTreeHelper(curNode.Left);
                Console.WriteLine(curNode.Data);
                PrintTreeHelper(curNode.Right);
            }
        }
    }
}