﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class WriteData
    {
        public void data()
        {
            string filepath = "C:\\First.txt";
            try
            {

                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.Write(Environment.NewLine + "Appending this new line");
                    sw.Close();
                }
                
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(File.ReadAllText(filepath));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteData w = new WriteData();
            w.data();
            Console.ReadKey();
        }
    }

}