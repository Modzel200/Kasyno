using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleCasino.Slots
{
    public class Slots
    {
        public List<SlotsElement> elements;
        public List<SlotsPrize> prizes;
        public Slots()
        {
            Random rnd = new Random();
            elements = new List<SlotsElement>();
            prizes = new List<SlotsPrize>();
            elements.Add(new SlotsElement(1 ,"Diament" , "placeholder", @"                                        
                                        
          @@@@@@@@@@@@@@@@@@@@@         
       #@@ @,    @@. #@@    @@ @@,      
     @@    /@ (@@       @& (@    *@@    
   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#  
     @@      @@           @#     .@@    
       @@     @@         @@     @@      
         @@    @(       @@    @@        
           @@  .@      @@   @@          
            /@% &@    @@  @@            
              &@,@@  ,@ @@              
                @@@@ @@@                
                  @@@@.                 
                    /                   
                                        
"));
            prizes.Add(new SlotsPrize(1, 5));
            elements.Add(new SlotsElement(2, "Wiśienki", "placeholder", @"                                        
                                        
                                        
                       @@@@             
                    @( @@               
                  @    @                
                @@    @%                
               %@     @@                
               @       @                
          @@@@@@@@@@  @@@@@@@@*         
         @@@@@@@@@@ @@@@@@@@@@@@        
        @ @@@@@@@@@@ @@@@@@@@@@@@       
         @@@@@@@@@@ @@@@@@@@@@@@        
          &@@@@@@@@@  @@@@@@@@          
                                        
                                        
"));
            prizes.Add(new SlotsPrize(2, 1.5));
            elements.Add(new SlotsElement(3, "Śliwka", "placeholder", @"                     /                  
                   (((                  
                  .((                   
                *(((( ##                
           ((((((##########%%,          
         (((((##############%%%%        
        (((((################%%%%       
       ((((###################%%%%      
      (((((###################%%%%%     
      ((((####################%%%%%     
      ((((####################%%%%%     
      ((((###################%%%%%%     
       ((((#################%%%%%%      
        ((((##############%%%%%%%       
          (((##########%%%%%%%%         
             ((%%%%%%%%%%%%%            
"));
            prizes.Add(new SlotsPrize(3, 1.25));
            elements.Add(new SlotsElement(4, "Dzwon", "placeholder", @"                                        
                                        
                                        
                  @@@@@                 
               @@@@@@@@@@@              
             @@@@@@@@@@@@@@@            
             @@@@@@@@@@@@@@@            
            @@@@@@@@@@@@@@@@@           
            @@@@@@@@@@@@@@@@@           
            @@@@@@@@@@@@@@@@@           
           @@@@@@@@@@@@@@@@@@@          
          @@@@@@@@@@@@@@@@@@@@@         
        @@@@@@@@@@@@@@@@@@@@@@@@@       
               @@@@@@                   
                 *                      
                                        
"));
            prizes.Add(new SlotsPrize(4, 2));
            elements.Add(new SlotsElement(5, "Koniczyna", "placeholder", @"                                        
           @@@@@@@     @@@@@@@          
         @@@@@@@@@@   @@@@@@@@@@        
      @@@@@@@@@@@@@@ @@@@@@@@@@@@@@     
     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    
      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@     
          @@@@@@@@@@@@@@@@@@@@@         
         (@@@@@@@@@@@@@@@@@@@@@(        
     *@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*    
     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    
      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@     
         @@@@@@@@@@ @ @@@@@@@@@@        
           @@@@@@@  @  @@@@@@@          
                   @@                   
                   @@                   
                 @@@                    
                @@@                     
"));
            prizes.Add(new SlotsPrize(5, rnd.NextDouble()+2));
            elements.Add(new SlotsElement(6, "Cytryna", "placeholder", @"                                        
                   @@@@@@@@             
             @@@               @@@@@    
         (@@                       @@   
       @@                           @   
     @@    @@                       @@  
    @@   @@                          @  
   @@   @@                           @  
   @   @@                       @@   @  
  @@                           @@   @@  
   @                          @@   @@   
   @@                        @    @@    
    @                           @@      
    @@                       @@.        
     @@@@@               @@@            
             .@@@@@@@@                  
"));
            prizes.Add(new SlotsPrize(6, 1));
            elements.Add(new SlotsElement(7, "Moneta", "placeholder", @"                                        
          ,@@@@@@@%**/&@@@@@@@          
       @@@@.      .&@%       /@@@@      
     @@@    @@@@@@@,,,@@@@@@@    @@@    
  .@@@   @@@@@@@@@     @@@@@@@@@   @@@  
  @@@  @@@@@@@@           @@@@@@@*  @@@ 
 @@@  @@@@@@@@    @@@@@ ,@@@@@@@@@@  @@@
 @@   @@@@@@@@@       @@@@@@@@@@@@@   @@
@@@  @@@@@@@@@@@@         @@@@@@@@@   @@
 @@   @@@@@@@@@@@@@@@@.    @@@@@@@@   @@
 @@@  @@@@@@@@    @@@@@    @@@@@@@@  @@@
  @@@  %@@@@@@@           @@@@@@@   @@@ 
   @@@   @@@@@@@@@@   @@@@@@@@@@   @@@  
     @@@    @@@@@@@%%%@@@@@@@   .@@@    
       @@@@%                 @@@@@      
           @@@@@@@@@&@@@@@@@@@          
"));
            prizes.Add(new SlotsPrize(7, 1));
            elements.Add(new SlotsElement(8, "Bar", "placeholder", @"                                                            
          (&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&@@@@&%*         
       @@@@@@@@                              %@@@@@@@@      
     .@@@@                                         @@@@     
     %@@@,      *@@@@@%     *@@%    *@@@@@%        @@@@     
     %@@@,      *@%  (@&   ,@(%@(   *@&  .@@       @@@@     
     %@@@,      *@@@@@@%   @@  @@,  *@@@@@         @@@@     
     %@@@,      *@%   @@  @@@@@@@@. *@&  &@%       @@@@     
     %@@@,       %%%%*   #%      %%  %*   (%.      @@@@     
      @@@@*                                       @@@@@     
       @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@      
           ,/***********************************/,          
                                                            "));
            prizes.Add(new SlotsPrize(8, 1));
            elements.Add(new SlotsElement(9, "Jabłko", "placeholder", @"                                        
                                        
                                        
                  .%%                   
                    ## #######*#        
                    %%###/####          
          #########%###########         
        ,#######################.       
        #########################       
        #########################       
        #########################       
         #######################        
          #####################         
            #################           
                *,     *.               
                                        
"));
            prizes.Add(new SlotsPrize(9, 1));
            elements.Add(new SlotsElement(10, "Serce", "placeholder", @"                                        
                                        
                                        
                                        
         @@@@@@@@@@   @@@@@@@@@@        
       &@@@@@@@@@@@@ @@@@@@@@@@@@,      
       @@@@@@@@@@@@@@@@@@@@@@@@@@@      
       &@@@@@@@@@@@@@@@@@@@@@@@@@*      
        @@@@@@@@@@@@@@@@@@@@@@@@,       
          @@@@@@@@@@@@@@@@@@@@@         
            @@@@@@@@@@@@@@@@@           
               @@@@@@@@@@@              
                  @@@@@                 
                                        
                                        
                                        
"));
            prizes.Add(new SlotsPrize(10, 1));
            elements.Add(new SlotsElement(11, "Winogrona", "placeholder", @"                                        
            @@@@@@*   @@@@@@@           
            @@@   @@@@@                 
             @@@@  @@@                  
        @@@@@@@(@@@@@@@@@.@@@@@@@       
      @@@     @@@       @@@     @@@     
      @@@     @@@       @@@     @@@     
        @@@@@@@ @@@@@@@@@ @@@@@@%       
          .@@@     @@@     @@@          
            ,@@@@@@@ @@@@@@@            
                @@@   @@@               
                  #@@@/                 
"));
            prizes.Add(new SlotsPrize(11, 1));
            elements.Add(new SlotsElement(12, "Pomarańcza", "placeholder", @"                                        
                                        
                                        
             ####### % #                
                ###*% ####(             
                .*******                
            .***************            
           *******************          
         .*********************         
         //*********************        
         /**********************        
          *********************         
           */****************,          
              ***/**//*****             
                                        
                                        
"));
            prizes.Add(new SlotsPrize(12, 1));
            elements.Add(new SlotsElement(13, "Podkowa", "placeholder", @"                                        
           @@@@@@@@@@@@@@@@@@@          
        @@@@@@.   @@@@@   /@@@@@@       
      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@     
    @@@@  @@@@@@         @@@@@@  @@@@   
   @@@@ @@@@@               @@@@@ @@@@  
  @@@@@@@@@@                 @@@@@@@@@@ 
  @@@  @@@@                   @@@@  @@@ 
  @@@  @@@@                   @@@@  @@@ 
   @@@@@@@@                   @@@@@@@@  
   @@@@@@@@                  *@@@@@@@@  
    @@@  @@@                 @@@  @@@   
     @@@@@@@                 @@@@@@@    
      @@@@@@@               @@@@@@@     
       @@@@@@@             @@@@@@@      
     @@@@@@@@@             @@@@@@@@@    
"));
            prizes.Add(new SlotsPrize(13, 1));
            elements.Add(new SlotsElement(14, "Siedem", "placeholder", @"                                        
                                        
               @@@@@@@@@@@@@@@          
             @              @           
            @              /            
           @  @       @                 
                     @                  
                        @               
                    @  @                
                   @                    
                   @  @                 
                      @                 
                  @   @                 
                  @                     
                                        
                                        
"));
            prizes.Add(new SlotsPrize(14, 1));
            elements.Add(new SlotsElement(15, "Znak zapytania", "placeholder", @"                                        
                  @@@@@.                
              @@@@@@@@@@@@@             
             @@@@      /@@@@            
             @@@@       @@@@            
                      @@@@@             
                   /@@@@&               
                  @@@@                  
                                        
                  @@@@                  
                  @@@@                  
                                        
"));
            prizes.Add(new SlotsPrize(15, 1));
            elements.Add(new SlotsElement(16, "Arbuz", "placeholder", @"                                        
                                        
                                        
                                        
                                        
 //    ./////////////////////////    .//
 //.    /////////////////////////    ///
 ///    //////%%%//%%%//%%%/////     //.
  ///     /////////////////////     /// 
    ///      //////////////(      ///   
      ///                      .///     
        ./////             /////        
             */////////////,            
                                        
                                        
                                        
"));
            prizes.Add(new SlotsPrize(16, 1));
        }
        public void Lever()
        {
            int counter = 0;
            Random r = new Random();
            int x = 0;
            List<int> actual = new List<int>();
            while (true)
            {
                counter++;
                switch (counter % 3)
                {
                    case 0:
                        for (int i=0; i<10; i++)
                        {
                            x = r.Next(16);
                            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                            Console.Write(elements[actual[0]].Asci);
                            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                            Console.Write(elements[actual[1]].Asci);
                            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                            Console.Write(elements[x].Asci);
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        actual.Add(x);
                        Console.Clear();
                        Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                        Console.Write(elements[actual[0]].Asci);
                        Console.Write(elements[actual[1]].Asci);
                        Console.Write(elements[actual[2]].Asci);
                        while (true) ;
                        counter = 0;
                        break;
                    case 1:
                        for (int i = 0; i < 10; i++)
                        {
                            x = r.Next(16);
                            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                            Console.Write(elements[x].Asci);
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        actual.Add(x);
                        break;
                    case 2:
                        for (int i = 0; i < 10; i++)
                        {
                            x = r.Next(16);
                            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                            Console.Write(elements[actual[0]].Asci);
                            Console.SetCursorPosition((Console.WindowWidth - 40) / 2, Console.CursorTop);
                            Console.Write(elements[x].Asci);
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        actual.Add(x);
                        break;
                }
                Thread.Sleep(500);
            }
        }
    }
}
