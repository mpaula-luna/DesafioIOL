namespace CodingChallenge.Data.Classes.Formas
{
    public class FormaPitagorica : Forma
    {
        public decimal Base { get; set; }

        public decimal Altura { get; set; }

        public FormaPitagorica(decimal b, decimal a, Idioma idioma)
        {
            Base = b;
            Altura = a;
            Idioma = idioma;

        }
    }
}
