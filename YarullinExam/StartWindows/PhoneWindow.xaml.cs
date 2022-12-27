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
using System.Windows.Shapes;
using YarullinExam.DataBase;
using YarullinExam.AdminWindows;
using YarullinExam.StartWindows;

namespace YarullinExam.StartWindow
{
    /// <summary>
    /// Логика взаимодействия для PhoneWindow.xaml
    /// </summary>
    public partial class PhoneWindow : Window
    {
        public PhoneWindow()
        {
            InitializeComponent();
            ListPnones.ItemsSource = MainWindow.modelShop.Phone.ToList();
        }

        private void ListPnones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var phone = ListPnones.SelectedItem as Phone;
            BuyPhone buyphone = new BuyPhone();
            this.Close();
            buyphone.Show();
        }
    }
}
