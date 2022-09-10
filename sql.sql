--Creating database
Create database BasSql;

--Creating tables
create table Users
(
	UserId int IDENTITY(1,1),
	UserName varchar(50),
	UserPassword varchar(50),
	UserEmail varchar(50),
	ChampionName varchar(50),
	ChampionMoney int,
	ChampionLevel int,
	AvatarId int,
	primary key (UserId)
);

create table Attributes
(
	UserId int,
	Health int,
	Dexterity int,
	Strength int,
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
	HelmetId int,
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
	ItemId int IDENTITY(1,1),
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
	IdProtection int IDENTITY(1,1),
	ProtectionName varchar(20),
	ProtectionDescribe varchar(255),
	PRIMARY KEY (IdProtection)
);

create table WeaponItem
(
	ItemId int IDENTITY(1,1),
	ItemName varchar(50),
	ItemDescribe varchar(255),
	ItemImgSrc varchar(50),
	ItemDemageForce int,
	ItemHealth int,
	ItemDexterity int,
	ItemStrength int,
	ItemInteligence int,
	ItemRequireLevel int,
	PRIMARY KEY (ItemId)
);

Create table Avatars
(
	AvatarId int IDENTITY(1,1),
	AvatarImgSrc varchar(100),
	AvatarName varchar(80),
	AvatarStory varchar(1000),
	AvatarSkillOne int,
	AvatarSkillTwo int,
	AvatarSkillThree int,
	Primary key (AvatarId)
);

Create table Skills
(
	SkillId int IDENTITY(1,1),
	SkillName varchar(50),
	SkillDescription varchar(1500),
	SkillImgSrc varchar(50),
	SkillForceCategory varchar(50),
	SkillForce float
);

-- INSERTS--

Insert into dbo.DefItemAbility VALUES 
('Fire Protection','This abilities gives your item special forces witch can protect your body from weapons dealing fire damage'),
('Swords Protection','Your armor was forged by a dark blacksmitch whos bestow your item special magic layer witch make your item more protected from swords'),
('Magic Protection','Your item was improve by the highest council of shamans. The Leged says that in this item will awakes part of the power of these shamans'),
('Arrow Protection','This item was improve by Druids from the southern forests, they used a  special thread and created  additialonal layer with will protect you before arrow during fight');

