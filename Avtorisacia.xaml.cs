using Primer.Classes;
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

namespace Primer
{
    
    public partial class Avtorisacia : Window
    {
        private List <User> users;
        public Avtorisacia()
        {
            InitializeComponent();
            users = new List<User>();
            users.Add(new User("админ", "admin", "qwerty"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (emailBox.Text!=null&& passwordBox.Password!= null)
            {
                foreach (User user in users)
                {
                    if (user.email.Equals(emailBox.Text) && user.password.Equals(passwordBox.Password))
                    {
                        UserPage userPage = new UserPage();
                        userPage.Show();
                        this.Close();
                    }
                }
                textExeptione.Text = "Неверный логин или пароль";
                passwordBox.BorderBrush = new SolidColorBrush(Colors.Red);
                emailBox.BorderBrush = new SolidColorBrush(Colors.Red);

            }
        }
    }
}
