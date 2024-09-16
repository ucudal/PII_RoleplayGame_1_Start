public class Program
{
    public static void Main()
    {
        // Creación de 2 items y Wizard de Mateo Cárdenas
        
        Item sopa = new Item("Sopa", 20, 5);  
        Item baston = new Item("BastonDeGandalf", 5, 10);   
        
        // Crear una lista de Items
        List<Item> items = new List<Item> { sopa, baston };

        // Crear un hechizo
        Spell oneforall = new Spell("OneForAll", 100, 80); // nombre, daño, coste de maná

        // Crear una lista de hechizos
        List<Spell> spellBook = new List<Spell> { oneforall };
        Wizard merlin = new Wizard("Merlin", 150, 15, items, 100, spellBook);
        
        // Imprimir detalles del Wizard
        Console.WriteLine($"{merlin.GetName()} tiene {merlin.GetHealth()} de vida y {merlin.GetMana()} de maná.");
        Console.WriteLine("Items:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.GetName()}: Ataque = {item.damage}, Defensa = {item.defense}");
        }
        
        // Lanzar el hechizo a un enemigo
        Character enemy = new Character("Orc", 80, 10, new List<Item>(), Character.CharacterType.Elf);
        merlin.CastSpell(oneforall, enemy);

        // Imprimir el estado del enemigo
        Console.WriteLine($"{enemy.GetName()} ahora tiene {enemy.GetHealth()} de vida.");
    }
}