using NUnit.Framework;
using RoleplayGame;

namespace RoleplayGameTests
{
    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void libroDeHechizosSumaElPoder()
        {
            // si agregamos dos hechizos al libro el ataque tiene que ser la suma
            LibroHechizos libro = new LibroHechizos();
            libro.AgregarHechizo(new Hechizo("rayo", 10));
            libro.AgregarHechizo(new Hechizo("bola de fuego", 20));

            Assert.That(libro.Ataque, Is.EqualTo(30));
        }

        [Test]
        public void libroDefensaSiempreCero()
        {
            // por ahora el libro de hechizos no da defensa
            LibroHechizos libro = new LibroHechizos();

            Assert.That(libro.Defensa, Is.EqualTo(0));
        }

        [Test]
        public void espadaDaAtaqueYNoDefensa()
        {
            // la espada deberia dar ataque pero no defensa
            Espada espada = new Espada();

            Assert.That(espada.Ataque, Is.GreaterThan(0));
            Assert.That(espada.Defensa, Is.EqualTo(0));
        }

        [Test]
        public void armaduraDaDefensaYNoAtaque()
        {
            // la armadura deberia dar defensa pero no ataque
            Armadura armadura = new Armadura();

            Assert.That(armadura.Defensa, Is.GreaterThan(0));
            Assert.That(armadura.Ataque, Is.EqualTo(0));
        }
    }
}