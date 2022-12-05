namespace FigureDLL
{
    public class Cerchio : Figura
    {
        double raggio;

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
            nome = "Cerchio";
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * raggio;
        }

        public override double Area()
        {
            return Math.PI * raggio * raggio;
        }
    }
}
