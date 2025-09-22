public interface ICharacter
{
    public int Armor { get; }
    public int Health { get; set; }
    public void Heal();
}