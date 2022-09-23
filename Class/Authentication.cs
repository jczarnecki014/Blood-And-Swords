using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


    static class Authentication
    {
        public static bool Start(string userName, string userPassword)
        {
            dbAcces newSql = new dbAcces();

            Cryptography ToHashedPassword = new Cryptography(userPassword,userName);
            
            if(ToHashedPassword.GetHash() == newSql.GetUserPassword(userName))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

