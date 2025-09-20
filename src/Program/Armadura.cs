namespace RoleplayGame
{
    public class Armadura : IItem
    {
        public string Nombre { get; } = "Armadura";
        public int Ataque { get; } = 0;
        public int Defensa { get; } = 20;
    }
}