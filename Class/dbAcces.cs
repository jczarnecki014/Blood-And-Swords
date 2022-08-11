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

        public bool CheckUserExist(string name)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               bool userExist = connection.ExecuteScalar<bool>($"select count(UserEmail) from Users where UserEmail='{name}' OR UserName = '{name}'");
               return userExist;
            }
        }
        public void InsertNewUser(User user,string password)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               connection.Execute($"Insert into dbo.Users Values ('{user.UserName}','{password}','{user.UserEmail}','{user.ChampionName}'," +
               $"{user.ChampionMoney},{user.ChampionLevel},{user.Avatar.AvatarId})"); //add new user to table

               int UserId = (connection.QuerySingle<int>($"select UserId from Users where UserName = '{user.UserName}'"));

               connection.Execute($"Insert into dbo.Attributes Values ({UserId},{user.ChampionAttributes.Health},{user.ChampionAttributes.Dexterity}," +
               $"{user.ChampionAttributes.Strength}, {user.ChampionAttributes.Inteligence})");//add attributes record

               connection.Execute($"Insert into dbo.Stats Values ({UserId} , {user.ChampionStats.Wins} , {user.ChampionStats.Lose} , {user.ChampionStats.Fights})"); // add stats record

               connection.Execute($"Insert into dbo.Sets(UserId) Values ({UserId})"); // add Sets record
            }
        }
        public List<Avatar> GetAvatars()
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               List<Avatar>avatars = new List<Avatar>();
               List<VolatileAvatar> volatileAvatars = connection.Query<VolatileAvatar>("Select * From dbo.Avatars").ToList();
               foreach(VolatileAvatar avatar in volatileAvatars)
               {
                   avatars.Add(avatar.GetStableAvatar());
               }
               return avatars;
            }
        }

        public Avatar GetAvatar(int avatarId)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               MessageBox.Show(avatarId.ToString());
               VolatileAvatar volatileAvatars = connection.QuerySingle<VolatileAvatar>($"Select * From dbo.Avatars WHERE AvatarId = {avatarId}");
               return volatileAvatars.GetStableAvatar();
            }
        }
        public Skill GetAvatarSkill(int SkillId)
        {
             using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
             {
               Skill avatarSkill = connection.QuerySingle<Skill>($"Select * From dbo.Skills Where SkillId = {SkillId}");
               return avatarSkill;
             }  
        }
    }

