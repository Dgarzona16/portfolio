using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.CONNECT_SQL;
using project.FORMS;
using System.Data;

namespace project.CLASS
{
    //
    //clase padre de los constructores de busqueda
    //
    public abstract class FormTemplate
    {
        public List<string> CmbItems = new List<string>();
        public SQLReaderWriter consulta;
        public FormTemplate()
        {

        }
        public abstract void RunView(DataTable dt);
    }
    //
    //constructor de busqueda de eventos
    //
    public class EventComplement : FormTemplate
    {
        public EventComplement()
        {
            CmbItems.Add("Nombre de Evento");
            CmbItems.Add("Area");
            consulta = new EventSQL();
        }

        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewEvento(dt))
            {
                view.ShowDialog();
            }
        }
    }
    //
    //constructor de busqueda de colecciones
    //
    public class ColectionComplement : FormTemplate
    {
        public ColectionComplement()
        {
            CmbItems.Add("Nombre de coleccion");
            CmbItems.Add("Tipo de coleccion");
            CmbItems.Add("Genero");
            consulta = new CollectionSQL();
        }
        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewColeccion(dt))
            {
                view.ShowDialog();
            }
        }
    }
    //
    //constructor de busqueda de materiales
    //
    public class MaterialComplement : FormTemplate
    {
        public MaterialComplement()
        {
            CmbItems.Add("Nombre del material");
            CmbItems.Add("Palabras clave");
            CmbItems.Add("Autor");
            CmbItems.Add("Formato");
            consulta = new MaterialSQL();
        }
        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewMaterial(dt))
            {
                view.ShowDialog();
            }
        }
    }
    //
    //constructor de busqueda de reservas
    //
    public class ReserveComplement : FormTemplate
    {
        public ReserveComplement()
        {
            CmbItems.Add("Reserva / Usuario");
            CmbItems.Add("Prestamo / Usuario");
            consulta = new ReserveSQL();
        }
        public override void RunView(DataTable dt)
        {
            MessageBox.Show("Informacion completa");
        }
    }
    //
    //constructor de busqueda de usuario 
    //
    public class UserComplement : FormTemplate
    {
        public UserComplement()
        {
            CmbItems.Add("Nombre");
            CmbItems.Add("Ocupacion");
            consulta = new UserSQL();
        }
        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewCarnet(dt))
            {
                view.ShowDialog();
            }
        }
    }
}
