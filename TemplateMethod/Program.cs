namespace TemplateMethod_Grupo1.TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReporteGenerator reporteFinanciero = new ReporteFinanciero();
            reporteFinanciero.GenerarReporte();

            Console.WriteLine();

            ReporteGenerator reporteVentas = new ReporteVentas();
            reporteVentas.GenerarReporte();
        }
    }
}
