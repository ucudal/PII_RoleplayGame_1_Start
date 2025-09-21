namespace RoleplayGame
{
    public class Elfo : IPersonaje
    {
        public string Nombre { get; }
        public int Vida { get; private set; } //solo el código dentro de la misma clase puede modificar el valor (private)
        public int VidaLimitada { get; }
        public List<IItem> Items { get; } = new List<IItem>();

        public Elfo(string nombre) //Aca creamos un elfo con los valores default
        {
            this.Nombre = nombre;
            this.Vida = 100;
            this.VidaLimitada = 100;
        }

        public int GetAtaqueTotal()
        {
            int total = 0;
            foreach (IItem item in Items)
            {
                total += item.Ataque;
            }
            return total;
        }
        public int GetDefensaTotal()
        {
            int total = 0;
            foreach (IItem item in Items)
            {
                total += item.Defensa;
            }
            return total;
        }

        public void Atacar(IPersonaje enemigo) // creamos el metodo de atacar el personaje,
        // Sumamos nuestro ataque total y le restamos la defensa total del otro, si es >0, le restamos el total
        {
            int daño = GetAtaqueTotal() - enemigo.GetDefensaTotal();
            if (daño > 0)
                enemigo.RecibirDaño(daño);
        }

        public void RecibirDaño(int daño)
        //el dato ("daño") nos lo da el metodo enemigo, este metodo(RecibirDaño) lo que hace es restar el total con la vida del personaje atacado
        {
            Vida -= daño;
            if (Vida < 0) Vida = 0;
        }

        public void Curar() 
        {
            Vida = VidaLimitada;
        }

        public void AgregarItem(IItem item)
        {
            Items.Add(item);
        }

        public void QuitarItem(IItem item)
        {
            Items.Remove(item);
        }

    }
}