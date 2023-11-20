using ConsoleCasino.Slots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleCasino
{
    public class Assets
    {
        private string tittle = @"                                                                                                                                                                                                                                                                                                          
                          (@@@@@@@%,      .%@@@@@@@@/   (@&.     .@@*    #@@#        &@*                ,%@@@@@@@/      .&@@/       .#@@@@@@%.   (@#    %@@%       &@,     ,%@@@@@@@@*   
                          #@%     &@#   .&@#       *@@/  ,@@,   ,@@.    (@(%@(       &@*              .&@(              %@,&@/      &@*          (@#    %@#@@*     &@,   ,@@(       /@@* 
                          #@%     %@#   %@#         *@@.  .@@/ /@%     /@#  %@(      &@*              &@(              #@/ .&@,     #@@*         (@#    %@* &@#    &@,   &@/         (@& 
                          #@@@@@@@(.    @@*         .@@,    #@&@#     *@%    &@*     &@*             *@@.             #@#   ,@@,      /&@@@#.    (@#    %@*  (@@.  &@,  ,@@,         ,@@.
                          #@%   ,@@/    &@(         *@@.     %@#     *@@(((((#@@*    &@*             .@@*            (@&(((((%@@,         ,&@%   (@#    %@*   .@@/.&@,  .@@*         /@& 
                          #@%     &@(   *@@*       ,@@*      %@#    ,@@.      *@@,   &@*              /@@,          *@&.      (@&.         /@&   (@#    %@*     %@%@@,   (@@.       *@@, 
                          #@%      &@#    #@@@%#%@@@(        %@#   .@@,        *@@.  &@@@@@@@&.        .%@@&%#%@@&.*@@.        (@& *@@@%#%@@%.   (@#    %@*      *@@@,    .%@@&%#%@@@/                                                                                                                                                     
";
        private List<string> slotsTitle = new List<string>();
        private List<SlotsElement> slotsElements = new List<SlotsElement>();
        private List<SlotsPrize> slotsPrizes = new List<SlotsPrize>();
        private List<string> slotsView = new List<string>();
        public void fillTablesSlots()
        {
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
            slotsElements.Add(new SlotsElement(1, "Diament", "placeholder", tmp));
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
            slotsPrizes.Add(new SlotsPrize(1, 5));
            slotsElements.Add(new SlotsElement(2, "Wiśienki", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(2, 1.5));
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
            slotsElements.Add(new SlotsElement(3, "Śliwka", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(3, 1.25));
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
            slotsElements.Add(new SlotsElement(4, "Dzwon", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(4, 2));
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
            slotsElements.Add(new SlotsElement(5, "Koniczyna", "placeholder", tmp));
            Random rnd = new Random();
            slotsPrizes.Add(new SlotsPrize(5, rnd.NextDouble() + 2));
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
            slotsElements.Add(new SlotsElement(6, "Cytryna", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(6, 1));
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
            slotsElements.Add(new SlotsElement(7, "Moneta", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(7, 1));
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
            slotsElements.Add(new SlotsElement(8, "Bar", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(8, 1));
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
            slotsElements.Add(new SlotsElement(9, "Jabłko", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(9, 1));
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
            slotsElements.Add(new SlotsElement(10, "Serce", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(10, 1));
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
            slotsElements.Add(new SlotsElement(11, "Winogrona", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(11, 1));
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
            slotsElements.Add(new SlotsElement(12, "Pomarańcza", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(12, 1));
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
            slotsElements.Add(new SlotsElement(13, "Podkowa", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(13, 1));
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
            slotsElements.Add(new SlotsElement(14, "Siedem", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(14, 1));
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
            slotsElements.Add(new SlotsElement(15, "Znak zapytania", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(15, 1));
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
            slotsElements.Add(new SlotsElement(16, "Arbuz", "placeholder", tmp));
            slotsPrizes.Add(new SlotsPrize(16, 1));
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
            slotsTitle = tmp;
            tmp = new List<string>();
            tmp.Add(@"   ____________________________________________________________________________________________________________________________________________" + "\n");
            tmp.Add(@" ///  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  \\\ " + "\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      ___\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "     (   )\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "      | |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "---\\  | |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "   |--| |  \n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "   |__(_)\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "   |\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "---/  \n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            tmp.Add(@" |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  ||| " + "\n");
            tmp.Add(@" \\\  " + @"                                        " + @"  |||  " + @"                                        " + @"  |||  " + @"                                        " + @"  /// " + "\n");
            tmp.Add(@"   --------------------------------------------------------------------------------------------------------------------------------------------" + "\n");
            tmp.Add("Wciśnij SPACE żeby zakręcić, ESC żeby wyjść");
            slotsView = tmp;
        }
        public void getSlotsTitle()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(slotsTitle[i]);
            }
        }
        public double slotsWin(int a, int b, int c)
        {
            if ((slotsElements[a].Id == slotsElements[b].Id) && (slotsElements[b].Id == slotsElements[c].Id))
            {
                return slotsPrizes[a].Value;
            }
            return 1;
        }
        public void getSlotsView()
        {
            int counter = 0;
            for(int i=9; i<30;  i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(slotsView[counter++]);
            }
        }
        public void getSlotsGameView(int a, int b, int c)
        {
            int counter = 0;
            for (int i = 11; i < 27; i++)
            {
                Console.SetCursorPosition(6, i);
                Console.Write(slotsElements[a].AsciTab[counter]);
                Console.SetCursorPosition(53, i);
                Console.Write(slotsElements[b].AsciTab[counter]);
                Console.SetCursorPosition(101, i);
                Console.Write(slotsElements[c].AsciTab[counter]);
                counter++;
            }
        }
        public void getSlotsLeverAnim()
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
        public void getSlotsLeverAnimBack()
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
        public void getTittle()
        {
            Console.SetCursorPosition(0, 3);
            Console.Write(tittle);
        }
        public void getBalance(Account account)
        {
            Console.SetCursorPosition(150, 1);
            Console.WriteLine("Stan konta: " + account.getBalance() + "$");
        }
    }
}
