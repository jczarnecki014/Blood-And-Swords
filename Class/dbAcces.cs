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
                VolatileUser volatileUser = connection.QuerySingle<VolatileUser>($"GetUser '{userName}'");
                return volatileUser.CreateStableUser();
            }
        }
        public Attributes GetUserAttributes(int attributesId)
        {
             using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                Attributes userAttributes = connection.QuerySingle<Attributes>($"GetUserAttributes '{attributesId}'");
                return userAttributes;
            }
        }

        public Stats GetUserStats(int statsId)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            { 
                Stats userStats = connection.QuerySingle<Stats>($"GetUserStats '{statsId}'");// tu ma byc procedura
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
                    defItem = connection.QuerySingle<DefItems>($"GetDefItem '{defItemId}'");
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
                     weaponItem = connection.QuerySingle<WeaponItems>($"GetWeaponItem '{weaponItemId}'");
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
                VolatileSets userSet = connection.QuerySingle<VolatileSets>($"GetUserSets '{setId}'");
                return userSet.CreateStableSet();
            }
        }

        public bool CheckUserExist(string name)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               bool userExist = connection.ExecuteScalar<bool>($"CheckUserExist '{name}'");
               return userExist;
            }
        }
        public void InsertNewUser(User user,string password)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
                connection.Execute($"InsertNewUser '{user.UserName}','{password}','{user.UserEmail}','{user.ChampionName}',{user.ChampionMoney},{user.ChampionLevel},{user.Avatar.AvatarId}," +
                $"{user.ChampionAttributes.Health},{user.ChampionAttributes.Dexterity},{user.ChampionAttributes.Strength},{user.ChampionAttributes.Inteligence}," +
                $"{user.ChampionStats.Wins},{user.ChampionStats.Lose},{user.ChampionStats.Fights}");
            }
        }
        public List<Avatar> GetAvatars()
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               List<Avatar>avatars = new List<Avatar>();
               List<VolatileAvatar> volatileAvatars = connection.Query<VolatileAvatar>("GetAvatars").ToList();
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
               VolatileAvatar volatileAvatars = connection.QuerySingle<VolatileAvatar>($"GetAvatar '{avatarId}'");
               return volatileAvatars.GetStableAvatar();
            }
        }
        public Skill GetAvatarSkill(int SkillId)
        {
             using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
             {
               Skill avatarSkill = connection.QuerySingle<Skill>($"GetAvatarSkill '{SkillId}'");
               return avatarSkill;
             }  
        }
        public List<Sounds> GetTracks()
        {
            using(IDbConnection connection = new SqlConnection(ConnectionStringHelper.CnnString("BasSql")))
            {
               List<Sounds>tracks = new List<Sounds>();
               tracks = connection.Query<Sounds>("GetSoundTracks").ToList();
               return tracks;
            }
        }
    }

