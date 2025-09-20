namespace RoleplayGame
{
    public class LibroHechizos : IItem
    {
        public string Nombre { get; } = "Libro de Hechizos";

        private List<Hechizo> Hechizos { get; } = new List<Hechizo>();

        // El ataque es la suma del poder de todos los hechizos
        public int Ataque => Hechizos.Sum(h => h.Poder);

        // Puede no dar defensa pero lo dejamos extensible
        public int Defensa => 0;

        public void AgregarHechizo(Hechizo hechizo)
        {
            Hechizos.Add(hechizo);
        }

        public void QuitarHechizo(Hechizo hechizo)
        {
            Hechizos.Remove(hechizo);
        }
    }
}