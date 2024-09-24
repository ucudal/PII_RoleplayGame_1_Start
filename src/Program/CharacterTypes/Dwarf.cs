/*Los enanos son expertos en combate físico y poseen una gran resistencia y fuerza.
 Tienen la habilidad de volverse locos y aumentar su daño en un 50%,
  lo que los distingue de los elfos y magos, cuyas fortalezas están en otras áreas.*/
public class Dwarf : Character
{
    public Dwarf(string name, double maxHealth, double baseDamage, List<Iitem> items)
        : base(name, maxHealth, baseDamage, items, CharacterType.Dwarf)
    { }
    
    // Método para aplicar una habilidad que aumenta el daño
    public void GoCrazy()
    {
        damage += damage / 2;
    }
}

