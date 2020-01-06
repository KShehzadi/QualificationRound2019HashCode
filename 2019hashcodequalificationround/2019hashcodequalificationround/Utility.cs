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
        
        public static List<slides> GetSlidesFromPictures(List<pictureinfo> pictures)
        {
            List<slides> slideslist = new List<slides>();
            int i = 1;
            int flag = 0;
            slides v = new slides();
            v.numberofpictures = 2;
            foreach (pictureinfo p in pictures)
            {
               
                if(p.Rotation == "H")
                {
                    slides s = new slides();
                    s.id = i;
                    s.numberofpictures = 1;
                    s.pictureid.Add(p.id.ToString());
                    foreach(string tag in p.tags)
                    {
                        s.slidetags.Add(tag);
                    }
                    slideslist.Add(s);
                    i++;
                }
                else if(p.Rotation=="V")
                {
                
                    v.pictureid.Add(p.id.ToString());
                    foreach (string tag in p.tags)
                    {
                        v.slidetags.Add(tag);
                    }
                    flag++;
                    if (flag == 2)
                    {
                        v.id = i;
                        i++;
                        flag = 0;
                        slideslist.Add(v);
                        v = new slides();
                        v.numberofpictures = 2;
                    }
                }
            }
            return slideslist;
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
            public int id;
            public int numberofpictures;
            public List<string> pictureid = new List<string>();
            public List<string> slidetags = new List<string>();
        }
    }
}
