using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino
{
    public class Roulette
    {
        private List<int> roulette = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private Random random = new Random();
        private int rand;
        private int number;
        public int time = 100;
        public int bid;
        public void Game(Account account)
        {
            Console.Write("Podaj za ile wchodzisz: ");
            bid = Int32.Parse(Console.ReadLine());
            if(account.getBalance()>bid)
            {
                Spin();
            }
        }
        public void Spin()
        {
            rand = (random.Next() % 20) + 10;
            number = rand;
            while (rand != 0)
            {
                Console.WriteLine("Wygrywa:" + (number % roulette.Count + 1));
                rand--;
                number++;
                Thread.Sleep(time);
                time += 20;
            }
        }
    }
}
