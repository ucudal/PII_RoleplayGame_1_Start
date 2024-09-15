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

    // Sobreescribimos heal cuando el personaje es de tipo Wizard, al curarse tambien se le suma 50% de su capacidad de mana
    public override void Heal()
    {
        base.Heal();
        mana += maxMana / 2;
    }

    // Agregar hechizo al libro de hechizos
    public List<Spell> LearnMagic(Spell hechizo)
    {
        listaLibroDeHechizos.Add(hechizo);
        return listaLibroDeHechizos;
    }
    
    // Consultar cuanta mana tiene actualmente
    public double GetMana() => mana;
    
    // Lanzar un hechizo
    public void CastSpell(Spell spell, Character objetivo)
    {
        if (Mana >= spell.GetManaCost())
        {
            Mana -= spell.GetManaCost();
            spell.Recite(objetivo);
        }
    }
}