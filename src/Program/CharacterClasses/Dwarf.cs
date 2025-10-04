using System.IO.Pipes;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace Program.CharacterClasses;

public class Dwarf : ICharacter         //Creo la clase Dwarf del tipo Icharacter
{
    
    public List<Inventory> ListInventory { get; set; }
    public string Name { get; set; }    //Atributo Name tipo string
    public int Health { get; set; }    //Atributo Health tipo int
    public int MeleeDamage { get; set; } //Atributo MeleeDamage tipo int
    public int TotalHealth {get; set;} //Atributo TotalHealth tipo int
    public Inventory Inventory {get; set;} //Atributo Inventory tipo Inventory
    public int Armor   //Atributo Armor tipo int
    {
        get            //get personalizado de Armor
        {
            int totalArmor = 0;     //Inicializo totalArmor en 0
            foreach (IItems item in this.Inventory.ListInventory) //Itero en cada item de la Lista ListInventory
            {
                totalArmor += item.Armor; //Sumo la armadura que da cada item a la armadura total
            }

            return totalArmor;  //Retorno totalArmor ya calculado
        }
    }
    
    public Dwarf(string name, int health, int meleeDamage, Inventory listInventory)  //Constructor Dwarf
    {
        this.Name = name;
        this.Health = health;   //Vida actual
        this.MeleeDamage = meleeDamage;
        this.TotalHealth = health;  //Vida total
        this.Inventory = listInventory;
        
       
    }

    public void Attack(ICharacter target) //Método Attack que toma el objetivo (target) al que está atacando
    {
        int additionalDamage = 0;       //Inicializo additionalDamage en 0 
        foreach(IItems item in this.Inventory.ListInventory)     //Itero en cada item de la lista ListInventory
        {
            additionalDamage += item.Damage;    //Sumo el daño que inflige cada item a additionalDamage
        }
        target.Health -= ((MeleeDamage + additionalDamage) - target.Armor); //Calculo cuanta vida le resta al target
    }
    

    public void Heal()  //Método Curar
    {
        this.Health = TotalHealth; //A Health le paso el valor TotalHealth que es el que guardamos cuando se creó el dwarf
    }

    public void CheckInventory() //Método que muestra el inventario
    {       
        this.Inventory.CheckInventory(); //Llama al método CheckInventory que está ubicado en Inventory
    }

    public void PickObject(IItems item)  //Método agarrar objeto (item) que recibe un item del tipo Items
    {
        this.Inventory.PickObject(item);    //Llama al método PickObject(item) que esta ubicado en Inventory
    }

    public void DropObject(IItems item)  //Método tirar objeto (item) que recibe un item del tipo Items
    {
        this.Inventory.DropObject(item);    //Llama al método DropObject(item) que esta ubicado en Inventory
    }

    
}
 