
public interface IPersonaje
{
   string Nombre { get; set; }
   int Vida { get; set; }
   int DañoAtaque{ get; set; }
   int ValorDefensa { get; set; }
   
   public void RecibirAtaque();
   public void Curarse();
}
