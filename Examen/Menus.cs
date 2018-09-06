using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Menus
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public int Horadeinicio { get; set; }
        public int Horadefin { get; set; }
        public List<Platillos> Platillos { get; set; }
        public Menus()
        {
            Nombre = "Nuevo menu";
            Platillos = new List<Platillos>();
        }
    }
}
