using ConsoleCasino.BlackJack;
using ConsoleCasino.Craps;
using ConsoleCasino.Roulette;
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
        private List<BlackjackElement> blackjackElements = new List<BlackjackElement>();
        private List<string> blackjackTitle = new List<string>();
        private List<string> blackjackTable = new List<string>();
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
        public void blackjackFill()
        {
            List<string> tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  A                   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                    Ɐ |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(0, "As", "placeholder", tmp, 11));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  2                   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                    2 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(1, "Dwa", "placeholder", tmp, 2));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  3                   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                    3 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(2, "Trzy", "placeholder", tmp, 3));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  4                   |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                    4 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(3, "Cztery", "placeholder", tmp, 4));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  5                   |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                    5 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(4, "Pięć", "placeholder", tmp, 5));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  6                   |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                    6 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(5, "Sześć", "placeholder", tmp, 6));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  7                   |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                    7 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(6, "Siedem", "placeholder", tmp, 7));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  8                   |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                    8 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(7, "Osiem", "placeholder", tmp, 8));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  9                   |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                    9 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(8, "Dziewięć", "placeholder", tmp, 9));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  10                  |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           ♥          |");
            tmp.Add(@"|    ♥             ♥   |");
            tmp.Add(@"|                   10 |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(9, "Dziesięć", "placeholder", tmp, 10));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  J       ___         |");
            tmp.Add(@"|    ♥     | |         |");
            tmp.Add(@"|          | |         |");
            tmp.Add(@"|          | |         |");
            tmp.Add(@"|          | |         |");
            tmp.Add(@"|          | |         |");
            tmp.Add(@"|          | |         |");
            tmp.Add(@"|      __  | |         |");
            tmp.Add(@"|      \ \/  /         |");
            tmp.Add(@"|       \___/          |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                  ♥   |");
            tmp.Add(@"|                    J |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(10, "Walet", "placeholder", tmp, 10));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  Q                   |");
            tmp.Add(@"|    ♥                 |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|           *          |");
            tmp.Add(@"|         * | *        |");
            tmp.Add(@"|        * \|/ *       |");
            tmp.Add(@"|   * * * \|O|/ * * *  |");
            tmp.Add(@"|    \o\o\o|O|o/o/o/   |");
            tmp.Add(@"|    (<><><>O<><><>)   |");
            tmp.Add(@"|     '==========='    |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                  ♥   |");
            tmp.Add(@"|                    Q |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(11, "Królowa", "placeholder", tmp, 10));
            tmp = new List<string>();
            tmp.Add(@" ______________________ ");
            tmp.Add(@"/                      \");
            tmp.Add(@"|  K                   |");
            tmp.Add(@"|    ♥                 |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|        * * * *       |");
            tmp.Add(@"|   * * * \|O|/ * * *  |");
            tmp.Add(@"|    \o\o\o|O|o/o/o/   |");
            tmp.Add(@"|    (<><><>O<><><>)   |");
            tmp.Add(@"|    '============='   |");
            tmp.Add(@"|                      |");
            tmp.Add(@"|                  ♥   |");
            tmp.Add(@"|                    K |");
            tmp.Add(@"\----------------------/");
            blackjackElements.Add(new BlackjackElement(12, "Król", "placeholder", tmp, 10));
            tmp = new List<string>();
            tmp.Add(@"                                                                                                    ");
            tmp.Add(@"                @@@                         .@@&                                       @@@          ");
            tmp.Add(@"  (@@@&&@@@@*   @@@                         .@@&          &@@*                         @@@          ");
            tmp.Add(@"  (@@/   /@@#   @@@   (@@@@@@@*    /@@@@@@  .@@&  ,@@@    &@@*  .@@@@@@@&     @@@@@@#  @@@   @@@(   ");
            tmp.Add(@"  (@@@@@@@@(    @@@         %@@   @@@       .@@&,@@@      &@@*        .@@@  #@@/       @@@ @@@,     ");
            tmp.Add(@"  (@@/    @@@#  @@@   #@@@@@@@@  ,@@&       .@@&@@@/      &@@*  .@@@@@@@@@  @@@.       @@@#@@&      ");
            tmp.Add(@"  (@@/   .@@@,  @@@  (@@*   &@@   @@@/   #. .@@& ,@@@.    @@@,  @@@   *@@@  #@@@   ,&  @@@  @@@(    ");
            tmp.Add(@"  *@@@@@@@&     @@@   /@@@@@.@@    *@@@@@&  .@@%   %@@%@@@@@     @@@@@*&@&    @@@@@@,  @@@   ,@@@   ");
            tmp.Add(@"                                                                                                    ");
            blackjackTitle = tmp;
            tmp = new List<string>();
            tmp.Add(@"                                                                                                                                                      ");
            tmp.Add(@"        ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((        ");
            tmp.Add(@"     @@&                                                                                                                                      *@@%    ");
            tmp.Add(@"   @@,                                                                                                                                           @@   ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"   @@                                                                                                                                            *@/  ");
            tmp.Add(@"    @@                                                                                                                                          %@@   ");
            tmp.Add(@"      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/     ");
            tmp.Add(@"                                                                                                                                                      ");
            tmp.Add("Wciśnij H żeby dobrać, S żeby nie dobierać, ESC żeby wyjść");
            blackjackTable = tmp;
        }
        private string basicRoulette = @"                                                                                                                                  
                                                                                                                                  
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                                              .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                                                                 @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                                                                  *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                                                                    @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                                                     @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                                                     @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                                                     @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                                                     @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                                                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ";
        private List<RouletteElement> rouletteImg = new List<RouletteElement>()
        {new RouletteElement(0,@"                                                                                                
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                        @@                      (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                       /@@@@@@%                      @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                       @@@@@@@@@@@@.                    .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                            .@@@@/                          @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                             .@@@@/                           .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                              .@@@@/                             @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                               .@@@@/                             *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                                .@@@@/                              @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                .@@@@/                               @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                .@@@@/                               @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                .@@@@/                               @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                                                     @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                                                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(5, @"                                                                                             
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                ,/%/                 @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                            .@@@@@@@@@                  .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                ,@@@@@@@(                   @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                @@@@@@.#@@                    .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                               #@@@@@(                           @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                              ,@@@@@&                             *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                              @@@@@@.                               @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                            #@@@@@(                                  @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                          ,@@@@@@                                    @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                         @@@@@@.                                     @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                           .@/                                       @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                                                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
           ,
            new RouletteElement(12,@"                                                                                             
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                 (,                     .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                    /@@@@@/                 @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                   ,%@@@@@@@@                 .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                              .(@@@@@@@@@@@@@.                   @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                          *&@@@@@@@@@@&*   @@,                    *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                     .#@@@@@@@@@@@(.         *                      @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                     %@@@@@@%,                                       @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                      (/                                             @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                                                     @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                                                     @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                                                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(3,@"                                                                                             
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                                              .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                                                                 @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                                          ,@(                     *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                     ,,,,,,................*@@@&                    @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@*                  @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                     &&&&&&&&&&&&&&&&&&&&&@@@@@@#                    @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                           ,@@,                      @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                           ,                         @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                                                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(10,@"                                                                                            
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                                              .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                     #@@@&,                                      @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                     /@@@@@@@@&,                                  *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                          /@@@@@@@@&,                               @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                              *@@@@@@@@&,    %%                      @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                  *@@@@@@@@@@@@,                     @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                      *@@@@@@@@&                     @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                        *@@@@@@@,                    @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                       %#*.                         &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(1,@"                                                                                            
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                      #@@@#                                   .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                       %@@@@@&.                                  @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                          /@@@@@@*                                *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                             ,@@@@@@#                               @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                #@@@@@&.                             @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                  /@@@@@@*  .&*                      @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                    ,@@@@@@@@@,                      @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                       &@@@@@@.                      @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                    .&@@@@@@@@                      &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(8,@"                                                                                            
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                          ,@@@@&                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                            #@@@@*                            .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                             .@@@@&                              @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                               #@@@@*                             *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                                .@@@@&                              @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                 #@@@@*                              @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                 .@@@@&                              @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                  #@@@@*                             @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                  .@@@@@#&@%                         @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                               (@@@@@@@@@@.                         &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                 .(@@@@*                           @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                     .                            &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(9,@"                                                                                           
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                .@@@@&.                     @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                 %@@@@,                       .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                                 /@@@@(                          @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                                 ,@@@@&                           *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                                  &@@@@,                            @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                 (@@@@(                              @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                ,@@@@%                               @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                &@@@@,                               @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                           .@@@@@@@@/                                @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                             (@@@@@@@@@%*                           &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                             ,@@@@(.                               @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(2,@"                                                                                            
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                      .%@@@/                  .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                                     *@@@@@@/                    @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                                    /@@@@@&,                      *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                                  .#@@@@@%.                         @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                ,&@@@@@(                             @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                         (#   /@@@@@@*                               @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                         *@@@@@@@@%.                                 @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                         ,@@@@@@#                                    @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                         .@@@@@@@@%.                                &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(7,@"                                                                                            
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                                              .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                                         .(&@@/                  @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                                      ,#@@@@@@@@(                 *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                                   *%@@@@@@@&(.                     @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                         %(    /&@@@@@@@&*                           @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                        /@@@@@@@@@@@%,                               @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                       .@@@@@@@@(.                                   @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                       (@@@@@@&.                                     @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                             .,(*                                   &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
            ,
            new RouletteElement(6, @"                                                                                  
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                                                              .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                                                                 @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                         /%                                       *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                       .#@@&. ......,,,,,****///((*                 @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                     .%@@@@@@@@@@@@@@@@@@@@@@@@@@@#                  @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                      ,%@@@@&&&%%%%%###((((////***,                  @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                         /@@,                                        @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                           .,                                        @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                                                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")
           ,
            new RouletteElement(11, @"                                                                       
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                             .                                .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                     .*#&@@@@*                                   @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                      ,@@@@@@@(.                                  *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                        (@@@@@@@@@@#,                               @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                        .&&. ./&@@@@@@@%*                            @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                         ,        *%@@@@@@@&/.                       @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                      ,#@@@@@@@@(.                   @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                          .(&@@@#                    @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                               ,                    &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                                                   @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  
")
           ,
            new RouletteElement(4,@"        
                                                                                                              //(((((((((((((((((((((((((((/,                                                 
                                                                                                      ,&@@@@@@(/(((((((((((((((((((((((((((/%%%#%%#,                                          
                                                                                                 #@@@@@@@@@@@@@/(((((((((((  ( ,((((((((((/#%%%%%%%%%%%%#.                                    
                                                                                            .@@@@@@@@@@@@@@@@@@%/(((((((((( ((. ((((((((((/%%%%%%%%%%%%%%%%%#*                                
                                                                                         @@@@@@@@@@. @@@@@@@@@@@(/((((((((( /(  (((((((((/%%%%%%%%%%%# *%%%%%%%%%.                            
                                                                                     .@@@@@@@@@@@@@ / /@@@@@@@@@&/((((((((((   (((((((((/(%%%%%%%%%% .%#(#%%%%%%%%%%/                         
                                                                                  .%#/(@@@@@@@@@@@@ #%   @@@@@@@@#/(((((((((((((((((((((/%%#%#%%%%%%%%. %%%%%%%%%%%#/%@...                    
                                                                                (%%%%%%//@@@@@@@@@@#*@@,,@@@@@@@@@/(((((///(((((//(((((/#%%%%%%%%%  /  %%%%%%%%%%#/@@@@@@&                    
                                                                              ##%%%%%%%%%(/@@@@@@@@@@@@@@@@@@%(&@@@/@@@@@@@@@@@@@@@@@@#(@@&(#%%#%%%%%%%%%%%%%%%(/@@@@@@@@@@@                  
                                                                            %%%%%%%%%%%%%%%(/&@@@@@@@@@@#&@@@@@@@@@%(@@@@@@@@@@@@@@@@@/@@@@@@@@@&(%%%%%%%%%%%((@@@@@@@@@@@@@@@ .              
                                                                         .(%%%%% .#%%%%%%%%%%#/#@@@@#@@@@@@@@@@@@@@@%@@@@@@&&&&&@@@@@@&@@@@@@@@@@@@@@(%%%%%/%@@@@@@@@@@@@@@@@@@@ .            
                                                                       ..%#%%#%%( #  *%%%%%%%%%#//@@@@@@@@@@@@@@@                         @@@@@@@@@@@@@@(/&@@@@@@@@@@@@   @@@@@@@/..          
                                                                      .#%%%%%  #%%%%%%, *%%%%#(@@@((@@@@@@@@                                   @@@@@@@&/@@@%@@@@@@@(  &@@@/  %@@@@@ .         
                                                                    . %%%%%%%, #  ,%#%%%%%%#(@@@@@@@%/@@                                          ,@@/@@@@@@@#@@@@@@@@@@@@@@@ (@@@@@.,        
                                                                   ,.#%%%%%%%#%%%%#* %%%%#(@@@@@@@@@@                                                (@@@@@@@@@%@@@@@  %#*,*%@@@@@@@@(,       
                                                                  ,.(#%%%%%%%%%%%%%%%%%%(@@@@@@@@@%                                                     @@@@@@@@@&@@@@@ .@@@@@@@@@@@@&/*      
                                                                 .,@@&%#///(#%%%%%%%%%%(@@@@@@@@@                                                        .@@@@@@@@%@@@@@@@@@@@@#//(#%%%**     
                                                                  @@@@@@@@@@&%(///#%%#&@@@@@@@@                                                            @@@@@@@@&@@@@&(//#%%%%%%%%%%#./    
                                                                /@@@@@@@@@@@@@@@@@@%#(//%@@@(@                        %@@@@@@&%(.                           .@@@@@(//(#%%%%%%%%%%%%%%%%%%,.   
                                                               ,.@@@@@@@@@@@@@@@@@@@#@@@@@@(@                        *@@@@@@#                                 @@@@@@@&%%%%%%%%%%%%%%%%%%%/(   
                                                               /@@@@@@@@@@@@@@@@@@@(@@@@@@&@                         #@@&@@@@&,                               *@@@@@@@(%%%%%%%%%%%#%%%%%%%**  
                                                              , @@@@/ #@  ,.  @@@@@@@@@@@@@                         ,*   ,%@@@@%.                              @@@@@@@@#%%%%% (%%#%  #%%%%.(  
                                                              (*@@@@@,        @@@@#@@@@@@@@                                *&@@@@(                              @@@@@@@(%%%% /%%,    /%%%%#(  
                                                              (%@@@@@@@@@@@@@@@@@@(@@@@@@@&                                  /@@@@@/                            @@@@@@@#%%%%%#%%#%%#%#%%%%#(  
                                                              (&@@@@@@@@@@@@@@@@@@(@@@@@@@&                                   .#@@@@&,                          @@@@@@@%%%%%%%%%%%%%%%%%%%%(  
                                                              /%@@@@@@@@@@@@@@@@@@(@@@@@@%@                                     .%@@@@%.                        @@@@@@@#%%%%%%%%%%%%%%%%%%#(  
                                                              */@@@@@@@@@&%#(//////((%&@@@@                                       *&@@@@(                      &@@@&%#(//////((###%%%%%%%%#(  
                                                               .((###%%%%%%%%%%%%%#@@@@@@@@/                                        /@%*                       @@@@@@@@&@@@@@@@@&&%%%%##((.(  
                                                               *%%%%%%%%%%%%%%%%%%%(@@@@@@@@                                                                  &@@@@@@@#@@@@@@@@@@@@@@@@@@@..  
                                                               ,*%%%%%%%%%%%%%%%%%%%%@@@@@@&@                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@(/   
                                                                *%%%%%%%%%%%%%%%%%%%#@@@@@@@@@                                                              @@@@@@@@@&@@@@  *@@@, @@@@@@@.    
                                                                 .%%%%#,.*/((/,  %%%%#&@@@@@@@@.                                                           @@@@@@@@@&@@@@@@@@@#    @@@@@ *    
                                                                 .,%%%%( *%%#%%#%%%%%#%%@@@@@@&(@                                                        %@(@@@@@@&@@@@@      *@@@@@@@@//     
                                                                  ,*%%%%((#%%%%%%%%%%%%%(@@(/@@@@@@                                                    #@@@@@#/%@(@@@@@@.  %@@@# &@@@@#*      
                                                                   .,#%%%%%%%%%%%%%%%%#(/(#@@@@@@@@@@%                                               @@@@@@@@@@%#//&@@@@@@@@&, .&@@@@(*       
                                                                     .%%%%%%%%%%%%%#//%@@@@@#@@@@@@@@@@@&                                         @@@@@@@@@@@%#%%%%%(/(@@@@@@@@@@@@@,,        
                                                                      .%#%%%%%%#//#@@@@@@@@@@@/@@@@@@@@@@@@@                                  @@@@@@@@@@@@@(%#%%%%%%%%#%(/#@@@@@@@@ .         
                                                                       .*#%%(//&@@@@@@@@@@@@@@@@@#@@@@@@@@@(#@@@@@                      ,@@@@@/@@@@@@@@@%#%%%%%%%%%%%%%%%%%#//@@@%,           
                                                                         .#%@@@@@@@@@@@@@@*  @@@@@@@(@@@@@/&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@/%@@@@(#%%%%###%%%%%%%%%%%%%%%%#(              
                                                                            @@@@@@@@@@@@@#*.   #@@@@@@@&(/@@@@@@@@@@@@@@@@@@@/@@@@@@@@@@@@@@@@@@%/#%%%%%%%%#  %%%%%%%%%%%%%%#%..              
                                                                              @@@@@@@@  @@@@@@@@@@@@@@@//%%##(%@@@@@@@@@@@@@@/@@@@@@@@@@@@@%(&@@@#/#%%%%%%%%%%  # ,#%%%%%%%%                  
                                                                                @@@@@@#   .@@@@@@@@@@&/(%%%%%%%#%%%%##(/(#%&%/&%##((%@@@@@@@@@@@@@%/(%%%%%%%%%%#. (%%%%%%#                    
                                                                                  .@@@@@@@@@@@@@@@@@%/#%%%%%%%%%%%#%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%(/%#%%%%%%%%%%%%%%%*                      
                                                                                     /@@@@@@@@@@@@@(/%%%%%%%%%( ., (%%%%%%%%#/@@@@@@@@  *  @@@@@@@@@@#/#%%%%%%%%%%#%/                         
                                                                                        .@@@@@@@@@/(#%%%%%%%%#    %%#%%%%%%%#/@@@@@@@@  @@ &@@@@@@@@@@%/(#%%%%%%%*                            
                                                                                            (@@@%/#%%%%%%%%%%. %% .%%%%%%%%%#/@@@@@@@@@( @( @@@@@@@@@@@%/(#%%(                                
                                                                                                .%#%%%%%%%%%%%.  ,%%%%%%%%%%#/@@@@@@@@@@    @@@@@@@@@@@@&.                                    
                                                                                                     .(%%%%%%%%%%%%%%%%%%%%%#/@@@@@@@@@@@@@@@@@@@@@%                                          
                                                                                                             .(#%#%%%%%%%%%%#/@@@@@@@@@@@@@&,                                                 
                                                                                                                                  ")

        };
        private string roulette = @"                                                                  &@@@@@@@@@       &@@@@@@@@@.     @@@       &@@#   &@@#       %@@@@@@@@@ /@@@@@@@@@@@@/@@@@@@@@@@@@/ /@@@@@@@@@.     
                                                                  &@@%    @@@%   @@@@,     @@@@    @@@       &@@#   &@@#       %@@#            @@@#         #@@@      /@@@            
                                                                  &@@%    @@@/  (@@@        %@@@   @@@       &@@#   &@@#       %@@#            @@@#         #@@@      /@@@            
                                                                  &@@@@@@@@     %@@@        (@@@   @@@       &@@#   &@@#       %@@@@@@@@       @@@#         #@@@      /@@@@@@@@*      
                                                                  &@@%   @@@%   (@@@        @@@&   @@@.      &@@/   &@@#       %@@#            @@@#         #@@@      /@@@            
                                                                  &@@%    @@@%   @@@@#    (@@@&    %@@@#    @@@@    &@@#       %@@#            @@@#         #@@@      /@@@            
                                                                  &@@%     @@@#    /@@@@@@@@,        #@@@@@@@&      &@@@@@@@@, #@@@@@@@@@.     @@@#         #@@@      *@@@@@@@@@*     ";
        private string craps = @"                                                                                                                                                                                                                     
                                                                         ..                                                          ...                            
                                                                     (@@@#**#@@@   %@@(/(#@@@#         @@@@.        @@((/(@@@@    (@@%,.*&@(
                                                                    @@(            %@@      @@/       @@.,@@        @@.     &@@  .@@.
                                                                   @@&             %@@     %@@       @@,  /@@       @@.     @@@   (@@@,
                                                                   @@(             %@@@@@@@*        @@/    %@@      @@&%%&@@@/       *@@@@&
                                                                   @@@             %@@    *@@.     @@@@@@@@@@@@     @@.                  *@@/ 
                                                                    @@@        .   %@@     ,@@,   %@&        @@&    @@.                   @@* 
                                                                     .@@@@@@@@@#   %@@      ,@@, #@@          @@%   @@.          *@@@@@@@@&";
        private string basicCraps = @"                                                                          
                                                                                 &@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#            
                                                                               *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
                                                                              %@@@@                                          *@@@@         
                                                                              @@@@/                                           @@@@@        
                                                                              @@@@/          @@@                ,@@@          @@@@@        
                                                                              @@@@/        @@@@@@@             @@@@@@/        @@@@@        
                                                                              @@@@/         @@@@@              .@@@@%         @@@@@        
                                                                              @@@@/                                           @@@@@        
                                                                              @@@@/                                           @@@@@        
                                                                              @@@@/         &@@@&               @@@@/         @@@@@        
                                                                              @@@@/        @@@@@@@             @@@@@@/        @@@@@        
                                                                              @@@@/         /@@@/               &@@@          @@@@@        
                                                                              @@@@/                                           @@@@@        
                                                                              @@@@/                                           @@@@@        
                                                                              @@@@/         @@@@@              *@@@@@         @@@@@        
                                                                              @@@@/        &@@@@@@             @@@@@@*        @@@@@        
                                                                              @@@@/          /@(                 %@,          @@@@@        
                                                                              @@@@/                                           @@@@@        
                                                                              /@@@@.                                         %@@@@         
                                                                                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
                                                                                  /@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.            ";
        private List<CrapsElement> crapsImg = new List<CrapsElement>()
    {
        new CrapsElement(1, @"                                                                               
             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#            
          ,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
         #@@@@                                          ,@@@@.        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                   @@@@#                   @@@@&        
         @@@@*                  @@@@@@@                  @@@@&        
         @@@@*                   (@@@,                   @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         /@@@@.                                         #@@@@         
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
             *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.            "),
        new CrapsElement(2,@"                                                                        
             @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#            
          ,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
         #@@@@                                          ,@@@@.        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*             &@@@@(                        @@@@&        
         @@@@*            .@@@@@@                        @@@@&        
         @@@@*              ,##                          @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                         #@@(              @@@@&        
         @@@@*                       ,@@@@@@             @@@@&        
         @@@@*                        #@@@@.             @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         /@@@@.                                         #@@@@         
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
             *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.            "),
        new CrapsElement(3,@"                                                                            
             &@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(            
          ,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
         #@@@@                                          *@@@@.        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         @@@@*         (@@@#                             @@@@&        
         @@@@*        &@@@@@@                            @@@@&        
         @@@@*         #@@@%                             @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                   @@@@#                   @@@@&        
         @@@@*                  @@@@@@@                  @@@@&        
         @@@@*                   (@@@,                   @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                             @@@@#         @@@@&        
         @@@@*                            @@@@@@/        @@@@&        
         @@@@*                             /@@&          @@@@&        
         @@@@*                                           @@@@&        
         @@@@*                                           @@@@&        
         *@@@@.                                         #@@@@         
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
             ,@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.             "),
        new CrapsElement(4,@"                                                                          
             &@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#            
          *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
         %@@@@                                          *@@@@         
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/           %@@@@          ,@@@@*           @@@@@        
         @@@@/          #@@@@@@         @@@@@@           @@@@@        
         @@@@/            @@@*           %@@&            @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/           ,@@@@           @@@@            @@@@@        
         @@@@/          %@@@@@@         @@@@@@           @@@@@        
         @@@@/           *@@@@           @@@@.           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         /@@@@.                                         %@@@@         
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
             /@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.            "),
        new CrapsElement(5,@"                                                                            
             &@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#            
          *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
         %@@@@                                          *@@@@         
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/         (@@@#               @@@@.         @@@@@        
         @@@@/        @@@@@@@             @@@@@@/        @@@@@        
         @@@@/         #@@@%               @@@@,         @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                   @@@@%                   @@@@@        
         @@@@/                  @@@@@@@                  @@@@@        
         @@@@/                   #@@@,                   @@@@@        
         @@@@/                                           @@@@@        
         @@@@/         @@@@@               @@@@%         @@@@@        
         @@@@/        @@@@@@@             @@@@@@/        @@@@@        
         @@@@/         .@@@.               /@@@          @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         /@@@@.                                         %@@@@         
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
             /@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.            "),
        new CrapsElement(6,@"                                                                          
             &@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#            
          *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
         %@@@@                                          *@@@@         
         @@@@/                                           @@@@@        
         @@@@/          @@@                ,@@@          @@@@@        
         @@@@/        @@@@@@@             @@@@@@/        @@@@@        
         @@@@/         @@@@@              .@@@@%         @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/         &@@@&               @@@@/         @@@@@        
         @@@@/        @@@@@@@             @@@@@@/        @@@@@        
         @@@@/         /@@@/               &@@@          @@@@@        
         @@@@/                                           @@@@@        
         @@@@/                                           @@@@@        
         @@@@/         @@@@@              *@@@@@         @@@@@        
         @@@@/        &@@@@@@             @@@@@@*        @@@@@        
         @@@@/          /@(                 %@,          @@@@@        
         @@@@/                                           @@@@@        
         /@@@@.                                         %@@@@         
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@          
             /@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.            ")
    };
        public void getCraps()
        {
            Console.Write(craps);
        }
        public void getBasicCraps()
        {
            Console.Write(basicCraps);
        }
        public List<CrapsElement> getCrapsImg()
        {
            return crapsImg;
        }
        public void getRoulette()
        {
            Console.Write(roulette);
        }
        public void getBasicRoulette()
        {
            Console.Write(basicRoulette);
        }
        public List<RouletteElement> getRouletteImg()
        {
            return rouletteImg;
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
            Console.SetCursorPosition(170, 1);
            Console.WriteLine("Stan konta: " + account.getBalance() + "$");
        }
        public void getBjTitle()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(blackjackTitle[i]);
            }
        }
        public void getBjTable()
        {
            int counter = 0;
            for (int i = 11; i < 47; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(blackjackTable[counter++]);
            }
        }
        public bool removeQuant(int id)
        {
            if (blackjackElements[id].Quantity > 0)
            {
                blackjackElements[id].Quantity--;
                return true;
            }
            return false;
        }
        public void resetQuant()
        {
            foreach(BlackjackElement elem in blackjackElements)
            {
                elem.Quantity = 4;
            }
        }
        public int getYourCard(int id)
        {
            for(int  i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(20, 20+i);
                Console.Write(blackjackElements[id].AsciTab[i]);
            }
            return blackjackElements[id].Weight;
        }
        public int getEnemyCard(int id)
        {
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(100, 20 + i);
                Console.Write(blackjackElements[id].AsciTab[i]);
            }
            return blackjackElements[id].Weight;
        }
        public void getYourSum(int a)
        {
            Console.SetCursorPosition(20, 37);
            Console.Write("Twoja suma: " + a);
        }
        public void getEnemySum(int a)
        {
            Console.SetCursorPosition(100, 37);
            Console.Write("Suma wroga: " + a);
        }
    }
}
