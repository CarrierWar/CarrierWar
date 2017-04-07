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



        public MainWindow()
            {
            InitializeComponent();

            }

        // I have no idea what this is
        //    //SunPosition.CalculateSunPosition(DateTime.Now, 38.813156, -77.042256);

        private void GameSetup()
            {

            
            // Create ships and task forces
            Ships.CV Yorktown = new Ships.CV("CV-5");
            Ships.CV Enterprise = new Ships.CV("CV-6");

            CarrierWar.TaskForces.TaskForce TF1 = new CarrierWar.TaskForces.TaskForce();

            TF1.Attach(Yorktown);
            TF1.Attach(Enterprise);

            CarrierWar.GlobalVariables.TheFleet.Add(TF1);
            
            //Adds the pushpin to the map.
            BattleSpace.Children.Add(Yorktown.LocationPushpin);
            BattleSpace.Children.Add(Enterprise.LocationPushpin);

            // Center and zoom the map
            BattleSpace.Center = new Microsoft.Maps.MapControl.WPF.Location(-8, 165);
            BattleSpace.SetView(5, 0);
            BattleSpace.Focus();


            }

        private void button_Click(object sender, RoutedEventArgs e)
            {

            GameSetup();

            }

        private void button1_Click(object sender, RoutedEventArgs e)
            {

            Console.WriteLine("Moving");

            CarrierWar.GameMechanics.GamePlay.Move();

            }
        }
    }
