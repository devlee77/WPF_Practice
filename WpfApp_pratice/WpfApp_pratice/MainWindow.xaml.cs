using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp_pratice
{
    

    public partial class MainWindow : Window
    {

        Cust c1;

        public MainWindow()
        {
            InitializeComponent();

            c1 = GetData();
            ViewData(c1);

            c1.PropertyChanged += C1_PropertyChanged;
        }

        private void C1_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //Debug.WriteLine("39:" + e.PropertyName);
            switch (e.PropertyName)
            {
                case "Name":
                    txt_name.Text = c1.Name; break;
                case "Age":
                    txt_age.Text = c1.Age.ToString(); break;
            }
        }

        private Cust GetData() 
        {
            Cust c = new Cust("홍길동", 27);
            return c;
        }

        private void ViewData(Cust c1)
        {
            txt_name.Text = c1.Name;
            txt_age.Text = c1.Age.ToString();
        }

        private void btn_year_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            int year = dt.Year - Convert.ToInt32(txt_age.Text) + 1;

            MessageBox.Show("당신의 출생년도는 : " + year.ToString() + " 입니다.");
        }

        private void btn_addage_Click(object sender, RoutedEventArgs e)
        {
            c1.Age++;
            //txt_age.Text = c1.Age.ToString();
        }
    }
}
