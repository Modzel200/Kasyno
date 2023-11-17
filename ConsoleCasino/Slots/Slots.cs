using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace ConsoleCasino.Slots
{
    public class Slots
    {
        public List<SlotsElement> elements;
        public List<SlotsPrize> prizes;
        public List<string> title;
        public Slots()
        {
            Random rnd = new Random();
            elements = new List<SlotsElement>();
            prizes = new List<SlotsPrize>();
            List<string> tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"          @@@@@@@@@@@@@@@@@@@@@         ");
            tmp.Add(@"       #@@ @,    @@. #@@    @@ @@,      ");
            tmp.Add(@"     @@    /@ (@@       @& (@    *@@    ");
            tmp.Add(@"   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#  ");
            tmp.Add(@"     @@      @@           @#     .@@    ");
            tmp.Add(@"       @@     @@         @@     @@      ");
            tmp.Add(@"         @@    @(       @@    @@        ");
            tmp.Add(@"           @@  .@      @@   @@          ");
            tmp.Add(@"            /@% &@    @@  @@            ");
            tmp.Add(@"              &@,@@  ,@ @@              ");
            tmp.Add(@"                @@@@ @@@                ");
            tmp.Add(@"                  @@@@.                 ");
            tmp.Add(@"                    /                   ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(1 ,"Diament" , "placeholder", tmp));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                       @@@@             ");
            tmp.Add(@"                    @( @@               ");
            tmp.Add(@"                  @    @                ");
            tmp.Add(@"                @@    @%                ");
            tmp.Add(@"               %@     @@                ");
            tmp.Add(@"               @       @                ");
            tmp.Add(@"          @@@@@@@@@@  @@@@@@@@*         ");
            tmp.Add(@"         @@@@@@@@@@ @@@@@@@@@@@@        ");
            tmp.Add(@"         @@@@@@@@@@ @@@@@@@@@@@@        ");
            tmp.Add(@"         @@@@@@@@@@ @@@@@@@@@@@@        ");
            tmp.Add(@"          &@@@@@@@@@  @@@@@@@@          ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            prizes.Add(new SlotsPrize(1, 5));
            elements.Add(new SlotsElement(2, "Wiśienki", "placeholder", tmp));
            prizes.Add(new SlotsPrize(2, 1.5));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                     /                  ");
            tmp.Add(@"                   (((                  ");
            tmp.Add(@"                  .((                   ");
            tmp.Add(@"                *(((( ##                ");
            tmp.Add(@"           ((((((##########%%,          ");
            tmp.Add(@"         (((((##############%%%%        ");
            tmp.Add(@"        (((((################%%%%       ");
            tmp.Add(@"       ((((###################%%%%      ");
            tmp.Add(@"       ((((#################%%%%%%      ");
            tmp.Add(@"       ((((#################%%%%%%      ");
            tmp.Add(@"       ((((#################%%%%%%      ");
            tmp.Add(@"        ((((##############%%%%%%%       ");
            tmp.Add(@"          (((##########%%%%%%%%         ");
            tmp.Add(@"             ((%%%%%%%%%%%%%            ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(3, "Śliwka", "placeholder", tmp));
            prizes.Add(new SlotsPrize(3, 1.25));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                  @@@@@                 ");
            tmp.Add(@"               @@@@@@@@@@@              ");
            tmp.Add(@"             @@@@@@@@@@@@@@@            ");
            tmp.Add(@"             @@@@@@@@@@@@@@@            ");
            tmp.Add(@"            @@@@@@@@@@@@@@@@@           ");
            tmp.Add(@"            @@@@@@@@@@@@@@@@@           ");
            tmp.Add(@"            @@@@@@@@@@@@@@@@@           ");
            tmp.Add(@"           @@@@@@@@@@@@@@@@@@@          ");
            tmp.Add(@"          @@@@@@@@@@@@@@@@@@@@@         ");
            tmp.Add(@"        @@@@@@@@@@@@@@@@@@@@@@@@@       ");
            tmp.Add(@"               @@@@@@                   ");
            tmp.Add(@"                 *                      ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(4, "Dzwon", "placeholder", tmp));
            prizes.Add(new SlotsPrize(4, 2));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"           @@@@@@@     @@@@@@@          ");
            tmp.Add(@"         @@@@@@@@@@   @@@@@@@@@@        ");
            tmp.Add(@"      @@@@@@@@@@@@@@ @@@@@@@@@@@@@@     ");
            tmp.Add(@"     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    ");
            tmp.Add(@"      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@     ");
            tmp.Add(@"          @@@@@@@@@@@@@@@@@@@@@         ");
            tmp.Add(@"         (@@@@@@@@@@@@@@@@@@@@@(        ");
            tmp.Add(@"     *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*    ");
            tmp.Add(@"     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    ");
            tmp.Add(@"      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@     ");
            tmp.Add(@"         @@@@@@@@@@ @ @@@@@@@@@@        ");
            tmp.Add(@"           @@@@@@@  @  @@@@@@@          ");
            tmp.Add(@"                   @@                   ");
            tmp.Add(@"                   @@                   ");
            tmp.Add(@"                 @@@                    ");
            elements.Add(new SlotsElement(5, "Koniczyna", "placeholder", tmp));
            prizes.Add(new SlotsPrize(5, rnd.NextDouble()+2));
            tmp = new List<string>();
            tmp.Add(@"                   @@@@@@@@             ");
            tmp.Add(@"             @@@               @@@@@    ");
            tmp.Add(@"         (@@                       @@   ");
            tmp.Add(@"       @@                           @   ");
            tmp.Add(@"     @@    @@                       @@  ");
            tmp.Add(@"    @@   @@                          @  ");
            tmp.Add(@"   @@   @@                           @  ");
            tmp.Add(@"   @   @@                       @@   @  ");
            tmp.Add(@"  @@                           @@   @@  ");
            tmp.Add(@"   @                          @@   @@   ");
            tmp.Add(@"   @@                        @    @@    ");
            tmp.Add(@"    @                           @@      ");
            tmp.Add(@"    @@                       @@.        ");
            tmp.Add(@"     @@@@@               @@@            ");
            tmp.Add(@"             .@@@@@@@@                  ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(6, "Cytryna", "placeholder", tmp));
            prizes.Add(new SlotsPrize(6, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"          ,@@@@@@@%**/&@@@@@@@          ");
            tmp.Add(@"       @@@@.      .&@%       /@@@@      ");
            tmp.Add(@"     @@@    @@@@@@@,,,@@@@@@@    @@@    ");
            tmp.Add(@"  .@@@   @@@@@@@@@     @@@@@@@@@   @@@  ");
            tmp.Add(@"  @@@  @@@@@@@@           @@@@@@@*  @@@ ");
            tmp.Add(@" @@@  @@@@@@@@    @@@@@ ,@@@@@@@@@@  @@@");
            tmp.Add(@" @@   @@@@@@@@@       @@@@@@@@@@@@@   @@");
            tmp.Add(@"@@@  @@@@@@@@@@@@         @@@@@@@@@   @@");
            tmp.Add(@" @@   @@@@@@@@@@@@@@@@.    @@@@@@@@   @@");
            tmp.Add(@" @@@  @@@@@@@@    @@@@@    @@@@@@@@  @@@");
            tmp.Add(@"  @@@  %@@@@@@@           @@@@@@@   @@@ ");
            tmp.Add(@"   @@@   @@@@@@@@@@   @@@@@@@@@@   @@@  ");
            tmp.Add(@"     @@@    @@@@@@@%%%@@@@@@@   .@@@    ");
            tmp.Add(@"       @@@@%                 @@@@@      ");
            tmp.Add(@"           @@@@@@@@@&@@@@@@@@@          ");
            elements.Add(new SlotsElement(7, "Moneta", "placeholder", tmp));
            prizes.Add(new SlotsPrize(7, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"     (%@@@@@@@@@@@@@@@@@@@@@@@@@@(,     ");
            tmp.Add(@"  @%                                @@  ");
            tmp.Add(@"  @   ((((*       /(*     ((((*      @  ");
            tmp.Add(@"  @   @@   @@    @@/@&    @@   @@.   @  ");
            tmp.Add(@"  @   @@@@@@*   @@  @@(   @@@@@@     @  ");
            tmp.Add(@"  @   @@   #@& %@@@@@@@/  @@  #@@    @  ");
            tmp.Add(@"  @   @@@@@@  (@&     @@  @@   #@@   @  ");
            tmp.Add(@"  @%                                @@  ");
            tmp.Add(@"     (@@@@@@@@@@@@@@@@@@@@@@@@@@@@(     ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(8, "Bar", "placeholder", tmp));
            prizes.Add(new SlotsPrize(8, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                  .%%                   ");
            tmp.Add(@"                    ## #######*#        ");
            tmp.Add(@"                    %%###/####          ");
            tmp.Add(@"          #########%###########         ");
            tmp.Add(@"        ,#######################.       ");
            tmp.Add(@"        #########################       ");
            tmp.Add(@"        #########################       ");
            tmp.Add(@"        #########################       ");
            tmp.Add(@"         #######################        ");
            tmp.Add(@"          #####################         ");
            tmp.Add(@"            #################           ");
            tmp.Add(@"                *,     *.               ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(9, "Jabłko", "placeholder", tmp));
            prizes.Add(new SlotsPrize(9, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"         @@@@@@@@@@   @@@@@@@@@@        ");
            tmp.Add(@"       &@@@@@@@@@@@@ @@@@@@@@@@@@,      ");
            tmp.Add(@"       @@@@@@@@@@@@@@@@@@@@@@@@@@@      ");
            tmp.Add(@"       &@@@@@@@@@@@@@@@@@@@@@@@@@*      ");
            tmp.Add(@"        @@@@@@@@@@@@@@@@@@@@@@@@,       ");
            tmp.Add(@"          @@@@@@@@@@@@@@@@@@@@@         ");
            tmp.Add(@"            @@@@@@@@@@@@@@@@@           ");
            tmp.Add(@"               @@@@@@@@@@@              ");
            tmp.Add(@"                  @@@@@                 ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(10, "Serce", "placeholder", tmp));
            prizes.Add(new SlotsPrize(10, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"            @@@@@@*   @@@@@@@           ");
            tmp.Add(@"            @@@   @@@@@                 ");
            tmp.Add(@"             @@@@  @@@                  ");
            tmp.Add(@"        @@@@@@@(@@@@@@@@@.@@@@@@@       ");
            tmp.Add(@"      @@@     @@@       @@@     @@@     ");
            tmp.Add(@"      @@@     @@@       @@@     @@@     ");
            tmp.Add(@"        @@@@@@@ @@@@@@@@@ @@@@@@%       ");
            tmp.Add(@"          .@@@     @@@     @@@          ");
            tmp.Add(@"            ,@@@@@@@ @@@@@@@            ");
            tmp.Add(@"                @@@   @@@               ");
            tmp.Add(@"                  #@@@/                 ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(11, "Winogrona", "placeholder", tmp));
            prizes.Add(new SlotsPrize(11, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"             ####### % #                ");
            tmp.Add(@"                ###*% ####(             ");
            tmp.Add(@"                .*******                ");
            tmp.Add(@"            .***************            ");
            tmp.Add(@"           *******************          ");
            tmp.Add(@"         .*********************         ");
            tmp.Add(@"         //*********************        ");
            tmp.Add(@"         /**********************        ");
            tmp.Add(@"          *********************         ");
            tmp.Add(@"           */****************,          ");
            tmp.Add(@"              ***/**//*****             ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(12, "Pomarańcza", "placeholder", tmp));
            prizes.Add(new SlotsPrize(12, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"           @@@@@@@@@@@@@@@@@@@          ");
            tmp.Add(@"        @@@@@@.   @@@@@   /@@@@@@       ");
            tmp.Add(@"      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@     ");
            tmp.Add(@"    @@@@  @@@@@@         @@@@@@  @@@@   ");
            tmp.Add(@"   @@@@ @@@@@               @@@@@ @@@@  ");
            tmp.Add(@"  @@@@@@@@@@                 @@@@@@@@@@ ");
            tmp.Add(@"  @@@  @@@@                   @@@@  @@@ ");
            tmp.Add(@"  @@@  @@@@                   @@@@  @@@ ");
            tmp.Add(@"   @@@@@@@@                   @@@@@@@@  ");
            tmp.Add(@"   @@@@@@@@                  *@@@@@@@@  ");
            tmp.Add(@"    @@@  @@@                 @@@  @@@   ");
            tmp.Add(@"     @@@@@@@                 @@@@@@@    ");
            tmp.Add(@"      @@@@@@@               @@@@@@@     ");
            tmp.Add(@"       @@@@@@@             @@@@@@@      ");
            tmp.Add(@"     @@@@@@@@@             @@@@@@@@@    ");
            elements.Add(new SlotsElement(13, "Podkowa", "placeholder", tmp));
            prizes.Add(new SlotsPrize(13, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"               @@@@@@@@@@@@@@@          ");
            tmp.Add(@"             @              @           ");
            tmp.Add(@"            @              /            ");
            tmp.Add(@"           @  @       @                 ");
            tmp.Add(@"                     @                  ");
            tmp.Add(@"                        @               ");
            tmp.Add(@"                    @  @                ");
            tmp.Add(@"                   @                    ");
            tmp.Add(@"                   @  @                 ");
            tmp.Add(@"                      @                 ");
            tmp.Add(@"                  @   @                 ");
            tmp.Add(@"                  @                     ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(14, "Siedem", "placeholder", tmp));
            prizes.Add(new SlotsPrize(14, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                  @@@@@.                ");
            tmp.Add(@"              @@@@@@@@@@@@@             ");
            tmp.Add(@"             @@@@      /@@@@            ");
            tmp.Add(@"             @@@@       @@@@            ");
            tmp.Add(@"                      @@@@@             ");
            tmp.Add(@"                   /@@@@&               ");
            tmp.Add(@"                  @@@@                  ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                  @@@@                  ");
            tmp.Add(@"                  @@@@                  ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(15, "Znak zapytania", "placeholder", tmp));
            prizes.Add(new SlotsPrize(15, 1));
            tmp = new List<string>();
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@" //    ./////////////////////////    .//");
            tmp.Add(@" //.    /////////////////////////    ///");
            tmp.Add(@" ///    //////%%%//%%%//%%%/////     //.");
            tmp.Add(@"  ///     /////////////////////     /// ");
            tmp.Add(@"    ///      //////////////(      ///   ");
            tmp.Add(@"      ///                      .///     ");
            tmp.Add(@"        ./////             /////        ");
            tmp.Add(@"             */////////////,            ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            tmp.Add(@"                                        ");
            elements.Add(new SlotsElement(16, "Arbuz", "placeholder", tmp));
            prizes.Add(new SlotsPrize(16, 1));
            tmp = new List<string>();
            tmp.Add(@"                                                                                ");
            tmp.Add(@"       @@@@@@@@&   /@@@          @@@@@@@@@@@,  .@@@@@@@@@@@@@. *@@@@@@@@(       ");
            tmp.Add(@"     .@@@,         /@@@        @@@@.     ,@@@@      .@@@.     ,@@@              ");
            tmp.Add(@"      @@@@@(       /@@@       %@@@        .@@@/     .@@@.      @@@@&/           ");
            tmp.Add(@"        (@@@@@@#   /@@@       &@@@         @@@(     .@@@.        #@@@@@@/       ");
            tmp.Add(@"            .@@@&  /@@@       #@@@        (@@@.     .@@@.            /@@@/      ");
            tmp.Add(@"     /@(.  .#@@@*  /@@@*****,  &@@@&,   *@@@@,      .@@@.     %@/.  .&@@@.      ");
            tmp.Add(@"      (@@@@@@@,    *@@@@@@@@@    *&@@@@@@@(         .@@@.      #@@@@@@&         ");
            tmp.Add(@"                                                                                ");
            this.title = tmp;
        }
        public void Game(Account account, Assets assets)
        {
            assets.getBalance(account);
            Console.SetCursorPosition(0, 0);
            ConsoleKeyInfo cki;
            int bet = 0;
            Console.Clear();
            Console.Write("Za ile chcesz wejść? ");
            bet = int.Parse(Console.ReadLine());
            Console.Clear();
            assets.getBalance(account);
            EmptyView();
            do
            {
                cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.Spacebar:
                        LeverAnim();
                        Lever(account, bet,assets);
                        LeverAnimBack();
                    break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
        public void LeverAnim()
        {
            Console.SetCursorPosition(152, 13);
            Console.Write("   ");
            Console.SetCursorPosition(151, 14);
            Console.Write("     ");
            Console.SetCursorPosition(152, 15);
            Console.Write("   ");
            Console.SetCursorPosition(152, 16);
            Console.Write("   ");
            Console.SetCursorPosition(152, 17);
            Console.Write("   ");
            Console.SetCursorPosition(152, 18);
            Console.Write("   ");
            Console.SetCursorPosition(152, 19);
            Console.Write("   ");
            Console.SetCursorPosition(152, 20);
            Console.Write("   ");
            Console.SetCursorPosition(152, 21);
            Console.Write(" _ ");
            Console.SetCursorPosition(153, 22);
            Console.Write(" ");
            Console.SetCursorPosition(152, 23);
            Console.Write("| |");
            Console.SetCursorPosition(152, 24);
            Console.Write("| |");
            Console.SetCursorPosition(152, 25);
            Console.Write("| |");
            Console.SetCursorPosition(152, 26);
            Console.Write("| |");
            Console.SetCursorPosition(152, 27);
            Console.Write("| |");
            Console.SetCursorPosition(152, 28);
            Console.Write("| |");
            Console.SetCursorPosition(151, 29);
            Console.Write("(___)");
        }
        public void LeverAnimBack()
        {
            Console.SetCursorPosition(152, 13);
            Console.Write("___");
            Console.SetCursorPosition(151, 14);
            Console.Write("(   )");
            Console.SetCursorPosition(152, 15);
            Console.Write("| |");
            Console.SetCursorPosition(152, 16);
            Console.Write("| |");
            Console.SetCursorPosition(152, 17);
            Console.Write("| |");
            Console.SetCursorPosition(152, 18);
            Console.Write("| |");
            Console.SetCursorPosition(152, 19);
            Console.Write("| |");
            Console.SetCursorPosition(152, 20);
            Console.Write("| |");
            Console.SetCursorPosition(152, 21);
            Console.Write("| |");
            Console.SetCursorPosition(153, 22);
            Console.Write("_");
            Console.SetCursorPosition(152, 23);
            Console.Write("   ");
            Console.SetCursorPosition(152, 24);
            Console.Write("   ");
            Console.SetCursorPosition(152, 25);
            Console.Write("   ");
            Console.SetCursorPosition(152, 26);
            Console.Write("   ");
            Console.SetCursorPosition(152, 27);
            Console.Write("   ");
            Console.SetCursorPosition(152, 28);
            Console.Write("   ");
            Console.SetCursorPosition(151, 29);
            Console.Write("     ");
        }
        public void EmptyView()
        {
            foreach (string elem in title)
            {
                Console.WriteLine(elem);
            }
            Console.Write(@"   ____________________________________________________________________________________________________________________________________________" + "\n");
            Console.Write(@" ///  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  \\\ " + "\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      ___\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "     (   )\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "---\\  | |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "   |--| |  \n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "   |__(_)\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "   |\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "---/  \n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            Console.Write(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            Console.Write(@" \\\  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  /// " + "\n");
            Console.Write(@"   --------------------------------------------------------------------------------------------------------------------------------------------" + "\n");
            Console.WriteLine("Wciśnij SPACE żeby zakręcić, ESC żeby wyjść");
        }
        public void GameView(int a, int b, int c)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(title[i]);
            }
            
            Console.SetCursorPosition(0, 9);
            Console.Write(@"   ____________________________________________________________________________________________________________________________________________" + "\n");
            Console.SetCursorPosition(0, 10);
            Console.Write(@" ///  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  \\\ " + "\n");
            Console.SetCursorPosition(0, 11);
            Console.Write(@" |||  " + elements[a].AsciTab[0] + @"  |||  " + elements[b].AsciTab[0] + @"  |||  " + elements[c].AsciTab[0] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 12);
            Console.Write(@" |||  " + elements[a].AsciTab[1] + @"  |||  " + elements[b].AsciTab[1] + @"  |||  " + elements[c].AsciTab[1] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 13);
            Console.Write(@" |||  " + elements[a].AsciTab[2] + @"  |||  " + elements[b].AsciTab[2] + @"  |||  " + elements[c].AsciTab[2] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 14);
            Console.Write(@" |||  " + elements[a].AsciTab[3] + @"  |||  " + elements[b].AsciTab[3] + @"  |||  " + elements[c].AsciTab[3] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 15);
            Console.Write(@" |||  " + elements[a].AsciTab[4] + @"  |||  " + elements[b].AsciTab[4] + @"  |||  " + elements[c].AsciTab[4] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 16);
            Console.Write(@" |||  " + elements[a].AsciTab[5] + @"  |||  " + elements[b].AsciTab[5] + @"  |||  " + elements[c].AsciTab[5] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 17);
            Console.Write(@" |||  " + elements[a].AsciTab[6] + @"  |||  " + elements[b].AsciTab[6] + @"  |||  " + elements[c].AsciTab[6] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 18);
            Console.Write(@" |||  " + elements[a].AsciTab[7] + @"  |||  " + elements[b].AsciTab[7] + @"  |||  " + elements[c].AsciTab[7] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 19);
            Console.Write(@" |||  " + elements[a].AsciTab[8] + @"  |||  " + elements[b].AsciTab[8] + @"  |||  " + elements[c].AsciTab[8] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 20);
            Console.Write(@" |||  " + elements[a].AsciTab[9] + @"  |||  " + elements[b].AsciTab[9] + @"  |||  " + elements[c].AsciTab[9] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 21);
            Console.Write(@" |||  " + elements[a].AsciTab[10] + @"  |||  " + elements[b].AsciTab[10] + @"  |||  " + elements[c].AsciTab[10] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 22);
            Console.Write(@" |||  " + elements[a].AsciTab[11] + @"  |||  " + elements[b].AsciTab[11] + @"  |||  " + elements[c].AsciTab[11] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 23);
            Console.Write(@" |||  " + elements[a].AsciTab[12] + @"  |||  " + elements[b].AsciTab[12] + @"  |||  " + elements[c].AsciTab[12] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 24);
            Console.Write(@" |||  " + elements[a].AsciTab[13] + @"  |||  " + elements[b].AsciTab[13] + @"  |||  " + elements[c].AsciTab[13] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 25);
            Console.Write(@" |||  " + elements[a].AsciTab[14] + @"  |||  " + elements[b].AsciTab[14] + @"  |||  " + elements[c].AsciTab[14] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 26);
            Console.Write(@" |||  " + elements[a].AsciTab[15] + @"  |||  " + elements[b].AsciTab[15] + @"  |||  " + elements[c].AsciTab[15] + @"  ||| " + "\n");
            Console.SetCursorPosition(0, 27);
            Console.Write(@" \\\  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  /// " + "\n");
            Console.SetCursorPosition(0, 28);
            Console.Write(@"   --------------------------------------------------------------------------------------------------------------------------------------------" + "\n");
            Console.SetCursorPosition(0, 29);
            Console.Write("Wciśnij SPACE żeby zakręcić, ESC żeby wyjść");
        }
        public void Lever(Account account, int bet, Assets assets)
        {
            assets.getBalance(account);
            Console.CursorVisible = false;
            account.removeBalance(bet);
            Random rand = new Random();
            List<int> iters = new List<int>();
            iters.Add(0);
            iters.Add(0);
            iters.Add(0);
            for (int i = 0; i < 30; i++)
            {
                if (i < 10)
                {
                    iters[0] = rand.Next(16);
                }
                if(i < 20)
                {
                    iters[1] = rand.Next(16);
                }
                iters[2] = rand.Next(16);
                GameView(iters[0], iters[1], iters[2]);
                Thread.Sleep(80);
            }
            if ((elements[iters[0]].Id == elements[iters[1]].Id) && (elements[iters[1]].Id == elements[iters[2]].Id))
            {
                account.addBalance(bet * prizes[iters[0]].Value);
            }
        }
    }
}
