using System.Collections;

namespace Program;

public class Wizard
{
    private string name;
    private double damage;
    private double healing;

    private ArrayList listaLibroDeHechizos = new ArrayList();
    // falta agregar el libro de hechizos
    public ArrayList listaDeItems = new ArrayList();

    public Wizard(string name, bool magic, ArrayList listaDeItems, ArrayList listaDeHechizos)
    {
        this.name = name;
        this.damage = damage;
        this.listaDeItems = listaDeItems;
        this.listaLibroDeHechizos = listaDeHechizos;
    }

    public ArrayList AddItem(items items)
    {
        listaDeItems.Add(items);
        return listaDeItems;
    }

    public ArrayList learnMagic(Hechizo hechizo)
    {
        listaLibroDeHechizos.Add(hechizo);
        return listaLibroDeHechizos;
    }
    //atacar
    public string Attack()
    {
        double dañoTotal = 0;
        foreach (Hechizo hechizo in listaLibroDeHechizos)
        {
            dañoTotal += hechizo.damage;
        }

        foreach (items items in listaDeItems)
        {
            dañoTotal += items.damage;
        }

        dañoTotal += damage;
        return $"{name} uso su daño {damage}, los hechizos {listaLibroDeHechizos} y los elementos {listaDeItems} causando {dañoTotal} puntos de daño.";
        // falta agregar la accion de aplicarle el daño a otro personaje pero nose como se hace
    }
    
    public string Defend()
    {
        double curacionTotal = 0;
        foreach (Hechizo hechizo in listaLibroDeHechizos)
        {
            curacionTotal += hechizo.healing;
        }

        foreach (items items in listaDeItems)
        {
            curacionTotal += items.healing;
        }

        curacionTotal += healing;
        return $"{name} uso su curacion {healing}, los hechizos {listaLibroDeHechizos} y los elementos {listaDeItems} dando {healing} puntos de curacion.";
        // falta aplicar a otro personaje, lo mismo que en attack.
    }
}