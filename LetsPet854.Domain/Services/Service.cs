using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet854.Domain
{
    public class Service
    {
        internal string Type { get; set; }//*
        internal string Species { get; set; }//*
        internal string Size { get; set; }//*
        internal string Name { get; set; }
        internal bool Special { get; set; }
        internal bool Lotion { get; set; }
        internal string GroomingType = "";
        internal int ServiceTime = 1;
        internal int Employees { get; set; }
        internal double Price { get; set; }//*

        public Service(string type, string species, string size, string name, bool special, bool lotion, string groomingType, int serviceTime, int employees, double price)
        {
            Type = type;
            Species = species;
            Size = size;
            Name = name;
            Special = special;
            Lotion = lotion;
            GroomingType = groomingType;
            ServiceTime = serviceTime;
            Employees = employees;
            Price = price;
        }
    }
}
