using FlowerShop.Database;
using FlowerShop.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlowerShop.Class
{
    class Authorization
    {
        public static bool AccsessCheck(string login,string password,string hide_password)
        {
            var data = FS.GetContext().User.ToList();
            var user = from users in data
                       where users.Login == login && (users.Password == password || users.Password == hide_password)
                       select users;

            if(user == null || user.FirstOrDefault() == null)
            {
                MessageBox.Show("Вы ввели неверный логин или пароль! Пожалуйста повторите ввод.");
                return false;
            }
            else
            {
                user.FirstOrDefault().LastEnter = new DateTime();
                Manager.MainFrame.Navigate(new Page_Sidebar());
                return true;
            }
        }
    }
}
