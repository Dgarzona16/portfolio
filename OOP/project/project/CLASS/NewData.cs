using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.CLASS
{
    public class NewEvent
    {
        public string Titulo;
        public string Portada;
        public string FechaHora_Inicio;
        public string FechaHora_Fin;
        public int CantidadParticipantes;
        public string Imagen;
        public int Id_Area;

        public NewEvent() { }
    }

    public class NewCollection
    {
        public string Nombre;
        public string Tipo;
        public string Genero;
        public int Id_Area;

        public NewCollection() { }
    }
}
