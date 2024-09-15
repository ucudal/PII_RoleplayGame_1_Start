/*Los elfos destacan por su capacidad de ayudar a los demás.
Contienen habilidades especiales como HelpOther() que hacen a los elfos únicos. 
Estos comportamientos no aplicarían a los magos o enanos.*/
public class Elf : Character
{
    public Elf(string name, double maxHealth, double damage, List<Item> items) 
        : base(name, maxHealth, damage, items, Character.CharacterType.Elf)  // Llamada al constructor de Character
    {}
    
    // Habilidad unica del Elfo, puede ayudar a los demas curandolos y si sos 
    public void HelpOther(Character companion)
    {
        if (companion.GetHealth() < companion.GetMaxHealth())
        { 
            companion.Heal();
        }
    }
}