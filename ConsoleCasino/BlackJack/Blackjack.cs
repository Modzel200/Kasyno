using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino.BlackJack
{
    public class Blackjack
    {
        Assets assets { get; set; }
        public Blackjack(Assets assets)
        {
            this.assets = assets;
        }
        public void Game(Account account)
        {
            int yoursum = 0;
            int enemysum = 0;
            assets.blackjackFill();
            assets.getBalance(account);
            assets.getBjTitle();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 9);
            ConsoleKeyInfo cki;
            int bet = 0;
            Console.Write("Ile chcesz postawić? ");
            bet = int.Parse(Console.ReadLine());
            Console.Clear();
            assets.getBalance(account);
            EmptyView();
            getYourSum(yoursum);
            getEnemySum(enemysum);
            int first = 0;
            do
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.H:
                        Thread.Sleep(200);
                        yoursum += hitCard();
                        getYourSum(yoursum);
                        Thread.Sleep(160);
                        enemysum += hitEnemyCard();
                        getEnemySum(enemysum);
                        if(checkConds(ref yoursum, ref enemysum, false, ref first) == 1)
                        {
                            //wygrana
                            assets.resetQuant();

                            yoursum = 0;
                            enemysum = 0;
                            EmptyView();
                            getYourSum(yoursum);
                            getEnemySum(enemysum);
                        }
                        if(checkConds(ref yoursum, ref enemysum, false, ref first) == 2)
                        {
                            //remis
                            assets.resetQuant();
                            yoursum = 0;
                            enemysum = 0;
                            EmptyView();
                            getYourSum(yoursum);
                            getEnemySum(enemysum);
                        }
                        if (checkConds(ref yoursum, ref enemysum, false, ref first) == -1)
                        {
                            //przegrana
                            assets.resetQuant();
                            yoursum = 0;
                            enemysum = 0;
                            EmptyView();
                            getYourSum(yoursum);
                            getEnemySum(enemysum);
                        }
                        //LeverAnim();
                        //LeverAnimBack();
                        first = 1;
                        break;
                    case ConsoleKey.S:
                        if(first == 0)
                        {
                            break;
                        }
                        if (checkConds(ref yoursum, ref enemysum, true, ref first) == 1)
                        {
                            //wygrana
                            assets.resetQuant();
                            yoursum = 0;
                            enemysum = 0;
                            EmptyView();
                            getYourSum(yoursum);
                            getEnemySum(enemysum);
                        }
                        if (checkConds(ref yoursum, ref enemysum, true, ref first) == 2)
                        {
                            //remis
                            assets.resetQuant();
                            yoursum = 0;
                            enemysum = 0;
                            EmptyView();
                            getYourSum(yoursum);
                            getEnemySum(enemysum);
                        }
                        if (checkConds(ref yoursum, ref enemysum, true, ref first) == -1)
                        {
                            //przegrana
                            assets.resetQuant();
                            yoursum = 0;
                            enemysum = 0;
                            EmptyView();
                            getYourSum(yoursum);
                            getEnemySum(enemysum);
                        }
                        //LeverAnim();
                        //LeverAnimBack();
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
        public void EmptyView()
        {
            assets.getBjTitle();
            assets.getBjTable();
        }
        public void getYourSum(int a)
        {
            assets.getYourSum(a);
        }
        public void getEnemySum(int a)
        {
            assets.getEnemySum(a);
        }
        public int checkConds(ref int a, ref int b, bool stand, ref int first)
        {
            if(a > 21)
            {
                a = 0;
                b = 0;
                first = 0;
                stand = false;
                return -1;
            }
            if(b > 21)
            {
                a = 0;
                b = 0;
                first = 0;
                stand = false;
                return 1;
            }
            if (!stand)
            {
                return 0;
            }
            if(a > b && stand)
            {
                a = 0;
                b = 0;
                first = 0;
                stand = false;
                return 1;
            }
            if(a < b && stand)
            {
                a = 0;
                b = 0;
                first = 0;
                stand = false;
                return -1;
            }
            if(a == b && stand)
            {
                a = 0;
                b = 0;
                first = 0;
                stand = false;
                return 2;
            }
            return 0;
        }
        public int hitCard()
        {
            Random rand = new Random();
            int card = rand.Next(12);
            while (!assets.removeQuant(card))
            {
                card = rand.Next(12);
            }
            return assets.getYourCard(card);
        }
        public int hitEnemyCard()
        {
            Random rand = new Random();
            int card = rand.Next(12);
            while (!assets.removeQuant(card))
            {
                card = rand.Next(12);
            }
            return assets.getEnemyCard(card);
        }
    }
}
