using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CarrierWar;

namespace CarrierWar.GameMechanics
    {
    public class Timer
        {

        private static System.Timers.Timer aTimer;

        public static void StartTimer()
            {
            SetTimer();

            //Console.WriteLine("\nPress the Enter key to exit the application...\n");
            //Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            //Console.ReadLine();
            //aTimer.Stop();
            //aTimer.Dispose();

            //Console.WriteLine("Terminating the application...");
            }

        private static void SetTimer()
            {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(5000);
            // Hook up the Elapsed event for the timer. 
            //aTimer.Elapsed += OnTimedEvent;
            //aTimer.AutoReset = true;
            //aTimer.Enabled = true;
            }

        //public static void OnTimedEvent//(Object source, ElapsedEventArgs e)
            //{


            // Loop the task forces
            //foreach (CarrierWar.TaskForces.TaskForce TheTaskForce in CarrierWar.GlobalVariables.TheFleet)
            //    {

            //    // Now loop the ships 
            //    foreach (CarrierWar.Ships.CV TheShip in TheTaskForce.OrderOfBattle)
            //        {

            //        TheShip.Move();

            //        }


            //    }

            //BattleSpace.UpdateLayout();
            //BattleSpace.BringIntoView();

            //BattleSpace.Focus();

            //GameMechanics.Movement.Distance(Yorktown.Location, Enterprise.Location);




            }
        }

    

