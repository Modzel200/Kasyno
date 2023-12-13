﻿using Kasyno.Logic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kasyno.Games
{
    public class BlackjackElement
    {
        public BlackjackElement(int Id, string Name, string ImageUrl, List<string> AsciTab, int Weight)
        {
            this.Id = Id;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.AsciTab = AsciTab;
            this.Weight = Weight;
            this.Quantity = 4;
        }
        public BlackjackElement(int Id, string Name, string ImageUrl, int Weight)
        {
            this.Id = Id;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.Weight = Weight;
            this.Quantity = 4;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<string>? AsciTab { get; set; }
        public int Weight { get; set; }
        public int Quantity { get; set; }
    }
    
    public partial class Blackjack : Window
    {
        private Random random = new Random();
        private Account account = new Account();
        private int userScore = 0;
        private int botScore = 0;
        private List<BlackjackElement> elements;
        public Blackjack()
        {
            InitializeComponent();
            initList();
            accBalance.Text = "Balans: " + account.getBalance();
        }
        private void initList()
        {
            elements = new List<BlackjackElement>();
            elements.Add(new BlackjackElement(0, "As", "acebj.png", 11));
            elements.Add(new BlackjackElement(1, "Dwa", "twobj.png", 2));
            elements.Add(new BlackjackElement(2, "Trzy", "threebj.png", 3));
            elements.Add(new BlackjackElement(3, "Cztery", "fourbj.png", 4));
            elements.Add(new BlackjackElement(4, "Pięć", "fivebj.png", 5));
            elements.Add(new BlackjackElement(5, "Sześć", "sixbj.png", 6));
            elements.Add(new BlackjackElement(6, "Siedem", "sevenbj.png", 7));
            elements.Add(new BlackjackElement(7, "Osiem", "eightbj.png", 8));
            elements.Add(new BlackjackElement(8, "Dziewięć", "ninebj.png", 9));
            elements.Add(new BlackjackElement(9, "Dziesięć", "tenbj.png", 10));
            elements.Add(new BlackjackElement(10, "Walet", "jopekbj.png", 10));
            elements.Add(new BlackjackElement(11, "Dama", "queenbj.png", 10));
            elements.Add(new BlackjackElement(12, "Król", "kingbj.png" , 10));
        }
        private void shouldEnemyHit()
        {
            if (botScore < 16)
            {
                hitEnemyCard();
            }
        }
        private void hitEnemyCard()
        {
            int card = random.Next(12);
            while (elements[card].Quantity==0)
            {
                card = random.Next(12);
            }
            elements[card].Quantity--;
            botScore += elements[card].Weight;
            botThrow.Source = new ImageSourceConverter().ConvertFromString(elements[card].ImageUrl) as ImageSource;
            MediaPlayer mplayer = new MediaPlayer();
            mplayer.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "card.mp3"));
            mplayer.Play();
        }
        private void hitCard()
        {
            int card = random.Next(12);
            while (elements[card].Quantity == 0)
            {
                card = random.Next(12);
            }
            elements[card].Quantity--;
            userScore += elements[card].Weight;
            userThrow.Source = new ImageSourceConverter().ConvertFromString(elements[card].ImageUrl) as ImageSource;
            MediaPlayer mplayer = new MediaPlayer();
            mplayer.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "card.mp3"));
            mplayer.Play();
        }
        private void whoIsWinner()
        {
            if (userScore > botScore)
            {
                Won();
            }
            if (botScore > userScore)
            {
                loss();
            }
            if (userScore == botScore)
            {
                draw();
            }
        }
        private int higerThanTO()
        {
            if (userScore > 21)
            {
                loss();
                return -1;
            }
            if (botScore > 21)
            {
                Won();
                return 1;
            }
            return 0;
        }
        private void loss()
        {
            botScore = 0;
            userScore = 0;
            initList();
            inittxt.Visibility = Visibility.Visible;
            initbet.Visibility = Visibility.Visible;
            initbutton.Visibility = Visibility.Visible;
            hitbj.Visibility = Visibility.Hidden;
            standbj.Visibility = Visibility.Hidden;
            bigWin.Visibility = Visibility.Hidden;
        }
        private void draw()
        {
            botScore = 0;
            userScore = 0;
            initList();
            account.addBalance(double.Parse(initbet.Text, CultureInfo.InvariantCulture.NumberFormat));
            inittxt.Visibility = Visibility.Visible;
            initbet.Visibility = Visibility.Visible;
            initbutton.Visibility = Visibility.Visible;
            hitbj.Visibility = Visibility.Hidden;
            standbj.Visibility = Visibility.Hidden;
            bigWin.Visibility = Visibility.Hidden;
        }
        private void Won()
        {
            userScore = 0;
            botScore = 0;
            userThrow.Visibility = Visibility.Hidden;
            botThrow.Visibility = Visibility.Hidden;
            bjtable.Visibility = Visibility.Hidden;
            bigWin.Visibility = Visibility.Visible;
            inittxt.Visibility = Visibility.Visible;
            initbet.Visibility = Visibility.Visible;
            initbutton.Visibility = Visibility.Visible;
            hitbj.Visibility = Visibility.Hidden;
            standbj.Visibility = Visibility.Hidden;
            account.addBalance(double.Parse(initbet.Text, CultureInfo.InvariantCulture.NumberFormat) * 2);
            accBalance.Text = "Balans: " + account.getBalance();
            Thread.Sleep(3000);
            bigWin.Source = new Uri(AppDomain.CurrentDomain.BaseDirectory + "money.mp4");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            userThrow.Visibility = Visibility.Visible;
            botThrow.Visibility = Visibility.Visible;
            inittxt.Visibility = Visibility.Hidden;
            initbet.Visibility = Visibility.Hidden;
            initbutton.Visibility = Visibility.Hidden;
            hitbj.Visibility = Visibility.Visible;
            standbj.Visibility = Visibility.Visible;
            bjtable.Visibility = Visibility.Visible;
            bigWin.Visibility = Visibility.Hidden;
            updateScore();
            account.removeBalance(double.Parse(initbet.Text, CultureInfo.InvariantCulture.NumberFormat));
            accBalance.Text = "Balans: " + account.getBalance();
            hitCard();
            updateScore();
            Thread.Sleep(200);
            shouldEnemyHit();
            updateScore();
            Thread.Sleep(200);
            higerThanTO();
        }
        private void Button_Click_Hit(object sender, RoutedEventArgs e)
        {
            hitCard();
            updateScore();
            Thread.Sleep(200);
            shouldEnemyHit();
            updateScore();
            Thread.Sleep(200);
            higerThanTO();
        }
        private void updateScore()
        {
            userScoreVis.Text = "Twoje punkty: " + userScore.ToString();
            botScoreVis.Text = "Punkty krupiera: " + botScore.ToString();
        }
        private void Button_Click_Stand(object sender, RoutedEventArgs e)
        {
            while(botScore <= 16)
            {
                shouldEnemyHit();
                updateScore();
                Thread.Sleep(200);
            }
            if(higerThanTO() == 0)
            {
                whoIsWinner();
            }
        }
    }
}
