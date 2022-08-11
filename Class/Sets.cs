
    public class Sets
    {
       public DefItems ?HelmetId { get; set; }
       public DefItems ?BodyArmorId { get; set; }
       public DefItems ?GlovesId{ get; set; }
       public DefItems ?RingId{ get; set; }
       public DefItems ?BottomId{ get;set;}
       public WeaponItems ?Weapon{ get; set; }
       public DefItems ?DefenceWeapon{ get;set;}
       public Sets(DefItems helmetId, DefItems bodyArmorId, DefItems glovesId, DefItems ringId, DefItems bottomId, WeaponItems weapon, DefItems defenceWeapon)
       {
            HelmetId = helmetId;
            BodyArmorId = bodyArmorId;
            GlovesId = glovesId;
            RingId = ringId;
            BottomId = bottomId;
            Weapon = weapon;
            DefenceWeapon = defenceWeapon;
       }
       public Sets(){ }
    }
    

    class VolatileSets:Sets
    {
       public int HelmetId{ get;set;}
       public int BodyArmorId { get; set; }
       public int GlovesId{ get; set; }
       public int RingId{ get; set; }
       public int BottomId{ get;set;}
       public int Weapon{ get; set; }
       public int DefenceWeapon{ get;set;} 
       public Sets CreateStableSet()
       {
            dbAcces newSql = new dbAcces();
            Sets StableSet = new Sets
            (
                newSql.GetDefItem(this.HelmetId),
                newSql.GetDefItem(this.BodyArmorId),
                newSql.GetDefItem(this.GlovesId),
                newSql.GetDefItem(this.RingId),
                newSql.GetDefItem(this.BottomId),
                newSql.GetWeaponItem(this.Weapon),
                newSql.GetDefItem(this.DefenceWeapon)
            );
            return StableSet;
       }
    }