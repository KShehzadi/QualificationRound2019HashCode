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
            string text = File.ReadAllText("C:\\Users\\DC\\source\\repos\\2019hashcodequalificationround\\qualification_round_2019.in\\c_memorable_moments.txt");
            Console.WriteLine(text);
            Console.WriteLine("****************File Read Successful!!*****************");
            Console.WriteLine("*********************Slides Created*********************");
            List<Utility.pictureinfo> mypictures = Utility.GetPictureList(text);
            List<Utility.slides> myslides = Utility.GetSlidesFromPictures(mypictures);
            Console.WriteLine(myslides.Count);
            foreach(Utility.slides s in myslides)
            {
                if(s.numberofpictures == 1)
                {
                    Console.WriteLine(s.pictureid[0]);
                }
                else
                {
                    Console.WriteLine(s.pictureid[0] + " " + s.pictureid[1]);
                }
            }
            Console.WriteLine("Break");
        }
        
    }
    
}
