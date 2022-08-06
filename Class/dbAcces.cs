using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;


    class dbAcces
    {
        public string GetUserPassword(string userName)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
                string databasePassword = connection.ExecuteScalar<string>($"GetPassword '{userName}'");
                return databasePassword;
            }
        }
        public User GetUser(string userName)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                VolatileUser volatileUser = connection.QuerySingle<VolatileUser>($"select * From Users where UserName = '{userName}'"); // tu ma byc procedura
                return volatileUser.CreateStableUser();
            }
        }
        public Attributes GetUserAttributes(int attributesId)
        {
             using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                Attributes userAttributes = connection.QuerySingle<Attributes>($"select * From Attributes Where UserId = {attributesId}"); // tu ma byc procedura
                return userAttributes;
            }
        }

        public Stats GetUserStats(int statsId)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                Stats userStats = connection.QuerySingle<Stats>($"select * From Stats Where UserId = {statsId}");// tu ma byc procedura
                return userStats;
            }
        }
        public DefItems GetDefItem(int defItemId)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                DefItems defItem;
                try
                {
                    defItem = connection.QuerySingle<DefItems>($"select * From DefItems Where ItemId = {defItemId}");
                }
                catch (InvalidOperationException)
                {
                    defItem = new DefItems();
                }
                return defItem;
            }
        }

        public WeaponItems GetWeaponItem(int weaponItemId)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                WeaponItems weaponItem;
                try
                {
                     weaponItem = connection.QuerySingle<WeaponItems>($"select * From WeaponItem Where ItemId = {weaponItemId}");
                }
                catch (InvalidOperationException)
                {
                     weaponItem = new WeaponItems();
                }
                return weaponItem;
            }
        }

        public Sets GetUserSets(int setId)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                VolatileSets userSet = connection.QuerySingle<VolatileSets>($"select * From Sets Where UserId = {setId}");// tu ma byc procedura
                return userSet.CreateStableSet();
            }
        }
    }

