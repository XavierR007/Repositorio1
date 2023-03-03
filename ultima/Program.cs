using System;
using System.IO;

namespace ultima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;

            using (TextWriter w = File.CreateText("log.txt"));
            {
                w.WriteLine("Linea uno");
                w.WriteLine("Linea dos");
            }

            using (TextReader r = File.OpenText("log.txt"));
            {
                while ((s = r.ReadLine()) != null) 
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}