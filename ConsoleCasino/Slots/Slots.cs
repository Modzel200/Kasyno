using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino.Slots
{
    public class Slots
    {
        List<SlotsElement> elements;
        List<SlotsPrize> prizes;
        public Slots()
        {
            Random rnd = new Random();
            elements = new List<SlotsElement>();
            prizes = new List<SlotsPrize>();
            elements.Add(new SlotsElement(1 ,"Diament" , "placeholder", ""));
            prizes.Add(new SlotsPrize(1, 5));
            elements.Add(new SlotsElement(2, "Wiśienki", "placeholder", ""));
            prizes.Add(new SlotsPrize(2, 1.5));
            elements.Add(new SlotsElement(3, "Śliwka", "placeholder", ""));
            prizes.Add(new SlotsPrize(3, 1.25));
            elements.Add(new SlotsElement(4, "Dzwon", "placeholder", ""));
            prizes.Add(new SlotsPrize(4, 2));
            elements.Add(new SlotsElement(5, "Koniczyna", "placeholder", ""));
            prizes.Add(new SlotsPrize(5, rnd.NextDouble()+2));
            elements.Add(new SlotsElement(6, "Cytryna", "placeholder", ""));
            prizes.Add(new SlotsPrize(6, 1));
            elements.Add(new SlotsElement(7, "Moneta", "placeholder", ""));
            prizes.Add(new SlotsPrize(7, 1));
            elements.Add(new SlotsElement(8, "Bar", "placeholder", ""));
            prizes.Add(new SlotsPrize(8, 1));
            elements.Add(new SlotsElement(9, "Jabłko", "placeholder", ""));
            prizes.Add(new SlotsPrize(9, 1));
            elements.Add(new SlotsElement(10, "Serce", "placeholder", ""));
            prizes.Add(new SlotsPrize(10, 1));
            elements.Add(new SlotsElement(11, "Winogrona", "placeholder", ""));
            prizes.Add(new SlotsPrize(11, 1));
            elements.Add(new SlotsElement(12, "Pomarańcza", "placeholder", ""));
            prizes.Add(new SlotsPrize(12, 1));
            elements.Add(new SlotsElement(13, "Podkowa", "placeholder", ""));
            prizes.Add(new SlotsPrize(13, 1));
        }
    }
}
