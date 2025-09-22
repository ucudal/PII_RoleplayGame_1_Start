public interface ICharacter
{
    public int Armor  { get; set; }
    public int Health { get; set; }
    public void Attack(ICharacter objetivo);
    public void Heal();
}