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

namespace EventAndCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.AddHandler(Window.MouseRightButtonDownEvent, new MouseButtonEventHandler(AboutDialog_MouseRightButtonDown), true);
            //this.AddHandler(ListBox.SelectionChangedEvent, new SelectionChangedEventHandler(ListBox_SelectionChanged));
            //this.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click));

            this.AddHandler(ListBox.SelectionChangedEvent, new SelectionChangedEventHandler(GenericHandler), true);
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(GenericHandler), true);
        }

        void AboutDialog_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {


            // Display information about this event
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " +
                e.OriginalSource.GetType().Name + " @ " + e.Timestamp;

            // In this example, all possible sources derive from Control
            Control source = e.Source as Control;
            // Toggle the border on the source control
            if (source.BorderThickness != new Thickness(5))
            {
                source.BorderThickness = new Thickness(5);
                source.BorderBrush = Brushes.Black;
            }
            else
            {
                source.BorderThickness = new Thickness(0);
            }
        }

        void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
                MessageBox.Show("You just selected " + e.AddedItems[0]);
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You just clicked " + e.Source);
        }

        void GenericHandler(object sender, RoutedEventArgs e)
        {
            if (e.RoutedEvent == Button.ClickEvent)
            {
                MessageBox.Show("You just clicked " + e.Source);
            }
            else if (e.RoutedEvent == ListBox.SelectionChangedEvent)
            {
                SelectionChangedEventArgs sce = (SelectionChangedEventArgs)e;
                if (sce.AddedItems.Count > 0)
                MessageBox.Show("You just selected " + sce.AddedItems[0]);
            }
        }
    }
}
