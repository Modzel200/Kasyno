using Kasyno.Logic;
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
        public BlackjackElement(int Id, string Name, Uri ImageUrl, List<string> AsciTab, int Weight)
        {
            this.Id = Id;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.AsciTab = AsciTab;
            this.Weight = Weight;
            this.Quantity = 4;
        }
        public BlackjackElement(int Id, string Name, Uri ImageUrl, int Weight)
        {
            this.Id = Id;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.Weight = Weight;
            this.Quantity = 4;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri ImageUrl { get; set; }
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
            elements.Add(new BlackjackElement(0, "As", new Uri(AppDomain.CurrentDomain.BaseDirectory + "acebj.png"), 11));
            elements.Add(new BlackjackElement(1, "Dwa", new Uri(AppDomain.CurrentDomain.BaseDirectory + "twobj.png"), 2));
            elements.Add(new BlackjackElement(2, "Trzy", new Uri(AppDomain.CurrentDomain.BaseDirectory + "threebj.png"), 3));
            elements.Add(new BlackjackElement(3, "Cztery", new Uri(AppDomain.CurrentDomain.BaseDirectory + "fourbj.png"), 4));
            elements.Add(new BlackjackElement(4, "Pięć", new Uri(AppDomain.CurrentDomain.BaseDirectory + "fivebj.png"), 5));
            elements.Add(new BlackjackElement(5, "Sześć", new Uri(AppDomain.CurrentDomain.BaseDirectory + "sixbj.png"), 6));
            elements.Add(new BlackjackElement(6, "Siedem", new Uri(AppDomain.CurrentDomain.BaseDirectory + "sevenbj.png"), 7));
            elements.Add(new BlackjackElement(7, "Osiem", new Uri(AppDomain.CurrentDomain.BaseDirectory + "eightbj.png"), 8));
            elements.Add(new BlackjackElement(8, "Dziewięć", new Uri(AppDomain.CurrentDomain.BaseDirectory + "ninebj.png"), 9));
            elements.Add(new BlackjackElement(9, "Dziesięć", new Uri(AppDomain.CurrentDomain.BaseDirectory + "tenbj.png"), 10));
            elements.Add(new BlackjackElement(10, "Walet", new Uri(AppDomain.CurrentDomain.BaseDirectory + "jopekbj.png"), 10));
            elements.Add(new BlackjackElement(11, "Dama", new Uri(AppDomain.CurrentDomain.BaseDirectory + "queenbj.png"), 10));
            elements.Add(new BlackjackElement(12, "Król", new Uri(AppDomain.CurrentDomain.BaseDirectory + "kingbj.png"), 10));
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
            botThrow.Source = elements[card].ImageUrl;
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
            userThrow.Source = elements[card].ImageUrl;
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
            userThrow.Visibility = Visibility.Hidden;
            botThrow.Visibility = Visibility.Hidden;
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
            updateScore();
            inittxt.Visibility = Visibility.Hidden;
            initbet.Visibility = Visibility.Hidden;
            initbutton.Visibility = Visibility.Hidden;
            hitbj.Visibility = Visibility.Visible;
            standbj.Visibility = Visibility.Visible;
            bigWin.Visibility = Visibility.Hidden;
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
