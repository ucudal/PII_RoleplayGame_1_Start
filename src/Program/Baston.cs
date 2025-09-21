namespace RoleplayGame
{
    // no hay mucho por comentar, usamos la interfaz IItem para crear Baston
    public class Baston : IItem
    { 
        public string Nombre { get; } = "Bastón mágico";
        public int Ataque { get; } = 10;
        public int Defensa { get; } = 5;
    }
}