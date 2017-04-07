using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar.TaskForces
    {
    /// <summary>
    /// A collection of ships assembled as a fighting force
    /// </summary>
    class TaskForce
        {
        public List<CarrierWar.Ship> OrderOfBattle = new List<CarrierWar.Ship>();
        private string Designation;





        /// <summary>
        /// Add the contents of another Task Force into this one
        /// </summary>
        public void Attach(Ships.CV TheShip)
            {
            OrderOfBattle.Add(TheShip);

            }

        /// <summary>
        /// Remove the specific ships from this Task Force and place them in their own Task Force
        /// </summary>
        public void Detach()
            {
            throw new System.NotImplementedException();
            }
        }
    }
