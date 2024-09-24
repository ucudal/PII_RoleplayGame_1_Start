/*La interfaz IChar define el comportamiento básico que todos los personajes deben implementar.
 Incluye métodos esenciales como atacar, defender, curar, y verificar si un personaje está vivo, 
 proporcionando una estructura común para todos los tipos de personajes.*/
public interface IChar
{
    // Obtener el nombre del personaje
    string GetName();

    string GetType(); //nos da el tipo de personaje, onda mago enano etc..
    
    // Obtener la vida actual del personaje
    double GetHealth();
    
    // Obtener la vida máxima del personaje
    double GetMaxHealth();
    
    // Añadir un ítem al personaje
    void AddItem(Iitem item);

    // Eliminar un ítem del personaje
    void RemoveItem(Iitem item);

    // Obtener el valor total de ataque
    double GetTotalAttackValue();

    // Obtener el valor total de defensa
    double GetTotalDefenseValue();

    // Método para recibir daño
    void ReceiveDamage(double damage);

    // Método para curar al personaje
    void Heal();

    // Método para atacar otro personaje
    void Attack(Character enemy);

    void ItemMagical(Character character, Iitem item); //para ver si el personaje es mago y asi puede usar el elemento magico
    
}