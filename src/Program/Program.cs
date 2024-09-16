using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Crear dos ítems
        Item battleAxe = new Item("Battle Axe", 25.0, 0.0); // Hacha de batalla con daño de 25 y defensa de 0
        Item heavyArmor = new Item("Heavy Armor", 0.0, 20.0); // Armadura pesada con daño de 0 y defensa de 20

        // Crear una lista de ítems y agregar los ítems
        List<Item> items = new List<Item> { battleAxe, heavyArmor };

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
        
        // Objetos y personaje de Ramiro Lopez
        
        // Agrego dos items
        Item espadaDeFuego = new Item("Espada de Fuego", 50, 0);
        Item cascoMagico = new Item("Casco Mágico", 0, 30);
        Item escudoDeMadera = new Item("Escudo de madera", 0, 1.0);
        
        // Creo una lista con los items
        List<Item> dondarItems = new List<Item> { espadaDeFuego, cascoMagico };
        
        // Creo un enano Dondar
        Dwarf dondarRami = new Dwarf("Dondar", 100, 40, dondarItems);
        
        // Agrego un item
        dondarRami.AddItem(escudoDeMadera);
        Console.WriteLine(dondarItems);
      
      
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