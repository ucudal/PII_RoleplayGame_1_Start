namespace Program.CharacterClasses;
public interface ICharacter

{
    public int Armor { get; }
    public int Health { get; set; }
    public void Heal();

    public void Attack(ICharacter target);
    public Inventory Inventory { get; set; }
    public List<Inventory> ListInventory { get; set; }
}