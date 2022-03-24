using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Dashboard1.Сlasses
{
    /// <summary>
    /// Логика взаимодействия для HotWater.xaml
    /// </summary>
    public partial class HotWater : UserControl, INotifyPropertyChanged
    {
        public HotWater()
        {
            InitializeComponent();
     Value = 160;
    DataContext = this;
        }
        private double _value;


        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        private void ChangeValueOnClick(object sender, RoutedEventArgs e)
        {
            Value = new Random().Next(0, 5010);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
