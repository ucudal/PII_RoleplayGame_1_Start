
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

    public double Mana
    {
        get { return mana; }
        set { mana = value; }
    }
    
    // Agregar hechizo al libro de hechizos
    public List<Spell> learnMagic(Spell hechizo)
    {
        listaLibroDeHechizos.Add(hechizo);
        return listaLibroDeHechizos;
    }
    
    public double GetMana() => mana;
    
    public void LanzarHechizo(Hechizo hechizo, Character objetivo)
    {
        if (Mana >= hechizo.GetManaCost())
        {
            Mana -= hechizo.GetManaCost();
            hechizo.Lanzar( Character objetivo);
            Console.WriteLine($"{name} ha lanzado {hechizo.GetName()} contra {Character.GetName}, consumiendo {hechizo.GetManaCost()} de mana.");
        }
        else
        {
            Console.WriteLine($"{name} no tiene suficiente mana para lanzar {hechizo.GetName()}.");
        }
    }
    
    public void RestoreMana()
    {
        Mana += this.maxMana / 3; // Recupera 1/3 de su mana máximo
    }
}