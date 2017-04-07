using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        // I have no idea what this is
        //    //SunPosition.CalculateSunPosition(DateTime.Now, 38.813156, -77.042256);

                   
        public MainWindow()
            {
            InitializeComponent();
            }



        [STAThread]
        private void button_Click(object sender, RoutedEventArgs e)
            {

            // Now start the gameplay on another thread
            // It will first do the setup and then loop through the moves.
            Thread t = new Thread(CarrierWar.GameMechanics.GamePlay.Controller);
            t.ApartmentState = ApartmentState.STA;
            t.Start();

            }

        private void button1_Click(object sender, RoutedEventArgs e)
            {



            }
        }
    }
