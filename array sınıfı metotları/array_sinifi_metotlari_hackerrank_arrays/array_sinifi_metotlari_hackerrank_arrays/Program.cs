using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string[] durruk = Console.ReadLine().Split(' ');
        int[] sayiDizisi = Array.ConvertAll(durruk, Int32.Parse);
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.Write($"{sayi} ");
        }
    }
}