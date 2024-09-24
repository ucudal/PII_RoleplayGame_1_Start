namespace UnitTest;
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class WizardTests
{
    private Wizard wizard;
    private List<Item> items;
    private List<Spell> spells;
    private Spell fireball;

    [SetUp]
    public void SetUp()
    {
        // Crear algunos ítems para el mago
        items = new List<Item>
        {
            new Item("Magic Staff", 10, 5), // Ejemplo de ítem
            new Item("Robe", 0, 3) // Ejemplo de ítem defensivo
        };

        // Crear algunos hechizos
        fireball = new Spell("Fireball", 20, 30); // Nombre, daño, costo de maná

        spells = new List<Spell> { fireball };

        // Crear un mago con maná inicial de 100, salud máxima de 200 y una lista de hechizos
        wizard = new Wizard("Gandalf", 200, 30, items, 100, spells);
    }

    [Test]
    public void TestWizardInitialSetup()
    {
        // Comprobar que los datos del mago son correctos
        Assert.AreEqual("Gandalf", wizard.GetName());
        Assert.AreEqual(200, wizard.GetMaxHealth());
        Assert.AreEqual(100, wizard.GetMana());
        Assert.AreEqual(40, wizard.GetTotalAttackValue());
        Assert.IsTrue(wizard.GetHealth() == 200);
    }

    [Test]
    public void TestWizardLearnsNewSpell()
    {
        // Crear un nuevo hechizo y aprenderlo
        Spell lightning = new Spell("Lightning", 15, 25);
        
        // Comprobar que los hechizos hayan sido añadidos a la lista
        Assert.Contains(lightning, wizard.LearnMagic(lightning));
        Assert.AreEqual(2, spells.Count); // Ahora debería tener 2 hechizos
    }

    [Test]
    public void TestWizardCastsSpellWithSufficientMana()
    {
        // Crear un objetivo
        Character orc = new Character("Orc", 100, 20, new List<Item>(), Character.CharacterType.Dwarf);
        
        // Lanzar el hechizo
        wizard.CastSpell( fireball, orc);

        // Comprobar que el maná se ha reducido correctamente y que el hechizo ha hecho daño
        Assert.AreEqual(70, wizard.GetMana()); // El maná ha bajado en 30
        Assert.AreEqual(80, orc.GetHealth()); // El orco ha recibido 20 de daño
    }

    [Test]
    public void TestWizardCannotCastSpellWithInsufficientMana()
    {
        // Crear un objetivo
        Character orc = new Character("Orc", 100, 20, new List<Item>(), Character.CharacterType.Dwarf);

        // Vaciar el maná del mago
        wizard.Mana = 10;
        Spell fireball = new Spell("Fireball", 20, 30); // Nombre, daño, costo de maná
        
        // Intentar lanzar el hechizo
        wizard.CastSpell(fireball, orc);

        // Comprobar que no se lanzó el hechizo
        Assert.AreEqual(10, wizard.GetMana()); // El maná no debe cambiar
        Assert.AreEqual(100, orc.GetHealth()); // El orco no ha recibido daño
    }
    [Test]
    public void TestWizardHeal()
    {
        // Infligir daño al mago y gastar algo de maná
        wizard.Health -= 50;
        wizard.Mana -= 50;

        // Curar al mago
        wizard.Heal();

        // Comprobar que se recuperó vida y 50% del maná
        Assert.AreEqual(200, wizard.GetHealth()); // Vida completa restaurada

        double expectedMana = 50 + (wizard.GetMaxMana() / 2); // Recupera 50% del mana máximo
        Assert.AreEqual(expectedMana, wizard.GetMana()); // Verificar que el mana es el esperado
    }
}
