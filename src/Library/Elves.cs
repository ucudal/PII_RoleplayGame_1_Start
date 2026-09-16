using System;

namespace Ucu.Poo.RolePlayGame
{


    public class Elves
    {

        public int Life { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Elves(int Life, int Attack, int Defense)
        {

            this.Life = Life;
            this.Attack = Attack;
            this.Defense = Defense;

        }

        public void helpOther(ref int life)
        {

            life += 2;
        }

        public class Bow
        {
            public int damage;
            public int quantity;

            public Bow(int quantity)
            {
                this.damage = 2;
                this.quantity = quantity;
            }
            public void shootArrow()
            {
                if (quantity > 0)
                {
                    quantity = quantity - 1;
                }
            }
        }

        public class Cape
        {
            public int defense;
            public int capeLife;

            public Cape(int defense, int capeLife)
            {

                this.defense = defense;
                this.capeLife = capeLife;
            }
            public void protect(Elves elves)
            {

                if (capeLife > 0)
                {

                    elves.Defense = elves.Defense + defense; capeLife = capeLife - 1;
                }
            }
        }
    }
}