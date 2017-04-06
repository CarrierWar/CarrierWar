using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar.Bases
    {
    public class Airfield
        {

        public GameMechanics.Location _Location;

        public int _RunwayLength;

        public Equipment.Radar Radar;

        public int _ApronSpace = 0; // Square footage for storing aircraft

        public int _LandingCapasity; // Minutes to land each craft

        public int _CurrentAviationFuel; // Gallons og AvGas

        public int _MaxAviationFuel; // The most it can store

        public int _Bombs; //  Number of bombs aviable

        public int _Torpodoes; // number of torpodes aviable

        public int Bombs
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int Torpodoes
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int ApronSpace
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int CurrentAviationFuel
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int LandingCapasity
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int MaxAviationFuel
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int RunwayLength
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public void Damage(int Effort)
            {
            throw new System.NotImplementedException();
            }

        public void Repair(int Effort)
            {
            throw new System.NotImplementedException();
            }
        }
    }
