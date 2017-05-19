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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for AnimationView.xaml
    /// </summary>
    public partial class AnimationView : UserControl
    {
        public AnimationView()
        {
            InitializeComponent();


        }

        private void StartAnimation1(object sender, RoutedEventArgs e)
        {
            //// Define the animation
            DoubleAnimation a1 = new DoubleAnimation();
            a1.From = 50;
            a1.To = 100;

            //// Start animating
            b1.BeginAnimation(Button.WidthProperty, a1);


            // Define the animation
            DoubleAnimation a2 = new DoubleAnimation();
            a2.From = 50;
            a2.To = 100;
            a2.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            // Start animating
            b2.BeginAnimation(Button.WidthProperty, a2);


            // Define the animation
            DoubleAnimation a3 = new DoubleAnimation();
            a3.BeginTime = TimeSpan.Parse("0:0:5");
            a3.From = 50;
            a3.To = 100;
            a3.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            // Start animating
            b3.BeginAnimation(Button.WidthProperty, a3);


            // Define the animation
            DoubleAnimation a4 = new DoubleAnimation();
            a4.BeginTime = TimeSpan.Parse("-0:0:5");
            a4.From = 50;
            a4.To = 100;
            a4.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            // Start animating
            b4.BeginAnimation(Button.WidthProperty, a4);
        }

        private void StartAnimation2(object sender, RoutedEventArgs e)
        {
            DoubleAnimation a1 = new DoubleAnimation();
            a1.From = 50;
            a1.To = 100;
            a1.AccelerationRatio = 0.5;
            a1.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            t1.BeginAnimation(Button.WidthProperty, a1);

            DoubleAnimation a2 = new DoubleAnimation();
            a2.From = 50;
            a2.To = 100;
            a2.DecelerationRatio = 0.5;
            a2.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            t2.BeginAnimation(Button.WidthProperty, a2);

            DoubleAnimation a3 = new DoubleAnimation();
            a3.From = 50;
            a3.To = 100;
            a1.AccelerationRatio = 0.33;
            a1.DecelerationRatio = 0.33;
            a3.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            t3.BeginAnimation(Button.WidthProperty, a3);

            DoubleAnimation a4 = new DoubleAnimation();
            a4.From = 50;
            a4.To = 100;
            a4.AccelerationRatio = 0.33;
            a4.DecelerationRatio = 0.33;
            a4.Duration = new Duration(TimeSpan.Parse("0:0:5"));

            t4.BeginAnimation(Button.WidthProperty, a4);
        }
    }
}
