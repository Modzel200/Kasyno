﻿using ConsoleCasino;
using ConsoleCasino.Roulette;
using ConsoleCasino.Slots;
using System.Runtime.InteropServices;

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
        string s = @"                                                                                                                                                                
                                                                                                                                                                
                                                                                                                                                                
                                                                                                                                                                
                          (@@@@@@@%,      .%@@@@@@@@/   (@&.     .@@*    #@@#        &@*                ,%@@@@@@@/      .&@@/       .#@@@@@@%.   (@#    %@@%       &@,     ,%@@@@@@@@*   
                          #@%     &@#   .&@#       *@@/  ,@@,   ,@@.    (@(%@(       &@*              .&@(              %@,&@/      &@*          (@#    %@#@@*     &@,   ,@@(       /@@* 
                          #@%     %@#   %@#         *@@.  .@@/ /@%     /@#  %@(      &@*              &@(              #@/ .&@,     #@@*         (@#    %@* &@#    &@,   &@/         (@& 
                          #@@@@@@@(.    @@*         .@@,    #@&@#     *@%    &@*     &@*             *@@.             #@#   ,@@,      /&@@@#.    (@#    %@*  (@@.  &@,  ,@@,         ,@@.
                          #@%   ,@@/    &@(         *@@.     %@#     *@@(((((#@@*    &@*             .@@*            (@&(((((%@@,         ,&@%   (@#    %@*   .@@/.&@,  .@@*         /@& 
                          #@%     &@(   *@@*       ,@@*      %@#    ,@@.      *@@,   &@*              /@@,          *@&.      (@&.         /@&   (@#    %@*     %@%@@,   (@@.       *@@, 
                          #@%      &@#    #@@@%#%@@@(        %@#   .@@,        *@@.  &@@@@@@@&.        .%@@&%#%@@&.*@@.        (@& *@@@%#%@@%.   (@#    %@*      *@@@,    .%@@&%#%@@@/   
                                                                                                                                                                
                                                                                                                                                                
                                                                                                                                                                
                                                                                                                                                                
";      
        Console.Write(s);
        Console.SetCursorPosition(170,0);
        Console.WriteLine("Stan konta: " + account.getBalance() + "$");
        Console.SetCursorPosition(0, 0);
        //Console.WriteLine("Witaj w Royal Casino: " + account.getName());
        //Console.WriteLine("Wybierz jedną z dostępnych gier: ");

        string[] options ={"slotsy","ruleta","blackjack"};
        Games games = new Games();
        int game = games.changeOption(options);
        Console.Clear();
        switch(game)
        {
            case 0:
                Slots te = new Slots();
                te.Game(account);
                break;
            case 1:
                Roulette roulette = new Roulette();
                roulette.Game(account);
                break;
        }
        
    }
}
