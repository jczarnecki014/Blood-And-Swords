
    public class User
    {
        public int UserId { get; set; }
        public string UserName{ get; set; }
        public string UserEmail { get;set;}
        public string ChampionName { get; set; }
        public int ChampionMoney { get; set; }
        public int ChampionLevel { get; set; }
        public Attributes ChampionAttributes{get;set;} 
        public Stats ChampionStats { get; set; } // tu ma być klasa stats
        public Sets ChampionSet { get; set;} // tu ma być klasa sets
        public Avatar Avatar { get; set; }
        public User(string userName, string userEmail, string championName, int championMoney, int championLevel, Attributes championAttributes, Stats championStats, Sets championSet, Avatar avatar)
        {
            UserName = userName;
            UserEmail = userEmail;
            ChampionName = championName;
            ChampionMoney = championMoney;
            ChampionLevel = championLevel;
            ChampionAttributes = championAttributes;
            ChampionStats = championStats;
            ChampionSet = championSet;
            Avatar = avatar;
        }
        public User()
        {

        }
}
    
    class VolatileUser:User
    {
        public int AvatarId { get;set;}
        public User CreateStableUser()
        {     
           dbAcces newSql = new dbAcces();
           Attributes champAttributes = newSql.GetUserAttributes(this.UserId);
           Stats champStats = newSql.GetUserStats(this.UserId);
           Sets ChampionSet = newSql.GetUserSets(this.UserId);
           Avatar StableAvatar =newSql.GetAvatar(AvatarId);

           User StableUser = new User(
                this.UserName,
                this.UserEmail,
                this.ChampionName,
                this.ChampionMoney,
                this.ChampionLevel,
                champAttributes,
                champStats,
                ChampionSet,
                StableAvatar
           );
           return StableUser;
        }
    }

