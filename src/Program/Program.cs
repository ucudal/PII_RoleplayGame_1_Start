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
        
        Item espadaDeFuego = new Item("Espada de Fuego", 50, 0);
        Item cascoMagico = new Item("Casco Mágico", 0, 30);
        List<Item> dondarItems = new List<Item> { espadaDeFuego, cascoMagico };
        Dwarf dondarRami = new Dwarf("Dondar", 100, 40, dondarItems);
        Console.WriteLine(dondarRami.GetTotalAttackValue());
    }
}