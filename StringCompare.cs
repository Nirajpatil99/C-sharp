using System;

class StringCompare
{
    static bool CompareString(string str1, string str2)
    {
        if (str1 == str2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        string s1 = "Hi";
        var s2 = "Hi";
        bool bRte = false;

        bRte = CompareString(s1, s2);

        if (bRte == true)
        {
            Console.WriteLine("Both are equal");
        }
        else
        {
            Console.WriteLine("Both are  not equal");
        }
    }
}