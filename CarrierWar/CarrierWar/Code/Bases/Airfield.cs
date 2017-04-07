using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar.Bases
    {
    public class Airfield
        {

        /// <summary>
        /// ff
        /// </summary>
        private GameMechanics.Location Location;

        /// <summary>
        /// ff
        /// </summary>
        private int RunwayLength;

        /// <summary>
        /// ff
        /// </summary>
        private Equipment.Radar Radar;

        /// <summary>
        /// The total aircraft storage capasity
        /// </summary>
        private int ApronSpace = 0;

        /// <summary>
        /// The number of aircraft that can land per minute
        /// </summary>
        private int LandingCapasity; // Minutes to land each craft

        /// <summary>
        /// The current amount of fuel stored on the base
        /// </summary>
        private int CurrentAviationFuel; // Gallons og AvGas

        /// <summary>
        /// The most amount of fuel that can be stored on the base
        /// </summary>
        private int MaxAviationFuel; // The most it can store

        /// <summary>
        /// Number of bmobs available on base
        /// </summary>
        private int Bombs; //  Number of bombs aviable

        /// <summary>
        /// Number of torpedoes avialable on base
        /// </summary>
        private int Torpodoes;
        /// <summary>
        /// To collection of air defenses equipment
        /// </summary>
        private List<AntiAircraftGun> AirDefenses;

        /// <summary>
        /// ff
        /// </summary>
       

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
