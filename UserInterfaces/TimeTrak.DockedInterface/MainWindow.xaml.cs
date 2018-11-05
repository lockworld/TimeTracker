using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsAppBar;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace TimeTrak.DockedInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private bool HamburgerMouseClicked = false;
        public MainWindow()
        {
            InitializeComponent();

            DockPosition.ItemsSource = new[]
            {
                AppBarDockMode.Left,
                AppBarDockMode.Right,
                AppBarDockMode.Top,
                AppBarDockMode.Bottom
            };
            DockMonitor.ItemsSource = MonitorInformation.GetAllMonitors();
            DockMonitor.SelectedItem = MonitorInformation.GetAllMonitors().Where(m => m.IsPrimary).FirstOrDefault();

            AppMenu.Background = SystemColors.ActiveBorderBrush;
            AppMenuName.Content = this.Title;
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ThumbControl_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            double delta;
            switch (DockMode)
            {
                case AppBarDockMode.Left:
                    delta = e.HorizontalChange * -1;
                    break;
                case AppBarDockMode.Right:
                    delta = e.HorizontalChange * -1;
                    break;
                case AppBarDockMode.Top:
                    delta = e.VerticalChange * -1;
                    break;
                case AppBarDockMode.Bottom:
                    delta = e.VerticalChange * -1;
                    break;
                default: throw new NotSupportedException();
            }

            
            this.DockedWidthOrHeight += (int)(delta / VisualTreeHelper.GetDpi(this).PixelsPerDip);

            // TODO...store last used width and set width or height to the appropriate saved value.
        }

        private void AppMenu_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //Border sp = sender as Border;
            //DoubleAnimation db = new DoubleAnimation();
            ////db.From = 12;
            //db.To = 125;
            //db.Duration = TimeSpan.FromSeconds(0.5);
            //db.AutoReverse = false;
            //db.RepeatBehavior = new RepeatBehavior(1);
            //sp.BeginAnimation(StackPanel.HeightProperty, db);

        }
        private void HamburgerMouseDown(object sender, System.Windows.Input.MouseEventArgs e)
        {
            HamburgerMouseClicked = true;
        }
        private void AppMouseUp(object sender, System.Windows.Input.MouseEventArgs e)
        {
            HamburgerMouseClicked = false;
        }
        private void AppMenu_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //Border sp = sender as Border;
            //DoubleAnimation db = new DoubleAnimation();
            ////db.From = 12;
            //db.To = 25;
            //db.Duration = TimeSpan.FromSeconds(0.5);
            //db.AutoReverse = false;
            //db.RepeatBehavior = new RepeatBehavior(1);
            //sp.BeginAnimation(StackPanel.HeightProperty, db);

        }
        private void HamburgerMouseUp(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(HamburgerMouseClicked)
            {
                if(AppMenu.Height==25)
                {
                    ShowAppMenu();
                    HamburgerMenu.Visibility = Visibility.Collapsed;
                    CloseMenu.Visibility = Visibility.Visible;
                }
                else
                {
                    HideAppMenu();
                    HamburgerMenu.Visibility = Visibility.Visible;
                    CloseMenu.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void ShowAppMenu()
        {
            Border sp = AppMenu as Border;
            DoubleAnimation db = new DoubleAnimation();
            //db.From = 12;
            db.To = 125;
            db.Duration = TimeSpan.FromSeconds(0.5);
            db.AutoReverse = false;
            db.RepeatBehavior = new RepeatBehavior(1);
            sp.BeginAnimation(StackPanel.HeightProperty, db);
        }
        private void HideAppMenu()
        {
            Border sp = AppMenu as Border;
            DoubleAnimation db = new DoubleAnimation();
            //db.From = 12;
            db.To = 25;
            db.Duration = TimeSpan.FromSeconds(0.5);
            db.AutoReverse = false;
            db.RepeatBehavior = new RepeatBehavior(1);
            sp.BeginAnimation(StackPanel.HeightProperty, db);
        }
    }
}
