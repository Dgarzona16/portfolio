using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.CLASS
{
    //
    //Objeto de evento
    //
    public class NewEvent
    {
        public string Titulo;
        public string FechaHora_Inicio;
        public string FechaHora_Fin;
        public int CantidadParticipantes;
        public string Imagen;
        public int Id_Area;

        public NewEvent() { }
    }
    //
    //Objeto de coleccion
    //
    public class NewCollection
    {
        public string Nombre;
        public string Tipo;
        public string Genero;
        public int Id_Area;

        public NewCollection() { }
    }
    //
    //Objeto de material
    //
    public class NewMaterial
    {
        public string Nombre;
        public string Autor;
        public string Editorial;
        public string FechaPublicacion;
        public string Idioma;
        public string Portada;
        public int Id_Formato;
        public int Id_Coleccion;

        public NewMaterial() { }
    }
    //
    //Objeto de Reserva
    //
    public class NewReservation
    {
        public int Id_Material;
        public int Id_Usuario;
        public string FechaHora_Prestamo;
        public string FechaHora_Devolucion;
        public string FechaHora_Reserva;

        public NewReservation() { }
    }
    //
    //Objeto de Usuario
    //
    public class NewUser
    {
        public string Nombre;
        public string Direccion;
        public string Institucion;
        public string Telefono;
        public string Correo;
        public string Fotografia;
        public string Ocupacion;

        public NewUser() { }
    }
}
