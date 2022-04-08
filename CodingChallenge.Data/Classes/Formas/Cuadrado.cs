namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Forma
    {
        public Cuadrado(decimal lado, Idioma idioma)
        : base(lado, idioma)
        {
            Nombre = nameof(Cuadrado);
            NombreTraducido = idioma.Formas[Nombre];
            NombrePlural = idioma.FormasPlural[Nombre];
        }
        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 4;
        }
    }
}
