using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2.Handler
{
    class Handler
    {
        Tools.Tools Tools = new Tools.Tools();
        bool flag = true;
        string oneString;
        List<string> strings = new List<string>();

        internal void Execution()
        {
            try
            {
                while (flag == true)
                {
                    oneString = Console.ReadLine();
                    if (oneString.Equals("stop"))
                    {
                        flag = false;
                    }
                    if (!oneString.Equals("stop"))
                    {
                        strings.Add(oneString);
                    }
                    
                }
                foreach (var subS in strings)
                {
                    Tools.Do(subS);   
                }


            }
            catch (Exception)
            {

                throw;
            }
        } 
    }
}
