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

namespace ClientApp
{
    
    public partial class Login : Window
    {
        public MainWindow mainWindow { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        public Login(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            // Перевірка, чи існує користувач з введеним логіном та паролем
            if (DatabaseHelper.CheckCredentials(login, password))
            {
                MessageBox.Show("Ви успішно увійшли в акаунт!", "Успіх");
            }
            else
            {
                MessageBox.Show("Логін або пароль не вірні. Будь ласка, перевірте ваші дані та спробуйте знову.", "Помилка");
            }
            TestWindow testWindow = new TestWindow();
            testWindow.Show();
            this.Close();
            mainWindow.Close();
        }

    }
}
