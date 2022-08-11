
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName{ get; set; }
        public string SkillDescription { get; set; }
        public string SkillImgSrc { get; set; }
        public string SkillForceCategory {get; set; }
        public float SkillForce{ get; set; }
    }

    struct SkillCategoryDescription
    {
        public static string GetDescription(Skill avatarSkill)
        {
            switch (avatarSkill.SkillForceCategory)
            {
                case "Intelligence":
                    return $"Zwiększa obrażenia magiczne. Obrażenia bohatera * {avatarSkill.SkillForce}";
                break;
                case "Strength":
                    return $"Zwiększa obrażenia fizyczne. Obrażenia bohatera * {avatarSkill.SkillForce}";
                break;
                case "Health":
                    return $"Zwiększa żywotność bohatera. Żywotność * {avatarSkill.SkillForce}";
                break;
                case "Dexterity":
                    return $"Zwiększa szansę na unik bohatera. Unik * {avatarSkill.SkillForce}";
                break;
                default:
                    return "Null";
            }
        }
    }