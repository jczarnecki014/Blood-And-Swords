
    public class User
    {
        public int UserId{ get; set; }
        public string UserName{ get; set; }
        public string UserEmail { get;set;}
        public string ChampionName { get; set; }
        public int ChampionMoney { get; set; }
        public int ChampionLevel { get; set; }
        public Attributes ChampionAttributes{get;set;} 
        public Stats ChampionStats { get; set; } // tu ma być klasa stats
        public Sets ChampionSet { get; set;} // tu ma być klasa sets
        public User(int userId, string userName, string userEmail, string championName, int championMoney, int championLevel, Attributes championAttributes, Stats championStats, Sets championSet)
        {
            UserId = userId;
            UserName = userName;
            UserEmail = userEmail;
            ChampionName = championName;
            ChampionMoney = championMoney;
            ChampionLevel = championLevel;
            ChampionAttributes = championAttributes;
            ChampionStats = championStats;
            ChampionSet = championSet;
        }
        public User()
        {

        }
}
    
    class VolatileUser:User
    {
        public int ChampionAttributes{ get;set;}
        public int ChampionStats { get; set; }
        public int ChampionSet { get; set; }
        public User CreateStableUser()
        {     
           dbAcces newSql = new dbAcces();
           Attributes champAttributes = newSql.GetUserAttributes(this.ChampionAttributes);
           Stats champStats = newSql.GetUserStats(this.ChampionStats);
           Sets ChampionSet = newSql.GetUserSets(this.ChampionSet);

           User StableUser = new User(
                this.UserId,
                this.UserName,
                this.UserEmail,
                this.ChampionName,
                this.ChampionMoney,
                this.ChampionLevel,
                champAttributes,
                champStats,
                ChampionSet
           );
           return StableUser;
        }
    }

