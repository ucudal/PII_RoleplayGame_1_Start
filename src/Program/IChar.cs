public interface IChar
{
    // Obtener el nombre del personaje
    string GetName();
    
    // Obtener la vida actual del personaje
    double GetHealth();
    
    // Obtener la vida máxima del personaje
    double GetMaxHealth();
    
    // Añadir un ítem al personaje
    void AddItem(Item item);

    // Eliminar un ítem del personaje
    void RemoveItem(Item item);

    // Obtener el valor total de ataque
    double GetTotalAttackValue();

    // Obtener el valor total de defensa
    double GetTotalDefenseValue();

    // Método para recibir daño
    void ReceiveDamage(double damage);

    // Método para curar al personaje
    void Heal();
}