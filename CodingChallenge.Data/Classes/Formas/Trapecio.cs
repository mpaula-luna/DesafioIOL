namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaPitagorica
    {
        public decimal BaseMenor { get; set; }
        public Trapecio(decimal b, decimal B, decimal h, decimal l,Idioma idioma)
            :base(B, h, idioma)
        {
            Nombre = nameof(Trapecio);
            NombreTraducido = idioma.Formas[Nombre];
            NombrePlural = idioma.FormasPlural[Nombre];
            BaseMenor = b;
            Lado = l;
        }

        public override void CalcularArea()
        {
            Area = ((Base * BaseMenor) * Altura) / 2;

        }

        public override void CalcularPerimetro()
        {
            Perimetro = (Lado * 2) + Base + BaseMenor;
        }

    }


}
