
    public class Attributes
    {
        public int Health { get; set; }
        public int Dexterity { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public Attributes(int health, int dexterity, int strength, int inteligence)
        {
            Health = health;
            Dexterity = dexterity;
            Strength = strength;
            Inteligence = inteligence;
        }
        public Attributes(){ }

        public static Attributes GetSummaryAttributes(User user)
        { 
            //This method return new Attributes object whith summary values (User attributes + all owned defItems attributes +  owned weapon attributes)
                int ChampionAttribute;
                
                int HelmetAttribute;
                int BodyArmorAttribute;
                int BottomAttribute;
                int RingAttribute;
                int GlovesAttribute;
                int DeffenceWeaponAttribute;
                int WeaponAttribute;

            //Protection
                    int SummaryProtection;
                    //Items
                    HelmetAttribute = user.ChampionSet.HelmetId.ItemProtection;
                    BodyArmorAttribute = user.ChampionSet.BodyArmorId.ItemProtection;
                    BottomAttribute = user.ChampionSet.BottomId.ItemProtection;
                    RingAttribute = user.ChampionSet.RingId.ItemProtection;
                    GlovesAttribute = user.ChampionSet.GlovesId.ItemProtection;
                    DeffenceWeaponAttribute = user.ChampionSet.DefenceWeaponId.ItemProtection;

                    SummaryProtection = HelmetAttribute + BodyArmorAttribute + BottomAttribute + RingAttribute + GlovesAttribute + DeffenceWeaponAttribute;
                    int SummaryHealth;
                    //Champion
                    ChampionAttribute = user.ChampionAttributes.Health;
                     //Items
                    HelmetAttribute = user.ChampionSet.HelmetId.ItemHealth;
                    BodyArmorAttribute = user.ChampionSet.BodyArmorId.ItemHealth;
                    BottomAttribute = user.ChampionSet.BottomId.ItemHealth;
                    RingAttribute = user.ChampionSet.RingId.ItemHealth;
                    GlovesAttribute = user.ChampionSet.GlovesId.ItemHealth;
                    DeffenceWeaponAttribute = user.ChampionSet.DefenceWeaponId.ItemHealth;
                    WeaponAttribute = user.ChampionSet.WeaponId.ItemHealth;
                    
                    SummaryHealth = ChampionAttribute + HelmetAttribute + BodyArmorAttribute + BottomAttribute + RingAttribute + GlovesAttribute 
                                    + DeffenceWeaponAttribute + WeaponAttribute;

            //Strength
                    int SummaryStrength;
                    //Champion
                    ChampionAttribute = user.ChampionAttributes.Strength;
                    //Items
                    HelmetAttribute = user.ChampionSet.HelmetId.ItemStrength;
                    BodyArmorAttribute = user.ChampionSet.BodyArmorId.ItemStrength;
                    BottomAttribute = user.ChampionSet.BottomId.ItemStrength;
                    RingAttribute = user.ChampionSet.RingId.ItemStrength;
                    GlovesAttribute = user.ChampionSet.GlovesId.ItemStrength;
                    DeffenceWeaponAttribute = user.ChampionSet.DefenceWeaponId.ItemStrength;
                    WeaponAttribute = user.ChampionSet.WeaponId.ItemStrength;
                    
                    SummaryStrength = ChampionAttribute + HelmetAttribute + BodyArmorAttribute + BottomAttribute + RingAttribute + GlovesAttribute 
                                    + DeffenceWeaponAttribute + WeaponAttribute;
            //Dexterity
                    int SummaryDexterity;
                    //Champion
                    ChampionAttribute = user.ChampionAttributes.Dexterity;
                    //Items
                    HelmetAttribute = user.ChampionSet.HelmetId.ItemDexterity;
                    BodyArmorAttribute = user.ChampionSet.BodyArmorId.ItemDexterity;
                    BottomAttribute = user.ChampionSet.BottomId.ItemDexterity;
                    RingAttribute = user.ChampionSet.RingId.ItemDexterity;
                    GlovesAttribute = user.ChampionSet.GlovesId.ItemDexterity;
                    DeffenceWeaponAttribute = user.ChampionSet.DefenceWeaponId.ItemDexterity;
                    WeaponAttribute = user.ChampionSet.WeaponId.ItemDexterity;
                    
                    SummaryDexterity = ChampionAttribute + HelmetAttribute + BodyArmorAttribute + BottomAttribute + RingAttribute + GlovesAttribute 
                                    + DeffenceWeaponAttribute + WeaponAttribute;
                
            //Intelligence
                    int SummaryInteligence;
                    //Champion
                    ChampionAttribute = user.ChampionAttributes.Inteligence;
                    //Items
                    HelmetAttribute = user.ChampionSet.HelmetId.ItemIntelligence;
                    BodyArmorAttribute = user.ChampionSet.BodyArmorId.ItemIntelligence;
                    BottomAttribute = user.ChampionSet.BottomId.ItemIntelligence;
                    RingAttribute = user.ChampionSet.RingId.ItemIntelligence;
                    GlovesAttribute = user.ChampionSet.GlovesId.ItemIntelligence;
                    DeffenceWeaponAttribute = user.ChampionSet.DefenceWeaponId.ItemIntelligence;
                    WeaponAttribute = user.ChampionSet.WeaponId.ItemIntelligence;
                    SummaryInteligence = ChampionAttribute + HelmetAttribute + BodyArmorAttribute + BottomAttribute + RingAttribute + GlovesAttribute 
                                    + DeffenceWeaponAttribute + WeaponAttribute;

            
                    return new Attributes((SummaryHealth+SummaryProtection),SummaryDexterity,SummaryStrength,SummaryInteligence);
        }
}

