using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            AddHotKeys();            
        }

        private void AddHotKeys()
        {
            try
            {
                // NOTE: Only works when window is in focus...looking into global hotkey management instead
                RoutedCommand firstSettings = new RoutedCommand();
                firstSettings.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(firstSettings, HKShowWindow));

                RoutedCommand secondSettings = new RoutedCommand();
                secondSettings.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Alt));
                CommandBindings.Add(new CommandBinding(secondSettings, HKHideWindow));
            }
            catch (Exception err)
            {
                //handle exception error
            }
        }

        private void HKShowWindow(object sender, ExecutedRoutedEventArgs e)
        {
            //handler code goes here.
            System.Windows.Forms.MessageBox.Show("Alt+A key pressed");
            ShowWindow();
        }

        private void HKHideWindow(object sender, RoutedEventArgs e)
        {
            //handler code goes here.
            System.Windows.Forms.MessageBox.Show("Alt+B key pressed");
            App.Current.MainWindow.Close();
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
            MessageBox.Show("Hiding...");
            this.Hide();
            e.Cancel = true;
            Task.Delay(10000).ContinueWith(_ => ShowWindow());
        }

        private void ShowWindow()
        {
            MessageBox.Show("Showing...");
            // create a thread  
            Thread newWindowThread = new Thread(new ThreadStart(() =>
            {
                // create and show the window
                MainWindow obj = new MainWindow();
                obj.Show();
                obj.Focus();

                // start the Dispatcher processing  
                System.Windows.Threading.Dispatcher.Run();
            }));

            // set the apartment state  
            newWindowThread.SetApartmentState(ApartmentState.STA);

            // make the thread a background thread  
            newWindowThread.IsBackground = true;

            // start the thread  
            newWindowThread.Start();
            
        }
    }
}
