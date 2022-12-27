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
using YarullinExam.DataBase;
using YarullinExam.StartWindow;
using YarullinExam.AdminWindows;

namespace YarullinExam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static web20Entities modelShop = new web20Entities();
        public User authUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            int b = 0;
            if (string.IsNullOrWhiteSpace(LoginTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Password))
            {
                MessageBox.Show($"Ошибка, заполните все поля ввода.");
            }
            else
            {
                foreach (var user in modelShop.User)
                {
                    if (user.Login == LoginTB.Text.Trim() && user.Password == PasswordTB.Password.Trim() && user.IdRole == 2)
                    {
                        b++;
                        MessageBox.Show($"Добро пожаловать в приложение {user.FIO}");
                        authUser = user;
                        PhoneWindow phonewin = new PhoneWindow();
                        this.Close();
                        phonewin.Show();
                    }
                    if (user.Login == LoginTB.Text.Trim() && user.Password == PasswordTB.Password.Trim() && user.IdRole == 1)
                    {
                        b++;
                        MessageBox.Show($"Добро пожаловать в приложение {user.FIO}");
                        authUser = user;
                        AddUserWindow adduser = new AddUserWindow();
                        this.Close();
                        adduser.Show();
                    }
                }
                if (b == 0)
                {
                    MessageBox.Show($"Неверный логин или пароль. Попробуйте еще раз.");
                }
            }
        }
    }
}
