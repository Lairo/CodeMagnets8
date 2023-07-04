using System;
using System.Collections.Generic;

namespace CodeMagnets8
{
    internal class Program
    {
        public static void Main()
        {
            List<string> a = new List<string>();

            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            a.RemoveAt(2);


            if (a.Contains("two"))
            {
                a.Add(twopointtwo);
            }
            if (a.Contains("three"))
            {
                a.Add("four");
            }
            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }

            PppPppL(a);
        }

        static void PppPppL(List<string> a)
        {
            foreach (string element in a)
            {
                Console.WriteLine(element);
            }
        }
    }
}
