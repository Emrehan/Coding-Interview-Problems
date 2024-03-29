﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dynamic_programming
{
    public static class P
    {
        public static void Print(int[] nums)
        {                        
            Console.WriteLine($"[{string.Join(",", nums)}]");
        }

        public static void Print(int num)
        {
            Console.WriteLine(num.ToString());
        }
        public static void Print(bool num)
        {
            Console.WriteLine(num.ToString());
        }
        public static void Print(long num)
        {
            Console.WriteLine(num.ToString());
        }
        public static void Print(string[][] allPaths)
        {
            if (allPaths == null)
            {
                Console.WriteLine("Null");
                return;
            }

            foreach (var path in allPaths)
            {
                Console.Write("[");
                foreach (var item in path)
                {
                    Console.Write(item + " ");
                }
                Console.Write("] ");
            }
        }
        public static void Print(int[][] allPaths)
        {
            if (allPaths == null)
            {
                Console.WriteLine("Null");
                return;
            }

            foreach (var path in allPaths)
            {
                Console.Write("[");
                foreach (var item in path)
                {
                    Console.Write(item + " ");
                }
                Console.Write("] ");
            }
        }
        public static void Print(List<List<string>> allPaths)
        {
            if (allPaths.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            foreach (var path in allPaths)
            {
                Console.Write("[");
                foreach (var item in path)
                {
                    Console.Write(item + " ");
                }
                Console.Write("], ");
            }
            Console.Write("\n");
        }

        public static void Print(List<string> str)
        {
            Console.Write("[ ");
            foreach (var s in str)
            {
                Console.Write("\"" + s + "\" ");
            }
            Console.Write(" ]\n");
        }
        public static void Print(char[][] A)
        {
            Console.WriteLine("[ ");
            foreach (var a in A)
            {
                Console.Write("[ ");
                foreach (var c in a)
                {
                    Console.Write(c + " ");
                }
                Console.Write("] ");
            }
            Console.WriteLine("]");
        }
        public static void Print(List<List<char>> A)
        {
            Console.Write("[ ");
            foreach (var a in A)
            {
                Console.Write("[ ");
                foreach (var c in a)
                {
                    Console.Write(c + " ");
                }
                Console.Write("] ");
            }
            Console.WriteLine("]");
        }

        internal static void Print(List<int> list)
        {
            Console.Write("[ ");
            foreach (var a in list)
                Console.Write(a + " ");
            Console.WriteLine(" ]");
        }

        internal static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public static void Print(ListNode s)
        {
            Console.WriteLine(s.val);
        }

        internal static void Print(IList<int> list)
        {
            Console.Write("[ ");
            foreach (var a in list)
                Console.Write(a + " ");
            Console.WriteLine(" ]");
        }

        internal static void Print(IList<IList<int>> list)
        {
            Console.Write("[ ");
            foreach (var a in list)
                Console.Write("[" + string.Join(",", a) + "]");
            Console.WriteLine(" ]");
        }

        static int COUNT = 5;
        internal static void Print(TreeNode root, int space = 0)
        {
            // Base case
            if (root == null)
                return;

            // Increase distance between levels
            space += COUNT;

            // Process right child first
            Print(root.right, space);

            // Print current node after space
            // count
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.val + "\n");

            // Process left child
            Print(root.left, space);
        }
    }
}
