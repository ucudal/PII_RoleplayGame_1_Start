/*Los magos tienen acceso a hechizos y maná, lo que introduce una mecánica de recursos que otros personajes no poseen.
La clase Wizard necesita manejar la gestión de su mana y el uso de hechizos, lo que implica métodos como 
CastSpell() y RestoreMana(). Este comportamiento no es relevante para un elfo o un enano, y por lo tanto debe ser exclusivo de los magos.*/
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
        set { if (value > maxMana)
            {
                mana = maxMana;
            }
            else
            {
                mana = value;
            }; }
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
    
    // Consultar por el su mañan máxima

    public double GetMaxMana() => maxMana;
    
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