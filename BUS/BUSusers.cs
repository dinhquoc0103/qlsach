using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;

namespace BUS
{
    public class BUSusers
    {
        DALusers dalUsers;
        DatabaseProvider db;

        public BUSusers()
        {
            dalUsers = new DALusers();
            db = new DatabaseProvider();
        }
        
        public bool checkLogin(users user)
        {
            bool result = dalUsers.checkExistRow(user, "login");
            dalUsers.closeConnect();
            return result;
        }

        public users getInfoUser(string email, string password)
        {
            users user = dalUsers.singleSelectRowUser(email, password);
            return user;
        }
    }
}
