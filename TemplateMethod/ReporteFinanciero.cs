namespace TemplateMethod_Grupo1.TemplateMethod
{
    public class ReporteFinanciero : ReporteGenerator
    {
        protected override void PasoEspecifico()
        {
            Console.WriteLine("Generando reporte financiero específico...");
        }
    }
}
