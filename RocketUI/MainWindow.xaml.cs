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
using System.Windows.Media.Animation;
using System.Security.Cryptography.X509Certificates;

namespace RocketUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        bool animbool = true;

        public void animation()
        {
            if(animbool)
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.Duration = TimeSpan.FromSeconds(2);
                //animation.From = longas.Width;
                animation.To = up2.Width - 70;
                Storyboard.SetTargetName(animation, "up2");
                Storyboard.SetTargetName(animation, "up2");
                Storyboard.SetTargetName(animation, "up3");
                Storyboard.SetTargetName(animation, "up4");
                Storyboard.SetTargetName(animation, "up3");
                Storyboard.SetTargetProperty(animation, new PropertyPath(Border.WidthProperty));
                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(animation);
                storyboard.Begin(this);
                animbool = false;
            }
            else
            {
                DoubleAnimation animation = new DoubleAnimation();
                animation.Duration = TimeSpan.FromSeconds(2);
                //animation.From = longas.Width;
                animation.To = up2.Width + 70;
                Storyboard.SetTargetName(animation, "up2");
                Storyboard.SetTargetName(animation, "up2");
                Storyboard.SetTargetName(animation, "up3");
                Storyboard.SetTargetName(animation, "up4");
                Storyboard.SetTargetName(animation, "up3");
                Storyboard.SetTargetProperty(animation, new PropertyPath(Border.WidthProperty));
                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(animation);
                storyboard.Begin(this);
                animbool = true;
            }
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void closeApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        bool zm = true;
        private void Maximize(object sender, RoutedEventArgs e)
        {
            if(zm == true)
            {
                this.WindowState = WindowState.Maximized;
                zm = false;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                zm = true;
            }

        }

        private void ShowLogin(object sender, RoutedEventArgs e)
        {
            DescContent.Visibility = Visibility.Collapsed;  
            LoginContent.Visibility = Visibility.Visible;
            animation();
        }

        private void LearnMore(object sender, RoutedEventArgs e)
        {
            DescContent.Visibility = Visibility.Visible;
            LoginContent.Visibility = Visibility.Collapsed;
            animation();
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void hidetext(object sender, RoutedEventArgs e)
        {
            username.Text = string.Empty;
        }

        private void JoinUs(object sender, RoutedEventArgs e)
        {
            animation();
        }
    }
}
