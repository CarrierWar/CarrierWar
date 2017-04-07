using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;

namespace CarrierWar
    {
    /// <summary>
    /// A Warship
    /// </summary>
    /// <seealso cref="CarrierWar.Unit" />
    public abstract class Ship : Unit
        {

        public double MaxSpeed { get; internal set; }
        public int Displacement { get; internal set; }
        public double Speed { get; set; }
        public double Course { get; set; }
        public string HullType { get; internal set; }
        public string HullNumber { get; internal set; }


        public void Move()
            {

            Console.WriteLine(HullNumber + " moved");

            //Location = GameMechanics.Movement.CalculateNewPosition(Location.Latitude, Location.Longitude, Course, 1);
            //LocationPushpin.Location.Latitude = Location.Latitude;
            //LocationPushpin.Location.Longitude = Location.Longitude;
            }







        }

    }
