using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar
    {
    public class GameSetup
        {
        public static void Setup()
            {


            // Create ships and task forces
            Ships.CV Yorktown = new Ships.CV("CV-5");
            Ships.CV Enterprise = new Ships.CV("CV-6");

            CarrierWar.TaskForces.TaskForce TF1 = new CarrierWar.TaskForces.TaskForce();

            TF1.Attach(Yorktown);
            TF1.Attach(Enterprise);

            GlobalVariables.TheFleet.Add(TF1);

          

            //Adds the pushpin to the map.
            //BattleSpace.Children.Add(Yorktown.LocationPushpin);
            //BattleSpace.Children.Add(Enterprise.LocationPushpin);

            //// Center and zoom the map
            //BattleSpace.Center = new Microsoft.Maps.MapControl.WPF.Location(-8, 165);
            //BattleSpace.SetView(5, 0);
            //BattleSpace.Focus();


            }

        }
    }
