using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class DALusers : DatabaseProvider
    {

        public bool checkExistRow(users user, string options)
        {
            bool flag = false;
            if(options == "login")
            {
                try
                {
                    SqlDataReader dr = this.selectDataTable("users", " WHERE Email = '" + user.Email + "' AND Password = '" + user.Password + "' AND Status = 1");
                    while (dr.Read())
                    {
                        flag = true;
                    }
                }
                catch(Exception error)
                {
                    throw error;
                }
            }

            return flag;
        }

        public users singleSelectRowUser(string email, string password)
        {
            DataTable table = new DataTable();
            table.Load(this.selectDataTable("users", " WHERE Email = '" + email + "' AND Password = '" + password + "'"));
            DataRow infoUser = table.Rows[0];

            users user = new users();
            user.UserCode = infoUser[0].ToString();
            user.FullName = infoUser[1].ToString();
            user.Email = infoUser[2].ToString();
            user.Password = infoUser[3].ToString();
            user.Status = Convert.ToInt32(infoUser[4]);
            user.JoinDate = Convert.ToDateTime(infoUser[5]);

            return user;
        }

        public bool updateRowUser(users user, string valueUpdate = null, string options = null)
        {
            bool flag = false;
            if(options == "changePassword")
            {
                try
                {
                    string sql = "UPDATE users SET Password = '" + valueUpdate + "' WHERE UserCode = '" + user.UserCode + "'";
                    this.ExeCuteNonQuery(sql);
                    flag = true;
                }
                catch (Exception error)
                {
                    throw error;
                }
            }

            return flag;
            
        }
    }
}
