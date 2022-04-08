namespace CodingChallenge.Data.Classes.Formas
{
    public class Rectangulo : FormaPitagorica
    {
        public Rectangulo(decimal b, decimal h, Idioma idioma)
            :base(b, h,idioma)
        {
            Nombre = nameof(Rectangulo);
            NombreTraducido = idioma.Formas[Nombre];
            NombrePlural = idioma.FormasPlural[Nombre];

        }

        public override void CalcularArea()
        {
            Area = Base * Altura;

        }

        public override void CalcularPerimetro()
        {
            Perimetro = 2*(Base*Altura);
        }
    }
}
