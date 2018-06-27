using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TimeTrak.WindowsApp.Features;

namespace TimeTrak.WindowsApp.Windows
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var key = new HotKey(
            //    (ModifierKeys.Alt),
            //    Key.B,
            //    this,
            //    delegate {
            //        App.Current.MainWindow.Show();
            //        App.Current.MainWindow.Focus();
            //        System.Media.SystemSounds.Asterisk.Play();
            //        System.Windows.Forms.MessageBox.Show("Alt+B key pressed");
            //    }
            //);
            //Hotkey hk = new Hotkey();
            //hk.KeyCode = Keys.NumPad6;
            //hk.Windows = true;
            //hk.Pressed += delegate
            //{
            //    System.Media.SystemSounds.Beep.Play();
            //};
            //if (!hk.GetCanRegister())
            //{
            //    System.Windows.Forms.MessageBox.Show("Whoops, looks like attempts to register will fail or throw an exception, show an error / visual user feedback");
            //}
            //else
            //{
            //    hk.Register();
            //    System.Windows.Forms.MessageBox.Show("Registered hotkey!");
            //}
            //// .. later, at some point
            //if (hk.Registered)
            //{ hk.Unregister(); }
            //System.Windows.Forms.MessageBox.Show("Now registering hotkeys...");
            //AddHotKeys();
        }

        
    }
}
