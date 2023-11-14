using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino
{
    public class Games
    {
        int selectedIndex=0;
        public void resetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public int changeOption(string[] options)
        {
            printOptions(options);
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.DownArrow:
                        if(selectedIndex<options.Length)
                        {
                            selectedIndex++;
                            printOptions(options);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if(selectedIndex>=0)
                        {
                            selectedIndex--;
                            printOptions(options);
                        }
                        break;
                }

            } while (cki.Key != ConsoleKey.Enter);
            return selectedIndex;
        }
        public void printOptions(string[] options)
        {
            Console.SetCursorPosition(0, 15);
            string currentOption;
            for (int i = 0; i < options.Length; i++)
            {
                
                currentOption = options[i];
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(currentOption);
            }
            resetColor();
        }
        
    }
}