Insert into dbo.DefItems VALUES 
--BodyArmors
('Bleassed Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Bleassed_Armor.png',1500, 6700, 210, 290, 210),
('Dragon Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Dragon_Armor.png', 1200, 5200, 61, 210, 210),
('Forest Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Forest_Armor.png', 800, 5200, 360, 30, 30),
('Guard Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Guard_Armor.png', 500, 3600, 50, 160, 50),
('Leather Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Leather_Armor.png', 150, 2200, 50,80,50),
('Magic Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Magic_Armor.png', 800, 4200, 60, 30, 420),
('Strengthened Leather Armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\Strengthened_Leather_Armor.png', 300, 3200, 80,120,80),
('Troll armor','BodyArmor','the will be some desciption','\IMG\DefItems\Armors\troll_armor.png', 800, 4300,20,200,50),
--Boots
('Buty Calvina','Boots','the will be some desciption','\IMG\DefItems\Boots\Celvins_boots.jpg', 600, 2500,20,180,110),
('Smocze buty','Boots','the will be some desciption','\IMG\DefItems\Boots\Dragon_boots.png', 800, 3000,40,200,230),
('Złote sandały','Boots','the will be some desciption','\IMG\DefItems\Boots\Gold_Sandal.png', 400, 1900,230,100,220),
('Buty myśliwskie','Boots','the will be some desciption','\IMG\DefItems\Boots\Hunter_Boots.png', 300, 800,150,100,100),
('Buty skórzane','Boots','the will be some desciption','\IMG\DefItems\Boots\Leather_Boots.png', 100, 300,70,100,100),
('Ulepszone buty skórzane','Boots','the will be some desciption','\IMG\DefItems\Boots\Improve_Leather_Boots.png', 350, 430,135,150,140),
('Buty królewskiego strażnika','Boots','the will be some desciption','\IMG\DefItems\Boots\KingdomGuard_boots.png', 574, 2250,120,213,60),
('Buty paladyna','Boots','the will be some desciption','\IMG\DefItems\Boots\Paladin_boots.png', 600, 2510,90,240,150),
--Gloves
('Żelazne rękawice','Gloves','the will be some desciption','\IMG\DefItems\Gloves\Iron_gloves.jpg', 230, 230,75,75,75),
('Rękawice krasnoluda','Gloves','the will be some desciption','\IMG\DefItems\Gloves\Dwarf_gloves.jpg', 480, 800,20,150,50),
('Rękawice zręczności','Gloves','the will be some desciption','\IMG\DefItems\Gloves\Dexterity_gloves.jpg', 480, 800,250,50,50),
('Rękawice Króla','Gloves','the will be some desciption','\IMG\DefItems\Gloves\King_gloves.jpg', 540, 1200,110,216,176),
('Magiczne rękawice króla','Gloves','the will be some desciption','\IMG\DefItems\Gloves\Magic_king_gloves.jpg', 540, 1500,140,256,226),
('Rękawice paladyna','Gloves','the will be some desciption','\IMG\DefItems\Gloves\Paldin_gloves.jpg', 480, 1000,80,160,130),
('Rękawice łucznika','Gloves','the will be some desciption','\IMG\DefItems\Gloves\scout_gloves.jpg', 300, 600,190,50,40),
('Rękawice czarnoksiężnika','Gloves','the will be some desciption','\IMG\DefItems\Gloves\Wizard_magic_gloves.jpg', 300, 800,50,30,295),
--Helmets
('Hełm krasnoluda','Helmet','the will be some desciption','\IMG\DefItems\Helmets\dwarf_helemet.jpg', 300, 500,40,120,70),
('Hełm strażnika leśnego','Helmet','the will be some desciption','\IMG\DefItems\Helmets\Forest_guard_helemet.jpg', 600, 1100,150,150,150),
('Złoty hełm gladiatora','Helmet','the will be some desciption','\IMG\DefItems\Helmets\Golden_gladiator_helemet.jpg', 800, 1600,60,170,80),
('Wojenny żelazny hełm','Helmet','the will be some desciption','\IMG\DefItems\Helmets\Iron_war_helmet.jpg', 600, 1300,70,150,40),
('Królewski hełm','Helmet','the will be some desciption','\IMG\DefItems\Helmets\King_helmet.jpg', 900, 2200,80,190,170),
('Magicznie wzmocniony hełm','Helmet','the will be some desciption','\IMG\DefItems\Helmets\Magic_power_helemet.jpg', 500, 1100,80,40,150),
('Hełm rodu szamnów','Helmet','the will be some desciption','\IMG\DefItems\Helmets\shaman_helemet.jpg', 500, 1400,50,60,130),
('Hełm sparty','Helmet','the will be some desciption','\IMG\DefItems\Helmets\spartan_helemet.jpg', 700, 1700,90,150,10),
--Ring
('Pierścień zręczności','Ring','the will be some desciption','\IMG\DefItems\Ring\dexterity_ring.jpg', 50, 10,180,10,10),
('Ognisty pierścień','Ring','the will be some desciption','\IMG\DefItems\Ring\fire_ring.jpg', 100, 25,60,120,120),
('Pierścień życia','Ring','the will be some desciption','\IMG\DefItems\Ring\life_ring.jpg', 100, 150,10,10,20),
('Magiczny pierścień','Ring','the will be some desciption','\IMG\DefItems\Ring\magic_ring.jpg', 100, 10,10,10,150),
('Pierścień wody','Ring','the will be some desciption','\IMG\DefItems\Ring\wather_ring.jpg', 100, 70,80,100,110),
--shield
('Smocza tarcza','Shield','the will be some desciption','\IMG\DefItems\Ring\Dragon_shield.jpg', 900, 1700,110,200,160),
('Tarcza krasnoluda','Shield','the will be some desciption','\IMG\DefItems\Ring\Dwraf_shield.jpg', 500, 700,70,130,50),
('Tarcza gladiatora','Shield','the will be some desciption','\IMG\DefItems\Ring\Gladiator_shield.jpg', 700, 700,30,140,50),
('Tarcza Paladyna','Shield','the will be some desciption','\IMG\DefItems\Ring\Paladin_shield.jpg', 500, 1000,80,170,150),
('Wzmocniona tarcza','Shield','the will be some desciption','\IMG\DefItems\Ring\Strengthened_shield.jpg', 180, 125,50,70,25),
('Zwykła tarcza','Shield','the will be some desciption','\IMG\DefItems\Ring\Usual_shield.jpg', 130, 110,40,50,25),
('Tarcza z roga trola','Shield','the will be some desciption','\IMG\DefItems\Ring\Troll_shield.jpg', 550, 610,70,120,50);

