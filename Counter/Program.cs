using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Counter
{
    class Program
    {
        private Timer StopWatchThing;
        private bool IsTimeUP;
        private double countednumber;
        int secondspassed = 0;
        int seconds;

        /*Main Proc*/
        static void Main(string[] args)
        {
            Program app = new Program();
            app.dowork();
            Console.Out.WriteLine("Press Enter to Finish");
            Console.ReadLine();
        }

        private void dowork()
        {
            StopWatchThing = new Timer();
            countednumber = 0;
            Console.Out.WriteLine("How Many Seconds?");
            seconds = int.Parse(Console.ReadLine());
            StopWatchThing.Interval =   1000;
            StopWatchThing.Elapsed += new ElapsedEventHandler(StopWatchThing_Elapsed);
            StopWatchThing.Enabled = true;
            IsTimeUP = false;
            while (IsTimeUP == false)
            {
                ++countednumber;
                //Console.Out.Write(".");
            }

            Console.Out.WriteLine("We counted to " + countednumber + " in " + seconds + " seconds");
        }

        void StopWatchThing_Elapsed(object sender, ElapsedEventArgs e)
        {
            ++secondspassed;
            if (secondspassed == seconds)
            {
                IsTimeUP = true;
                StopWatchThing.Enabled = false;
            }
            else
            {
                Console.Out.WriteLine("We counted to " + countednumber + " in " + secondspassed + " seconds");
            }
        }
    }
}
