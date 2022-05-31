using System;
using System.Collections.Generic;
using System.Linq;

namespace dynamic_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Programming (https://www.youtube.com/watch?v=oBt53YbR9Kk)

            //Fibonacci
            //Print(fib(6)); //8
            //Print(fib(7)); //13
            //Print(fib(8)); //21
            //Print(fib(50));//12586269025

            //Grid Traveler
            //Print(gridTravel(1, 1));    //1
            //Print(gridTravel(2, 3));    //3
            //Print(gridTravel(3, 2));    //3
            //Print(gridTravel(3, 3));    //6
            //Print(gridTravel(18, 18));  //2333606220

            // canSum
            //Print(canSum(7, new int[] { 2, 3 }));      //true 
            //Print(canSum(7, new int[] { 5, 3, 4, 7 }));//true
            //Print(canSum(7, new int[] { 2, 4 }));      //false
            //Print(canSum(8, new int[] { 2, 3, 5 }));   //true
            //Print(canSum(300, new int[] { 7, 14 }));   //false

            // howSum
            //Print(howSum(7, new int[] { 2, 3 }));       //[3, 2, 2]
            //Print(howSum(7, new int[] { 5, 3, 4, 7 })); //[4, 3]
            //Print(howSum(7, new int[] { 2, 4 }));       // null
            //Print(howSum(8, new int[] { 2, 3, 5 }));    //[2, 2, 2, 2]
            //Print(howSum(300, new int[] { 7, 14 }));    // null

            // bestSum
            //Print(bestSum(7, new int[] { 5, 3, 4, 7 }));    // [7]
            //Print(bestSum(8, new int[] { 2, 3, 5 }));       // [3, 5]
            //Print(bestSum(8, new int[] { 1, 4, 5 }));       // [4, 4]
            //Print(bestSum(100, new int[] { 1, 2, 5, 25 })); // [25, 25, 25, 25]

            // canConstruct
            //Print(canConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); // true
            //Print(canConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // false
            //Print(canConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // true
            //Print(canConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee", "eeeeeee", "eeeeeeee", "eeeeeeeee", "eeeeeeee" })); // false

            // countConstruct
            //Print(countConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl"})); // 2
            //Print(countConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); // 1
            //Print(countConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0
            //Print(countConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // 4
            //Print(countConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee", "eeeeeee", "eeeeeeee", "eeeeeeeee", "eeeeeeee" })); // 0

            // allConstruct
            //Print(allConstruct("abc", new string[] { "a", "ab", "b", "c"})); // [a b c] [ab c]
            //Print(allConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl"})); // [purp le] [p ur p le]
            //Print(allConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // []
            //Print(allConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee", "eeeeeee", "eeeeeeee", "eeeeeeeee", "eeeeeeee" })); // 0

            // 
            // Problems (https://www.youtube.com/watch?v=Peq4GCPNC5c)
            // 

            //Print(IsAnagram("emrehan", "mehanre")); //true

            //Print(FirstAndLastIndex(5, new int[] { 2, 4, 5, 5, 5, 5, 5, 7, 9, 9 })); // [2, 6]
            //Print(FirstAndLastIndex(3, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })); // [-1,-1]
            //Print(FirstAndLastIndex(3, new int[] { 1, 3, 4, 4, 5, 6, 7})); // [1, 1]
            //Print(FirstAndLastIndex(3, new int[] { 1, 2, 4, 4, 5, 6, 7})); // [-1,-1]
            //Print(FirstAndLastIndex(3, new int[] { 1, 3, 3, 4, 5, 6, 7})); // [1, 2]
            //Print(FirstAndLastIndex(3, new int[] { 1, 2, 2, 2, 3, 3, 7})); // [4, 5]

            //Print(FindKthLargest(4, new int[] { 4, 2, 9, 7, 5, 6, 7, 1, 3 })); //6    Largest 4 is 6. [9 7 7 (6)]

            //Print(AllParantheses(3)); //["((()))", "(()())", "(())()", "()(())", "()()()"]
            //Print(AllParantheses(2)); //["(())", "()()"]

            //Gas station has 2 parameters gas->gas you will take when you receive that station, cost->cost of leaving that station. 
            //Return first index where you can start at, go all way and return back to that index.
            //for example: Example 3 -> Start at 8 9 10 0 1 . . 7 8 -> Successfully returned the initial state
            //Print(GasStation(new int[] { 1, 2, 3 }, new int[] { 3, 1, 2 })); // 1
            //Print(GasStation(new int[] { 1, 1, 1 }, new int[] { 3, 3, 3 })); // -1
            //Print(GasStation(new int[] { 1,5,3,3,5,3,1,3,4,5 }, new int[] { 5,2,2,8,2,4,2,5,1,2 })); // 8

            //Cources list,  reqs -> array of (x,y)  you have to take course "b" to take "a". Return true if it is possible to take all courses, false otherwise.
            //Print(SchoolSchedule(new int[] { 0, 1, 2 }, new List<Tuple<int, int>>() { Tuple.Create(0, 1), Tuple.Create(1, 2) })); //true
            //Print(SchoolSchedule(new int[] { 0, 1, 2, 3, 4, 5 }, new List<Tuple<int, int>>() { Tuple.Create(0, 1), Tuple.Create(3, 0), Tuple.Create(1, 3), Tuple.Create(2, 1), Tuple.Create(4, 1), Tuple.Create(4, 2), Tuple.Create(5, 3), Tuple.Create(5, 4) })); //false
            //Print(SchoolSchedule(new int[] { 0, 1, 2, 3, 4, 5 }, new List<Tuple<int, int>>() {                     Tuple.Create(3, 0), Tuple.Create(1, 3), Tuple.Create(2, 1), Tuple.Create(4, 1), Tuple.Create(4, 2), Tuple.Create(5, 3), Tuple.Create(5, 4) })); //true

            //Print Kth permutation. K-> 2 
        }

        private static bool SchoolSchedule(int[] courses, List<Tuple<int, int>> reqs)
        {
            if (courses.Length == 0) return true;

            foreach (var course in courses)
            {
                var preReqs = reqs.Where(f => f.Item1.Equals(course));
                bool check = false;

                foreach (var req in preReqs)
                {
                    if(courses.Count(f => f.Equals(req.Item2)) == 0)
                    {
                        check = true;
                    }
                }

                if (check || preReqs.Count() == 0)
                {
                    if(SchoolSchedule(courses.RemoveAt(course), reqs))
                        return true;
                }
            }

            return false;
        }

        private static int GasStation(int[] gas, int[] cost)
        {
            for(int id = 0; id < gas.Length; id++)
            {
                bool a = false;

                var currentP = id;
                var nextP = (id + 1) % gas.Length;
                var G = gas[currentP];

                do
                {
                    var remainGas = G - cost[currentP];
                    if (remainGas >= 0)
                    {
                        currentP = nextP;
                        nextP = (nextP+1) % gas.Length;

                        G = remainGas + gas[currentP];

                        a = true;
                    }
                    else
                        break;

                } while (currentP != id);
                
                if (a && currentP == id)
                    return id;
            }

            return -1;
        }

        private static List<string> AllParantheses(int count, Stack<char> stack = null)
        {
            if (stack == null) stack = new Stack<char>();
            if (count == 0 && stack.Count == 0) return new List<string>() { "" };
            if (count < 0) return null;

            List<string> all = new List<string>();

            //
            var set = new Stack<char>(stack);
            set.Push('(');
            var result1 = AllParantheses(count - 1, set);
            if (result1 != null)
            {
                for (int i = 0; i < result1.Count; i++)
                {
                    all.Add("(" + result1[i]);
                }
            }


            //
            if (stack.TryPeek(out char poped) && poped == '(')
            {
                var set2 = new Stack<char>(stack);
                set2.Pop();
                var result2 = AllParantheses(count, set2);
                if(result2 != null)
                    for(int i = 0; i < result2.Count; i++)
                    {
                        all.Add(")" +result2[i]);
                    }
            }


            return all;
        }

        #region FindKthLargest
        private static int FindKthLargest(int target, int[] nums)
        {
            for (int i = 0; i < target - 1; i++)
            {
                nums = nums.RemoveAt(Max(nums));
            }
            return nums[Max(nums)];
        }

        private static int Max(int[] nums)
        {
            int largest = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[largest])
                {
                    largest = i;
                }
            }
            return largest;
        } 
        #endregion

        private static int[] FirstAndLastIndex(int target, int[] arr)
        {
            if (target < arr[0] || target > arr[arr.Length - 1]) return new int[] { -1, -1 };

            int start = 0;
            int end = arr.Length - 1;
            int mid = arr.Length / 2;
            while(start <= end)
            {
                mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    break;
                }

                if (arr[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            
            if(arr[mid] != target) return new int[] { -1, -1 };

            // We found the target
            int firstIndex = mid;
            int lastIndex = mid;

            while (arr[firstIndex] == target)
                firstIndex--;
            
            while (arr[lastIndex] == target)
                lastIndex++;

            return new int[] { firstIndex+1, lastIndex-1 };
        }

        private static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            if (string.IsNullOrEmpty(str1)) return true;

            Dictionary<char, int> lookup = new Dictionary<char, int>();
            for(int i = 0; i < str1.Length; i++)
            {
                var currentChar = str1[i];
                if (lookup.ContainsKey(currentChar))
                {
                    lookup[currentChar]++;
                }
                else
                {
                    lookup[currentChar] = 1;
                }
            }

            for(int i = 0; i < str2.Length; i++)
            {
                var currentChar = str2[i];
                if (lookup.ContainsKey(currentChar))
                {
                    lookup[currentChar]--;
                    if (lookup[currentChar] < 0)
                        return false;
                    else if (lookup[currentChar] == 0)
                        lookup.Remove(currentChar);
                }
                else
                {
                    return false;
                }
            }

            return lookup.Count == 0;
        }

        private static List<List<string>> allConstruct(string str, string[] words, Dictionary<string, List<List<string>>> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<string, List<List<string>>>();
            if (lookup.ContainsKey(str)) return lookup[str];
            if (string.IsNullOrEmpty(str)) return new List<List<string>>() { new List<string>()};

            List<List<string>> paths = new List<List<string>>();
            foreach (var word in words.Where(f => str.StartsWith(f)))
            {
                var result = allConstruct(str.Substring(word.Length), words, lookup);
                if (result.Count != 0)
                {
                    foreach (var r in result)
                    {
                        var newList = new List<string> { word };
                        newList.AddRange(r);
                        paths.Add(newList);
                    }
                }
            }

            lookup[str] = paths;
            return paths;
        }

        private static int countConstruct(string str, string[] words, Dictionary<string, int> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<string, int>();
            if (lookup.ContainsKey(str)) return lookup[str];
            if (string.IsNullOrEmpty(str)) return 1;

            int count = 0;

            foreach (var word in words.Where(f => str.StartsWith(f)))
            {
                count += countConstruct(str.Substring(word.Length), words, lookup);
            }
            
            lookup[str] = count;
            return count;
        }

        private static bool canConstruct(string str, string[] words, Dictionary<string, bool> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<string, bool>();
            if (lookup.ContainsKey(str)) return lookup[str];
            if (string.IsNullOrEmpty(str)) return true;

            foreach (var word in words.Where(f => str.StartsWith(f)))
            {
                if (canConstruct(str.Substring(word.Length), words, lookup))
                {
                    lookup[str] = true;
                    return true;
                }
            }
            lookup[str] = false;
            return false;
        }

        private static int[] bestSum(int sum, int[] nums, int[] path = null, Dictionary<int, int[]> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<int, int[]>();

            if (lookup.ContainsKey(sum)) return lookup[sum];
            if (sum == 0) return new int[] { };
            if (sum < 0) return null;

            int bestSumCount = int.MaxValue;
            int[] bestPath = null;

            foreach (var num in nums)
            {
                var result = sum - num;
                var howSumResult = bestSum(result, nums, path, lookup);

                if (howSumResult != null)
                {
                    var newList = new int[] { num }.Concat(howSumResult).ToArray();
                    
                    if (newList.Length < bestSumCount)
                    {
                        bestSumCount = newList.Length;
                        bestPath = newList;
                    }
                }
            }
            lookup[sum] = bestPath;
            return bestPath;
        }
        
        private static int[] howSum(int sum, int[] nums, int[] path = null, Dictionary<int, int[]> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<int, int[]>();

            if (lookup.ContainsKey(sum)) return lookup[sum];
            if (sum == 0) return new int[] {};
            if (sum < 0) return null;

            foreach(var num in nums)
            {
                var result = sum - num;

                var howSumResult = howSum(result, nums, path, lookup);
                if (howSumResult != null)
                {
                    lookup[result] = howSumResult;
                    return new int[] { num }.Concat(howSumResult).ToArray();
                }
            }

            lookup[sum] = null;
            return null;
        }

        private static bool canSum(int sum, int[] nums, Dictionary<long, bool> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<long, bool>();

            if (lookup.ContainsKey(sum)) return lookup[sum];
            if (sum < 0) return false;
            if (sum == 0) return true;
            
            foreach (var num in nums)
            {
                var result = sum - num;
                lookup[result] = canSum(result, nums, lookup);
                
                if (lookup[result])
                    return true;
            }

            return false;
        }

        private static long gridTravel(int x, int y, Dictionary<string, long> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<string, long>();

            var key = Math.Max(x, y).ToString() + "," + Math.Min(x, y).ToString();

            if (lookup.ContainsKey(key)){return lookup[key];}
            if (x == 0 || y == 0) return 0;
            if (x == 1 && y == 1) return 1;

            lookup[key] = gridTravel(x - 1, y, lookup) + gridTravel(x, y - 1, lookup);
            return lookup[key];
        }

        private static long fib(long v, Dictionary<long, long> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<long, long>();
            if (v <= 2) return 1;
            if (lookup.ContainsKey(v)) return lookup[v];

            lookup[v] = fib(v - 1, lookup) + fib(v - 2, lookup);
            return lookup[v];
        }

        private static void Print(int[] nums)
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

        private static void Print(int num)
        {
            Console.WriteLine(num.ToString());
        }
        private static void Print(bool num)
        {
            Console.WriteLine(num.ToString());
        }
        private static void Print(long num)
        {
            Console.WriteLine(num.ToString());
        }
        private static void Print(string[][] allPaths)
        {
            if(allPaths == null)
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
        private static void Print(List<List<string>> allPaths)
        {
            if(allPaths.Count == 0)
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

        private static void Print(List<string> str)
        {
            Console.Write("[ ");
            foreach (var s in str)
            {
                Console.Write("\"" + s + "\" ");
            }
            Console.Write(" ]\n");
        }

        
    }

    public static class EmrehanExtension
    {
        public static T[] RemoveAt<T>(this T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);

            return arr;
        }
    }
}
