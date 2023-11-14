using ConsoleCasino;
using ConsoleCasino.Roulette;
using ConsoleCasino.Slots;

Account account = new Account();
Console.WriteLine("Witaj w Royal Casino "+account.getName());
Console.WriteLine("Twój aktualny status konta: "+account.getBalance());
Roulette roulette = new Roulette();
roulette.Game(account);
//Slots te = new Slots();
//te.Game(account, 5);
