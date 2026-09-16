using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ElvesTests
    {
        [Test]
        public void HelpOther_WhenHelpingAnotherCharacter_IncreasesLifeByTwo()
        {
            Elves elf = new Elves(10, 5, 3);
            int life = 10;

            elf.helpOther(ref life);

            Assert.That(life, Is.EqualTo(12));
        }

        [Test]
        public void Bow_WhenShootingWithArrows_DecreasesQuantity()
        {
            Elves.Bow bow = new Elves.Bow(5);

            bow.shootArrow();

            Assert.That(bow.quantity, Is.EqualTo(4));
        }

        [Test]
        public void Bow_WhenThereAreNoArrows_DoesNotShoot()
        {
            Elves.Bow bow = new Elves.Bow(0);

            bow.shootArrow();

            Assert.That(bow.quantity, Is.EqualTo(0));
        }

        [Test]
        public void Bow_WhenCreated_HasDamageOfTwo()
        {
            Elves.Bow bow = new Elves.Bow(5);

            Assert.That(bow.damage, Is.EqualTo(2));
        }

        [Test]
        public void Cape_WhenProtectingAnElf_IncreasesDefense()
        {
            Elves elf = new Elves(10, 5, 3);
            Elves.Cape cape = new Elves.Cape(2, 3);

            cape.protect(elf);

            Assert.That(elf.Defense, Is.EqualTo(5));
        }

        [Test]
        public void Cape_WhenProtectingAnElf_DecreasesCapeLife()
        {
            Elves elf = new Elves(10, 5, 3);
            Elves.Cape cape = new Elves.Cape(2, 3);

            cape.protect(elf);

            Assert.That(cape.capeLife, Is.EqualTo(2));
        }

        [Test]
        public void Cape_WhenCapeLifeIsZero_DoesNotIncreaseDefense()
        {
            Elves elf = new Elves(10, 5, 3);
            Elves.Cape cape = new Elves.Cape(2, 0);

            cape.protect(elf);

            Assert.That(elf.Defense, Is.EqualTo(3));
        }
    }
}