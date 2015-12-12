using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacingSymbols
{
    class Program
    {
        //Написать метод, входными параметрами которого являются строка,
        //два символа. Метод должен заменить в строке все вхождения первого символа на символ «*» если рядом с этим символом не стоит второй символ.
        public string ReplaceSymbols(string inputLine, string characters)
        {
            string outputLine = null;
            for (int i = 0; i < (inputLine.Length - 1); i++)
            {
                if (inputLine[i] == characters[0])
                {
                    if (inputLine[i + 1] != characters[1])
                    {
                        outputLine[i] = "*";
                    }
                }
            }
            return outputLine;
        }
        static void Main(string[] args)
        {
        }
    }
}
