using ConsoleCasino;
using ConsoleCasino.Roulette;
using ConsoleCasino.Slots;
using System.Runtime.InteropServices;
using ConsoleCasino.Craps;
using ConsoleCasino.BlackJack;

class Program
{
    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetConsoleWindow();
    private static IntPtr ThisConsole = GetConsoleWindow();
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    private const int HIDE = 0;
    private const int MAXIMIZE = 3;
    private const int MINIMIZE = 6;
    private const int RESTORE = 9;
   
    static void Main(string[] args)
    {
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        ShowWindow(ThisConsole, MAXIMIZE);
        Account account = new Account();
        Assets assets = new Assets();
        assets.Intro();
        do
        {
            Console.Clear();
            assets.getTittle();
            assets.getBalance(account);
            string[] options = { "Slotsy", "Ruletka", "BlackJack", "Craps" };
            Games games = new Games();
            int game = games.changeOption(options);
            Console.Clear();
            switch (game)
            {
                case 0:
                    Slots slots = new Slots(assets);
                    slots.Game(account);
                    break;
                case 1:
                    Roulette roulette = new Roulette();
                    roulette.Game(account, assets);
                    break;
                case 2:
                    Blackjack bjgame = new Blackjack(assets);
                    bjgame.Game(account);

                    break;
                case 3:
                    Craps craps = new Craps();
                    craps.Game(account, assets);
                    break;
            }
        } while (true);
        
    }
}
