using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrierWar
    {
    /// <summary>
    /// Any military unit such as a ship, aircraft etc.
    /// </summary>
    public class Unit
        {
        public string Nationality { get; private set; }
        public GameMechanics.Location Location { get; set; } = new GameMechanics.Location();
        public Pushpin LocationPushpin { get; set; } = new Pushpin();
        
        }
    }
