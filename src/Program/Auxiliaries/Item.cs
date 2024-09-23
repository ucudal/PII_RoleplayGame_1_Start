namespace Program2;

public class Items
{
    public class Item : Iitem
    {
        private string name;
        private double damage;
        private double defense;

        public Item(string name, double damage, double defense)
        {
            this.name = name;
            this.damage = damage;
            this.defense = defense;
        }

        public string GetName()
        {
            return name;
        }

        public double GetDamage()
        {
            return damage;
        }

        public double GetDefense()
        {
            return defense;
        }
    }
}