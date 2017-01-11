using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarrierWar
    {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {

      CarrierWar.TaskForces.TaskForce TF_1 = new CarrierWar.TaskForces.TaskForce();


        public MainWindow()
            {
            InitializeComponent();


            //SunPosition.CalculateSunPosition(DateTime.Now, 38.813156, -77.042256);

            // Create two ships

            // Yorktown
            Ships.CV z = new Ships.CV();
            z.AircraftCapacity = 50;
            z.MaxSpeed = 36;
            z.CurrentSpeed = 25;
            z.Course = 225;
            z.CurrentLocation = new GameMechanics.Location { Latitude = -8, Longititude = 155.407007 };
            z.Construct("CV", "CV-5", "Yorktown");

            // Enterprise
            Ships.CV x = new Ships.CV();
            x.AircraftCapacity = 50;
            x.MaxSpeed = 36;
            x.CurrentSpeed = 25;
            x.Course = 125;
            x.CurrentLocation = new GameMechanics.Location { Latitude = -8, Longititude = 155.407007 };
            x.Construct("CV", "CV-6", "Enterprise");

            TF_1.OrderOfBattle.Add(z);
            TF_1.OrderOfBattle.Add(x);

            CarrierWar.GlobalVariables.TheFleet.Add(TF_1);

            BattleSpace.Focus();

            // The pushpin to add to the map.
            //Pushpin pin = new Pushpin();
            //pin.Location = new Microsoft.Maps.MapControl.WPF.Location(z.CurrentLocation.Latitude, z.CurrentLocation.Longititude);
            //pin.Name = "X";


            // Adds the pushpin to the map.
            BattleSpace.Children.Add(z.PushPin);
            BattleSpace.Children.Add(x.PushPin);

            }

        private void button_Click(object sender, RoutedEventArgs e)
            {

            while (true)

                {

                foreach (Ships.CV item in TF_1.OrderOfBattle)
                    {

                    item.Move();

                    }

                //Carrier_War.Ship CV1 = TF_1.OrderOfBattle.Find(yy => yy.HullNumber == "CV-5");
                //Carrier_War.Ship CV2 = TF_1.OrderOfBattle.Find(y => y.HullNumber == "CV-6");
                //GameMechanics.Movement.Distance(CV1.CurrentLocation, CV2.CurrentLocation);

                //BattleSpace.UpdateLayout();

                //BattleSpace.SetView(-8, 155.407007);




                }

            }





        //  Carrier_War.GameMechanics.Timer.StartTimer();



        //private void MovePin(GameMechanics.Location NewLocation, string Name)
        //  {

        //BattleSpace.Focus();

        // The pushpin to add to the map.
        //  var t = BattleSpace.Children.Count;


        //Pushpin pin = BattleSpace.Children.Count

        //Pushpin pin = new Pushpin();
        //pin.Location = new Microsoft.Maps.MapControl.WPF.Location(NewLocation.Latitude, NewLocation.Longititude);

        //// Adds the pushpin to the map.
        //BattleSpace.Children.Add(pin);
        //BattleSpace.Center = pin.Location;


        //BattleSpace.UpdateLayout();



        //BattleSpace.Focus();

        //// The pushpin to add to the map.
        //Pushpin pin = new Pushpin();
        //pin.Location = new Microsoft.Maps.MapControl.WPF.Location(NewLocation.Latitude, NewLocation.Longititude);

        //// Adds the pushpin to the map.
        //BattleSpace.Children.Add(pin);
        //BattleSpace.Center = pin.Location;


        //BattleSpace.UpdateLayout();





        //   }

        }
    }
