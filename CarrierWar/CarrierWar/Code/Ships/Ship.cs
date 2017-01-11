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
    class Ship : Unit
        {
        

        public double MaxSpeed
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public double CurrentSpeed;
        //{
        //get
        //    {
        //    throw new System.NotImplementedException();
        //    }

        //set
        //    {
        //    }
        //}

        public int Weight
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public string Name
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public string Type
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public string HullNumber;
        //{
        //get
        //    {
        //    throw new System.NotImplementedException();
        //    }

        //set
        //    {
        //    }
        //}

        public double Course;
        //{
        //get
        //    {
        //    throw new System.NotImplementedException();
        //    }

        //set
        //    {
        //    }
        //}

        public int MaxFuel
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public int CurrentFuel
            {
            get
                {
                throw new System.NotImplementedException();
                }

            set
                {
                }
            }

        public GameMechanics.Location CurrentLocation;
        //{
        //get
        //    {
        //    throw new System.NotImplementedException();
        //    }

        //set
        //    {
        //    }
        //}


        public Pushpin PushPin;


        public void Move()
            {

            CurrentLocation = GameMechanics.Movement.CalculateNewPosition(CurrentLocation.Latitude, CurrentLocation.Longititude, Course, 1);
            PushPin.Location.Latitude = CurrentLocation.Latitude;
            PushPin.Location.Longitude = CurrentLocation.Longititude;



            }
        }
    
    }
