namespace RoleplayGame
{
    public class Mago : IPersonaje
    {
        public string Nombre { get; }
        public int Vida { get; private set; }
        public int VidaLimitada { get; }
        public List<IItem> Items { get; } = new List<IItem>();

        public Mago(string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 80;
            this.VidaLimitada = 80;
        }

        public int GetAtaqueTotal() => Items.Sum(i => i.Ataque);
        public int GetDefensaTotal() => Items.Sum(i => i.Defensa);

        public void Atacar(IPersonaje enemigo)
        {
            int daño = GetAtaqueTotal() - enemigo.GetDefensaTotal();
            if (daño > 0)
                enemigo.RecibirDaño(daño);
        }

        public void RecibirDaño(int daño)
        {
            Vida -= daño;
            if (Vida < 0) Vida = 0;
        }

        public void Curar()
        {
            Vida = VidaLimitada;
        }

        public void AgregarItem(IItem item) => Items.Add(item);
        public void QuitarItem(IItem item) => Items.Remove(item);
    }
}