using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : Forma
    {
        public Circulo(decimal lado, Idioma idioma)
            :base(lado, idioma)
        {
            Nombre = nameof(Circulo);
            NombreTraducido = idioma.Formas[Nombre];
            NombrePlural = idioma.FormasPlural[Nombre];
        }
        public override void CalcularArea()
        {
            Area = (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }

        public override void CalcularPerimetro()
        {
            Perimetro = (decimal)Math.PI * Lado;
        }
    }
}
