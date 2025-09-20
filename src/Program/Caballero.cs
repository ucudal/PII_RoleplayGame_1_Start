

public class Caballero : IPersonaje
{

    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int DañoAtaque{ get; set; }
    public int ValorDefensa { get; set; }

    public Caballero(string nombre, int vida, int dañoataque, int valordefensa)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.DañoAtaque = dañoataque;
        this.ValorDefensa = valordefensa;
    }

    public void RecibirAtaque(int puntosAtaque)
    {
        this.Vida -= puntosAtaque;
    }
    public void Curarse();
        
}