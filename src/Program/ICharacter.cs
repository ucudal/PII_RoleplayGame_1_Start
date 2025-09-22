public interface ICharacter
{
    public int Armor { get; }
    public int Health { get; set; }
    public void Attack(ICharacter objetivo);
    public void Heal();
}