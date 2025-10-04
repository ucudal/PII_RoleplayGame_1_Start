namespace Program;

public class SpellBook
{
    public List<Spells> SpellList;
    public SpellBook()
    {
        SpellList = new List<Spells>();
    }
    public void AddSpell(Spells spell)
    {
        SpellList.Add(spell);
        Console.WriteLine($"Se añadió el hechizo: {spell.Name}");
    }
}