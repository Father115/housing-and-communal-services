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

namespace Dashboard1.Сlasses
{
    /// <summary>
    /// Логика взаимодействия для ДанныеКвартиры.xaml
    /// </summary>
    public partial class ДанныеКвартиры : Page
    {
   
        public ДанныеКвартиры()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //   Housing_officeEntities db = new Housing_officeEntities();
            //   Rate rate;
            // rate.ID_Тариф = holod;
            //  rate.ID_Тариф = red;
            //  rate.ID_Тариф = energ;
            //  rate.ID_Тариф = heating;

            int Pot;
            int P;
            int P1;
            int Pc;
            int Sum;

           int holod = 29;
           int red = 30;
           int energ = 2;
           int heating = 778;
   

            Pot = (int)(heating * Convert.ToDecimal(Heating.Text));
            P = (int)(Convert.ToDouble(Xolod.Text) * holod);
            P1 = (int)(Convert.ToDouble(Hot.Text) * red);
            Pc = (int)(Convert.ToDouble(Energy.Text) * energ);
           Sum = Pot + P + P1 + Pc ;
            Copy.Text = Convert.ToString(Sum);

        }
    
    }
}
