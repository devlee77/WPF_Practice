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

namespace WpfApp_practice5
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
        Window1 win1 = null;
        private void Button_Click(object sender, RoutedEventArgs e)

        {
            if (win1 == null)
            {
                win1 = new Window1();
                win1.OnchildTextnputEvent += new Window1.OnchildTextnputHandler(win1_OnchildTextnputEvent);
                win1.Show();
            }

        }

        void win1_OnchildTextnputEvent(string parameters)
        {
            textBlock.Text = parameters;
            if (win1 != null)
            {
                win1.Close();
                win1.OnchildTextnputEvent -= new Window1.OnchildTextnputHandler(win1_OnchildTextnputEvent);
                win1 = null;
            }
        }
    }
}
