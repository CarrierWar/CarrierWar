using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarrierWar.Ships
    {
    class CV : Ship
        {

        public void Construct(string Type, string HullNumber, string Name)
            {

           this.Type = Type;
            this.HullNumber = HullNumber;
            this.Name = Name;

            ////System.Windows.Controls.ContextMenu TheMenu = new System.Windows.Controls.ContextMenu();
            ////PushPin.ContextMenu = new System.Windows.Controls.ContextMenu();

            PushPin = new Pushpin();
            PushPin.Location = new Location();
            PushPin.Location.Latitude = CurrentLocation.Latitude;
            PushPin.Location.Longitude = CurrentLocation.Longititude;


            }






        public int AircraftCapacity
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int AircraftFuel
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int Torpedos
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

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

       
        }
    }
