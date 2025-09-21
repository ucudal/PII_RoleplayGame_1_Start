namespace RoleplayGame
{
    public class Hechizo
    {
        public string Nombre { get; } 
        public int Poder { get; }

        public Hechizo(string nombre, int poder)
        {
            this.Nombre = nombre;
            this.Poder = poder;
        }
    }
}