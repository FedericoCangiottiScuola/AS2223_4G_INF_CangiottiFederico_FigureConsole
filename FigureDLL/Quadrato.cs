namespace FigureDLL
{
    public class Quadrato : Figura
    {
        double lato;

        public Quadrato(double lato)
        {
            this.lato = lato;
            nome = "Quadrato";
            lati = 4;
        }

        public override double Perimetro()
        {
            return lato * lati;
        }

        public override double Area()
        {
            return lato * lato;
        }
    }
}
