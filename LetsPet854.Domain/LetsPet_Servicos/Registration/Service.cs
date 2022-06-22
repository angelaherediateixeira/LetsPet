using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public class Service
    {
        public string Type { get; set; }//*
        public string Species { get; set; }//*
        public string Size { get; set; }//*
        public string Name { get; set; }
        public bool Special { get; set; }
        public bool Lotion { get; set; }
        public string GroomingType = "";
        public int ServiceTime = 1;
        public double Price { get; set; }//*

        public Service(string type, string species, string size, string name, bool special, bool lotion, string groomingType, int serviceTime, double price)
        {
            Type = type;
            Species = species;
            Size = size;
            Name = name;
            Special = special;
            Lotion = lotion;
            GroomingType = groomingType;
            ServiceTime = serviceTime;
            Price = price;
        }
    }
}
