namespace Program;

public class Inventory
{
    public List<Items> ListInventory;

    public Inventory(Items item)
    {
        this.ListInventory = new List<Items>();
    }
    
    public void CheckInventory()
    {
        foreach (Items item in ListInventory)
        { 
            Console.WriteLine(item);
        }
    } 
    public void DropObject(Items item)
    { 
        ListInventory.Remove(item); 
        Console.WriteLine($"Se eliminó {item.Name}");
    }
    
    public void PickObject(Items item)
    {
        bool Object_in_inventory = false;
        foreach (Items objetos in ListInventory)
        {
            if (item.Type == objetos.Type)
            {
                Object_in_inventory = true;
            }
        }

        if (Object_in_inventory)
        {
            Console.WriteLine("¡No puedes tener dos objetos del mismo tipo!");
        } else {ListInventory.Add(item);}
    }
}