namespace RoleplayGame
{
    // no hay mucho por comentar, usamos la interfaz IItem para crear Espada
    public class Espada : IItem
    {
        public string Nombre { get; } = "Espada";
        public int Ataque { get; } = 15;
        public int Defensa { get; } = 0;
    }
}