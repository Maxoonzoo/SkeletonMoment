using System;
using Microsoft.Win32;

class Program
{
    public static void Main()
    {
        RegistryKey rkey = Registry.ClassesRoot;
    
        string[] KeyNames = rkey.GetSubKeyNames();

        Console.WriteLine("Ключі з " + rkey.Name + ", що починаються на '.':");

        foreach (string s in KeyNames)
        {
            if (s[0] == '.')
            {
                Console.WriteLine(s);
            }
        }
    }
}