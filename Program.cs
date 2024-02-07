using System;
using System.Collections.Generic;


namespace BST
{
    public class Node
    {
        public int value;
        public Node? left;
        public Node? right;

        public Node(int _value = 0, Node? _left = null, Node? _right = null) 
        {
            this.value = _value;
            this.left = _left;
            this.right = _right;
        }
        public Node(List<int> _list)
        {
            if (_list.Count == 0) return;
            this.value = _list[0];
            if (_list.Count == 1) return;
            for (int i = 1; i < _list.Count; i++)
                Add(this, _list[i]);
        }
        public Node(int[] Array)
        {
            if (Array.Length == 0) return;
            this.value = Array[0];
            if (Array.Length == 1) return;
            for (int i = 1; i < Array.Length; i++)
                Add(this, Array[i]);
        }
        public void Add(Node root, int _value)
        {

            if (_value <= root.value)
            {
                if (root.left != null)
                    Add(root.left, _value);
                else
                    root.left = new Node(_value);
            }
            else
            {
                if (root.right != null)
                    Add(root.right, _value);
                else
                    root.right = new Node(_value);
            }
        }

    }
    public static class BST
    {
        public static void Add(Node root, int _value)
        {

            if (_value <= root.value)
            {
                if (root.left != null)
                    Add(root.left, _value);
                else
                    root.left = new Node(_value);
            }
            else
            {
                if (root.right != null)
                    Add(root.right, _value);
                else
                    root.right = new Node(_value);
            }
        }
        public static void Remove(Node root, int _value)
        {

        }
        public static Node ListToBST(List<int> List)
        {
            Node root = new Node(List[0]);
            if (List.Count == 1) return root;
            for (int i = 1; i < List.Count; i++)
                Add(root, List[i]);
            return root;
        }
        public static void PrintLKR(Node root)
        {
            if (root.left != null) PrintLKR(root.left);
            Console.Write(root.value.ToString() + " ");
            if (root.right != null) PrintLKR(root.right);
        
        }
        public static void PrintLRK(Node root)
        {
            if (root.left != null) PrintLKR(root.left);
            if (root.right != null) PrintLKR(root.right);
            Console.Write(root.value.ToString() + " ");
        }
        public static void PrintKLR(Node root)
        {
            Console.Write(root.value.ToString() + " ");
            if (root.left != null) PrintLKR(root.left);
            if (root.right != null) PrintLKR(root.right);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> Data = new List<int>() { 2, 1, 4, 5, 8 };
            int[] Dane = new int[] { 7, 4, 2, 3, 7, 1 };
            //Node root = BST.ListToBST(Data);
            Node root = new Node(Dane);
            BST.PrintLKR(root);
            
        }

    }

}