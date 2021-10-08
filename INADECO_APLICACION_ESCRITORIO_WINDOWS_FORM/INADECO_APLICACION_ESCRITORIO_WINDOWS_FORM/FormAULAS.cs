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
    public partial class FrmAULAS : Form
    {
        public FrmAULAS()
        {
            InitializeComponent();
        }

        //CREAMOS EL DATACLASSES1DATACONTEXT DE LA BASE DE DATOS INADECO_GESTION
        DataClasses1DataContext BaseDatosInadecoGestion = new DataClasses1DataContext();
        private void FrmAULAS_Load(object sender, EventArgs e)
        {
            cargarGridAulas();
        }

        //CARGAR EL GRID DE LOS DATOS DE AULAS Y CUENTA EL NUMERO TOTAL DE AULAS REGISTRADAS EN EL TEXTNUMEROTOTALAULAS LOS MUESTRA
        void cargarGridAulas()
        {
            try
            {
                var CargaGridAulas = from aulas in BaseDatosInadecoGestion.AULAS select aulas;
                GRIDDATOSAULAS.DataSource = CargaGridAulas;
                int numero = CargaGridAulas.Count();
                textNUMEROTOTALAULAS.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS DE AULAS");
            }
        }

        //METODO RESET LIMPIAR DATOS DE TODOS LOS CAMPOS DEL FORMULARIO AULAS
        void reset()
        {
            try
            {
                textIDAULA.Text = "";
                textNOMBREAULA.Text = "";
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO RESETEAR LOS CAMPOS");
            }
        }

        //DAR DE ALTA UN AULA
        private void btnAULA_Click(object sender, EventArgs e)
        {
            try
            {
                AULAS MiAula = new AULAS();
                MiAula.ID_AULA= (int.Parse(textIDAULA.Text));
                MiAula.NOMBRE_AULA = textNOMBREAULA.Text;
                BaseDatosInadecoGestion.AULAS.InsertOnSubmit(MiAula);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridAulas();
                MessageBox.Show("EL AULA " + textIDAULA.Text + " " + textNOMBREAULA.Text + " HA SIDO DADA DE ALTA CORRECTAMENTE");
                reset();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE ALTA EL AULA, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //DAR DE BAJA UN AULA POR SU ID_AULA
        private void btnBAJAAULA_Click(object sender, EventArgs e)
        {
            try
            {

                //Sentencia Lambda
                AULAS MiAula = BaseDatosInadecoGestion.AULAS.Single(p => p.ID_AULA == (int.Parse(textIDAULA.Text)));
                BaseDatosInadecoGestion.AULAS.DeleteOnSubmit(MiAula);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridAulas();
                MessageBox.Show("EL AULA CON ID_AULA " + textIDAULA.Text + " HA SIDO DADA DE BAJA CORRECTAMENTE");
                reset();

            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE BAJA EL AULA, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //MODIFICAR LOS DATOS DEL AULA POR SU ID_AULA
        private void btnMODIFICAAULA_Click(object sender, EventArgs e)
        {
            try
            {
                //Sentencia Lambda
                AULAS MiAula = BaseDatosInadecoGestion.AULAS.Single(p => p.ID_AULA == (int.Parse(textIDAULA.Text)));
                MiAula.ID_AULA = int.Parse(textIDAULA.Text);
                MiAula.NOMBRE_AULA = textNOMBREAULA.Text;
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridAulas();
                MessageBox.Show("EL AULA CON ID_AULA " + textIDAULA.Text + " HA SIDO MODIFICADOS SUS DATOS CORRECTAMENTE");
                reset();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO MODIFICAR LOS DATOS DEL AULA, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //RESET REFRESCAR (LIMPIAR) TODOS LOS CAMPOS DEL FORMULARIO AULAS
        private void btnREFRESCARCAMPOSALUMNO_Click(object sender, EventArgs e)
        {
                textIDAULA.Text = "";
                textNOMBREAULA.Text = "";

        }
    }
}
