using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class CrearReporte
    {
        public static string Imprimir(List<Forma> formas, Idioma idioma)
        {
            var sb = new StringBuilder();
            int contadorDeFormas = 0;
            decimal totalPerimetros = 0m;
            decimal totalAreas = 0m;

            formas.ForEach(x => x.CalcularPerimetro());
            formas.ForEach(x => x.CalcularArea());

            HashSet<string> setFormas = new HashSet<string>(formas.Select(x => x.Nombre));
            contadorDeFormas = formas.Count;

            if (!formas.Any())
            {
                sb.Append(idioma.Mensajes["Vacio"]);
                return sb.ToString();
            }

            sb.Append(idioma.Mensajes["Reporte"]);

            foreach (var forma in setFormas)
            {
                var filtrado = formas.Where(x => x.Nombre == forma).ToList();

                MostrarTotalPorFormas(filtrado, sb, idioma ,ref totalPerimetros, ref totalAreas);
            }

            MostrarTotales(idioma, contadorDeFormas, totalPerimetros, totalAreas, sb);                                                                                                                                                                          
            

            return sb.ToString();

        }

        public static void MostrarTotalPorFormas(List<Forma> formas, StringBuilder builder, Idioma lan, 
           ref decimal totalPerimetros, ref decimal totalAreas)
        {
            var nombreForma = formas.Count > 1 ? formas.First().NombrePlural 
                : formas.First().NombreTraducido;

            builder.Append($"{formas.Count} {nombreForma}");

            totalAreas += MostrarArea(formas, builder, lan);
            totalPerimetros += MostrarPerimetros(formas, builder, lan);
            
        }

        public static decimal MostrarPerimetros(List<Forma> formas, StringBuilder builder, Idioma lan)
        {
            var perimetro = 0m;

            formas.ForEach(x => 
                perimetro += x.Perimetro);

            builder.Append($" | { lan.Titulos["Perimetro"]} {perimetro:#.##} <br/>");

            return perimetro;
        }

        public static decimal MostrarArea(List<Forma> formas, StringBuilder builder, Idioma lan)
        {
            var area = 0m;

            formas.ForEach(x => 
                area += x.Area);
            
            builder.Append($" | { lan.Titulos["Area"]} {area:#.##}");

            return area;
        }

        public static void MostrarTotales(Idioma lan, int cantFormas,  
            decimal perimetros, 
            decimal areas, 
            StringBuilder builder)
        {
            var forma = cantFormas > 1 ? lan.Titulos["Formas"] : lan.Titulos["Forma"];

            builder.Append($"{lan.Mensajes["Total"]}{cantFormas} {forma} " +
                $"{lan.Titulos["Perimetro"]} {perimetros:#.##} {lan.Titulos["Area"]} {areas:#.##}");
            
        }

        
    }
}
