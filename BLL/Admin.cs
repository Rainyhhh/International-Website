using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interwebsite.BLL
{
    public class Admin
    {
        public bool login(string username, string password)
        {
            DAL.Admin admin = new DAL.Admin();
            return admin.login(username,password);
        }
    }
}
