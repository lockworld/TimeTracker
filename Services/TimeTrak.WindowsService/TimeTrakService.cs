using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TimeTrak.WindowsService
{
    public partial class TimeTrakService : ServiceBase
    {
        public TimeTrakService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //MessageBox.Show("Hi");
            System.Media.SystemSounds.Beep.Play();
        }

        protected override void OnStop()
        {
            //MessageBox.Show("Bye...");
            System.Media.SystemSounds.Exclamation.Play();
        }
    }
}
