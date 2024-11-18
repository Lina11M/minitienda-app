using Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Model;


namespace Logic
{
    public class UsersLog
    {
        UsersDat objUsers = new UsersDat();

        public DataSet showUsers()
        {
            return objUsers.showUsers();
        }


        public bool saveUsers(string _correo, string _contrasena, string _salt, string _estado)
        {
            return objUsers.saveUsers(_correo, _contrasena, _salt, _estado);
        }


        public bool updateUsers(int _idUsers, string _correo, string _contrasena, string _salt, string _estado)
        {
            return objUsers.updateUsers(_idUsers, _correo, _contrasena, _salt, _estado);

        }


        public bool deleteUsers(int _idUsers)
        {
            return objUsers.deleteUsers(_idUsers);

        }

        public UserMod showUserMail(string mail)
        {
            return objUsers.showUserMail(mail);
        }




    }
}