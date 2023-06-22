namespace harlequin_cs
{
    public abstract class Character
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public int AttackDamge { get; set; }
        public int AttackSpeed { get; set; }
        public int Defense { get; set; }
        public int MovementSpeed { get; set; }
        protected Character(string name) : this(name, 100, 20, 20, 10, 10) { }
        protected Character(string name, double health, int attackDamage, int attackSpeed, int defense, int movementSpeed)
        {
            Name = name;
            Health = health;
            AttackDamge = attackDamage;
            AttackSpeed = attackSpeed;
            Defense = defense;
            MovementSpeed = movementSpeed;
        }
    }
}
