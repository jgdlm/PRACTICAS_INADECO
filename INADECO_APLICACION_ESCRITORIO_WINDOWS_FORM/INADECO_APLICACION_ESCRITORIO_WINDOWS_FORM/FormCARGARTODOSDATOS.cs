using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INADECO_APLICACION_ESCRITORIO_WINDOWS_FORM
{
    public partial class FrmCARGARTODOSDATOS : Form
    {
        public FrmCARGARTODOSDATOS()
        {
            InitializeComponent();
        }

        //CREAMOS EL DATACLASSES1DATACONTEXT DE LA BASE DE DATOS INADECO_GESTION
        DataClasses1DataContext BaseDatosInadecoGestion = new DataClasses1DataContext();
        private void FrmCARGARTODOSDATOS_Load(object sender, EventArgs e)
        {
            cargarGridTodosDatos();
        }

        //CARGAR EL GRID DE LOS DATOS DE CURSOS Y CUENTA EL NUMERO TOTAL DE CURSOS REGISTRADOS EN EL TEXTNUMEROTOTALCURSOS LOS MUESTRA
        void cargarGridTodosDatos()
        {
            try
            {
                var CargaGridTodosDatos = from todos in BaseDatosInadecoGestion.ALUMNOS select todos;
                GRIDTODOSDATOS.DataSource = CargaGridTodosDatos;
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS DE TODOS LOS DATOS: ALUMNOS, PROFESORES, CURSOS, AULAS");
            }

        }

        
    }
}
