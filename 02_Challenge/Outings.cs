﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public enum TypeOfOutings { Golf, Bowling, AmusementPark, Concert};

    public class Outings
    {
        public TypeOfOutings Type { get; set; }
        public double CostPerPerson { get; set; }
        public DateTime EventDate { get; set; }
        public int NumberOfPeople { get; set; }
        public double TotalCost { get; set; }

        public Outings(TypeOfOutings type, double cpp, DateTime ed, int noppl)
        {
            Type = type;
            CostPerPerson = cpp;
            EventDate = ed;
            NumberOfPeople = noppl;
            TotalCost = cpp*noppl;
        }

        public Outings()
        {
            // Empty cosntructor 
        }

    }
}