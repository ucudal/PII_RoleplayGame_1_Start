using System.Collections.Generic;
using System;
using Program2;

public class Program
{
    public static void Main()
    {
        //----------------------------Martin------------------------------------------------
        // Crear dos ítems
        Iitem battleAxe = new Items.Item("Battle Axe", 25.0, 0.0); // Hacha de batalla con daño de 25 y defensa de 0
        Iitem heavyArmor = new Items.Item("Heavy Armor", 0.0, 20.0); // Armadura pesada con daño de 0 y defensa de 20

        // Crear una lista de ítems y agregar los ítems
        List<Iitem> items = new List<Iitem> { battleAxe, heavyArmor };

        // Crear un enano
        Dwarf dwarf = new Dwarf("Gimli", 120.0, 15.0, items);

        // Imprimir información del enano y los ítems
        Console.WriteLine($"Dwarf Name: {dwarf.GetName()}");
        Console.WriteLine($"Dwarf Health: {dwarf.GetHealth()}");
        Console.WriteLine($"Dwarf Max Health: {dwarf.GetMaxHealth()}");

        // Mostrar ítems del enano
        Console.WriteLine("Items:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.GetName()} - {item.GetDamage()} damage, {item.GetDefense()} defense");
        }
        
        // Ejemplo de habilidad especial del enano
        Console.WriteLine("Using GoCrazy ability...");
        dwarf.GoCrazy();
        Console.WriteLine($"Dwarf Damage after GoCrazy: {dwarf.GetTotalAttackValue()}");
        
        //----------------------------Ramiro------------------------------------------------
        
        // Agrego dos items
        Iitem espadaDeFuego = new Items.Item("Espada de Fuego", 50, 0);
        Iitem cascoMagico = new Items.Item("Casco Mágico", 0, 30);
        Iitem escudoDeMadera = new Items.Item("Escudo de madera", 0, 1.0);
        
        // Creo una lista con los items
        List<Iitem> dondarItems = new List<Iitem> { espadaDeFuego, cascoMagico };
        
        // Creo un enano Dondar
        Dwarf dondarRami = new Dwarf("Dondar", 100, 40, dondarItems);
        
        // Agrego un item
        dondarRami.AddItem(escudoDeMadera);
        Console.WriteLine(dondarItems);
      
        //----------------------------Mateo------------------------------------------------
        
        Iitem sopa = new Items.Item("Sopa", 20, 5);  
        Iitem baston = new Items.Item("BastonDeGandalf", 5, 10);   

        //crear una lista de Items
        List<Iitem> items2 = new List<Iitem> { sopa, baston };

        //crear un hechizo
        Spell oneforall = new Spell("OneForAll", 100, 80); // nombre, daño, coste de maná

        //crear una lista de hechizos
        List<Spell> spellBook = new List<Spell> { oneforall };
        Wizard merlin = new Wizard("Merlin", 150, 15, items2, 100, spellBook);
        
        Console.WriteLine($"{merlin.GetName()} tiene {merlin.GetHealth()} de vida y {merlin.GetMana()} de maná.");
        Console.WriteLine("Items:");
        foreach (var item in items2)
        {
            //usamos los metodos de la interfaz Iitem para obtener los valores de daño y defensa
            Console.WriteLine($"- {item.GetName()}: Ataque = {item.GetDamage()}, Defensa = {item.GetDefense()}");
        }

        
        // Lanzar el hechizo a un enemigo
        Character enemy = new Character("Orc", 80, 10, new List<Iitem>(), Character.CharacterType.Elf);
        merlin.CastSpell(oneforall, enemy);

        // Imprimir el estado del enemigo
        Console.WriteLine($"{enemy.GetName()} ahora tiene {enemy.GetHealth()} de vida.");
        
        //----------------------------Lucia------------------------------------------------
        Iitem hacha = new Items.Item("hacha", 100.0, 0.0);
        Iitem tunica = new Items.Item("tunica", 50.0, 90.0);
        List<Iitem> luliItems = new List<Iitem> { hacha, tunica };
        Character luliElf = new Character("luil", 100.0, 50.0, luliItems, Character.CharacterType.Elf);
    }
}
