using RestourantDataAccess.Entities;
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
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public MainWindow MyProperty { get; set; }
        public SignUp()
        {
            InitializeComponent();
        }

        public SignUp(MainWindow myProperty)
        {
            InitializeComponent();
            MyProperty = myProperty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;
            string email = EmailTextBox.Text;
            string address = AddressTextBox.Text;
            string login = LoginTextBox.Text;
            string password = passwordBox.Password;
            int a = 5;
            a = 6;

            // Перевірка унікальності логіну та номера телефону
            if (DatabaseHelper.CheckIfLoginExists(login))
            {
                MessageBox.Show("Цей логін вже використовується. Будь ласка, виберіть інший логін.", "Помилка");
                return;
            }

            if (DatabaseHelper.CheckIfPhoneNumberExists(phoneNumber))
            {
                MessageBox.Show("Цей номер телефону вже використовується. Будь ласка, виберіть інший номер.", "Помилка");
                return;
            }

            // Створення об'єкта клієнта і додавання його в базу даних
            Client newClient = new Client
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNukmber = phoneNumber,
                Email = email,
                Address = address,
                Login = login,
                Password = password
            };

            DatabaseHelper.AddClientToDatabase(newClient);

            MessageBox.Show("Реєстрація успішно завершена!", "Успіх");
            TestWindow window = new TestWindow();
            window.Show();
            this.Close();
            MyProperty.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
