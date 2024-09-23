/*La clase Item representa objetos que los personajes pueden equipar, como armas o armaduras,
 y que influyen en sus atributos de ataque y defensa. Los items son clave para mejorar las 
 habilidades en combate y se pueden equipar, cambiar o quitar.*/
public interface Iitem

{
    string GetName();
    // Consultar el daño que hace el Item
    double GetDamage();
    // Consultar la defensa que tiene el Item
    double GetDefense();
    bool GetMagic();
}