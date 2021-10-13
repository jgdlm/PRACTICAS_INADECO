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
        //CREAMOS EL DATACLASSES1DATACONTEXT DE LA BASE DE DATOS INADECO_GESTION
        DataClasses1DataContext BaseDatosInadecoGestion = new DataClasses1DataContext();
        public FrmCARGARTODOSDATOS()
        {
            InitializeComponent();
        }

        //CARGAR EL GRID DE LOS DATOS DE CURSOS Y CUENTA EL NUMERO TOTAL DE CURSOS REGISTRADOS EN EL TEXTNUMEROTOTALCURSOS LOS MUESTRA
        void cargarGridTodosDatos()
         {
             try
             {
                 
                 GRIDTODOSDATOS.DataSource = BaseDatosInadecoGestion.cargarGridTodosDatos();
             }
             catch
             {
                 MessageBox.Show("NO SE HA PODIDO CARGAR LOS REGISTROS DE TODOS LOS DATOS: ALUMNOS, PROFESORES, CURSOS, AULAS");
             }

         }

        private void FrmCARGARTODOSDATOS_Load(object sender, EventArgs e)
        {
            this.cargarGridTodosDatos();

        }

       


    }
}
