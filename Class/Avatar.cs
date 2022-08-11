
    public class Avatar
    {
        public int AvatarId { get; set; }
        public string AvatarImgSrc{ get; set; }
        public string AvatarName { get; set;}
        public string AvatarStory{ get; set; }

        public Skill AvatarSkillOne;
        public Skill AvatarSkillTwo;
        public Skill AvatarSkillThree;

        public Avatar(int avatarId, string avatarImgSrc, string avatarName, string avatarStory, Skill avatarSkillOne, Skill avatarSkillTwo, Skill avatarSkillThree)
        {
            AvatarId = avatarId;
            AvatarImgSrc = avatarImgSrc;
            AvatarName = avatarName;
            AvatarStory = avatarStory;
            AvatarSkillOne = avatarSkillOne;
            AvatarSkillTwo = avatarSkillTwo;
            AvatarSkillThree = avatarSkillThree;
        }

        public Avatar(){ 
        }
    }

    public class VolatileAvatar:Avatar
    {
        public int AvatarSkillOne;
        public int AvatarSkillTwo;
        public int AvatarSkillThree;
        dbAcces newSql = new dbAcces();
        public Avatar GetStableAvatar()
        {
            Skill SkillOne = newSql.GetAvatarSkill(AvatarSkillOne);
            Skill SkillTwo = newSql.GetAvatarSkill(AvatarSkillTwo);
            Skill SkillThree = newSql.GetAvatarSkill(AvatarSkillThree);
            return new Avatar(this.AvatarId,this.AvatarImgSrc,this.AvatarName,this.AvatarStory,SkillOne,SkillTwo,SkillThree);
        }
    }

