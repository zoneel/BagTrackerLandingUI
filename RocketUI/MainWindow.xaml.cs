using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

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
            if (animbool)
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

        public void buttonAnimation()
        {
            ColorAnimation bttnAnim = new ColorAnimation();
            bttnAnim.Duration = TimeSpan.FromSeconds(1);
            bttnAnim.To = Colors.Red;
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
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
            if (zm == true)
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

        Color gcolor = (Color)ColorConverter.ConvertFromString("#555862");
        Color greencolor = (Color)ColorConverter.ConvertFromString("#11691A");
        private void ShowLogin(object sender, RoutedEventArgs e)
        {

            DescContent.Visibility = Visibility.Collapsed;
            LoginContent.Visibility = Visibility.Visible;
            JoinContent.Visibility = Visibility.Collapsed;
            animation();

            joinus.Background = new SolidColorBrush(gcolor);
            learnmore.Background = new SolidColorBrush(gcolor);
            ShowModal.Background = new SolidColorBrush(greencolor);

        }

        private void LearnMore(object sender, RoutedEventArgs e)
        {
            DescContent.Visibility = Visibility.Visible;
            LoginContent.Visibility = Visibility.Collapsed;
            JoinContent.Visibility = Visibility.Collapsed;
            animation();

            joinus.Background = new SolidColorBrush(gcolor);
            learnmore.Background = new SolidColorBrush(greencolor);
            ShowModal.Background = new SolidColorBrush(gcolor);
        }


        private void hidetext(object sender, RoutedEventArgs e)
        {
            email.Text = string.Empty;
        }

        private void JoinUs(object sender, RoutedEventArgs e)
        {
            DescContent.Visibility = Visibility.Collapsed;
            LoginContent.Visibility = Visibility.Collapsed;
            JoinContent.Visibility = Visibility.Visible;
            joinus.Background = new SolidColorBrush(greencolor);
            learnmore.Background = new SolidColorBrush(gcolor);
            ShowModal.Background = new SolidColorBrush(gcolor);
            animation();
        }
    }
}
