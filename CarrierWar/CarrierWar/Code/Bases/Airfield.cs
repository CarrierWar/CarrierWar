using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar.Bases
    {
    class Airfield
        {

        public GameMechanics.Location Location;

        public double RunwayLength;

        public Equipment.Radar Radar;

        public double ApronSpace; // Square footage for storing aircraft

        public double LandingCapasity; // Minutes to land each craft

        public double CurrentAviationFuel; // Gallons og AvGas

        public double MaxAviationFuel; // The most it can store

        public int Bombs; //  Number of bombs aviable

        public int Torpodoes; // number of torpodes aviable
        
        }
    }
