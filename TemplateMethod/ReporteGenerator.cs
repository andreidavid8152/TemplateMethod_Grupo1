namespace TemplateMethod_Grupo1.TemplateMethod
{
    public abstract class ReporteGenerator
    {

        public void GenerarReporte()
        {
            PasoComun1();
            PasoEspecifico();
            PasoComun2();
        }

        protected void PasoComun1()
        {
            Console.WriteLine("Paso común 1: Preparando datos para el reporte...");
        }

        protected abstract void PasoEspecifico();

        protected void PasoComun2()
        {
            Console.WriteLine("Paso común 2: Renderizando reporte...");
        }

    }
}
