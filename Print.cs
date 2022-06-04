using System;
using System.Collections.Generic;
using System.Text;

namespace dynamic_programming
{
    public static class P
    {
        public static void Print(int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("null");
                return;
            }

            var str = "";
            foreach (var num in nums)
            {
                str += num + " ";
            }
            Console.WriteLine(str);
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
    }
}
