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
    public abstract class FormTemplate
    {
        public List<string> CmbItems = new List<string>();
        public SQLReaderWriter consulta;
        public FormTemplate()
        {

        }
        public abstract void RunView(DataTable dt);
    }

    public class EventComplement : FormTemplate
    {

        public EventComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre de Evento");
            CmbItems.Add("Area");
            consulta = new EventSQL();
        }

        public override void RunView(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }

    public class ColectionComplement : FormTemplate
    {
        public ColectionComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre de coleccion");
            CmbItems.Add("Tipo de coleccion");
            CmbItems.Add("Genero");
            consulta = new CollectionSQL();
        }
        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewCarnet(dt))
            {
                view.ShowDialog();
            }
        }
    }

    public class MaterialComplement : FormTemplate
    {
        public MaterialComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Nombre del material");
            CmbItems.Add("Palabras clave");
            CmbItems.Add("Autor");
            CmbItems.Add("Formato");
            consulta = new MaterialSQL();
        }
        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewCarnet(dt))
            {
                view.ShowDialog();
            }
        }
    }

    public class ReserveComplement : FormTemplate
    {
        public ReserveComplement()
        {
            //
            //Buscar
            //
            CmbItems.Add("Reserva / Usuario");
            CmbItems.Add("Prestamo / Usuario");
            consulta = new ReserveSQL();
        }
        public override void RunView(DataTable dt)
        {
            using (var view = new frmViewCarnet(dt))
            {
                view.ShowDialog();
            }
        }
    }

    public class UserComplement : FormTemplate
    {
        public UserComplement()
        {
            //
            //Buscar
            //
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