Insert into Avatars 
Values 
('Wizz1.png','Czarownica','Zmysłowa i kobieca - z pewnością zawróci w głowie niejednemu mężczyźnie, lecz strzeż się! Czarownica włada najpotężniejszymi, siejącymi zamęt i zniszczenie magicznymi zdolnościami i wykorzystuje do własnych celów potężne siły czarnej energii',1,2,3),
('Guard1.png','Wyklęty Rycerz','Charakteryzują go szczególne zasady postępowania. Niekiedy bardzo honorowe, innym razem tak godne pożałowania, że został wygnany przez samego Władcę Ursbarduru. Przemierza Królestwa w poszukiwaniu szczęścia, bogactwa i wrażeń. Nie można mu także odmówić silnych morale, sprytu oraz umiejętności zastraszania i prowokowania. Wzór cnót.',4,5,6),
('Scout1.png','Mówca','Niech Cię nie zwiedzie powierzchowność tego młodego Elfa, pomimo anemicznego wyglądu i skromnej postury jego najcięższym orężem jest umysł. Inteligencja i zdolności psychokinetyczne dają mu przewagę nad tęgimi osiłkami i zbyt pewnymi siebie arogantami, pękającymi jak krwawe bańki mydlane od jednego pstryknięcia palcem.
Jedyne co może zakłócić jego moc to ... kobieta.',22,23,24),
('Wizz2.png','Druid','Jest starcem od zawsze, odkąd tylko sięga pamięcią. Nie wiadomo jak trafił do Ursbardur, lecz wyplenił z Purpurowego Boru wszelkie plugastwa jakie zadomowiły się w nim po Świętej Nocy, więc osadnicy zostawili go w spokoju, czasami  tylko prosząc o wyleczenie konającej krowy lub pobłogosławienie plonów. Druid żyje w zgodzie z florą i fauną, kontroluje pogodę i pozwala dzięciołowi spać w swoim kapeluszu.',13,14,15),
('guard2.png','Gladiator','Dobrze mu idzie nie tylko w walce, ale i sztuce aktorskiej. Chętnie włączy się do bójki, nie ważne po której stronie - wystarczy, że dobrze zapłacisz. Każda przelana krew wzmacnia go i popycha ku większemu okrucieństwu. Mógłbyś powiedzieć, że to bestia zamknięta w ciele człowieka. Nie mylisz się.',16,17,18),
('scout2.png','Łowca','Tropienie śladów, łowiectwo, przetrwanie w dziczy, skradanie się. To tylko część umiejętności Łowcy, a przynajmniej te, o których może mówić. Kieruje nim własny kompas moralny przez co wysłano za nim wiele listów gończych. Jeśli jesteś kłusownikiem, zbirem lub śmiałkiem zapuszczajacym się w las po jego głowę pilnuj, żeby twoja pozostała na swoim miejscu.',25,26,27),
('girl1.png','Szamanka','Jej ród miał chronić i leczyć śmiertelników, jednak po masakrze na jej rodzinie poprzysięgła ludziom zemstę. Włada tajemniczymi mocami i wchodzi w umysł wrogów szerząc strach i szaleństwo. Nie ma sobie równych w sztuce skradania się i kamuflażu, więc miej się na baczności.',7,8,9),
('prince1.png','Paladyn','Święty wojownik broniący boskich praw i szlacheckich cnót. Dzięki boskiej opatrzności jako jedyny jest w stanie walczyć z niumarłymi Odważny, prawy i zaprawiony w boju zawsze stanie w obronie prawdy i sprawiedliwości przed niekończącymi się atakami zła. Poza tym nie odmówi uratowania pięknej niewiasty od czasu do czasu.',10,11,12),
('dwarf1.png','Krasnolud','Rasa kolonistów rozsianych po całym świecie, świetnie wyszkolona do walki i pieszych wędrówek. Krasnoludy znane są ze swojego niewielkiego wzrostu, nieugiętego charakteru i dużej siły. Nie boją się żadnej pracy, ani wyzwania, poza dosięgnięciem do najwyższej półki.',19,20,21);



Insert into Skills
Values
('Pochłaniacz', 'Mag pochłania czarną energię z duszy swojego przeciwnika i wykorzystuje ją do zwiększenia swojej magicznej siły','IMG\Skils\Witch\Pochlaniacz.png','Intelligence',1.3),
('Tchnienie Śmierci', 'Mag łączy się z czarną energią pochłonioną z duszy swojego przeciwnika, tworząc potężną dawkę magicznej mocy. Następnie zwraca ją do swojego przeciwnika zadając ogromne obrażenia duszy przeciwnika.','IMG\Skils\Witch\Tchnienie_Smierci.png','Intelligence',1.6),
('Płaszcz','Mag wykorzystuje wszystkie pokłady nagromadzonej czarnej energi pozyskanej z duszy swojego przeciwnika a następnie tworzy z niej magiczny płaszcz otulający jego ciało który chroni go przed atakami','IMG\Skils\Witch\Plaszcz.png','Health', 1.6),
('Cięcie','Wyklęty rycerz wykonuje szybkie cięcia orężem powodując krwawienie swojego przeciwnika doprowadzjąc do jego szybkiej śmierci.','IMG\Skils\Accursed_knight\Ciecie.png','Strength', 1.4),
('Stalowa siła','Wyklęty rycerz jest ponad przeciętnie odporny na ataki ze strony przeciwników. Zaprawienie w licznych bojach zahartowało jego ciało powodując, że stało się ono bardziej odporne na większość ataków','IMG\Skils\Accursed_knight\Stalowa_siła.png','Health', 2.0),
('Wrzask','Wyklęty rycerz swym ostrym krzykiem ogłusza przeciwników przez co zyskuje czas na uniknięcie ataku przeciwnika','IMG\Skils\Accursed_knight\Wrzask.png','Dexterity', 1.3),
('Truposze','Szamanka wskrzesza wszystkie pochowane ciała w okolicy i rozkazuje im atakować wskazanych przeciwników','IMG\Skils\Shaman\truposze.png','Intelligence', 1.9),
('Jad','Szamanka wymawia zaklęcia zamieniając swój oreż w zaklętego jadowitego węża, który znacząco zwiększa obrażenia zadawane od broni','IMG\Skils\Shaman\jad.png','Intelligence', 1.5),
('Noc Truposzy','Szamanka wpada w szał śpiewając piosenkę w tajemniczym języku. Piosenka przebudza poległych tego świata, którzy wynurzają się z ziemi atakując swoich przeciwników','IMG\Skils\Shaman\noc_truposzy.png','Intelligence', 2.2),
('Szarża','Paladyn rozpoczyna szarże przeciwników niosąc na ustach hymn swego królestwa. Przeciwnicy odczuwają przerażenie słysząc donośny tupot końskich kopyt','IMG\Skils\Paladin\Szarża.png','Strength', 3),
('Błogosławieństwo','Paladyni jako święci wojownicy zyskali błogosławieństwo boże, które towarzyszy im w bitwach. Dzięki bożej łasce paladyn jest najbardziej odpornym bohaterem na wszystkie ataki','IMG\Skils\Paladin\Blogoslawienstwo.png','Health', 2.6),
('Kometa','Paladyn w trudnych chwilach walki odmawia modlitwę prosząc swojego boga o wsparcie, modlitwy te zostają wysłuchane a z nieba spada potężna kometa śmiertelnie raniąca przeciwników','IMG\Skils\Paladin\Kometa.png','Strength', 1.7),
('Uderzenie','Druid ładuje swoją laskę siłami natury a następnie udeża nią w swych przeciwników zadając obrażenia magiczne.','IMG\Skils\Druid\Uderzenie.png','Intelligence', 1.3),
('Pędziwiatr','Druid wykorzysuje siły natury (powietrze) aby rozpętać minitornado pod swoimi nogami. Czyni to go niebywale zwinnym i szybkim co pozwala uniknąc ataków ze strony przeciwników ','IMG\Skils\Druid\Pedziwiatr.png','Dexterity', 1.6),
('Żywa aura','Druid wykorzysuje wszystkie siły natury (ogień,wode,powietrze) łączy je i buduje z nich magiczną tarczę otaczającą jego ciało. Tak przygotowana osłona pozwala mu zablokować dużą część ataków przeciwnika  ','IMG\Skils\Druid\zywa_aura.png','Health', 1.8),
('Triumf','Gladiator ocieka dumą po serii ostatnich zwycięstw. Duma ta dodaje mu otuchy i pewności siebie przez co staje się mniej wrażliwy na ból','IMG\Skils\Gladiator\Triumf.png','Health', 1.4),
('Natarcie','Gladiator pewnie rozpoczyna natarcie gdy tylko usłyszy gong rozpoczynający walkę, z szaleństwem rzuca się na przeciwnika powodując u niego konsternacje oraz przytłoczenie . Ale czy czasem taka pewność siebie nie przyniesie mu zguby ? ','IMG\Skils\Gladiator\Natarcie.png','Strength', 1.7),
('Ferwor','Gladiator świetnie czuje się w ferworze walki, adrenalina i zajadłość jaka towarzyszy mu na arenie powoduje, że traci on jakiekolwiek poczucie świadomości, bólu nie mówiąc już o strachu...','IMG\Skils\Gladiator\Ferwor.png','Health', 1.9),
('Bój','Krasnoludy to rasa, której głównym celem w rzyciu jest toczenie bojów... Z tą cecha rodzi się każdy młody krasnolud. Napewno nie będzie to łatwy przeciwnik...','IMG\Skils\Dwarf\Boj.png','Strength', 1.6),
('Łamacz','Krasnoludy mocnym uderzeniem bronią przełamuje obronę przeciwnika, ogłuszając go na sekundę. Tworzy sobię tym sposobem idealną sytuację aby zadać cios krytyczny','IMG\Skils\Dwarf\Lamacz.png','Strength', 1.9),
('Orzeł','Krasnoludy od setek lat uważają, że najwspanialszym zwierzęciem są orły. Stały się one ich najwierniejszymi kompanami w walce i w życiu. Orły rzucają się na przeciwnika krasnoluda pozwalając krasnoludą uniknąć ciosów przeciwnika.','IMG\Skils\Dwarf\Orzel.png','Dexterity', 1.2),
('Kopniak','Mówca "sprzedaje" kopa swojemu przeciwnikowi zadając mu obrażenia fizyczne','IMG\Skils\Speaker\Kopniak.png','Strength', 1.1),
('Rycie gara','Mówca zaczyna pierdzielić takie głupoty, że doprowadza do potężnego bólu głowy wszystkich przeciwników znajdujących się w okolicy -||-"Ludzie woleli złożyć broń niż słuchać tego pitolenia"','IMG\Skils\Speaker\Rycie_gara.png','Strength', 1.3),
('Akcja ewakuacja','Jedyną odpornoscią na umiejętności mówcy jest... GŁUCHOTA. Niesty zdażają się głusi jak pień przeciwnicy na, których jedyną bronią jest ciężki oręż, którego najpewniej mówca nie uniesie. W takiej sytuacji nie pozostaje nic innego niż "Pakować walize" ','IMG\Skils\Speaker\akcja_ewakuacja.png','Dexterity', 3),
('Strzała','Największy atutem łucznika jest zasięg, łucznik może zadawać śmiertelne obrażenia celą oddalonym o kilaset metrów dalej.','IMG\Skils\Hunter\Strzala.png','Dexterity', 1.9),
('Związane nogi','Łucznicy słyną z świetnego sprytu i zręczności. Są zwinni i niezauważeni. Mimo, że walczą z dystansu potrafią podejść naprawdę blisko swojego przeciwnika aby wyrządzić mu psikusa. Łucznik zakrada się do przeciwnika i w ułamku sekundy związuje mu buty tworząc pajęczynę z jego sznurówek','IMG\Skils\Hunter\Zwiazane_nogi.png','Dexterity', 2.1),
('Wszyscy razem','Łucznicy kryją się wszędzie nawet nie wiesz jak wielu może ich być w twojej okolicy. Łucznik głośnym krzykiem wzywa swoich przyjacieli i wszscy razem jednym tępem zasypują przeciwników gradem strzał','IMG\Skils\Hunter\Wszyscy_razem.png','Dexterity', 1.8);


--Creating procedures 

create procedure dbo.GetPassword
	@EnteredUserName varchar(25)
as
begin
	select UserPassword From dbo.Users Where UserName = @EnteredUserName;
end
-------------------
Create procedure dbo.GetUser
	@EnteredUserName varchar(25)
as
begin
	select * From Users where UserName = @EnteredUserName;
end
--------------------
Create procedure dbo.GetUserAttributes
	@EnteredAttributesId int
as
begin
	select * From Attributes Where UserId = @EnteredAttributesId;
end
-------------------
Create procedure dbo.GetUserStats
	@EnteredStatsId int
as
begin
	select * From Stats Where UserId = @EnteredStatsId
end
-------------------
Create procedure GetDefItem
	@EnteredDefItemId int
as
begin
	select * From DefItems Where ItemId = @EnteredDefItemId
end
-------------------
Create procedure GetWeaponItem
	@EnteredWeaponItemId int
as
begin
	select * From WeaponItem Where ItemId = @EnteredWeaponItemId;
end
-------------------
Create procedure GetUserSets
	@EnteredSetId int
as
begin 
	select * From Sets Where UserId = @EnteredSetId
end
-------------------
Create procedure CheckUserExist
	@EnteredName varchar(50)
as
begin 
	select count(UserEmail) from Users where UserEmail= @EnteredName OR UserName = @EnteredName
end
-------------------
Create procedure InsertNewUser
	--Add user record
	@EnteredUserName varchar(50),
	@EnteredPassword varchar(50),
	@EnteredUserEmail varchar(50),
	@EnteredChampionName varchar(50),
	@EnteredChampionMoney int,
	@EnteredChampionLevel int,
	@EnteredAvatarId int,
	--Add attributes record
	@EnteredChampionHealth int,
	@EnteredChampionDexterity int,
	@EnteredChampionStrength int,
	@EnteredChampionInteligence int,
	--Add stats record
	@EnteredChampionWins int,
	@EnteredChampionLose int,
	@EnteredChampionFights int

as
begin
	--New record in Users Table
	Insert into dbo.Users Values (@EnteredUserName,@EnteredPassword,@EnteredUserEmail,@EnteredChampionName,@EnteredChampionMoney,@EnteredChampionLevel,@EnteredAvatarId)
	--Gets assigned ID for user record by Identity
	DECLARE @SelectedUserId AS INTEGER;
	SELECT @SelectedUserId = IDENT_CURRENT('dbo.Users')
	--New record in Attributes Table
	Insert into dbo.Attributes Values (@SelectedUserId,@EnteredChampionHealth,@EnteredChampionDexterity,@EnteredChampionStrength,@EnteredChampionInteligence)
	--New record in Stats Table
	Insert into dbo.Stats Values(@SelectedUserId,@EnteredChampionWins,@EnteredChampionLose,@EnteredChampionFights)
	--New record in Sets Table
	Insert into dbo.Sets(UserId) Values(@SelectedUserId)
end
-------------------
CREATE PROCEDURE GetAvatars
as
begin
	Select * From dbo.Avatars;
end
-------------------
CREATE PROCEDURE GetAvatar
	@EnteredAvatarId int
as
begin
	Select * From dbo.Avatars WHERE AvatarId = @EnteredAvatarId;
end
-------------------
CREATE PROCEDURE GetAvatarSkill
	@EnteredAvatarSkillId int
as
begin
	Select * From dbo.Skills Where SkillId = @EnteredAvatarSkillId;
end