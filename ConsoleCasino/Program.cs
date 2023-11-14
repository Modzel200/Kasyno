using ConsoleCasino;
using ConsoleCasino.Slots;

Account account = new Account();
Console.WriteLine("Witaj w Royal Casino "+account.getName());
Console.WriteLine("Twój aktualny status konta: "+account.getBalance());
//Roulette game = new Roulette();
//game.Game(account);
Slots te = new Slots();
te.Game(account, 5);
