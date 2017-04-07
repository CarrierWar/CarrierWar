using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gavaghan.Geodesy;

namespace CarrierWar.GameMechanics
    {
    class Movement
        {
        
        /// <summary>
        /// Calculates the new position or a unit traveling at a specific course at a specific speed.
        /// </summary>
        /// <param name="Latitude">The starting latitude.</param>
        /// <param name="Longititude">The starting longititude.</param>
        /// <param name="Bearing">The course.</param>
        /// <param name="Speed">The speed.</param>
        /// <returns>The new location</returns>
        public static Location CalculateNewPosition(double Latitude, double Longititude, double Bearing, double Speed)

            {

        // This is a third party DLL we use for determining the end locaiton of each move.
        GeodeticCalculator geoCalc = new GeodeticCalculator();

            // select a reference elllipsoid
            Ellipsoid reference = Ellipsoid.WGS84;
                       
            GlobalCoordinates StartPosition;
            StartPosition = new GlobalCoordinates(new Angle(Latitude), new Angle(Longititude));

            // set the direction and distance
            Angle startBearing = new Angle(Bearing);
            double distance = (Speed/1.15078); // This is where we calculate the distance covered in miles by however often teh movement timer is firing.

            // find the destination
            Angle endBearing;
            GlobalCoordinates dest = geoCalc.CalculateEndingGlobalCoordinates(reference, StartPosition, startBearing, distance, out endBearing);

            return new Location { Latitude = Convert.ToDouble(dest.Latitude.Degrees), Longitude=Convert.ToDouble(dest.Longitude.Degrees) };
            
            }


        /// <summary>
        /// Determines the distance between two locations
        /// </summary>
        /// <param name="Location1">The first location.</param>
        /// <param name="Location2">The second location.</param>
        /// <returns>Distance in feet</returns>
        public static double Distance(Location Location1, Location Location2)
            {

            // instantiate the calculator
            GeodeticCalculator geoCalc = new GeodeticCalculator();

            // select a reference elllipsoid
            Ellipsoid reference = Ellipsoid.WGS84;

            GlobalCoordinates FirstUnit;
            FirstUnit = new GlobalCoordinates(new Angle(Location1.Latitude), new Angle(Location1.Longitude ));

            GlobalCoordinates SecondUnit;
            SecondUnit = new GlobalCoordinates(new Angle(Location2.Latitude), new Angle(Location2.Longitude));

            // calculate the geodetic curve
            GeodeticCurve geoCurve = geoCalc.CalculateGeodeticCurve(reference, FirstUnit, SecondUnit);
            double ellipseKilometers = geoCurve.EllipsoidalDistance / 1000.0;
            double ellipseMiles = ellipseKilometers * 0.621371192;

            //Console.WriteLine("2-D path from Lincoln Memorial to Eiffel Tower using WGS84");
            //Console.WriteLine("   Ellipsoidal Distance: {0:0.00} kilometers ({1:0.00} miles)", ellipseKilometers, ellipseMiles);
            //Console.WriteLine("   Azimuth:              {0:0.00} degrees", geoCurve.Azimuth.Degrees);
            //Console.WriteLine("   Reverse Azimuth:      {0:0.00} degrees", geoCurve.ReverseAzimuth.Degrees);

            System.Diagnostics.Debug.WriteLine("Distance - " + ellipseMiles + ", Course - " + geoCurve.ReverseAzimuth.Degrees);
            
            return geoCurve.ReverseAzimuth.Degrees;

            }

        
        }

    /// <summary>
    /// The location of a unit as expressed in Latitude and Longtitude
    /// </summary>
    public class Location
        {
        
        public double Latitude;

        public double Longitude;

        }
    
    }
