using System;

namespace CodingChallenge.Data.Classes
{
    public class Forma
    {
        public Forma()
        {

        }
        public Forma(decimal lado, Idioma idioma)
        {
            Lado = lado;
            Idioma = idioma;

        }
        
        public string Nombre { get; set; }

        public string NombreTraducido { get; set; }

        public string NombrePlural { get; set; }
        public decimal Lado { get;  set; }
        public Idioma Idioma { get; set; }

        public decimal Perimetro { get; set; }

        public decimal Area { get; set; }



        

        public virtual void CalcularArea()
        {
            throw new NotImplementedException();
        }

        public virtual void CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}
