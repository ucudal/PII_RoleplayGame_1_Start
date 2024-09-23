namespace Program2;

public class Items
{
    public class Item : Iitem
    {
        private string name;
        private double damage;
        private double defense;
        private bool magic;

        public Item(string name, double damage, double defense, bool magic)
        {
            this.name = name;
            this.damage = damage;
            this.defense = defense;
            this.magic = magic;
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

        public bool GetMagic()
        {
            return magic;
        }
    }
}