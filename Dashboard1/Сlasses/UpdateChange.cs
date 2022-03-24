using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Сlasses
{
    public class UpdateChange
    {
        public static bool changeUser( string txbEmail,  string password, Housing_officeEntities db)

        {
            try
            {
                User user = db.User.Where(s => s.Email == txbEmail).FirstOrDefault();
                user.Email = txbEmail;
                user.Passowrd = password;

                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool changeuser(int RoleId, int id ,string secondName, string name, string lastName, string txbEmail, string password, string login, string telefon, Housing_officeEntities db)

        {
            try
            {
                User user = db.User.Where(s => s.ID_Пользователь == id).FirstOrDefault();
                user.Email = txbEmail;
                user.Passowrd = password;
                user.Login = login;
                user.Фамилия = secondName ; 
                user.Имя = name ;
                user.Отчество = lastName;
                user.ID_Тип_пользователя = RoleId;
                user.Телефон = telefon;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool changeUsers( string secondName, string name, string lastName, string txbEmail, string password, string login, string telefon, Housing_officeEntities db)

        {
            try
            {
                User user = db.User.Where(s => s.Имя == name).FirstOrDefault();
                user.Email = txbEmail;
                user.Passowrd = password;
                user.Login = login;
                user.Фамилия = secondName;
                user.Имя = name;
                user.Отчество = lastName;
                user.Телефон = telefon;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
