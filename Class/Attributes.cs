
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
}

