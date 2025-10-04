namespace Program;

public class Inventory
{
    public List<IItems> ListInventory;       //Inventario es una lista de objetos del tipo Items
    
    public int Count => ListInventory.Count;

    public Inventory()
    {
        this.ListInventory = new List<IItems>();
    }
    
    public void CheckInventory()                        //Método para visualizar el inventario
    {
        foreach (IItems item in ListInventory)
        { 
            Console.WriteLine(item.Name);
        }
    } 
    public void DropObject(IItems item)                   //Método para solar un objeto
    { 
        ListInventory.Remove(item);                      //Se elimna el objeto de la lista
        Console.WriteLine($"Se eliminó {item.Name}");
    }
    
    public void PickObject(IItems item)                   //Método para agregar un objeto al inventario
    {
        bool Object_in_inventory = false;                //Definimos si el objeto esta en el inventario o no
        foreach (IItems objetos in ListInventory)         
        {
            if (item.Type == objetos.Type)               //Observamos si el tipo de objeto seleccionado es igual a algún tipo de objeto que tenemos dentro del inventario
            {
                Object_in_inventory = true;
            }
        }

        if (Object_in_inventory)                         //Evitamos que pueda tener un tipo de objeto repetido en el inventario
        {
            Console.WriteLine("¡No puedes tener dos objetos del mismo tipo!");
        } else {ListInventory.Add(item);}
    }
}