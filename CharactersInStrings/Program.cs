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
            char[] twoCharacters = characters.ToCharArray();

            

            for (int i = 1; i < (outputLine.Length - 1); i++)
            {
                if (((outputLine[i] == twoCharacters[0]) && (outputLine[i + 1] != twoCharacters[1])) || ((outputLine[i] == twoCharacters[0]) && (outputLine[i - 1] != twoCharacters[1])))
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

            //Обработаем последний элемент строки. 
            //Если он равен первому символу второй строки из двух элементов, то мы заменим элемента на *
            if ((outputLine[outputLine.Length - 1] == twoCharacters[0]) && (outputLine[outputLine.Length - 2] != twoCharacters[1]))
            {
                outputLine[outputLine.Length - 1] = Convert.ToChar("*");
                Console.WriteLine(outputLine[outputLine.Length - 1]);
                Console.ReadKey();
            }

            if ((outputLine[0] == twoCharacters[0]) && (outputLine[1] != twoCharacters[1]))
            {
                outputLine[0] = Convert.ToChar("*");
                Console.WriteLine(outputLine[0]);
                Console.ReadKey();
            }
            

            string outputString = new string(outputLine);
            return outputString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, в которой будет осуществляться поиск далее введенных двух символов: ");
            string inputString = "qweqwjwqkwqkwq";
            Console.WriteLine("Введите два символа, на основании которых будет вестись поиск в строке: ");
            string inputCharacters = "qw";
            Program searchReplace = new Program();
            inputString = searchReplace.ReplaceSymbols(inputString, inputCharacters);
            Console.WriteLine("The result is " + inputString);
            Console.ReadKey();
        }
    }
}
