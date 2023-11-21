namespace ConsoleCasino.Craps;

public class Craps
{
    
    

    private int bid;
    private Random random = new Random();
    private int rand;
    private int number;
    private int write;
    private int throw1;
    private int throw2;
    private List<CrapsElement> crapsImg;
    public void Game(Account account, Assets assets)
    {
      ConsoleKeyInfo cki;
      do
      {
            
            Console.SetCursorPosition(0, 15);
            assets.getBasicCraps();
            Console.SetCursorPosition(0,1);
            assets.getCraps();
            assets.getBalance(account);
            Console.WriteLine();
            Console.WriteLine("Wciśnij SPACE żeby rzucić koścmi, ESC żeby wyjść");
            cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Spacebar:
                Console.Write("Twój zakład: ");
                bid = int.Parse(Console.ReadLine());
                if (account.getBalance() >= bid)
                {
                    Console.Clear();
                if (Throw(assets))
                {
                    account.addBalance(bid);
                    Console.SetCursorPosition(100, 21);
                    Console.WriteLine("Wygrywasz, twój aktualny balans:" + account.getBalance());
                    Thread.Sleep(2000);
                    assets.getBigWin();
                    Console.Clear() ;
                }
                else
                {
                    account.removeBalance(bid);
                    Console.SetCursorPosition(100, 21);
                    Console.WriteLine("Przegrywasz, twój aktualny balans:" + account.getBalance());
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            break;
        }
      } while (cki.Key!=ConsoleKey.Escape);
    }

    public bool Throw(Assets assets)
    {
        crapsImg = assets.getCrapsImg();
        Console.SetCursorPosition(0, 1);
        assets.getCraps();
        int time = 100;
        Console.CursorVisible = false;
        rand = random.Next() % 20 + 10;
        int newrand;
        Console.SetCursorPosition(10, 9);
        Console.WriteLine("Twoje rzuty: ");
        while (rand != 0)
        {
            Console.SetCursorPosition(10, 10);
            newrand = (random.Next() % 5) + 1;
            Console.Write(crapsImg[newrand].image);
            rand--;
            throw1 = crapsImg[newrand].number;
            Thread.Sleep(time);
            time += 20;
        }
        Thread.Sleep(2000);
        rand = random.Next() % 20 + 10;
        time = 100;
        Console.SetCursorPosition(10, 33);
        Console.WriteLine("Rzuty rywala: ");
        while (rand != 0)
        {
            Console.SetCursorPosition(10, 34);
            newrand = (random.Next() % 5) + 1;
            Console.Write(crapsImg[newrand].image);
            rand--;
            throw2 = crapsImg[newrand].number;
            Thread.Sleep(time);
            time += 20;
        }
        if(throw1>throw2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}