using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarrierWar;

namespace Unit_Tests
    {
    [TestClass]
    public class CarrierWar
        {
        [TestMethod]
        public void RadarDamage()
            {

            global::CarrierWar.Equipment.Radar ThisRadar = new global::CarrierWar.Equipment.Radar("T-1");
            ThisRadar.Damage(1);
            Assert.AreEqual(9, ThisRadar.Condition);
            }
        [TestMethod]
        public void RadarRepair()
            {

            global::CarrierWar.Equipment.Radar ThisRadar = new global::CarrierWar.Equipment.Radar("T-1");
            ThisRadar.Repair(1);
            Assert.AreEqual(11, ThisRadar.Condition);

            }
        [TestMethod]
        public void RadarDestroy()
            {

            global::CarrierWar.Equipment.Radar ThisRadar = new global::CarrierWar.Equipment.Radar("T-1");
            Assert.AreEqual(false, ThisRadar.Damage(11));

            }


        }
    }
