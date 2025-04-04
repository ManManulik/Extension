using System;
using System.Collections.Generic;

public static class Ex
{
    public static int MyIndexOf(this string str, string value)
    {
        for(int i = 0; i <= str.Length - value.Length; ++i)
        {
            if(str.Substring(i, value.Length) == value)
            {
                return i;
            }
        }
        return -1;
    }
}
public class Program
{
    public static void Main()
    {
        string text = "hello";
        int i = text.MyIndexOf("lo");
        int a = text.MyIndexOf("loo");
        Console.WriteLine(i);
        Console.WriteLine(a);
    }
}
