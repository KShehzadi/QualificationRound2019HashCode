using System;
using System.Collections.Generic;
using System.Text;

namespace _2019hashcodequalificationround
{
    class Utility
    {
        public static string GetLine(string text, int lineNo)
        {
            string[] lines = text.Replace("\r", "").Split('\n');
            return lines.Length >= lineNo ? lines[lineNo - 1] : null;
        }
        
        
        public static List<pictureinfo> GetPictureList(string text)
        {
            int numberofpictures = Convert.ToInt32(Utility.GetLine(text, 1));
            List<Utility.pictureinfo> picturelist = new List<Utility.pictureinfo>();
            for (int i = 1; i <= numberofpictures; i++)
            {
                Utility.pictureinfo p = new Utility.pictureinfo();
                p.id = i - 1;
                string line = Utility.GetLine(text, i + 1);
                string[] linesplit = line.Split(" ");
                p.Rotation = linesplit[0];
                p.numberoftags = Convert.ToInt32(linesplit[1]);
                List<string> sampletags = new List<string>();
                for (int j = 0; j < p.numberoftags; j++)
                {
                    sampletags.Add(linesplit[j + 2]);
                }
                p.tags = sampletags;
                picturelist.Add(p);
            }
            return picturelist;
        }
        public class pictureinfo
        {
            public int id { get; set; }
            public string Rotation { get; set; }
            public int numberoftags { get; set; }
            public List<string> tags { get; set; }
        }

        public class slides
        {

        }
    }
}
