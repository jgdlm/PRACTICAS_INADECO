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


        //METODO CARGAR EL GRID DE TODOS LOS DATOS DE LOS FORMS: FormCURSOS, FormALUMNOS, FormPROFESORES, FormAULAS
        private void FrmCARGARTODOSDATOS_Load(object sender, EventArgs e)
        {
            this.cargarGridTodosDatos();

        }


        //CARGAR EL GRID DE TODOS LOS DATOS DE LOS FORMS: FormCURSOS, FormALUMNOS, FormPROFESORES, FormAULAS
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

        

        
    }
}
