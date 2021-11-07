using System;
using System.Threading;

namespace StopWatchApplication
{
    public class StopWatch
    {
        public DateTime start { get; set; }
        public DateTime stop { get; set; }
        public bool started = false;


        public void startfun(DateTime sf)
        {
            if (!started)
            {
                start = sf;
                started = true;
            }
        }
        public void stopfun(DateTime pt)
        {
            if (started)
            {
                stop = pt;
                started = false;
            }
        }
        public TimeSpan getinterval()
        {
            var duration = start - stop;
            return duration;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            for (int i = 0; i < 2; i++)
            {

                Thread.Sleep(1000);

            }
            stopWatch.startfun(DateTime.Now.AddDays(1));
            stopWatch.stopfun(DateTime.Now.AddYears(-1));
            Console.WriteLine( stopWatch.getinterval());
           
        }
    }
}
