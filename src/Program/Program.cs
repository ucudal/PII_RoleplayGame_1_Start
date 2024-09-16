// Personaje e items de Ramiro Lopez
Item espadaDeFuego = new Item("Espada de Fuego", 50, 0);
Item cascoMagico = new Item("Casco Mágico", 0, 30);
List<Item> dondarItems = new List<Item> { espadaDeFuego, cascoMagico };
Dwarf dondarRami = new Dwarf("Dondar", 100, 40, dondarItems);
Console.WriteLine(dondarRami.GetTotalAttackValue());