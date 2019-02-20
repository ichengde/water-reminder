using System;

using System.Timers;
using System.Windows.Forms;

namespace reminder
{
    public class Canhu
    {

        [STAThread]
        public static void Main()
        {
            MyTimer ansTimer = new MyTimer();
            Application.Run();
        }

    }

    public class MyTimer
    {

        delegate void hide();
        delegate void show();
        public MyTimer()
        {
            this.InitTimer();
            
        }

        
        public int currentCount = 0;

        public System.Timers.Timer timer;

        public delegate void SetControlValue(string value);

        public void InitTimer()
        {
            int interval = 1000;
            timer = new System.Timers.Timer(interval);

            timer.AutoReset = true;
            timer.Enabled = true;

            timer.Elapsed += this.TimeUp;
            

        }
        

        public void TimeUp(object sender, System.Timers.ElapsedEventArgs e)
        {

            currentCount += 1;

            {

                if (currentCount % (1000 * 60 * 30) == 0)
                {
                    MessageBox.Show("该喝水了");
                } 
            };
            Console.WriteLine("nice " + currentCount.ToString());
        }
    }
    
}


