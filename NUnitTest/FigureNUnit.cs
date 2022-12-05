using FigureDLL;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_PerimetroQuadrato()
        {
            Quadrato q = new Quadrato(5);

            Assert.That(q.Perimetro(), Is.EqualTo(20));
        }

        [Test]
        public void Test_AreaQuadrato()
        {
            Quadrato q = new Quadrato(5);

            Assert.That(q.Area(), Is.EqualTo(25));
        }

        [Test]
        public void Test_PerimetroRettangolo()
        {
            Rettangolo r = new Rettangolo(5, 6);

            Assert.That(r.Perimetro(), Is.EqualTo(22));
        }

        [Test]
        public void Test_AreaRettangolo()
        {
            Rettangolo r = new Rettangolo(5, 6);

            Assert.That(r.Area(), Is.EqualTo(30));
        }

        [Test]
        public void Test_PerimetroCerchio()
        {
            Cerchio c = new Cerchio(6.42);

            Assert.That(c.Perimetro(), Is.EqualTo(40.33).Within(0.01));
        }

        [Test]
        public void Test_AreaCerchio()
        {
            Cerchio c = new Cerchio(6.42);

            Assert.That(c.Area(), Is.EqualTo(129.48).Within(0.01));
        }
    }
}
