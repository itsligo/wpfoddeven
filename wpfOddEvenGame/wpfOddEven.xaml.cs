using System;
using System.Windows;
using System.Windows.Threading;
using System.Diagnostics;
using System.Windows.Controls;

namespace wpfOddEvenGame
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WPFWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();    // declare and create the timer
        Random rnd;         // declare the random number generator
        int noOdd = 0, noEven = 0;  // declare and initialise the counters

        public WPFWindow()
        {
            InitializeComponent();
            //int seed = Convert.ToInt32(DateTime.Now.Millisecond); // alternative to seed the random number generator
            int seed = System.Environment.TickCount;        // seed for randomisation
            rnd = new Random(seed);
        }

        private void dispatcherTimer_Tick (object sender, EventArgs e) {
            int test = rnd.Next(100);
            if ((test % 2) == 0) noEven++; else noOdd++;
            TxtRandom.Text = test.ToString();
            TxtResult.Text = String.Format("Odd: {0}\r\nEven: {1}", noOdd, noEven);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // wire up the event handler for the 'Tick' event
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            // set the timer to 'tick' every 1second
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, (int)(1000/SldRate.Value));
            // start the timer going
            dispatcherTimer.Start();

            noOdd = noEven = 0;         // zero the counters
            BtnStart.IsEnabled = false; // reflect changes to UI
            BtnStop.IsEnabled = true;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            BtnStart.IsEnabled = true;  // reflect changes to UI
            BtnStop.IsEnabled = false;
            dispatcherTimer.Stop();     // stop the timer
        }

        private void sldRate_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // slider ranges from 1 - 10
            // timer should range 1000 - 100
            //txtSlider.Text = sldRate.Value.ToString();
            //txtSlider.Text = ((Slider)sender).Value.ToString();
            //txtSlider.Text = (sender as Slider).Value.ToString();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,(int)(1000/SldRate.Value));
        }
    }   // end class
}   // end namespace
