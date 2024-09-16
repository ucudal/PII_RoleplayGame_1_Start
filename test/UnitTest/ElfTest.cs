using NUnit.Framework;
using System.Collections.Generic;

namespace elfo.Tests
{
    [TestFixture]
    public class TestElfo
    {
        private Elf elf;
        private List<Item> items;
        private Character companion;


        [SetUp]
        public void Setup()
        {
            items = new List<Item>(); 
            elf = new Elf("luli", 100, 60, items);
            companion = new Character("rami", 50, 5, new List<Item>(), Character.CharacterType.Dwarf);
        }


        [Test]
        public void HelpOther_Cura()
        {
            companion.Health = 30; // health inferior a max
            elf.HelpOther(companion); // alfo ayuda
            double expectedHealth = 30 + (companion.GetMaxHealth() / 3); 
            Assert.AreEqual(expectedHealth, companion.GetHealth(), 0.01, "Fue curado.");
        }


        [Test]
        public void HelpOther_NuCura()
        {
            companion.Health = companion.GetMaxHealth(); //health igual 
            elf.HelpOther(companion); //ayuda
            double expectedHealth = companion.GetMaxHealth(); //helath de enano deberia seguir igual
            Assert.AreEqual(expectedHealth, companion.GetHealth(), 0.01, "No funiono.");
        }
    }
}