using System.Collections;
public class Wizard: Character
{
    private double mana;
    private double maxMana;
    private List<Spell> listaLibroDeHechizos;
    public Wizard(string name, double maxHealth, double damage, List<Item> items, double mana, List<Spell> listaDeHechizos) 
        : base(name, maxHealth, damage, items, Character.CharacterType.Wizard)  // Llamada al constructor de Character
    {
        this.mana = mana;  // Asignar el mana solo para los magos
        this.listaLibroDeHechizos = listaDeHechizos;
    }
    
    // Agregar hechizo al libro de hechizos
    public List<Spell> learnMagic(Spell hechizo)
    {
        listaLibroDeHechizos.Add(hechizo);
        return listaLibroDeHechizos;
    }
}