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
    public partial class FrmPROFESORES : Form
    {
        public FrmPROFESORES()
        {
            InitializeComponent();
        }

        //CREAMOS EL DATACLASSES1DATACONTEXT DE LA BASE DE DATOS INADECO_GESTION
        DataClasses1DataContext BaseDatosInadecoGestion = new DataClasses1DataContext();

        //METODO CARGAR EL GRID DE DATOS PROFESORES CON LOS DATOS DE PROFESORES DE LA BASE DE DATOS INADECO_GESTION SQL
        private void FrmPROFESORES_Load(object sender, EventArgs e)
        {
            cargarGridProfesores();
        }

        //CARGAR EL GRID DE LOS DATOS DE PROFESORES Y CUENTA EL NUMERO TOTAL DE PROFESORES REGISTRADOS EN EL TEXTNUMEROTOTALPROFESORES LOS MUESTRA
        void cargarGridProfesores()
        {
            try
            {
                var CargaGridProfesores = from profesores in BaseDatosInadecoGestion.PROFESORES select profesores;
                GRIDDATOSPROFESOR.DataSource = CargaGridProfesores;
                int numero = CargaGridProfesores.Count();
                textNUMEROTOTALPROFESORES.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS DE PROFESORES");
            }

        }

        //METODO RESET LIMPIAR DATOS DE TODOS LOS CAMPOS DEL FORMULARIO PROFESORES
        void reset()
        {
            try
            {
                textDNIPROFESOR.Text = "";
                textNOMBRE.Text = "";
                textPRIMER_APELLIDO.Text = "";
                textSEGUNDO_APELLIDO.Text = "";
                textDIRECCION.Text = "";
                textCIUDAD.Text = "";
                textCODIGO_POSTAL.Text = "";
                textPROVINCIA.Text = "";
                textTELEFONO.Text = "";
                textEMAIL.Text = "";
                textBUSCARPROFESOR.Text = "";
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO RESETEAR LOS CAMPOS");
            }
        }

        //DAR DE ALTA UN PROFESOR
        private void btnALTAPROFESOR_Click(object sender, EventArgs e)
        {
            try
            {
                PROFESORES MiProfesor = new PROFESORES();
                MiProfesor.DNI_PROFESOR = textDNIPROFESOR.Text;
                MiProfesor.NOMBRE = textNOMBRE.Text;
                MiProfesor.PRIMER_APELLIDO = textPRIMER_APELLIDO.Text;
                MiProfesor.SEGUNDO_APELLIDO = textSEGUNDO_APELLIDO.Text;
                MiProfesor.DIRECCION = textDIRECCION.Text;
                MiProfesor.CIUDAD = textCIUDAD.Text;
                MiProfesor.CODIGO_POSTAL = int.Parse(textCODIGO_POSTAL.Text);
                MiProfesor.PROVINCIA = textPROVINCIA.Text;
                MiProfesor.TELEFONO = textTELEFONO.Text;
                MiProfesor.EMAIL = textEMAIL.Text;
                BaseDatosInadecoGestion.PROFESORES.InsertOnSubmit(MiProfesor);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridProfesores();
                MessageBox.Show("EL PROFESOR " + textNOMBRE.Text + " " + textPRIMER_APELLIDO.Text + " " + textSEGUNDO_APELLIDO.Text + " HA SIDO DADO DE ALTA CORRECTAMENTE");
                reset();

            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE ALTA EL PROFESOR, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //DAR DE BAJA UN ALUMNO POR SU DNI_PROFESOR
        private void btnBAJAPROFESOR_Click(object sender, EventArgs e)
        {
            try
            {

                //Sentencia Lambda
                PROFESORES MiProfesor = BaseDatosInadecoGestion.PROFESORES.Single(p => p.DNI_PROFESOR == textDNIPROFESOR.Text);
                BaseDatosInadecoGestion.PROFESORES.DeleteOnSubmit(MiProfesor);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridProfesores();
                MessageBox.Show("EL PROFESOR CON DNI " + textDNIPROFESOR.Text + " HA SIDO DADO DE BAJA CORRECTAMENTE");
                reset();

            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE BAJA EL PROFESOR, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //MODIFICAR LOS DATOS DEL PROFESOR POR SU DNI_PROFESOR
        private void btnMODIFICAPROFESOR_Click(object sender, EventArgs e)
        {
            try
            {
                //Sentencia Lambda
                PROFESORES MiProfesor = BaseDatosInadecoGestion.PROFESORES.Single(p => p.DNI_PROFESOR == textDNIPROFESOR.Text);
                MiProfesor.DNI_PROFESOR = textDNIPROFESOR.Text;
                MiProfesor.NOMBRE = textNOMBRE.Text;
                MiProfesor.PRIMER_APELLIDO = textPRIMER_APELLIDO.Text;
                MiProfesor.SEGUNDO_APELLIDO = textSEGUNDO_APELLIDO.Text;
                MiProfesor.DIRECCION = textDIRECCION.Text;
                MiProfesor.CIUDAD = textCIUDAD.Text;
                MiProfesor.CODIGO_POSTAL = int.Parse(textCODIGO_POSTAL.Text);
                MiProfesor.PROVINCIA = textPROVINCIA.Text;
                MiProfesor.TELEFONO = textTELEFONO.Text;
                MiProfesor.EMAIL = textEMAIL.Text;
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridProfesores();
                MessageBox.Show("EL PROFESOR CON DNI " + textDNIPROFESOR.Text + " HAN SIDO MODIFICADO SUS DATOS CORRECTAMENTE");
                reset();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO MODIFICAR LOS DATOS DEL PROFESOR, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //RESET REFRESCAR (LIMPIAR) TODOS LOS CAMPOS DEL FORMULARIO PROFESORES
        private void btnREFRESCARCAMPOSPROFESOR_Click(object sender, EventArgs e)
        {
            textDNIPROFESOR.Text = "";
            textNOMBRE.Text = "";
            textPRIMER_APELLIDO.Text = "";
            textSEGUNDO_APELLIDO.Text = "";
            textDIRECCION.Text = "";
            textCIUDAD.Text = "";
            textCODIGO_POSTAL.Text = "";
            textPROVINCIA.Text = "";
            textTELEFONO.Text = "";
            textEMAIL.Text = "";
            textBUSCARPROFESOR.Text = "";
        }

        //BUSCAR EL PROFESOR POR SU DNI Y LO CARGA EN EL GRIDDATOSPROFESORES
        private void btnBUSCARPROFESOR_Click(object sender, EventArgs e)
        {
            try
            {
                var Buscar = from PROFESORES in BaseDatosInadecoGestion.PROFESORES where
                PROFESORES.DNI_PROFESOR == textBUSCARPROFESOR.Text select PROFESORES;
                GRIDDATOSPROFESOR.DataSource = Buscar;
                int numero = Buscar.Count();
                textNUMEROTOTALPROFESORES.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO HACER LA BUSQUEDA DEL PROFESOR, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }
    }
}
