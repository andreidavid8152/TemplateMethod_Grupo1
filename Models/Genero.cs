namespace TemplateMethod.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
