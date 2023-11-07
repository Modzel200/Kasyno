﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCasino.Slots
{
    public class SlotsElement
    {
        public SlotsElement(int Id ,string Name, string ImageUrl, string Asci)
        {
            this.Id = Id;
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.Asci = Asci;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Asci { get; set; }
    }
    public class SlotsPrize
    {
        public SlotsPrize(int Id, double Value)
        {
            this.Id = Id;
            this.Value = Value;
        }
        public int Id { get; set; }
        public double Value { get; set; }
    }
}
