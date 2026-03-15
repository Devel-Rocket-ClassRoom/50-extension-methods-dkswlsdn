using System;
using System.Collections.Generic;
using System.Text;

public static class Palindrome
{
    public static bool IsPalindrome(this string text)
    {
        if (text == null || text == string.Empty) return false;

        List<string> temp = new List<string>();

        foreach (var c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                temp.Add(c.ToString());
            }
        }

        for (int i = 0; i < temp.Count / 2; i++)
        {
            if (!(temp[i].ToLower() == temp[temp.Count - i - 1].ToLower()))
            {
                return false;
            }
        }

        return true;
    }
}