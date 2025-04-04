using System;
using System.Collections.Generic;

public static class Ex
{
    public static bool Contains(this string str, string value)
    {
        for(int i = 0; i <= str.Length - value.Length; ++i)
        {
            if(str.Substring(i, value.Length) == value)
            {
                return true;
            }
        }
        return false;
    }
}
public class Program
{
    public static void Main()
    {
        string text = "hello";
        bool i = text.Contains("lo");
        bool a = text.Contains("loo");
        Console.WriteLine(i);
        Console.WriteLine(a);
    }
}
