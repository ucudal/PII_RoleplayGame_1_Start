namespace RoleplayGame
{
    public class Baston : IItem
    {
        public string Nombre { get; } = "Bastón mágico";
        public int Ataque { get; } = 10;
        public int Defensa { get; } = 5;
    }
}