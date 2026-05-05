namespace TP1bis.Models
{
    public class cabaña
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int capacidad;
        private List <string> listaFotos;
        private List <string> listaAmbientes;
        public cabaña (int id, string nombre, string descripcion, int capacidad, List <string> listaFotos, List <string> listaAmbientes)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.capacidad = capacidad;
            this.listaFotos = listaFotos;
            this.listaAmbientes = listaAmbientes;
        }
        public int devolverId ()
        {
            return id;
        }
        public string devolverNombre ()
        {
            return nombre;
        }
         public string devolverDescripcion ()
        {
            return descripcion;
        }
        public int devolverCapacidad ()
        {
            return capacidad;
        }
        public List<string> devolverListaFotos ()
        {
            return listaFotos;
        }
        public List <string> devolverListaAmbientes ()
        {
            return listaAmbientes;
        }
    }
}
