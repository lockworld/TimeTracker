using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeTrak.WindowsApp.Features;

namespace TimeTrak.WindowsApp
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string localDB;
        public MainWindow()
        {
            localDB = Properties.Settings.Default.LocalDB;
            InitializeComponent();

            var key = new HotKey(
                (ModifierKeys.Alt),
                Key.A,
                this,
                delegate
                {
                    ShowMainWindow();
                }
            );
        }

        private static void ShowMainWindow()
        {
            App.Current.MainWindow.Show();
            App.Current.MainWindow.Focus();
            System.Media.SystemSounds.Asterisk.Play();
            System.Windows.Forms.MessageBox.Show("Alt+B key pressed");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.LocalDB = textBox.Text;
            //Properties.Settings.Default.Var2 = textBox.Text;
            Properties.Settings.Default.Save();
            //textBox.Text = Properties.Settings.Default.LocalDB;
            TimeTrak.WindowsApp.Windows.Configuration cfg = new TimeTrak.WindowsApp.Windows.Configuration();
            cfg.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
