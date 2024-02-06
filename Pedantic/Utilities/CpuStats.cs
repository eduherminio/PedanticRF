﻿using System.Diagnostics;

namespace Pedantic.Utilities
{
    public struct CpuStats
    {
        public CpuStats()
        {
            startTime = DateTime.Now;
            startCpuUsage = Process.GetCurrentProcess().TotalProcessorTime;
        }

        public void Reset()
        {
            startTime = DateTime.Now;
            startCpuUsage = Process.GetCurrentProcess().TotalProcessorTime;
        }

        public int CpuLoad
        {
            get
            {
                TimeSpan totalUsage = Process.GetCurrentProcess().TotalProcessorTime - startCpuUsage;
                TimeSpan totalTime = DateTime.Now - startTime;
                int cpuLoad = (int)((totalUsage.TotalMilliseconds * 1000) / (totalTime.TotalMilliseconds));
                return cpuLoad;
            }
        }

        private DateTime startTime;
        private TimeSpan startCpuUsage;
    }
}
