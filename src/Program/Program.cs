using System;
using RoleplayGame;

class Program
{
    static void Main(string[] args)
    {
        // Crear personajes
        Mago gandalf = new Mago("Gandalf");
        Enano gimli = new Enano("Gimli");

        // Crear ítems
        Espada espada = new Espada();
        Armadura armadura = new Armadura();
        LibroHechizos libro = new LibroHechizos();

        // Crear hechizos y agregarlos al libro
        Hechizo bolaFuego = new Hechizo("Bola de fuego", 25);
        Hechizo rayo = new Hechizo("Rayo", 15);
        libro.AgregarHechizo(bolaFuego);
        libro.AgregarHechizo(rayo);

        // Asignar ítems a los personajes
        gandalf.AgregarItem(libro); // el mago tiene su libro
        gimli.AgregarItem(espada);  // el enano tiene espada
        gimli.AgregarItem(armadura); // y armadura

        // Mostrar estado inicial
        Console.WriteLine($"{gandalf.Nombre} vida: {gandalf.Vida}, ataque: {gandalf.GetAtaqueTotal()}, defensa: {gandalf.GetDefensaTotal()}");
        Console.WriteLine($"{gimli.Nombre} vida: {gimli.Vida}, ataque: {gimli.GetAtaqueTotal()}, defensa: {gimli.GetDefensaTotal()}");
        Console.WriteLine("---- COMBATE ----");

        // Turno 1: Gandalf ataca a Gimli
        gandalf.Atacar(gimli);
        Console.WriteLine($"{gimli.Nombre} recibió el ataque y ahora tiene {gimli.Vida} de vida.");

        // Turno 2: Gimli contraataca
        gimli.Atacar(gandalf);
        Console.WriteLine($"{gandalf.Nombre} recibió el ataque y ahora tiene {gandalf.Vida} de vida.");

        // Curar a Gandalf
        gandalf.Curar();
        Console.WriteLine($"{gandalf.Nombre} se cura y vuelve a {gandalf.Vida} de vida.");
    }
}