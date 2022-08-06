--Creating database
Create database BasSql;

--Creating tables
create table Users
(
	UserId int,
	UserName varchar(15),
	UserPassword varchar(25),
	UserEmail varchar(25),
	ChampionName varchar(25),
	ChampionMoney int,
	ChampionLevel int,
	ChampionAttributes int,
	ChampionStats int,
	ChampionSet int
	primary key (UserId)
);

create table Attributes
(
	UserId int,
	Health int,
	Dexterity int,
	Strength int,
	Durability int,
	Inteligence int
	primary key (UserId)
);

create table Stats
(
	UserId int,
	Wins int,
	Lose int,
	Fights int
	primary key (UserId)
);

create table Sets
(
	UserId int,
	HelemtId int,
	BodyArmorID int,
	GlovesId int,
	RingId int,
	BottomId int,
	Weapon int,
	DefenceWeapon int
	primary key (UserId)
);

create table DefItems
(
	ItemId int,
	ItemName varchar(50),
	ItemCategory varchar(20),
	ItemDescribe varchar(255),
	ItemImgSrc varchar(100),
	ItemProtection int,
	ItemHealth int,
	ItemDexterity int,
	ItemStrength int,
	ItemIntelligence int,
	primary key (ItemId)
);


create table DefItemAbility
(
	IdProtection int,
	ProtectionName varchar(20),
	ProtectionDescribe varchar(255),
	PRIMARY KEY (IdProtection)
);

-- INSERTS--

Insert into dbo.DefItemAbility VALUES 
(1,'Fire Protection','This abilities gives your item special forces witch can protect your body from weapons dealing fire damage'),
(2,'Swords Protection','Your armor was forged by a dark blacksmitch whos bestow your item special magic layer witch make your item more protected from swords'),
(3,'Magic Protection','Your item was improve by the highest council of shamans. The Leged says that in this item will awakes part of the power of these shamans'),
(4,'Arrow Protection','This item was improve by Druids from the southern forests, they used a  special thread and created  additialonal layer with will protect you before arrow during fight');

Insert into dbo.DefItems VALUES 
(1,'Bleassed Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Bleassed_Armor.png',1500, 6700, 210, 290, 210),
(2,'Dragon Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Dragon_Armor.png', 1200, 5200, 61, 210, 210),
(3,'Forest Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Forest_Armor.png', 800, 5200, 360, 30, 30),
(4,'Guar Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Guar_Armor.png', 500, 3600, 50, 160, 50),
(5,'Leather Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Leather_Armor.png', 150, 2200, 50,80,50),
(6,'Magic Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Magic_Armor.png', 800, 4200, 60, 30, 420),
(7,'Strengthened Leather Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Strengthened_Leather_Armor.png', 300, 3200, 80,120,80),
(8,'troll armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\troll_armor.png', 800, 4300,20,200,50);


--Creating procedures 

create procedure dbo.GetPassword
	@EnteredUserName varchar(25)
as
begin
	select UserPassword From dbo.Users Where UserName = @EnteredUserName;
end

