using System;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo : Forma
    {
        public Triangulo(decimal lado, Idioma idioma)
            :base(lado, idioma)
        {
            Nombre = nameof(Triangulo);
            NombreTraducido = idioma.Formas[Nombre];
            NombrePlural = idioma.FormasPlural[Nombre];
        }
        
        public override void  CalcularArea()
        {
            Area =  ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
           
        }

        public override void CalcularPerimetro()
        {
            Perimetro = Lado * 3;
        }
    }
}
