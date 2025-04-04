using System;
using System.Collections.Generic;

public static class Ex
{
    public static List<string> MySplit(this string str, string seperator)
    {
        List<string> res = new List<string>();
        int startIndex = 0;
        for(int i = 0; i < str.Length - seperator.Length; ++i)
        {
            if(str.Substring(i, seperator.Length) == seperator)
            {
                res.Add(str.Substring(startIndex, i - startIndex));
                startIndex = i + seperator.Length;
            }
        }
        res.Add(str.Substring(startIndex, str.Length - startIndex));
        return res;
    }
}
public class Program
{
    public static void Main()
    {
        string text = "fsk--hfks--hfjks";
        List<string> result = text.MySplit("--");
        foreach(string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
