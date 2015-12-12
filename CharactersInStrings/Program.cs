using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ReplacingSymbols
{
    class Program
    {
        //Написать метод, входными параметрами которого являются строка,
        //два символа. Метод должен заменить в строке все вхождения первого символа на символ «*» если рядом с этим символом не стоит второй символ.
        public string ReplaceSymbols(string inputLine, string characters)
        {
            char[] outputLine = inputLine.ToCharArray();
            Console.WriteLine("Length of outputLine " + outputLine.Length);
            Console.ReadKey();
            char[] twoCaharacters = characters.ToCharArray();

            for (int i = 0; i < (outputLine.Length - 1); i++)
            {
                if ((outputLine[i] == twoCaharacters[0]) && (outputLine[i + 1] != twoCaharacters[1]))
                {
                    outputLine[i] = Convert.ToChar("*");
                    Console.WriteLine(outputLine[i]);
                    Console.ReadKey();
                }
                else
                {
                    outputLine[i] = Convert.ToChar(outputLine[i]);
                    Console.WriteLine(outputLine[i]);
                    Console.ReadKey();
                }
            }
            if (outputLine[outputLine.Length - 1] == twoCaharacters[0])
            {
                outputLine[outputLine.Length - 1] = Convert.ToChar("*");
                Console.WriteLine(outputLine[outputLine.Length - 1]);
                Console.ReadKey();
            }
            return outputLine.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, в которой будет осуществляться поиск далее введенных двух символов: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Введите два символа, на основании которых будет вестись поиск в строке: ");
            string inputCharacters = Console.ReadLine();
            Program searchReplace = new Program();
            string resultString = searchReplace.ReplaceSymbols(inputString, inputCharacters);
            Console.WriteLine("The result is " + resultString);
            Console.ReadKey();
        }
    }
}
