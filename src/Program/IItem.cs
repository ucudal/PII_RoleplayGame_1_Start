
public interface IItem
{
    // Nombre del ítem
    string Nombre { get; }

    // Valor de ataque que aporta el ítem (0 si no aplica)
    int Ataque { get; }

    // Valor de defensa que aporta el ítem (0 si no aplica)
    int Defensa { get; }
}
