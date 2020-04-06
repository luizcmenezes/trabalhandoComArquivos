﻿using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Projeto_Dev\trabalhandoComArquivos\file1.txt";
            string targetPath = @"D:\Projeto_Dev\trabalhandoComArquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
