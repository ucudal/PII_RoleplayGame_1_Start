namespace RoleplayGame
{
    public interface IPersonaje
    {
        string Nombre { get; }
        int Vida { get; }
        int VidaLimitada { get; }
        List<IItem> Items { get; }

        int GetAtaqueTotal();
        int GetDefensaTotal();
        void Atacar(IPersonaje enemigo);
        void Curar();
        void AgregarItem(IItem item);
        void QuitarItem(IItem item);
        void RecibirDaño(int daño);
    }
}