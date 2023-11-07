using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino
{
    public class Account
    {
        private string name;
        private float accBalance;
        public Account()
        {
            if (!File.Exists("account.txt"))
            {
                Console.Write("Podaj swoje imie: ");
                name = Console.ReadLine();
                File.WriteAllText("account.txt",name+"\n"+"1000");
            }
            name = File.ReadLines("account.txt").ElementAtOrDefault(0);
            accBalance = float.Parse(File.ReadLines("account.txt").ElementAtOrDefault(1), CultureInfo.InvariantCulture.NumberFormat);
        }
        public string getName()
        {
            return name;
        }
        public float getBalance()
        {
            return accBalance;
        }
    }
}
