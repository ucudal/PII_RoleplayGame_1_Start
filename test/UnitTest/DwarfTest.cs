namespace UnitTest
{
    using NUnit.Framework;
    using System.Collections.Generic;

    namespace YourNamespace.Tests
    {
        // Aqui comienza
        [TestFixture]
        public class DwarfTests
        {
            private Dwarf dwarf;
            private List<Item> items;
            
            [SetUp]
            public void Setup()
            {
                // Agrego algunos datos para las pruebas
                items = new List<Item>();
                dwarf = new Dwarf("Thorin", 100, 20, items);
            }
            
            [Test]
            public void GoCrazy_IncreasesDamageBy50Percent()
            {
                double initialDamage = dwarf.GetTotalAttackValue(); // Obtiene el daño inicial
                dwarf.GoCrazy(); // Aplica la habilidad
                double expectedDamage = initialDamage + (initialDamage / 2); // Daño esperado después de aplicar la habilidad
                Assert.AreEqual(expectedDamage, dwarf.GetTotalAttackValue(), 0.01, "El daño no aumentó en un 50%");
            }
            
            [Test]
            public void Dwarf_Initialization_CorrectValues() // Control de variables
            {
                string expectedName = "Thorin";
                double expectedMaxHealth = 100;
                double expectedBaseDamage = 20;
                
                Assert.AreEqual(expectedName, dwarf.GetName());
                Assert.AreEqual(expectedMaxHealth, dwarf.GetMaxHealth());
                Assert.AreEqual(expectedBaseDamage, dwarf.GetTotalAttackValue());
            }

        }
    }
}