namespace Program.CharacterClasses;

public class Elfo: ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MagicDamage { get; set; }
    public int MeleeDamage { get; set; }
    public int TotalHealth { get; set; }
    public int Armor        //Atributo que resta la cantidad de vida que se le quita dependiendo si en el inventario poseés algo que aumente la defensa
    {
        get
        {
            int totalArmor = 0;
            foreach (Items item in this.Inventory.ListInventory)   //Recorremos el inventario para sumar armadura
            {
                totalArmor += item.Armor;
            }
            return totalArmor;
        }
    }

    public Inventory Inventory {get; set;}

    
    public Elfo(string name, int health, int magicDamage, int meleeDamage, Inventory listInventory)
    {
        this.Name = name;
        this.Health = health;
        this.MagicDamage = magicDamage;
        this.MeleeDamage = meleeDamage;
        this.TotalHealth = health;
        this.Inventory = listInventory;
    }
    
    public void Attack(ICharacter target)           //Método que sirve para atacar
    {
        int additionalDamage = 0;
        foreach(Items item in this.Inventory.ListInventory)
        {
            additionalDamage += item.Damage + item.MagicDamage;     
        }
        target.Health -= ((MeleeDamage + MagicDamage + additionalDamage) - target.Armor); //Sumamos los daños de los objetos más el daño del usuario
    }

    public void Heal()          //Método para curar la vida al completo
    {
        this.Health = TotalHealth ;
    }

    public void CheckInventory()    //Método para revisar el inventario
    {
        this.Inventory.CheckInventory();
    }

    public void PickObject(Items item)      //Método para agarrar un objeto/Añadir al inventario
    {
        this.Inventory.PickObject(item);
    }

    public void DropObject(Items item)      //Método para tirar el objeto seleccionado del inventario
    {
        this.Inventory.DropObject(item);
    }
    
    //Cosas para mejorar:
    // Poder Seleccionar un objeto y atacar con el mismo
    // Diferenciar los daños magicos de los daños físicos
}