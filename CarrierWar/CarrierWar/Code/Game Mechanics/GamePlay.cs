using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar.GameMechanics
    {
    static public class GamePlay
        {

        static public void Move()
            {

            // Loop the task forces
            foreach (CarrierWar.TaskForces.TaskForce TheTaskForce in CarrierWar.GlobalVariables.TheFleet)
                {

                // Now loop the ships 
                foreach (CarrierWar.Ships.CV TheShip in TheTaskForce.OrderOfBattle)
                    {

                    TheShip.Move();

                    }

                //GameMechanics.Movement.Distance(TheTaskForce.OrderOfBattle...First.Location, Enterprise.Location);


                }

            //CarrierWar.MainWindow.WindowStyleProperty.BattleSpace.UpdateLayout();
            //BattleSpace.BringIntoView();

            //BattleSpace.Focus();

            


            }
        }
    }


