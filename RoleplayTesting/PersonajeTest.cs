using NUnit.Framework;
using RoleplayGame;
namespace RoleplayGameTests
{
    [TestFixture]
    public class PersonajeTests
    {
        [Test]
        public void curarVuelveLaVidaAlMaximo()
        {
            // probamos que si un mago se cura vuelve a tener la vida inicial
            Mago lord = new Mago("Lord");
            lord.RecibirDaño(20); // le bajamos la vida

            Assert.That(lord.Vida, Is.LessThan(lord.VidaLimitada));

            lord.Curar();

            Assert.That(lord.Vida, Is.EqualTo(lord.VidaLimitada));
        }

        [Test]
        public void atacarBajaVidaDelOtro()
        {
            // si un mago con espada ataca a un enano deberia bajarle la vida
            Mago lord = new Mago("Lord");
            lord.AgregarItem(new Espada());

            Enano laPerla = new Enano("La Perla");
            int vidaAntes = laPerla.Vida;

            lord.Atacar(laPerla);

            Assert.That(laPerla.Vida, Is.LessThan(vidaAntes));
        }
        [Test]
        public void defensaConArmaduraReduceElDaño()
        {
            // mago ataca a dos enanos, uno con armadura y otro sin
            Mago lord = new Mago("Lord");
            lord.AgregarItem(new Espada()); // el mago ataca con espada

            Enano enanoSinArmadura = new Enano("Enano1");
            Enano enanoConArmadura = new Enano("Enano2");
            enanoConArmadura.AgregarItem(new Armadura());

            int vidaAntes1 = enanoSinArmadura.Vida;
            int vidaAntes2 = enanoConArmadura.Vida;

            // el mago ataca a los dos
            lord.Atacar(enanoSinArmadura);
            lord.Atacar(enanoConArmadura);

            int dañoSinArmadura = vidaAntes1 - enanoSinArmadura.Vida;
            int dañoConArmadura = vidaAntes2 - enanoConArmadura.Vida;

            // el enano con armadura tiene que recibir menos daño
            Assert.That(dañoConArmadura, Is.LessThan(dañoSinArmadura));
        }
        [Test]
        public void personajeSinItemsNoHaceDaño()
        {
            // un elfo sin items no deberia poder dañar a un enano
            Elfo joaco = new Elfo("Joaco");
            Enano tata = new Enano("Tata");

            int vidaAntes = tata.Vida;
            joaco.Atacar(tata);

            Assert.That(tata.Vida, Is.EqualTo(vidaAntes));
        }
    }
}