using System;
using RoleplayGame;

class Program
{
    static void Main(string[] args)
    {
        // Crear personajes
        Mago lord = new Mago("Lord");
        Enano laperla = new Enano("La Perla");

        // Crear ítems
        Espada espada = new Espada();
        Armadura armadura = new Armadura();
        LibroHechizos libro = new LibroHechizos();

        // Creamos hechizos y los agregamos al libro
        Hechizo bolaFuego = new Hechizo("Bola de fuego", 25);
        Hechizo rayo = new Hechizo("Rayo", 15);
        libro.AgregarHechizo(bolaFuego);
        libro.AgregarHechizo(rayo);

        // Asignamos ítems a los personajes
        lord.AgregarItem(libro);     // Lord tiene su libro
        laperla.AgregarItem(espada); // La Perla tiene espada
        laperla.AgregarItem(armadura); // y armadura

        // Mostrar estado inicial
        Console.WriteLine($"{lord.Nombre} vida: {lord.Vida}, ataque: {lord.GetAtaqueTotal()}, defensa: {lord.GetDefensaTotal()}");
        Console.WriteLine($"{laperla.Nombre} vida: {laperla.Vida}, ataque: {laperla.GetAtaqueTotal()}, defensa: {laperla.GetDefensaTotal()}");
        Console.WriteLine("---- COMBATE ----");

        // Round 1: Lord ataca a La Perla
        lord.Atacar(laperla);
        Console.WriteLine($"{laperla.Nombre} recibió el ataque y ahora tiene {laperla.Vida} de vida.");

        // Round 2: La Perla contraataca
        laperla.Atacar(lord);
        Console.WriteLine($"{lord.Nombre} recibió el ataque y ahora tiene {lord.Vida} de vida.");

        // Curamos a Lord
        lord.Curar();
        Console.WriteLine($"{lord.Nombre} se cura y vuelve a {lord.Vida} de vida.");
    }
}
