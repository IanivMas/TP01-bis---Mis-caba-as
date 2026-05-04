namespace TP1bis.Models
{
    public class complejo
    {
        private Dictionary <int, cabaña> cabañas;
        public complejo ()
        {
            this.cabañas = new Dictionary <int, cabaña>();
            cargaDeDatosManual();
        }
        public void cargaDeDatosManual ()
        {
            cabaña cabaña1 = new cabaña (1, "zas", "cabaña moderna", 5, new List<string>{"foto1.png","foto2.png","foto3.png"}, new List<string>{"cocina","comedor","habitacion 1","habitacion 2", "habitacion 3"});
            cabañas.Add(1, cabaña1);
            cabaña cabaña2 = new cabaña (2, "nashe", "cabaña vieja", 4, new List<string>{"foto4.png","foto5.png","foto6.png"}, new List<string>{"cocina","comedor","habitacion 1","habitacion 2"});
            cabañas.Add(2, cabaña2);
            cabaña cabaña3 = new cabaña (3, "polimardo", "cabaña moderna grande", 7, new List<string>{"foto7.png","foto8.png","foto9.png"}, new List<string>{"cocina","comedor","habitacion 1","habitacion 2","habitacion 3","habitacion 4"});
            cabañas.Add(3, cabaña3);
        }
        public Dictionary <int, cabaña> devolverCabañas ()
        {
            return cabañas;
        }
        public cabaña devolverCabaña(int id)
        {
            cabaña cabaña = null;
            foreach (cabaña c in cabañas.Values)
            {
                if (c.devolverId() == id)
                {
                    cabaña = c;
                }
            }
            return cabaña;
        }
    }
}