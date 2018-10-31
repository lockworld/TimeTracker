using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static WindowsAppBar.AppBarMethods;

namespace WindowsAppBar
{
    public sealed class MonitorInformation : IEquatable<MonitorInformation>
    {
        public Rect ViewportBounds { get; }

        public Rect WorkAreaBounds { get; }

        public bool IsPrimary { get; }

        public string DeviceId { get; }

        internal MonitorInformation(MONITORINFOEX mex)
        {
            this.ViewportBounds = (Rect)mex.rcMonitor;
            this.WorkAreaBounds = (Rect)mex.rcWork;
            this.IsPrimary = mex.dwFlags.HasFlag(MONITORINFOF.PRIMARY);
            this.DeviceId = mex.szDevice;
        }

        public static IEnumerable<MonitorInformation> GetAllMonitors()
        {
            var monitors = new List<MonitorInformation>();
            MonitorEnumDelegate callback = delegate (IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData)
            {
                MONITORINFOEX mi = new MONITORINFOEX();
                mi.cbSize = Marshal.SizeOf(typeof(MONITORINFOEX));
                if (!GetMonitorInfo(hMonitor, ref mi))
                {
                    throw new Win32Exception();
                }
                
                monitors.Add(new MonitorInformation(mi));
                return true;
            };

            EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, callback, IntPtr.Zero);

            return monitors;
        }

        public override string ToString() => DeviceId;

        public override bool Equals(object obj) => Equals(obj as MonitorInformation);

        public override int GetHashCode() => DeviceId.GetHashCode();

        public bool Equals(MonitorInformation other) => this.DeviceId == other?.DeviceId;

        public static bool operator ==(MonitorInformation a, MonitorInformation b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null))
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(MonitorInformation a, MonitorInformation b) => !(a == b);
    }
}
