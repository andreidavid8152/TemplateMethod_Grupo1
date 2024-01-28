namespace TemplateMethod_Grupo1.TemplateMethod
{
    public class ReporteVentas : ReporteGenerator
    {
        protected override void PasoEspecifico()
        {
            Console.WriteLine("Generando reporte de ventas específico...");
        }
    }
}
