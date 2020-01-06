using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _2019hashcodequalificationround
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\DC\\source\\repos\\2019hashcodequalificationround\\qualification_round_2019.in\\a_example.txt");
            Console.WriteLine(text);
            Console.WriteLine("****************File Read Successful!!*****************");
            List<Utility.pictureinfo> mypictures = Utility.GetPictureList(text);
            Console.WriteLine("Break");
        }
        
    }
    
}
