﻿using System;
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
        Account account { get; set; }
        int first = 0;
        int yoursum = 0;
        int enemysum = 0;
        public Blackjack(Assets assets, Account account)
        {
            this.assets = assets;
            this.account = account;
        }
        public void Game()
        {
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
            EmptyView();
            getYourSum(yoursum);
            getEnemySum(enemysum);
            do
            {
                account.removeBalance(bet);
                assets.getBalance(account);
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.H:
                        Thread.Sleep(200);
                        yoursum += hitCard();
                        getYourSum(yoursum);
                        Thread.Sleep(160);
                        shouldEnemyHit(enemysum);
                        first = 1;
                        higerThanTO(yoursum, enemysum, bet);
                        break;
                    case ConsoleKey.S:
                        if(first == 0)
                        {
                            break;
                        }
                        while(enemysum <= 16)
                        {
                            shouldEnemyHit(enemysum);
                            Thread.Sleep(160);
                        }
                        if(higerThanTO(yoursum, enemysum, bet) == 0)
                        {
                            whoIsWinner(yoursum, enemysum, bet);
                        }
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
        public void win(int bet)
        {
            Console.SetCursorPosition(25, 50);
            Console.Write("Wygrałeś");
            account.addBalance(2 * bet);
            Thread.Sleep(800);
            Console.SetCursorPosition(25, 50);
            Console.Write("                             ");
            yoursum = 0;
            enemysum = 0;
            first = 0;
            assets.resetQuant();
            EmptyView();
            getYourSum(yoursum);
            getEnemySum(enemysum);
        }
        public void shouldEnemyHit(int b)
        {
            if (b <= 16)
            {
                enemysum += hitEnemyCard();
                getEnemySum(enemysum);
            }
        }
        public void draw(int bet)
        {
            Console.SetCursorPosition(25, 50);
            Console.Write("Remis");
            account.addBalance(bet);
            Thread.Sleep(800);
            Console.SetCursorPosition(25, 50);
            Console.Write("                             ");
            yoursum = 0;
            enemysum = 0;
            first = 0;
            assets.resetQuant();
            EmptyView();
            getYourSum(yoursum);
            getEnemySum(enemysum);
        }
        public void loss()
        {
            Console.SetCursorPosition(25, 50);
            Console.Write("Przegrałeś");
            Thread.Sleep(800);
            Console.SetCursorPosition(25, 50);
            Console.Write("                             ");
            yoursum = 0;
            enemysum = 0;
            first = 0;
            assets.resetQuant();
            EmptyView();
            getYourSum(yoursum);
            getEnemySum(enemysum);
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
        public int higerThanTO(int a, int b, int bet)
        {
            if(a > 21)
            {
                loss();
                return -1;
            }
            if(b > 21)
            {
                win(bet);
                return 1;
            }
            return 0;
        }
        public void whoIsWinner(int a, int b, int bet)
        {
            if(a > b)
            {
                win(bet);
            }
            if(b > a)
            {
                loss();
            }
            if(a == b)
            {
                draw(bet);
            }
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
