using System;
using System.Threading;

namespace AsynchronousTimer
{
    class AsynchronousTimer
    {
        private Action<DateTime> action;
        private int ticks;
        private int timeIntervals;

        public AsynchronousTimer(Action<DateTime> action, int ticks, int timeIntervals)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.TimeIntervals = timeIntervals;
        }

        public Action<DateTime> Action { get; set; }

        public int Ticks { get; set; }

        public int TimeIntervals { get; set; }

        public void Run()
        {
            var parallel = new Thread(this.Execute);
            parallel.Start();
        }

        private void Execute()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.TimeIntervals);
                this.Action(DateTime.Now);
            }
        }
    }
}