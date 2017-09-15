using System;
using System.IO;
using System.Text;

namespace Class_Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\admin\Documents\Reference\Demo3File.txt";
            if (!File.Exists(filePath))
            {
            using (FileStream fs = File.Create(filePath))
            {
                Byte[] myText = new UTF8Encoding(true).GetBytes("This is my text");
                fs.Write(myText, 0, myText.Length);
            }

            }else
            {
            using (StreamReader sr = File.OpenText(filePath))
            {
                    //string s = "";
                    //while ((s = sr.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(s);
                    //}

                    string[] words = File.ReadAllLines(filePath);

                    foreach(string line in words)
                    {
                        Console.WriteLine(line);
                    }
                        //Console.Read();
            }
                AddText(filePath);
                DeleteText(filePath);
            }

        
        }

        static void AddText(string filePath)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.Write(Environment.NewLine);
                sw.WriteLine("Look, more text!!");
            }
        }

        static void DeleteText(string filePath)
        {
            File.Delete(filePath);
            Console.WriteLine("Your shit's gone bruh.");
            Console.Read();
        }
    }
}
