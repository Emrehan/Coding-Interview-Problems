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
            directGraph.Add('E', new char[] { });
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
            //P.Print(encryption("haveaniceday")); // hae and via ecy

            //https://www.hackerrank.com/challenges/flipping-bits/problem?isFullScreen=true            
            //P.Print(flippingBits(2147483647)); //2147483648
            //P.Print(flippingBits(1)); //4294967294
            //P.Print(flippingBits(0)); //4294967295

            //https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem?isFullScreen=true
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 1, 3, 1 }, new List<int>() { 2, 1, 2 }, new List<int>() { 3, 3, 3 } })); //Impossible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 0, 2, 1 }, new List<int>() { 1, 1, 1 }, new List<int>() { 2, 0, 0 } })); //Possible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 1 } })); //Possible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 2 } })); //Possible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 0, 1 }, new List<int>() { 1, 0 } })); //Possible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 2, 0 }, new List<int>() { 4, 0 } })); //Possible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 1, 1 }, new List<int>() { 1, 1 } })); //Possible
            //P.Print(organizingContainers(new List<List<int>>() { new List<int>() { 0, 2 }, new List<int>() { 1, 1 } })); //Impossible

            //https://www.hackerrank.com/challenges/the-grid-search/problem?isFullScreen=true
            //P.Print(gridSearch( //YES
            //    new List<string>() { "7283455864", "6731158619", "8988242643", "3830589324", "2229505813", "5633845374", "6473530293", "7053106601", "0834282956", "4607924137" }, 
            //    new List<string>() { "9505", "3845", "3530"})); 

            //P.Print(gridSearch( //YES
            //    new List<string>() { "999999", "121211" }, 
            //    new List<string>() { "99", "11"})); 

            //P.Print(gridSearch( //YES
            //    new List<string>() { "123412", "561212", "123634", "781288" }, 
            //    new List<string>() { "12", "34"})); 

            //https://www.hackerrank.com/challenges/bigger-is-greater/problem?isFullScreen=true
            //P.Print(biggerIsGreater("ab")); //ba
            //P.Print(biggerIsGreater("bb")); //no answer
            //P.Print(biggerIsGreater("hefg")); //hegf
            //P.Print(biggerIsGreater("dhck")); //dhkc
            //P.Print(biggerIsGreater("dkhc")); //hcdk

            //https://www.hackerrank.com/challenges/matrix-rotation-algo/problem?isFullScreen=true
            //matrixRotation(new List<List<int>>()
            //{
            //    new List<int>() { 1, 2, 3, 4 },     // 3  4  8  12
            //    new List<int>() { 5, 6, 7, 8 },     // 2 11 10  16
            //    new List<int>() { 9, 10, 11, 12 },  // 1  7  6  15
            //    new List<int>() { 13, 14, 15, 16 }  // 5  9 13  14
            //}, 2); 

            //matrixRotation(new List<List<int>>()
            //{
            //    new List<int>() { 1, 2, 3, 4 },      // 28  27  26  25
            //    new List<int>() { 7, 8, 9, 10 },     // 22   9  15  19
            //    new List<int>() { 13, 14, 15, 16 },  // 16   8  21  13
            //    new List<int>() { 19, 20, 21, 22 },  // 10  14  20   7
            //    new List<int>() { 25, 26, 27, 28 },  //  4   3   2   1
            //}, 7); 

            //https://leetcode.com/problems/additive-number/
            //P.Print(additiveNumber("112358")); //true
            //P.Print(additiveNumber("199100199")); //true
            //P.Print(additiveNumber("199100")); //true
            //P.Print(additiveNumber("101")); //true

            //https://leetcode.com/problems/longest-substring-without-repeating-characters/            
            //P.Print(LengthOfLongestSubstring("abcabcbb")); //3
            //P.Print(LengthOfLongestSubstring("bbbbb")); //1
            //P.Print(LengthOfLongestSubstring("pwwkew")); //3
            //P.Print(LengthOfLongestSubstring("")); //0
            //P.Print(LengthOfLongestSubstring("a")); //1
            //P.Print(LengthOfLongestSubstring("ab")); //2

            //https://leetcode.com/problems/trapping-rain-water/
            //P.Print(Trap(new List<int>() { 4, 2, 0, 3, 2, 5 })); //9
            //P.Print(Trap(new List<int>() { 0, 1, 2, 1, 0, 1, 2, 0, 2 })); //6
            //P.Print(Trap(new List<int>() { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 })); //6

            //https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
            //P.Print(MinOperations(new int[] { 1, 1, 4, 2, 3}, 5)); // 2
            //P.Print(MinOperations(new int[] { 5, 6, 7, 8, 9}, 4)); // -1
            //P.Print(MinOperations(new int[] { 5, 6, 7, 8, 9}, 4)); // -1
            //P.Print(MinOperations(new int[] { 3, 2, 20, 1, 1, 3}, 10)); // 5

            //P.Print(MinOperations2(new int[] { 1, 1, 4, 2, 3}, 5)); // 2
            //P.Print(MinOperations2(new int[] { 5, 6, 7, 8, 9}, 4)); // -1
            //P.Print(MinOperations2(new int[] { 5, 6, 7, 8, 9}, 4)); // -1
            //P.Print(MinOperations2(new int[] { 3, 2, 20, 1, 1, 3}, 10)); // 5

            //https://leetcode.com/problems/maximum-erasure-value/
            //P.Print(MaximumUniqueSubarray(new int[] { 4, 2, 4, 5, 6 })); //17
            //P.Print(MaximumUniqueSubarray(new int[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 })); //8

            //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
            //P.Print(TwoSum(new int[] { 2, 7, 11, 15 }, 9)); // [1, 2]
            //P.Print(TwoSum(new int[] { 2, 3, 4 }, 6)); // [1, 3]
            //P.Print(TwoSum(new int[] { -1, 0 }, -1)); // [1, 2]

            //https://leetcode.com/problems/remove-palindromic-subsequences/
            //P.Print(RemovePalindromeSub("ababa")); //1
            //P.Print(RemovePalindromeSub("abb")); //2
            //P.Print(RemovePalindromeSub("baabb")); //2

            //https://leetcode.com/problems/merge-sorted-array/
            //P.Print(Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3)); // [1, 2, 2, 3, 5, 6]
            //P.Print(Merge(new int[] { 1 }, 1, new int[] { }, 0)); // [1]
            //P.Print(Merge(new int[] { 0 }, 0, new int[] { 1 }, 1)); // [1]
            //P.Print(Merge(new int[] { 0 }, 0, new int[] { 0 }, 0)); // []

            //https://leetcode.com/problems/triangle/
            //IList<IList<int>> tc1 = new List<IList<int>>() { new List<int>() { -10 } };
            //IList<IList<int>> tc2 = new List<IList<int>>() { new List<int>() { 2 }, new List<int>() { 3, 4 }, new List<int>() { 6, 5, 7 }, new List<int>() { 4, 1, 8, 3 } };
            //P.Print(MinimumTotal(tc1)); // -10
            //P.Print(MinimumTotal(tc2)); // 11

            //https://www.hackerrank.com/challenges/circular-palindromes/problem?isFullScreen=true
            //P.Print(circularPalindromes("cacbbba")); //3 3 3 3 3 3 3
            //P.Print(circularPalindromes"aaaaabbbbaaaa")); //12 12 10 8 8 9 11 13 11 9 8 8 10

            //https://leetcode.com/problems/n-queens-ii/submissions/
            //P.Print(TotalNQueens(1)); //1
            //P.Print(TotalNQueens(2)); //0
            //P.Print(TotalNQueens(3)); //0
            //P.Print(TotalNQueens(4)); //2
            //P.Print(TotalNQueens(5)); //10
            //P.Print(TotalNQueens(6)); //4
            //P.Print(TotalNQueens(9)); //352

            #region Nodes
            var c3 = new ListNode(5);
            var c2 = new ListNode(4);
            var c1 = new ListNode(8);

            var a1 = new ListNode(4);
            var a2 = new ListNode(1);

            var b1 = new ListNode(5);
            var b2 = new ListNode(6);
            var b3 = new ListNode(1);

            var headA = a1;
            a1.next = a2;
            a2.next = c1;

            var headB = b1;
            b1.next = b2;
            b2.next = b3;
            b3.next = c1;

            c1.next = c2;
            c2.next = c3;
            #endregion
            //https://leetcode.com/problems/intersection-of-two-linked-lists/
            //P.Print(GetIntersectionNode(headA, headB)); //8

            //https://leetcode.com/problems/find-the-town-judge/
            //P.Print(FindJudge(2, new int[1][] { new int[2] { 1, 2 } })); //2
            //P.Print(FindJudge(3, new int[2][] { new int[2] { 1, 3 }, new int[2] { 2, 3 } })); //3
            //P.Print(FindJudge(3, new int[3][] { new int[2] { 1, 3 }, new int[2] { 2, 3 }, new int[2] { 3, 1 } })); //-1

            //https://leetcode.com/problems/find-center-of-star-graph/
            //P.Print(FindCenter(new int[3][] { new int[2] { 1, 2 }, new int[2] { 2, 3 }, new int[2] { 4, 2 } }));

            //https://leetcode.com/problems/find-if-path-exists-in-graph/
            //P.Print(ValidPath(3, new int[3][] { new int[2] { 1, 2 }, new int[2] { 2, 3 }, new int[2] { 4, 2 } }, 0, 2));
            //P.Print(ValidPath(10, new int[10][] { 
            //    new int[2] { 1, 2 }, 
            //    new int[2] { 2, 3 }, 
            //    new int[2] { 4, 2 }, 
            //    new int[2] { 4, 2 }, 
            //    new int[2] { 4, 2 },
            //    new int[2] { 1, 2 }, 
            //    new int[2] { 2, 3 }, 
            //    new int[2] { 4, 2 }, 
            //    new int[2] { 4, 2 }, 
            //    new int[2] { 4, 2 } }, 7, 5));

            //https://leetcode.com/problems/longest-valid-parentheses/submissions/
            //P.Print(LongestValidParentheses("(()"));  //2
            //P.Print(LongestValidParentheses(")()())"));  //4
            //P.Print(LongestValidParentheses(""));  //0

            //https://leetcode.com/problems/missing-number/
            //P.Print(MissingNumber(new int[] { 3, 0, 1 })); //2
            //P.Print(MissingNumber(new int[] { 0, 1 })); //2
            //P.Print(MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 })); //8

            //https://leetcode.com/problems/short-encoding-of-words/
            //P.Print(MinimumLengthEncoding(new string[] { "time", "me", "bell" })); //10
            //P.Print(MinimumLengthEncoding(new string[] { "t" })); //2

            var x_d1 = new TreeNode(7);
            var x_d2 = new TreeNode(15);
            var x_c1 = new TreeNode(20, x_d2, x_d1);
            var x_c2 = new TreeNode(9);
            var x_root = new TreeNode(3, x_c2, x_c1);
            //https://leetcode.com/problems/average-of-levels-in-binary-tree/
            //P.Print(AverageOfLevels(x_root).Select(f => f.ToString()).ToList()); //[3, 14.5, 11]

            var xx_d1 = new TreeNode(3);
            var xx_d2 = new TreeNode(7);
            var xx_c1 = new TreeNode(6, xx_d1, xx_d2);
            var xx_c2 = new TreeNode(4);
            var xx_root = new TreeNode(5, xx_c2, xx_c1);
            //https://leetcode.com/problems/validate-binary-search-tree
            //P.Print(IsValidBST(xx_root)); //false

            //ceabaacb
            //https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
            P.Print(MinDeletions("aab")); //0
            P.Print(MinDeletions("aaabbbcc")); //2
            P.Print(MinDeletions("ceabaacb")); //2


        }

        public static int MinDeletions(string s)
        {
            var ts = new HashSet<int>();
            int count = 0;
            
            var arr = s.ToCharArray();
            Array.Sort(arr);
            
            var n = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(i != arr.Length - 1 && arr[i] == arr[i+1])
                {
                    n++;
                }
                else
                {
                    if(!ts.Contains(n))
                    {
                        ts.Add(n);
                        n = 1;
                    }
                    else
                    {
                        int p = n;
                        while(ts.Contains(p) && p != 0)
                        {
                            p--;
                            count++;
                        }

                        ts.Add(p);
                        n = 1;
                    }
                }
            }

            return count;
        }

        public static bool IsValidBST(TreeNode root)
        {
            return IsValid(root, long.MinValue, long.MaxValue);
        }

        public static bool IsValid(TreeNode root, long min, long max)
        {
            if (root == null) return true;

            if (root.val <= min || root.val >= max) return false;

            return IsValid(root.left, min, root.val) && IsValid(root.right, root.val, max);
        }

        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var Q = new Queue<TreeNode>();
            Q.Enqueue(root);
            Q.Enqueue(null);

            int count = 0;
            long sum = 0;
            var avgLevels = new List<Double>();

            while (Q.Count != 0)
            {
                var current = Q.Dequeue();

                if (current == null)
                {
                    if (count != 0)
                    {
                        //Console.WriteLine($"çizgi geldi {sum} {count}" );

                        avgLevels.Add((double)sum / count);
                        sum = 0;
                        count = 0;
                        Q.Enqueue(null);
                    }
                }
                else
                {
                    sum += current.val;
                    count++;

                    //Console.WriteLine($"{current.val} geldi {sum} {count}" );

                    if (current.left != null) Q.Enqueue(current.left);
                    if (current.right != null) Q.Enqueue(current.right);
                }
            }

            return avgLevels;
        }


        public static int MinimumLengthEncoding(string[] words)
        {
            //Init word set
            var wordsSet = new HashSet<string>(words);

            //Remove sub-strings
            foreach (var word in words)
                for (int i = 1; i < word.Length; i++)
                    wordsSet.Remove(word.Substring(i));

            //Total length of words + number of #
            return wordsSet.Select(f => f.Length).Sum() + wordsSet.Count;
        }

        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            return (n * (n + 1)) / 2 - nums.Sum();
        }

        public static int LongestValidParentheses(string s)
        {
            int left = 0;
            int right = 0;
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                    max = Math.Max(max, right * 2);
                else if (right > left)
                {
                    left = 0;
                    right = 0;
                }
            }

            left = 0;
            right = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                    left++;
                else
                    right++;

                if (left == right)
                    max = Math.Max(max, right * 2);
                else if (right < left)
                {
                    left = 0;
                    right = 0;
                }
            }

            return max;
        }

        public static bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            HashSet<int> visited = new HashSet<int>();
            Queue<int> Q = new Queue<int>();

            Q.Enqueue(source);

            while (Q.Count != 0)
            {
                var current = Q.Dequeue();
                visited.Add(current);

                if (current == destination)
                    return true;

                foreach (var nextEdges in edges.Where(f => f.Contains(current)))
                {
                    foreach (var a in nextEdges)
                    {
                        if(a != current && !visited.Contains(a))
                        {
                            Q.Enqueue(a);
                        }
                    }
                }
            }

            return false;
        }

        public static int FindCenter(int[][] edges)
        {
            HashSet<int> edgeSet = new HashSet<int>();

            foreach (var edge in edges)
            {
                if (edgeSet.Contains(edge[0]))
                    return edge[0];
                else
                    edgeSet.Add(edge[0]);

                if (edgeSet.Contains(edge[1]))
                    return edge[1];
                else
                    edgeSet.Add(edge[1]);
            }

            return -1;
        }

        public static int FindJudge(int n, int[][] trust)
        {

            var judge = Enumerable.Range(1, n).ToList()
                              .Where(p => !trust.Select(f => f[0]).Contains(p))
                              .Where(t => trust.Where(f => f[1] == t).Distinct().Count() == n - 1)
                              .FirstOrDefault();



            return judge != 0 ? judge : -1;
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int lenA = CountLinkedList(headA);
            int lenB = CountLinkedList(headB);

            var pA = headA;
            var pB = headB;

            for (int i = 0; i < Math.Abs(lenA - lenB); i++)
                if (lenA > lenB)
                    pA = pA.next ?? headA;
                else
                    pB = pB.next ?? headB;

            for (int j = 0; j < Math.Min(lenA, lenB); j++)
            {
                if (pA == pB)
                {
                    return pA;
                }

                pA = pA.next;
                pB = pB.next;
            }

            return null;
        }

        public static int CountLinkedList(ListNode head)
        {
            int c = 1;

            var temp = head;
            while (temp != null)
            {
                temp = temp.next;
                c++;
            }

            return c;
        }

        public static int TotalNQueens(int n, List<int> prev = null)
        {
            if (prev == null) prev = new List<int>();
            if (prev.Count == n) return 1;

            var allMoves = Enumerable.Range(0, n).ToList();

            for (int i = 0; i < prev.Count; i++)
            {
                allMoves.Remove(prev[i]);
                allMoves.Remove(prev[i] + (prev.Count - i));
                allMoves.Remove(prev[i] - (prev.Count - i));
            }

            int count = 0;
            foreach (var nextMove in allMoves)
            {
                count += TotalNQueens(n, prev.Concat(new int[] { nextMove }).ToList());
            }

            return count;
        }

        static Dictionary<string, int> lookup = new Dictionary<string, int>();
        public static List<int> circularPalindromes(string s)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < s.Length; i++)
            {
                result.Add(FindMaxPalindromes(s.Substring(i, s.Length - i) + s.Substring(0, i)));
            }
            return result;
        }

        private static int FindMaxPalindromes(string s)
        {
            if (lookup.ContainsKey(s)) return lookup[s];

            for (int i = s.Length; i >= 2; i--)
            {
                for (int j = 0; j < s.Length - i + 1; j++)
                {                    
                    if (IsPalindrome(s.Substring(j, i)))
                    {
                        lookup[s] = i;
                        return i;
                    }
                }
            }

            lookup[s] = 1;
            return 1;
        }

        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 1) return triangle[0][0];

            for (int level = triangle.Count - 2; level >= 0; level--)
            {
                for (int j = 0; j < triangle[level].Count; j++)
                {
                    triangle[level][j] += Math.Min(triangle[level + 1][j], triangle[level + 1][j + 1]);
                }
            }

            return triangle[0][0];
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] arr = new int[m + n];
            int c = 0;

            int p1 = 0;
            int p2 = 0;

            while (p1 < m && p2 < n)
            {
                if (nums1[p1] <= nums2[p2])
                    arr[c++] = nums1[p1++];
                else
                    arr[c++] = nums2[p2++];
            }

            while (p1 < m)
                arr[c++] = nums1[p1++];

            while (p2 < n)
                arr[c++] = nums2[p2++];

            nums1 = arr;
            return nums1;
        }

        public static int RemovePalindromeSub(string s)
        {
            if (IsPalindrome(s)) return 1;
            return 2;
        }

        private static bool IsPalindrome(string v)
        {            
            int l = 0;
            int r = v.Length - 1;

            while(l <= r)
            {
                if (v[l] != v[r])
                {
                    return false;
                }

                l++;
                r--;
            }

            return true;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;

            int sum = numbers[l] + numbers[r];
            while (sum != target)
            {
                if (sum > target) r--;
                else l++;

                sum = numbers[l] + numbers[r];
            }

            return new int[] { l + 1, r + 1 };
        }

        public static int MaximumUniqueSubarray(int[] nums)
        {
            int l = 0, r = 0, maxSum = -1;
            HashSet<int> table = new HashSet<int>();
            int currentSum = 0;

            while(r < nums.Length)
            {
                if(!table.Contains(nums[r]))
                {
                    table.Add(nums[r]);
                    currentSum += nums[r];
                    r++;

                    if (currentSum > maxSum)
                        maxSum = currentSum;
                }
                else
                {
                    while(table.Contains(nums[r]))
                    {
                        currentSum -= nums[l];
                        table.Remove(nums[l]);
                        l++;
                    }
                }
            }

            return maxSum;
        }

        public static int MinOperations(int[] nums, int x, Dictionary<string, int> lookup = null)
        {
            if (lookup == null) lookup = new Dictionary<string, int>();

            var key = string.Join("-", nums) + ":" + x;
            if (lookup.ContainsKey(key)) return lookup[key];
            if (x == 0) return 0;
            if (x < 0) return -1;
            if (nums.Length == 0) return -1;

            int bestTotalOp = int.MaxValue;

            var firstValue = MinOperations(nums.Skip(1).ToArray(), x - nums[0], lookup);
            lookup[string.Join("-", nums.Skip(1)) + ":" + x] = firstValue;
            if (firstValue != -1 && firstValue <= bestTotalOp)
                bestTotalOp = firstValue;

            var lastValue = MinOperations(nums.Take(nums.Count() - 1).ToArray(), x - nums[nums.Length - 1], lookup);
            lookup[string.Join("-", nums.Take(nums.Count() - 1)) + ":" + x] = lastValue;
            if (lastValue != -1 && lastValue <= bestTotalOp)
                bestTotalOp = lastValue;

            return bestTotalOp == int.MaxValue ? -1 : (bestTotalOp + 1);
        }

        public static int MinOperations2(int[] nums, int x)
        {
            int l = 0;
            int r = 0;
            int target = nums.Sum() - x;

            int max = -1;
            int currentSum = 0;
            for(r = 0; r < nums.Length; r++)
            {
                currentSum += nums[r];
                while (l <= r && currentSum > target) currentSum -= nums[l++];
                if (currentSum == target) max = Math.Max(max, r - l + 1);
            }
            return max == -1 ? -1 : nums.Length - max;
        }

        private static int Trap(List<int> list)
        {
            bool trapStart = false;
            int trapStartValue = 0;
            int totalWaterTrapped = 0;
            int potansielWaterTrapped = 0;

            for(int i = 1; i < list.Count; i++)
            {
                if(list[i] < list[i - 1] && !trapStart)
                {
                    trapStart = true;
                    trapStartValue = list[i-1];
                }

                if (list[i] >= trapStartValue)
                {
                    trapStart = false;
                    totalWaterTrapped += potansielWaterTrapped;
                    potansielWaterTrapped = 0;
                }

                if (trapStart)
                    potansielWaterTrapped += trapStartValue - list[i]; 
            }

            return totalWaterTrapped;
        }

        //HashSet -> Time %87 Usage %27
        //List    -> Time %78 Usage %29
        public static int LengthOfLongestSubstring(string s)
        {
            int p = 0;
            int back = 0;
            int count = 0;
            int maxCount = 0;
            List<char> set = new List<char>();

            while(p < s.Length)
            {
                var currentChar = s[p];
                if (set.Contains(currentChar))
                {
                    if (count > maxCount)
                        maxCount = count;

                    while(set.Contains(currentChar))
                    {
                        set.Remove(s[back++]);
                        count--;
                    }
                }
                else
                {
                    set.Add(currentChar);
                    p++;
                    count++;
                }
            }
            if (count > maxCount)
                maxCount = count;

            return maxCount;
        }

        private static bool additiveNumber(string num)
        {
            if (num.Length < 3) return false;

            bool found = false;
            for(int i = 1; i < num.Length - 1; i++)
            {
                for(int j = 1; j < num.Length - 1; j++)
                {
                    for(int k = 1; k < num.Length - i - j + 1; k++)
                    {
                        var num1 = num.Substring(0, i);
                        var num2 = num.Substring(i, j);
                        var num3 = num.Substring(i + j, k);
                        if (!IsValid(num1, num2, num3)) continue;
                        found = true;

                        var p = i + j + k;
                        var search = SumTwoString(num2, num3);

                        while(p < num.Length)
                        {
                            found = false;

                            if (p + search.ToString().Length > num.Length) break;

                            var check = num.Substring(p, search.ToString().Length);

                            if (long.Parse(check) == search)
                            {
                                p += check.Length;
                                num2 = num3;
                                num3 = check;
                                search = SumTwoString(num2, num3);

                                found = true;
                            }
                            else
                            {
                                found = false;
                                break;
                            }
                        }

                        if (found) return true;

                    }
                }
            }

            return found;
        }

        private static long SumTwoString(string num1, string num2)
        {
            return long.Parse(num1) + long.Parse(num2);
        }

        private static bool IsValid(string num1, string num2, string num3)
        {
            if (num3.Length < num2.Length || num3.Length < num1.Length) return false;
            if (num3.StartsWith("0") && num3.Length != 1) return false;
            if (num2.StartsWith("0") && num2.Length != 1) return false;
            if (num1.StartsWith("0") && num1.Length != 1) return false;
            if (Math.Max(num1.Length, num2.Length) + 1 != num3.Length && Math.Max(num1.Length, num2.Length) != num3.Length) return false;

            return long.Parse(num1) + long.Parse(num2) == long.Parse(num3);
        }

        public static void matrixRotation(List<List<int>> matrix, int r)
        {
            var rowN = matrix.Count;
            var colN = matrix[0].Count;

            for (int i = 0; i < Math.Min(colN, rowN) / 2; i++)
            {
                matrix = Rotate(matrix, i, r);
            }

            foreach (var row in matrix)
            {
                foreach (var col in row)
                    Console.Write(col + " ");
                Console.WriteLine("");
            }
        }

        public static List<List<int>> Rotate(List<List<int>> matrix, int indis, int r)
        {
            var rowN = matrix.Count - 2 * indis;
            var colN = matrix[0].Count - 2 * indis;
            var all = ((colN + rowN - 2) * 2);
            r = r % all;

            var newMatrix = matrix.Select(x => x.ToList()).ToList();

            int i = indis;
            int j = indis;
            for (int x = 0; x < all; x++)
            {
                var iteratedPosition = calculateNewPosition(i, j, colN, rowN, r, indis);

                newMatrix[iteratedPosition.Item1][iteratedPosition.Item2] = matrix[i][j];

                var nextPosition = calculateNewPosition(i, j, colN, rowN, 1, indis);
                i = nextPosition.Item1;
                j = nextPosition.Item2;
            }
            return newMatrix;
        }

        private static Tuple<int, int> calculateNewPosition(int r, int c, int colN, int rowN, int turn, int indis)
        {
            bool increase = true;
            bool useCol = true;
                       
            for (int i = 0; i < turn; i++)
            {
                if(c == indis && r != rowN + indis - 1)
                {
                    increase = true;
                    useCol = false;
                }
                else if(r == rowN + indis - 1 && c != colN + indis - 1)
                {
                    increase = true;
                    useCol = true;
                }
                else if(c == colN + indis - 1 && r != indis)
                {
                    increase = false;
                    useCol = false;
                }
                else if (r == indis && c != indis)
                {
                    increase = false;
                    useCol = true;
                }

                if (useCol) c = c + (increase ? 1 : -1);
                if (!useCol) r = r + (increase ? 1 : -1);
            }

            return Tuple.Create(r, c);
        }

        public static string biggerIsGreater(string w)
        {
            int prev = w.Length - 1;
            bool found = false;
            for(int i = w.Length - 2; i >= 0; i--)
            {
                if(w[i] < w[prev])
                {
                    found = true;
                    prev = i;
                    break;
                }

                prev = i;
            }

            if (prev == 0 && !found) return "no answer";

            var result = w.Substring(0, prev);

            var newChars = w.Substring(prev, w.Length - prev).ToList();
            newChars.Sort();

            var newHead = newChars.First(f => f > w[prev]);
            newChars.Remove(newHead);

            result += newHead;
            foreach (var ch in newChars)
                result += ch;

            return result;
        }

        public static string gridSearch(List<string> G, List<string> P)
        {
            for(int i = 0; i < G.Count - P.Count + 1; i++)
            {
                var allowCheck = true;
                for(int control = 0; control < P.Count; control++)
                {
                    if (!G[i + control].Contains(P[control]))
                    {
                        allowCheck = false;
                        break;
                    }
                }
                if (!allowCheck) continue;

                
                for(int j = 0; j < G[i].Length - P[0].Length + 1; j++)
                {
                    if (G[i].Substring(j, P[0].Length).Equals(P[0]))
                    {
                        bool found = true;
                        for(int jj = 1; jj < P.Count; jj++)
                        {
                            if (!G[i+jj].Substring(j, P[jj].Length).Equals(P[jj]))
                            {
                                found = false;
                                break;
                            }
                        }
                        if (found) return "YES";
                    }
                }
            }

            return "NO";
        }


        public static string organizingContainers(List<List<int>> container)
        {
            List<int> containerInfo = new int[container.Count].ToList();
            List<int> ballInfo = new int[container.Count].ToList();

            for (int c = 0; c < container.Count; c++)
            {
                for (int b = 0; b < container[c].Count; b++)
                {
                    if (container[c][b] != 0)
                    {
                        containerInfo[c] += container[c][b];
                        ballInfo[b] += container[c][b];
                    }
                }
            }

            ballInfo = ballInfo.OrderByDescending(c => c).ToList();
            containerInfo = containerInfo.OrderByDescending(c => c).ToList();

            for (int i = 0; i < ballInfo.Count; i++)
            {
                //No ball to place, go new ball
                if (ballInfo[i] <= 0) continue;

                for (int c = 0; c < containerInfo.Count; c++)
                {
                    //Not enough space to place
                    if (containerInfo[c] <= 0) continue;

                    //Place some/all of balls to this container
                    ballInfo[i] -= containerInfo[c];
                    containerInfo[c] = 0;

                    //All balls placed, go new ball
                    if (ballInfo[i] <= 0)
                        break;
                }

                //There are still balls thats not placed.
                if (ballInfo[i] > 0) return "Impossible";
            }

            //All balls are placed.
            return "Possible";
        }

        public static long flippingBits(long n)
        {
            // xD
            return 4294967295 - n;
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

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
 
}
