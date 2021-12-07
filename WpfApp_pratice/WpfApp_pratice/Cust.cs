using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_pratice
{
    public class Cust : INotifyPropertyChanged
    {
        private string name;
        private int age;

        public Cust() { }
        public Cust(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



        public string Name
        {
            get { return this.name; }
            set { this.name = value; Notify("Name"); }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; Notify("Age"); }
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        protected void Notify(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
