using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

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
        public void getTittle()
        {
            Console.SetCursorPosition(0, 3);
            Console.Write(tittle);
        }
        public void getBalance(Account account)
        {
            Console.SetCursorPosition(200, 0);
            Console.WriteLine("Stan konta: " + account.getBalance() + "$");
        }
    }
}
