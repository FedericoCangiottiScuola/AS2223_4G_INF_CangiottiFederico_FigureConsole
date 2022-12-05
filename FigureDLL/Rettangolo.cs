namespace FigureDLL
{
    public class Rettangolo : Figura
    {
        double b;
        double altezza;

        public Rettangolo(double b, double altezza)
        {
            this.b = b;
            this.altezza = altezza;
            nome = "Rettangolo";
            lati = 4;
        }

        public override double Perimetro()
        {
            return b * 2 + altezza * 2;
        }

        public override double Area()
        {
            return b * altezza;
        }
    }
}
