using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_2.Tools
{
    internal class Tools
    {
        const string INT = @"-?\d+";
        const string FLOAT = @"-?\d+[\,\.]\d+";

        internal int FloatCount { get; set; }
        internal int IntCount { get; set; }

        List<int> Ints = new List<int>();
        List<float> Floats = new List<float>();

        Regex regex1 = new Regex(INT);
        Regex regex2 = new Regex(FLOAT);

        //internal string IntParsing(string subString)
        //{
        //    while (regex1.IsMatch(subString))
        //    {
        //        Ints.Add( Int32.Parse(regex1.Match(subString).Value) );
        //        subString = subString.Replace(regex1.Match(subString).Value,"");
        //    }
        //    //Ints = Regex.Split(str,);
               
        //    IntCount = IntCount + Ints.Count;
        //    return subString; 
        //}

        //internal string FloatParsing(string subString)
        //{
        //    while (regex2.IsMatch(subString))
        //    {
        //        Floats.Add(float.Parse(regex2.Match(subString).Value));
        //        subString = subString.Replace(regex2.Match(subString).Value, "");
        //        //Console.WriteLine(subString);
        //    }
        //    FloatCount = FloatCount + Floats.Count;
        //    return subString;
        //}

        internal void Do(string subString)
        {
            int IntSum = 0;
            float FloatSum = 0;
            while (regex2.IsMatch(subString))
            {
                Floats.Add(float.Parse(regex2.Match(subString).Value));
                subString = subString.Replace(regex2.Match(subString).Value, " ");
                //Console.WriteLine(subString);
            }
            FloatCount = FloatCount + Floats.Count;
            Console.WriteLine("Count of floats = "+ FloatCount);

            while (regex1.IsMatch(subString))
            {
                Ints.Add(int.Parse(regex1.Match(subString).Value));
                subString = subString.Replace(regex1.Match(subString).Value, " ");
            }
            IntCount = IntCount + Ints.Count;
            Console.WriteLine("Count of integers = "+ IntCount);

            for (int i = 0; i < Ints.Count; i++)
            {
                Console.WriteLine(Ints[i].ToString().PadLeft(22));
                IntSum = IntSum + Ints[i];
                
            }
            double IAverage = (double)IntSum / IntCount;
            Console.Write("Average = ");
            Console.WriteLine(IAverage.ToString().PadLeft(12));

            for (int i = 0; i < Floats.Count; i++)
            {
                Console.WriteLine(Floats[i].ToString().PadLeft(22));
                FloatSum = FloatSum + Floats[i];

            }
            Console.Write("Average = "  );
            Console.WriteLine("{0:F2}", (FloatSum / FloatCount));
        }
    }
}
