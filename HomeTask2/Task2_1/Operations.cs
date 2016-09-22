using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Task2_1
{
    class Operations
    {
        const string SENTENCE_END = "[\\.\\!\\?]\\s";

        Regex regex2 = new Regex(SENTENCE_END);

        public string Reading(string filePath)
        {
            string text;
            FileStream file = new FileStream(filePath, FileMode.Open
                , FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            text = reader.ReadToEnd();
            reader.Close();
            return text;       
        }

        public string TextModifying(string text)
        {
            string date;

            if (!text.Equals(""))
            {
                text = text.ToLower();
                date = DateTime.Now.ToString("{MM / dd / yyy HH: mm: ss.fff} ");
                text = date + text;
                text = text.Trim();
                text = text.Replace(". ", ".\n" + date);
                text = text.Replace("? ", "?\n" + date);
                text = text.Replace("! ", "!\n" + date);
                text = text.Replace("... ", "...\n" + date);
            }
            return text;
        }

        public void Writing(string filePath, string text)
        {
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Write); 
            StreamWriter writer = new StreamWriter(file);  
            writer.Write(text);
            writer.Close();
        }


    }
}
