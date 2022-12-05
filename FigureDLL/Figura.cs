namespace FigureDLL
{
    public class Figura
    {
        protected string? nome;
        protected int lati;

        protected Figura()
        {
            nome = "Figura generica";
            lati = 0;
        }

        public virtual double Perimetro()
        {
            return 0;
        }

        public virtual double Area()
        {
            return 0;
        }
    }
}
