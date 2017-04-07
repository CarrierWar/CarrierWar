using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar.Equipment
    {
    public class Radar
        {

        /// <summary>
        /// The radar type
        /// </summary>
        public string Type { get; private set; }
        /// <summary>
        /// On a scale of 1-10 how functional is the radar
        /// </summary>
        public int Condition { get; private set; }

        /// <summary>
        /// Determines the likelyhood this radar can dectect a specific object
        /// </summary>
        /// <param name="Range">Distance in miles</param>
        /// <param name="Altitude">Altitude of the target object</param>
        /// <param name="Size">The size of the object (i.e number of aircraft)</param>
        public double Detect(int Range, int Altitude, int Size)
            {

            // Ok - let's run a simple switch and calculate the odds of a detection.

            switch (Type)
                {
                case "T-1":
                    return 1.0;


                    break;
                }

            return 0.0;




            }

        /// <summary>
        /// Simulates battle damage by reducing the unit's abilities
        /// </summary>
        /// <param name="Count">How much damage has been inflicted</param>
        public bool Damage(int Count)
            {
            Condition = Condition - Count;

            // If the damage is bad enough the equipment is destroyed
            if (Condition <= 0)
                {
                return true;

                }
            else
                {
                return false;

                }
            }

        /// <summary>
        /// Simulates the effors of repair crews
        /// </summary>
        /// <param name="Count">How much repaid work has been done</param>
        public void Repair(int Count)
            {
            Condition = Condition + Count;
            }

        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="Type">The type of radar being creted</param>
        public Radar(string Type)
            {

            Type = Type;
            Condition = 10;

            }
        }
    }
