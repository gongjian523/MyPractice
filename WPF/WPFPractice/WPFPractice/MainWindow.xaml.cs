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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PanelView panelView = new PanelView();
        private EventAndCommandView eventAndCommandView = new EventAndCommandView();
        private ContentControlView contentControlView = new ContentControlView();
        private ItemControlView itemControlView = new ItemControlView();
        private AnimationView animationView = new AnimationView();
        private CustomizedControlView customizedControlView = new CustomizedControlView();
        private TemplateView templateView = new TemplateView();

        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(panelView);
        }

        private void EnterPanel(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(panelView);
        }

        private void EnterEventAndCommand(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(eventAndCommandView);
        }

        private void EnterContentControl(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(contentControlView);
        }


        private void EnterItemControl(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(itemControlView);
        }

        private void EnterAnimation(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(animationView);
        }

        private void EnterCustomizedControl(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(customizedControlView);
        }

        private void EnterTemplate(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(templateView);
        }
    }
}
