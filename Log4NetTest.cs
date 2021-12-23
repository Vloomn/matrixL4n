using System;
using System.Diagnostics;
using System.Threading;
using log4net;
using log4net.Config;


namespace AdvanceLib
{
    public class Log4NetTest
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly Stopwatch stopwatch = new Stopwatch();
        public static void StopwatchLog(int num)
        {
            //BasicConfigurator.Configure();
            if (num < 0)
            {
                return;
            }
            // Create new stopwatch.

            // Begin timing.
            stopwatch.Start();

            // Do something.
            int i = 0;
            while (i < num)
            {
                i++;
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            string output = DateTime.Now.ToString("M/d/yyyy") + " - Input:" + num.ToString() + " - Time: " + stopwatch.Elapsed;
            log.Info(output);
        }
    }
}
