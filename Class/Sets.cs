
    public class Sets
    {
       public DefItems ?HelmetId { get; set; }
       public DefItems ?BodyArmorId { get; set; }
       public DefItems ?GlovesId{ get; set; }
       public DefItems ?RingId{ get; set; }
       public DefItems ?BottomId{ get;set;}
       public WeaponItems ?WeaponId{ get; set; }
       public DefItems ?DefenceWeaponId{ get;set;}
       public Sets(DefItems helmetId, DefItems bodyArmorId, DefItems glovesId, DefItems ringId, DefItems bottomId, WeaponItems weapon, DefItems defenceWeapon)
       {
            HelmetId = helmetId;
            BodyArmorId = bodyArmorId;
            GlovesId = glovesId;
            RingId = ringId;
            BottomId = bottomId;
            WeaponId = weapon;
            DefenceWeaponId = defenceWeapon;
       }
       public Sets(){ }
    }
    

    class VolatileSets:Sets
    {
        //DefItems ID
       public int HelmetId{ get;set;}
       public int BodyArmorId { get; set; }
       public int GlovesId{ get; set; }
       public int RingId{ get; set; }
       public int BottomId{ get;set;}
       public int WeaponId{ get; set; }
       public int DefenceWeaponId{ get;set;} 
       //DefItems Level
       public int HelmetLevel { get; set;}
       public int BodyArmorLevel { get; set; }
       public int GlovesLevel { get;set;}
       public int RingLevel { get; set; }
       public int BottomLevel { get; set; }
       public int WeaponLevel { get;set; }
       public int DefenceWeaponLevel { get; set; }
       //DefItems Drop Type
       public float HelmetDropType { get; set; }
       public float BodyArmorDropType { get; set; }
       public float GlovesDropType { get; set; }
       public float RingDropType { get; set;}
       public float BottomDropType { get; set;}
       public float WeaponDropType { get; set; }
       public float DefenceWeaponDropType { get; set; }
       public Sets CreateStableSet()
       {
            dbAcces newSql = new dbAcces();

            int[] ItemsId = new int[7]{HelmetId,BodyArmorId,GlovesId,RingId,BottomId,WeaponId,DefenceWeaponId};
            int[] ItemsLevel = new int[7]{HelmetLevel,BodyArmorLevel,GlovesLevel,RingLevel,BottomLevel,WeaponLevel,DefenceWeaponLevel};
            float[] ItemsDropType = new float[7]{HelmetDropType,BodyArmorDropType,GlovesDropType,RingDropType,BottomDropType,WeaponDropType,DefenceWeaponDropType};

            Iitems item;
            Iitems[] ReadyDefItems = new Iitems[7];

            int index = 0;
            while(index<ItemsId.Length)
            {
                if(index == 5 )
                {
                    item = newSql.GetWeaponItem(ItemsId[index]);
                    WeaponItems weaponItm = (WeaponItems) item;
                    weaponItm.ItemDemageForce = (int)(weaponItm.ItemDemageForce * (ItemsLevel[index]*(0.01+1)) * ItemsDropType[index]);
                }
                else
                {
                    item = newSql.GetDefItem(ItemsId[index]);
                    DefItems defItm = (DefItems) item;
                    defItm.ItemProtection = (int)(defItm.ItemProtection * (ItemsLevel[index]*(0.01+1)) * ItemsDropType[index]);
                }

                item.ItemLevel = ItemsLevel[index];
                item.ItemDropType = ItemsDropType[index];
                item.ItemHealth = (int)(item.ItemHealth * (ItemsLevel[index]*0.01+1) * ItemsDropType[index]);
                item.ItemDexterity = (int)(item.ItemDexterity * (ItemsLevel[index]*0.01+1) * ItemsDropType[index]);
                item.ItemStrength = (int)(item.ItemStrength * (ItemsLevel[index]*0.01+1) * ItemsDropType[index]);
                item.ItemIntelligence = (int)(item.ItemIntelligence * (ItemsLevel[index]*0.01+1) * ItemsDropType[index]);
                ReadyDefItems[index] = item;
                index++;
            }
            Sets StableSet = new Sets
            (
                (DefItems)ReadyDefItems[0],
                (DefItems)ReadyDefItems[1],
                (DefItems)ReadyDefItems[2],
                (DefItems)ReadyDefItems[3],
                (DefItems)ReadyDefItems[4],
                (WeaponItems)ReadyDefItems[5],
                (DefItems)ReadyDefItems[6]
            );
            return StableSet;
        }
    }