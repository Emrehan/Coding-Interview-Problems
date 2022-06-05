using System;
using System.Collections.Generic;
using System.Linq;

namespace dynamic_programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Programming (https://www.youtube.com/watch?v=oBt53YbR9Kk)

            //Fibonacci
            //P.Print(fib(6)); //8
            //P.Print(fib(7)); //13
            //P.Print(fib(8)); //21
            //P.Print(fib(50));//12586269025

            //Grid Traveler
            //P.Print(gridTravel(1, 1));    //1
            //P.Print(gridTravel(2, 3));    //3
            //P.Print(gridTravel(3, 2));    //3
            //P.Print(gridTravel(3, 3));    //6
            //P.Print(gridTravel(18, 18));  //2333606220

            // canSum
            //P.Print(canSum(7, new int[] { 2, 3 }));      //true 
            //P.Print(canSum(7, new int[] { 5, 3, 4, 7 }));//true
            //P.Print(canSum(7, new int[] { 2, 4 }));      //false
            //P.Print(canSum(8, new int[] { 2, 3, 5 }));   //true
            //P.Print(canSum(300, new int[] { 7, 14 }));   //false

            // howSum
            //P.Print(howSum(7, new int[] { 2, 3 }));       //[3, 2, 2]
            //P.Print(howSum(7, new int[] { 5, 3, 4, 7 })); //[4, 3]
            //P.Print(howSum(7, new int[] { 2, 4 }));       // null
            //P.Print(howSum(8, new int[] { 2, 3, 5 }));    //[2, 2, 2, 2]
            //P.Print(howSum(300, new int[] { 7, 14 }));    // null

            // bestSum
            //P.Print(bestSum(7, new int[] { 5, 3, 4, 7 }));    // [7]
            //P.Print(bestSum(8, new int[] { 2, 3, 5 }));       // [3, 5]
            //P.Print(bestSum(8, new int[] { 1, 4, 5 }));       // [4, 4]
            //P.Print(bestSum(100, new int[] { 1, 2, 5, 25 })); // [25, 25, 25, 25]

            // canConstruct
            //P.Print(canConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); // true
            //P.Print(canConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // false
            //P.Print(canConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // true
            //P.Print(canConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee", "eeeeeee", "eeeeeeee", "eeeeeeeee", "eeeeeeee" })); // false

            // countConstruct
            //P.Print(countConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl"})); // 2
            //P.Print(countConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" })); // 1
            //P.Print(countConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0
            //P.Print(countConstruct("enterapotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" })); // 4
            //P.Print(countConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee", "eeeeeee", "eeeeeeee", "eeeeeeeee", "eeeeeeee" })); // 0

            // allConstruct
            //P.Print(allConstruct("abc", new string[] { "a", "ab", "b", "c"})); // [a b c] [ab c]
            //P.Print(allConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl"})); // [purp le] [p ur p le]
            //P.Print(allConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // []
            //P.Print(allConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee", "eeeeeee", "eeeeeeee", "eeeeeeeee", "eeeeeeee" })); // 0






            // 
            // Problems (https://www.youtube.com/watch?v=Peq4GCPNC5c)
            // 

            //P.Print(IsAnagram("emrehan", "mehanre")); //true

            //P.Print(FirstAndLastIndex(5, new int[] { 2, 4, 5, 5, 5, 5, 5, 7, 9, 9 })); // [2, 6]
            //P.Print(FirstAndLastIndex(3, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })); // [-1,-1]
            //P.Print(FirstAndLastIndex(3, new int[] { 1, 3, 4, 4, 5, 6, 7})); // [1, 1]
            //P.Print(FirstAndLastIndex(3, new int[] { 1, 2, 4, 4, 5, 6, 7})); // [-1,-1]
            //P.Print(FirstAndLastIndex(3, new int[] { 1, 3, 3, 4, 5, 6, 7})); // [1, 2]
            //P.Print(FirstAndLastIndex(3, new int[] { 1, 2, 2, 2, 3, 3, 7})); // [4, 5]

            //P.Print(FindKthLargest(4, new int[] { 4, 2, 9, 7, 5, 6, 7, 1, 3 })); //6    Largest 4 is 6. [9 7 7 (6)]

            //P.Print(AllParantheses(3)); //["((()))", "(()())", "(())()", "()(())", "()()()"]
            //P.Print(AllParantheses(2)); //["(())", "()()"]

            //Gas station has 2 parameters gas->gas you will take when you receive that station, cost->cost of leaving that station. 
            //Return first index where you can start at, go all way and return back to that index.
            //for example: Example 3 -> Start at 8 9 10 0 1 . . 7 8 -> Successfully returned the initial state
            //P.Print(GasStation(new int[] { 1, 2, 3 }, new int[] { 3, 1, 2 })); // 1
            //P.Print(GasStation(new int[] { 1, 1, 1 }, new int[] { 3, 3, 3 })); // -1
            //P.Print(GasStation(new int[] { 1,5,3,3,5,3,1,3,4,5 }, new int[] { 5,2,2,8,2,4,2,5,1,2 })); // 8

            //Cources list,  reqs -> array of (x,y)  you have to take course "b" to take "a". Return true if it is possible to take all courses, false otherwise.
            //P.Print(SchoolSchedule(new int[] { 0, 1, 2 }, new List<Tuple<int, int>>() { Tuple.Create(0, 1), Tuple.Create(1, 2) })); //true
            //P.Print(SchoolSchedule(new int[] { 0, 1, 2, 3, 4, 5 }, new List<Tuple<int, int>>() { Tuple.Create(0, 1), Tuple.Create(3, 0), Tuple.Create(1, 3), Tuple.Create(2, 1), Tuple.Create(4, 1), Tuple.Create(4, 2), Tuple.Create(5, 3), Tuple.Create(5, 4) })); //false
            //P.Print(SchoolSchedule(new int[] { 0, 1, 2, 3, 4, 5 }, new List<Tuple<int, int>>() {                     Tuple.Create(3, 0), Tuple.Create(1, 3), Tuple.Create(2, 1), Tuple.Create(4, 1), Tuple.Create(4, 2), Tuple.Create(5, 3), Tuple.Create(5, 4) })); //true

            //P.Print Kth permutation. (N,K) 
            //  N = 2
            //  1 2
            //  2 1 -> K=2
            //P.Print(KthPermutation(3, 3)); // [2,1,3]

            //MinimumWindowSubstring  find minimum lenght substring of str that containts all characters in t
            //P.Print(MinimumWindowSubstring("ABBBA", "AA")); // "ABBBA"
            //P.Print(MinimumWindowSubstring("ADOBECODEBANC", "ABC")); // "BANC"
            //P.Print(MinimumWindowSubstring("ADCFEBECEABEBADFCDFCBFCBEAD", "ABCA")); // "CEABEBA"

            //LargestRectangleInHistogram
            //P.Print(LargestRectangleInHistogram(new int[] { 6, 3, 4, 2 })); //9
            //P.Print(LargestRectangleInHistogram(new int[] { 3, 2, 4, 5, 7, 6, 1, 3, 8, 9, 10, 11, 10, 7, 5, 2, 6 })); //35







            // https://leetcode.com/problems/max-points-on-a-line/
            //P.Print(MaxPoints(new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 }, new int[] { 4, 4 } })); //4
            //P.Print(MaxPoints(new int[][] { new int[] { 1, 1 }, new int[] { 3, 2 }, new int[] { 5, 3 }, new int[] { 4, 1 }, new int[] { 2, 3 }, new int[] { 1, 4 } })); //4
            //P.Print(MaxPoints(new int[][] { new int[] { -184, -551 }, new int[] { -105, -467 }, new int[] { -90, -394 }, new int[] { -60, -248 }, new int[] { 115, 359 }, new int[] { 138, 429 }, new int[] { 60, 336 }, new int[] { 150, 774 }, new int[] { 207, 639 }, new int[] { -150, -686 }, new int[] { -135, -613 }, new int[] { 92, 289 }, new int[] { 23, 79 }, new int[] { 135, 701 }, new int[] { 0, 9 }, new int[] { -230, -691 }, new int[] { -115, -341 }, new int[] { -161, -481 }, new int[] { 230, 709 }, new int[] { -30, -102 } })); //4








            //https://www.youtube.com/watch?v=A80YzvNwqXA
            //N Quenn
            //P.Print(SolveNQueen(4)); //[ [1,3,0,2], [2,0,3,1] ]





            //     A -> H <- I 
            //     |
            //     v
            //     B -> D -> F - > G
            //     | 
            //     v
            //     C -> E
            //
            var directGraph = new Dictionary<char, char[]>();
            directGraph.Add('A', new char[] { 'B', 'H' });
            directGraph.Add('B', new char[] { 'D', 'C' });
            directGraph.Add('C', new char[] { 'E' });
            directGraph.Add('D', new char[] { 'F' });
            directGraph.Add('E', new char[] {  });
            directGraph.Add('F', new char[] { 'G' });
            directGraph.Add('G', new char[] { });
            directGraph.Add('H', new char[] { });
            directGraph.Add('I', new char[] { 'H' });

            //   A - B - C
            //   |
            //   D
            //
            //   E - F
            //
            //   G - H - I
            //       |
            //       J
            var nonDirectGraph = new Dictionary<char, char[]>();
            nonDirectGraph.Add('A', new char[] { 'B', 'D' });
            nonDirectGraph.Add('B', new char[] { 'A', 'C' });
            nonDirectGraph.Add('C', new char[] { 'B' });
            nonDirectGraph.Add('D', new char[] { 'A' });
            nonDirectGraph.Add('E', new char[] { 'F' });
            nonDirectGraph.Add('F', new char[] { 'E' });
            nonDirectGraph.Add('G', new char[] { 'H' });
            nonDirectGraph.Add('H', new char[] { 'G', 'I', 'J' });
            nonDirectGraph.Add('I', new char[] { 'H' });
            nonDirectGraph.Add('J', new char[] { 'H' });

            //https://www.youtube.com/watch?v=tWVWeAqZ0WU //Graphs
            //P.Print(HasPath(graph, 'A', 'G')); //true
            //P.Print(HasPath(graph, 'A', 'E')); //true
            //P.Print(HasPath(graph, 'A', 'Y')); //false

            //P.Print(CountOfGroups(nonDirectGraph)); //3
            //P.Print(GetGroups(nonDirectGraph)); // [ [A, B, C, D], [E, F], [G, H, I, J] ]



            //HackerRank
            //https://www.hackerrank.com/challenges/climbing-the-leaderboard
            //P.Print(ClimbingLeaderboard(new List<int>() { 100, 90, 90, 80, 75, 60 }, new List<int>() { 50, 65, 77, 90, 102 })); // [6, 5, 4, 2, 1]
            //P.Print(ClimbingLeaderboard(new List<int>() { 100, 100, 50, 40, 40, 20, 10}, new List<int>() { 5, 25, 50, 120 })); // [6, 4, 2, 1]
            //P.Print(ClimbingLeaderboard(new List<int>() { 100, 90, 90, 80}, new List<int>() { 70, 80, 105 })); // [4, 3, 1]

            //https://www.hackerrank.com/challenges/compare-the-triplets
            //P.Print(compareTriplets(new List<int>() { 5, 6, 7 }, new List<int>() { 3, 6, 10 })); // [1, 1]
            //P.Print(compareTriplets(new List<int>() { 17, 28, 30 }, new List<int>() { 99, 16, 8 })); // [2, 1]

            //https://www.hackerrank.com/challenges/magic-square-forming
            //3x3'te magic number hep 15 olur
            //P.Print(formingMagicSquare( new List<List<int>>() { new List<int>() { 5, 3, 4}, new List<int>() { 1, 5, 8}, new List<int>() { 6, 4, 2} } )); //7
            //P.Print(formingMagicSquare( new List<List<int>>() { new List<int>() { 4, 9, 2}, new List<int>() { 1, 5, 8}, new List<int>() { 6, 4, 2} } )); //4

            //https://www.hackerrank.com/challenges/encryption/problem?isFullScreen=true
            P.Print(encryption("haveaniceday")); // hae and via ecy

            //https://www.hackerrank.com/challenges/flipping-bits/problem?isFullScreen=true
        }

        public static string encryption(string s)
        {
            s = s.Replace(" ", "");

            int r = (int)Math.Floor(Math.Sqrt(s.Length));
            int c = (int)Math.Ceiling(Math.Sqrt(s.Length));

            if (r * c < s.Length)
                r = c;

            string result = "";
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                    if (i + j * c < s.Length)
                        result += s[i + j * c];
                result += " ";
            }

            return result;
        }

        public static int formingMagicSquare(List<List<int>> s)
        {
            int count = 0;
            foreach (var row in s)
                count += Math.Abs(15 - row.Sum());
            return count;
        }
    

        private static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var aScore = 0;
            var bScore = 0;
            for(int i = 0; i < a.Count; i++)
            {
                var diff = a[i] - b[i];
                if (diff > 0)
                    aScore++;
                else if (diff < 0)
                    bScore++;
            }
            return new List<int>() { aScore, bScore };
        }

        private static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            foreach (var x in player)
            {
                var editedList = new List<int>(ranked);
                editedList.Add(x);
                editedList = editedList.Distinct().ToList();
                editedList.Sort();
                editedList.Reverse();
                
                int l = 0;
                int r = editedList.Count - 1;
                int m = 0;

                while(l < r)
                {
                    m = (l + r) / 2;

                    if (editedList[m] == x)
                        break;
                    else if (editedList[m] > x)
                        l = m + 1;
                    else
                        r = m - 1;
                }
                m = (l + r) / 2;
                
                result.Add(m+1);
            }
            return result;
        }

        private static List<List<char>> GetGroups(Dictionary<char, char[]> nonDirectGraph)
        {
            var visited = new HashSet<char>();
            var groups = new List<List<char>>();
            foreach (var node in nonDirectGraph.Keys)
            {
                var result = GetGroup(nonDirectGraph, node, visited);
                if (result != null)
                    foreach (var g in result)
                        groups.Add(g);
            }
            return groups;
        }

        private static List<List<char>> GetGroup(Dictionary<char, char[]> nonDirectGraph, char node, HashSet<char> visited)
        {
            if (visited.Contains(node)) return null;
            visited.Add(node);

            var groups = new List<List<char>>() { new List<char>() { node } };            
            foreach (var neighboor in nonDirectGraph[node])
            {
                var result = GetGroup(nonDirectGraph, neighboor, visited);
                if (result != null)
                    for(int i = 0; i < groups.Count; i++)
                        foreach (var resultGroup in result)
                            groups[i] = groups[i].Concat(resultGroup).ToList();
            }
            
            return groups;
        }

        private static int CountOfGroups(Dictionary<char, char[]> nonDirectGraph)
        {
            int c = 0;
            var visited = new HashSet<char>();
            foreach (var node in nonDirectGraph.Keys)
            {
                if (ExploreGroups(nonDirectGraph, node, visited))
                    c++;
            }
            return c;
        }

        private static bool ExploreGroups(Dictionary<char, char[]> nonDirectGraph, char node, HashSet<char> visited)
        {
            if (visited.Contains(node)) return false;
            visited.Add(node);

            foreach (var neighboor in nonDirectGraph[node])
            {
                ExploreGroups(nonDirectGraph, neighboor, visited);
            }
            return true;
        }

        private static bool HasPath(Dictionary<char, char[]> graph, char src, char target, HashSet<char> visited = null)
        {
            if (visited == null) visited = new HashSet<char>();
            if (src == target) return true;
            if (visited.Contains(src)) return false;
            
            visited.Add(src);
            
            foreach (var next in graph[src])
            {
                if(HasPath(graph, next, target, visited))
                {
                    return true;
                }
            }
            return false;
        }

        private static int[][] SolveNQueen(int n, int[] prev = null)
        {
            if (prev == null) prev = new int[] { };
            if (prev.Length == n) return new int[][] { prev };

            List<int[]> allWays = new List<int[]>();
            
            for(int i = 0; i < n; i++)
            {
                if (prev.Contains(i))                     
                    continue;

                if (prev.Length != 0)
                    if (prev.Last() + 1 == i || prev.Last() - 1 == i)
                        continue;

                var result = SolveNQueen(n, prev.Concat(new int[] { i }).ToArray());
                if (result != null)
                    allWays.AddRange(result);
            }

            return allWays.ToArray();
        }

        private static int LargestRectangleInHistogram(int[] numbers)
        {
            Queue<Tuple<int, int>> Q = new Queue<Tuple<int, int>>();
            for (int i = 0; i < numbers.Length; i++)
                Q.Enqueue(Tuple.Create(i, i));

            Tuple<int, int> maxTuple = Tuple.Create(0, 0);
            int maxSize = -1;

            while(Q.Count != 0)
            {
                var T = Q.Dequeue();
                var tSize = SizeOfTuple(T, numbers);

                if (tSize >= maxSize)
                {
                    maxTuple = T;
                    maxSize = tSize;
                }

                var leftTuple = Tuple.Create(T.Item1 - 1, T.Item2);
                if (leftTuple.Item1 >= 0 && !Q.Contains(leftTuple))
                    Q.Enqueue(leftTuple);

                var rightTuple = Tuple.Create(T.Item1, T.Item2+1);
                if (rightTuple.Item2 < numbers.Length && !Q.Contains(rightTuple))
                    Q.Enqueue(rightTuple);
            }

            return maxSize;
        }

        private static int SizeOfTuple(Tuple<int, int> t, int[] numbers)
        {
            int width = t.Item2 - t.Item1 + 1;

            int min = numbers[t.Item2];
            for(int i = t.Item1; i < t.Item2; i++)
            {
                if(numbers[i] <= min)
                {
                    min = numbers[i];
                }
            }

            return min * width;
        }

        //Goodone
        private static string MinimumWindowSubstring(string str, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 0);
                dict[c]++;
            }

            Dictionary<char, int> subStringDict = new Dictionary<char, int>();
            foreach (char c in str.Substring(0, t.Length))
            {
                if (!subStringDict.ContainsKey(c))
                    subStringDict.Add(c, 0);
                subStringDict[c]++;
            }

            int n = str.Length;
            int start = 0;
            int interval = t.Length;
            bool moveRight = true;

            while(interval != n)
            {
                if (CompareFreq(dict, subStringDict))
                    return str.Substring(start, interval);

                if( (moveRight && (start+interval < n)) || (!moveRight && (start-1 >= 0)))
                {
                    if(moveRight)
                    {
                        ChangeTarget(subStringDict, str[start], false);
                        ChangeTarget(subStringDict, str[start + interval], true);
                        start++;
                    }
                    else
                    {
                        ChangeTarget(subStringDict, str[start + interval - 1], false);
                        ChangeTarget(subStringDict, str[start - 1], true);
                        start--;
                    }
                }
                else
                {
                    if (moveRight)
                        ChangeTarget(subStringDict, str[start - 1], true);
                    else
                        ChangeTarget(subStringDict, str[start + interval], true);

                    interval++;

                    moveRight = !moveRight;
                    if (!moveRight)
                        start--;
                }
            }
            if (CompareFreq(dict, subStringDict))
                return str;
            else
                return "";
        }

        private static void ChangeTarget(Dictionary<char, int> target, char c, bool add)
        {
            if (add)
            {
                if (!target.ContainsKey(c))
                    target.Add(c, 0);
                target[c]++;
            }
            else
            {
                target[c]--;
                if (target[c] == 0)
                    target.Remove(c);
            }
        }

        private static bool CompareFreq(Dictionary<char, int> source, Dictionary<char, int> target)
        {
            foreach (var item in source)
            {
                if (!target.ContainsKey(item.Key))
                    return false;
                if (target[item.Key] < item.Value)
                    return false;
            }
            return true;
        }

        //Shit one 
        private static string MinimumWindowSubstring2(string str, string t)
        {
            int l = t.Length;
            int start = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(var c in t)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 0);
                dict[c]++;
            }

            string minFound = "";
            while(l!=str.Length)
            {
                start = 0;

                while (start + l != str.Length + 1)
                {
                    var subStr = str.Substring(start, l);
                    if (dict.All(f => subStr.Count(x => x == f.Key) >= f.Value ))
                    {
                        if (minFound.Length == 0 || subStr.Length < minFound.Length)
                        {
                            minFound = subStr;
                        }
                    }

                    start++;
                }
                
                l++;
            }

            return minFound;
        }

        private static int MaxPoints(int[][] nums, int[] prev = null, Dictionary<string, int> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<string, int>();
            if (prev == null) prev = new int[] { };

            var key = "";
            foreach (var keke in prev) key += keke + ",";
            if (lookup.ContainsKey(key)) return lookup[key];


            List<int> possibleNode = new List<int>();

            int[] a1 = null;
            int[] a2 = null;

            if (prev.Length >= 2)
            {
                a1 = nums[prev[prev.Length - 1]];
                a2 = nums[prev[prev.Length - 2]];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (prev.Contains(i)) continue;

                if (prev.Length < 2)
                    possibleNode.Add(i);
                else if (((nums[i][0] - a1[0]) * (a2[1] - a1[1])) == ((nums[i][1] - a1[1]) * (a2[0] - a1[0])))
                    possibleNode.Add(i);
            }


            if (possibleNode.Count == 0)
            {
                lookup[key] = prev.Length;
                return prev.Length;
            }

            var maxResult = 0;
            foreach (var n in possibleNode)
            {
                var result = MaxPoints(nums, prev.Append(n).ToArray(), lookup);

                if (result > maxResult)
                    maxResult = result;
            }

            lookup[key] = maxResult;
            return maxResult;
        }

        private static int[] KthPermutation(int n, int k)
        {
            return null;
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
    }

    public static class EmrehanExtension
    {
        public static T[] RemoveAt<T>(this T[] arr, int index)
        {
            T[] arr2 = (T[])arr.Clone();
            for (int a = index; a < arr2.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr2[a] = arr2[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr2, arr2.Length - 1);

            return arr2;
        }
    }
}
