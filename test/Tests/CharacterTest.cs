[TestFixture]
public class CharacterTests
{
    [Test]
    public void Constructor_ShouldInitializeCorrectly()
    {
        // Arrange
        var items = new List<Item>();
        var character = new Character("Aragorn", 100, 10, items, Character.CharacterType.Dwarf);

        // Act & Assert
        Assert.AreEqual("Aragorn", character.GetName());
        Assert.AreEqual(100, character.GetHealth());
        Assert.AreEqual(100, character.GetMaxHealth());
        Assert.AreEqual(0, character.GetTotalAttackValue());
    }

    [Test]
    public void AddItem_ShouldIncreaseAttackValue()
    {
        // Arrange
        var items = new List<Item>();
        var character = new Character("Gimli", 100, 10, items, Character.CharacterType.Dwarf);
        var sword = new Item { name = "Sword", damage = 20, defense = 5 };

        // Act
        character.AddItem(sword);

        // Assert
        Assert.AreEqual(20, character.GetTotalAttackValue());
    }

    [Test]
    public void RemoveItem_ShouldDecreaseAttackValue()
    {
        // Arrange
        var items = new List<Item>();
        var character = new Character("Legolas", 100, 10, items, Character.CharacterType.Elf);
        var bow = new Item { name = "Bow", damage = 15, defense = 3 };

        // Act
        character.AddItem(bow);
        character.RemoveItem(bow);

        // Assert
        Assert.AreEqual(0, character.GetTotalAttackValue());
    }

    [Test]
    public void ReceiveDamage_ShouldReduceHealth()
    {
        // Arrange
        var items = new List<Item>();
        var character = new Character("Gandalf", 100, 10, items, Character.CharacterType.Wizard);

        // Act
        character.ReceiveDamage(30);

        // Assert
        Assert.AreEqual(70, character.GetHealth());
    }

    [Test]
    public void ReceiveDamage_ShouldNotHaveNegativeHealth()
    {
        // Arrange
        var items = new List<Item>();
        var character = new Character("Boromir", 50, 10, items, Character.CharacterType.Dwarf);

        // Act
        character.ReceiveDamage(60);

        // Assert
        Assert.AreEqual(0, character.GetHealth());
    }

    [Test]
    public void Heal_ShouldIncreaseHealth()
    {
        // Arrange
        var items = new List<Item>();
        var character = new Character("Frodo", 100, 10, items, Character.CharacterType.Elf);

        // Act
        character.ReceiveDamage(50);
        character.Heal();

        // Assert
        Assert.AreEqual(83.33, character.GetHealth(), 0.01); // Recupera 1/3 de la salud
    }

    [Test]
    public void Attack_ShouldReduceEnemyHealth()
    {
        // Arrange
        var items = new List<Item>();
        var attacker = new Character("Aragorn", 100, 15, items, Character.CharacterType.Dwarf);
        var enemy = new Character("Orc", 100, 10, items, Character.CharacterType.Elf);

        // Act
        attacker.Attack(enemy);

        // Assert
        Assert.AreEqual(85, enemy.GetHealth()); // El orco recibe 15 de daño
    }
}