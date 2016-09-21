using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_1
{
    class HandlerClass
    {
        Operations opers = new Operations();

        const string EXPRESSION = "\\w*.txt";

        Regex regex1 = new Regex(EXPRESSION);
       
        public void Execution()
        {
            try
            {   
                string innerString = Console.ReadLine();
                string primaryText;
                string modifiedText;

                /* Работа с текстом из файла                       */
                if (regex1.IsMatch(innerString))
                {
                    primaryText = opers.Reading(innerString);
                    modifiedText = opers.TextModifying(primaryText);
                    opers.Writing(innerString, modifiedText);
                }
                /* Работа с текстом из консоли                     */
                else
                {
                    modifiedText = opers.TextModifying(innerString);
                    Console.WriteLine(modifiedText);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("This file is not exist");
            }
            
        }   
        
    }
}
