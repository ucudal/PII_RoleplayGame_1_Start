namespace LibraryTests;
using Program;
using System;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestPickObject()        //Es necesario que este metodo funcione para poder obtener armas y armaduras
    {
        Inventory Armas =new Inventory();
        Items Hacha = new Items("Hacha", 0, 20, 0, "Arma");
        Armas.PickObject(Hacha);
        Assert.IsTrue(Armas.Count > 0);
    }
    
    [Test]
    public void TestDropObject()            //Es necesario que este metodo funcion para poder cambiar o solar el arma o armadura seleccionada
    {
        Inventory Armas = new Inventory();
        Items Espada = new Items("Espada", 0, 20, 0, "Arma");
        Armas.PickObject(Espada);
        Armas.DropObject(Espada);
        Assert.IsTrue(Armas.Count == 0);
    }
}