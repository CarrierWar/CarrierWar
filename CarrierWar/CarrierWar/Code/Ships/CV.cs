using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarrierWar.Ships
    {
    public class CV : Ship
        {

        public int AircraftCapacity { get; private set; }
        public int AircraftFuel { get; private set; }
        public int Torpodoes { get; private set; }
        public int Bombs { get; private set; }


        public CV(string HullNumber)
            {

            switch (HullNumber)
                {

                case "CV-1": // Langley
                    break;
                case "CV-2": // Lexington
                    break;
                case "CV-3": // Saratoga
                    break;
                case "CV-4": // Ranger
                    break;
                case "CV-5": // Yorktown
                    AircraftCapacity = 50;
                    MaxSpeed = 20;
                    Location.Latitude = -8;
                    Location.Longitude = 155.407007;
                    Course = 100;
                    Speed = 22;
                    this.HullNumber = "CV-5";
                    break;
                case "CV-6": // Enterprise
                    AircraftCapacity = 50;
                    MaxSpeed = 40;
                    Location.Latitude = -8;
                    Location.Longitude = 155.407007;
                    Course = 20;
                    Speed = 15;
                    this.HullNumber = "CV-6";
                    break;
                case "CV-7": // Wasp
                    break;
                case "CV-8": // Hornet
                    break;
                }

            //LocationPushpin.Location = new Location();
            //LocationPushpin.Location.Latitude = Location.Latitude;
            //LocationPushpin.Location.Longitude = Location.Longitude;

            }












        }
    }
