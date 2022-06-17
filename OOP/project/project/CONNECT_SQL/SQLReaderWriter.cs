using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using project.CLASS;

namespace project.CONNECT_SQL
{
    //
    //Interfaz
    //
    public interface SQLReaderWriter
    {
        DataTable consult(string a, string b);
    }
    //
    //Evento
    //
    public class EventSQL : accessSQL, SQLReaderWriter
    {
        public EventSQL() : base()
        {
        }
        public DataTable getAreas()
        {
            DataTable ds = new DataTable();
            using(var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Nombre FROM AREA";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(ds);
                }
            }
            return ds;
        }
        public DataTable consult(string word, string colunm)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (colunm == "Nombre de Evento")
                    {
                        command.CommandText = $"SELECT EVENTO.Id, EVENTO.Titulo, EVENTO.FechaHora_Inicio, EVENTO.FechaHora_Fin, EVENTO.CantidadParticipantes, AREA.Nombre AS 'Area' FROM EVENTO INNER JOIN AREA ON EVENTO.Id_Area = AREA.Id WHERE Titulo LIKE '{word}%'";
                    }
                    if (colunm == "Area")
                    {
                        command.CommandText = $"SELECT EVENTO.Id, EVENTO.Titulo, EVENTO.FechaHora_Inicio, EVENTO.FechaHora_Fin, EVENTO.CantidadParticipantes, AREA.Nombre AS 'Area' FROM EVENTO INNER JOIN AREA ON EVENTO.Id_Area = AREA.Id WHERE AREA.Nombre LIKE '{word}%'";
                    }

                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public bool Insert(NewEvent EventData)
        {
            using(var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO EVENTO (Titulo, Imagen, FechaHora_Inicio, FechaHora_Fin, CantidadParticipantes, Id_Area) VALUES ('{EventData.Titulo}','{EventData.Imagen}', CONVERT(datetime,'{EventData.FechaHora_Inicio}'), CONVERT(datetime,'{EventData.FechaHora_Fin}'), {EventData.CantidadParticipantes}, {EventData.Id_Area})";
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
    //
    //Coleccion
    //
    public class CollectionSQL : accessSQL, SQLReaderWriter
    {
        public CollectionSQL() : base()
        {
        }
        public DataTable getAreas()
        {
            DataTable ds = new DataTable();
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Nombre FROM AREA";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(ds);
                }
            }
            return ds;
        }
        DataTable SQLReaderWriter.consult(string word, string colunm)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (colunm == "Nombre de coleccion")
                    {
                        command.CommandText = $"SELECT COLECCION.Id, COLECCION.Nombre, COLECCION.Tipo, COLECCION.Genero, AREA.Nombre AS 'Area' FROM COLECCION INNER JOIN AREA ON COLECCION.Id_Area = AREA.Id WHERE COLECCION.Nombre LIKE '{word}%'";
                    }
                    if (colunm == "Tipo de coleccion")
                    {
                        command.CommandText = $"SELECT COLECCION.Id, COLECCION.Nombre, COLECCION.Tipo, COLECCION.Genero, AREA.Nombre AS 'Area' FROM COLECCION INNER JOIN AREA ON COLECCION.Id_Area = AREA.Id WHERE COLECCION.Tipo LIKE '{word}%'";
                    }
                    if (colunm == "Genero")
                    {
                        command.CommandText = $"SELECT COLECCION.Id, COLECCION.Nombre, COLECCION.Tipo, COLECCION.Genero, AREA.Nombre AS 'Area' FROM COLECCION INNER JOIN AREA ON COLECCION.Id_Area = AREA.Id WHERE COLECCION.Genero LIKE '{word}%'";
                    }

                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public bool Insert(NewCollection CollectionData)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO COLECCION (Nombre, Tipo, Genero, Id_Area) VALUES ('{CollectionData.Nombre}', '{CollectionData.Tipo}', '{CollectionData.Genero}', '{CollectionData.Id_Area}')";
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
    //
    //Material
    //
    public class MaterialSQL : accessSQL, SQLReaderWriter
    {
        public MaterialSQL() : base()
        {
        }
        public DataTable getFormato() 
        {
            DataTable dt = new DataTable();
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Tipo FROM FORMATO";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable getColecciones()
        {
            DataTable dt = new DataTable();
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Nombre FROM COLECCION";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(dt);
                }
            }
            return dt;
        }
        DataTable SQLReaderWriter.consult(string word, string colunm)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (colunm == "Nombre del material")
                    {
                        command.CommandText = $"SELECT MATERIAL.Id, MATERIAL.Nombre, MATERIAL.Autor, MATERIAL.Idioma, MATERIAL.Editorial, COLECCION.Nombre AS 'Coleccion' FROM MATERIAL INNER JOIN COLECCION ON MATERIAL.Id_Coleccion = COLECCION.Id WHERE MATERIAL.Nombre LIKE '{word}%'";
                    }
                    if (colunm == "Autor")
                    {
                        command.CommandText = $"SELECT MATERIAL.Id, MATERIAL.Nombre, MATERIAL.Autor, MATERIAL.Idioma, MATERIAL.Editorial, COLECCION.Nombre AS 'Coleccion' FROM MATERIAL INNER JOIN COLECCION ON MATERIAL.Id_Coleccion = COLECCION.Id WHERE MATERIAL.Autor LIKE '{word}%'";
                    }
                    if (colunm == "Formato")
                    {
                        command.CommandText = $"SELECT MATERIAL.Id, MATERIAL.Nombre, MATERIAL.Autor, MATERIAL.Idioma, MATERIAL.Editorial, COLECCION.Nombre AS 'Coleccion' FROM MATERIAL INNER JOIN COLECCION ON MATERIAL.Id_Coleccion = COLECCION.Id INNER JOIN FORMATO ON MATERIAL.Id_Formato = FORMATO.Id WHERE FORMATO.Tipo LIKE '{word}%'";
                    }
                    if (colunm == "Palabras clave")
                    {
                        command.CommandText = $"SELECT MATERIAL.Id, MATERIAL.Nombre, MATERIAL.Autor, MATERIAL.Idioma, MATERIAL.Editorial, COLECCION.Nombre AS 'Coleccion' FROM MATERIAL INNER JOIN COLECCION ON MATERIAL.Id_Coleccion = COLECCION.Id INNER JOIN PALABRAS ON PALABRAS.Id_Material = MATERIAL.Id WHERE PALABRAS.Palabra LIKE '{word}%'";
                    }

                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public bool Insert(NewMaterial materialData)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO MATERIAL (Nombre, Portada, Autor, Idioma, Editorial, Fecha_Publicacion,Id_Formato, Id_Coleccion) VALUES ('{materialData.Nombre}', '{materialData.Portada}', '{materialData.Autor}', '{materialData.Idioma}', '{materialData.Editorial}', CONVERT(date,'{materialData.FechaPublicacion}'), '{materialData.Id_Formato}', '{materialData.Id_Coleccion}')";
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
    //
    //Reserva
    //
    public class ReserveSQL : accessSQL, SQLReaderWriter
    {
        public ReserveSQL() : base()
        {
        }
        DataTable SQLReaderWriter.consult(string word, string colunm)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (colunm == "Reserva / Usuario")
                    {
                        command.CommandText = $"SELECT USUARIO.Nombre AS 'Usuario', RESERVA.FechaHora_Reserva AS 'Fecha_Reserva', RESERVA.FechaHora_Prestamo AS 'Fecha_Prestamo', RESERVA.FechaHora_Devolucion AS 'Fecha_Devolucion', MATERIAL.Nombre AS 'Objeto_Prestado'FROM RESERVA INNER JOIN USUARIO ON RESERVA.Id_Usuario = USUARIO.Id INNER JOIN MATERIAL ON RESERVA.Id_Material = MATERIAL.Id WHERE USUARIO.Nombre LIKE '{word}%'";
                    }
                    if (colunm == "Prestamo / Usuario")
                    {
                        command.CommandText = $"SELECT USUAIO.Nombre AS 'Usuario', PRESTAMO.FechaHora_Prestamo AS 'Fecha Prestamo', PRESTAMO.FechaHora_Devolucion AS 'Fecha devolucion', MATERIAL.Nombre AS 'Objeto prestado'FROM PRESTAMO INNER JOIN USUARIO ON PRESTAMO.Id_Usuario = USUARIO.Id INNER JOIN MATERIAL ON PRESTAMO.Id_Material = MATERIAL.Id WHERE USUARIO.Nombre LIKE '{word}%'";
                    }

                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        bool Insert(NewEvent EventData)//modificar
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO EVENTO (Titulo, FechaHora_Inicio, FechaHora_Fin, CantidadParticipantes, Id_Area) VALUES ('{EventData.Titulo}', '{EventData.FechaHora_Inicio}', '{EventData.FechaHora_Fin}', '{EventData.CantidadParticipantes}', '{EventData.Id_Area}')";
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
    //
    //Usuario
    //
    public class UserSQL : accessSQL, SQLReaderWriter
    {
        public UserSQL() : base()
        {
        }
        DataTable SQLReaderWriter.consult(string word, string colunm)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    if (colunm == "Nombre")
                    {
                        command.CommandText = $"SELECT Id, Nombre, Direccion, Institucion, Telefono, Correo, Ocupacion FROM USUARIO WHERE Nombre LIKE '{word}%'";
                    }
                    if (colunm == "Ocupacion")
                    {
                        command.CommandText = $"SELECT Id, Nombre, Direccion, Institucion, Telefono, Correo, Ocupacion FROM USUARIO WHERE Nombre LIKE '{word}%'";
                    }

                    command.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        bool Insert(NewEvent EventData)//modificar
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO EVENTO (Titulo, FechaHora_Inicio, FechaHora_Fin, CantidadParticipantes, Id_Area) VALUES ('{EventData.Titulo}', '{EventData.FechaHora_Inicio}', '{EventData.FechaHora_Fin}', '{EventData.CantidadParticipantes}', '{EventData.Id_Area}')";
                    command.CommandType = CommandType.Text;
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}



