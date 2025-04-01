using System.Collections.Generic;
using System.Linq;

namespace Solution.Palindrome;

public static class PalindromeChecker
{
    public static bool CekPalindrom(string input)
    {
        if (string.IsNullOrEmpty(input)) return true;
        
        string normalized = NormalizeString(input);
        if (string.IsNullOrEmpty(normalized)) return true;

        Stack<char> stack = new Stack<char>(normalized);
        
        foreach (char c in normalized)
        {
            if (c != stack.Pop())
            {
                return false;
            }
        }
        return true;
    }

    private static string NormalizeString(string input)
    {
        return new string(input
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());
    }
}