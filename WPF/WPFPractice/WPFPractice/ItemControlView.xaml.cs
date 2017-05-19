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
    public enum Gender
    {
        Male,
        Female
    }

    public class Record
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri Website { get; set; }
        public bool IsBillionaire { get; set; }
        public Gender Gender { get; set; }
    }

    /// <summary>
    /// Interaction logic for ItemControlView.xaml
    /// </summary>
    public partial class ItemControlView : UserControl
    {
        public ItemControlView()
        {
            InitializeComponent();
        }
    }
}
