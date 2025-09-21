namespace RoleplayGame
{
    public class LibroHechizos : IItem
    {
        public string Nombre { get; } = "Libro de Hechizos";

        private List<Hechizo> Hechizos { get; } = new List<Hechizo>();

        // El ataque es la suma del poder de todos los hechizos
        public int Ataque
        {
            get
            {
                int total = 0;
                foreach (Hechizo h in Hechizos)  
                {
                    total += h.Poder;
                }
                return total;
            }
        }


        // Puede no dar defensa pero lo dejamos extensible
        public int Defensa
        {
            get
            {
                int total = 0;
                return total;
            }
        }


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