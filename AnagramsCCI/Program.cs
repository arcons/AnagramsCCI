using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        // elements automatically initialized to 0
        int[] letterCounts = new int[26];

        foreach (char c in a) { letterCounts[c - 'a']++; }
        foreach (char c in b) { letterCounts[c - 'a']--; }
        Console.WriteLine(letterCounts.Sum(x => Math.Abs(x)));
    }
}
