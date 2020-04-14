using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Projeto_Dev\trabalhandoComArquivos\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um error");
                Console.WriteLine(e.Message);
            }
            finally
            {
            }
        }
    }
}
