using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Platillos
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }
        private float Floatprecio;
        public float Precio
        {
            get
            {
                return Floatprecio;
            }
            set
            {
                if (value < 50)
                {
                    Floatprecio = 50;
                }
                else
                {
                    Floatprecio = value;
                }
            }
        }
        public List<Ingredientes> Ingredientes { get; set; }
        public Platillos()
        {
            Ingredientes = new List<Ingredientes>();
        }
    }
}
