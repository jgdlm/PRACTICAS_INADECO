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
    public partial class FrmALUMNOS : Form
    {
        public FrmALUMNOS()
        {
            InitializeComponent();
        }

        //CREAMOS EL DATACLASSES1DATACONTEXT DE LA BASE DE DATOS INADECO_GESTION
        DataClasses1DataContext BaseDatosInadecoGestion = new DataClasses1DataContext();

        //METODO CARGAR EL GRID DE DATOS ALUMNOS CON LOS DATOS DE ALUMNOS DE LA BASE DE DATOS INADECO_GESTION SQL
        private void FrmALUMNOS_Load(object sender, EventArgs e)
        {
            cargarGridAlumnos();
        }

        //CARGAR EL GRID DE LOS DATOS DE ALUMNOS Y CUENTA EL NUMERO TOTAL DE ALUMNOS REGISTRADOS EN EL TEXTNUMEROTOTALALUMNOS LOS MUESTRA
        void cargarGridAlumnos()
        {
            try
            {
                var CargaGridAlumnos = from alumnnos in BaseDatosInadecoGestion.ALUMNOS select alumnnos;
                GRIDDATOSALUMNOS.DataSource = CargaGridAlumnos;
                int numero = CargaGridAlumnos.Count();
                textNUMEROTOTALALUMNOS.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS DE ALUMNOS");
            }

        }

        //METODO RESET LIMPIAR DATOS DE TODOS LOS CAMPOS DEL FORMULARIO ALUMNOS
        void reset()
        {
            try
            {
                textDNIALUMNO.Text = "";
                textNOMBRE.Text = "";
                textPRIMER_APELLIDO.Text = "";
                textSEGUNDO_APELLIDO.Text = "";
                textDIRECCION.Text = "";
                textCIUDAD.Text = "";
                textCODIGO_POSTAL.Text = "";
                textPROVINCIA.Text = "";
                textTELEFONO.Text = "";
                textEMAIL.Text = "";
                textBUSCARALUMNO.Text = "";
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO RESETEAR LOS CAMPOS");
            }
        }

        //DAR DE ALTA UN ALUMNO
        private void btnALTAALUMNO_Click(object sender, EventArgs e)
        {
            try 
            {   
                ALUMNOS MiAlumno = new ALUMNOS();
                MiAlumno.DNI_ALUMNO = textDNIALUMNO.Text;
                MiAlumno.NOMBRE = textNOMBRE.Text;
                MiAlumno.PRIMER_APELLIDO = textPRIMER_APELLIDO.Text;
                MiAlumno.SEGUNDO_APELLIDO = textSEGUNDO_APELLIDO.Text;
                MiAlumno.DIRECCION = textDIRECCION.Text;
                MiAlumno.CIUDAD = textCIUDAD.Text;
                MiAlumno.CODIGO_POSTAL = int.Parse(textCODIGO_POSTAL.Text);
                MiAlumno.PROVINCIA = textPROVINCIA.Text;
                MiAlumno.TELEFONO = textTELEFONO.Text;
                MiAlumno.EMAIL = textEMAIL.Text;
                BaseDatosInadecoGestion.ALUMNOS.InsertOnSubmit(MiAlumno);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridAlumnos();
                MessageBox.Show("EL ALUMNO " +  textNOMBRE.Text  + " " + textPRIMER_APELLIDO.Text + " " + textSEGUNDO_APELLIDO.Text  + " HA SIDO DADO DE ALTA CORRECTAMENTE");
                reset();

            }
            catch 
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE ALTA EL ALUMNO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //DAR DE BAJA UN ALUMNO POR SU DNI_ALUMNO
        private void btnBAJAALUMNO_Click(object sender, EventArgs e)
        {

            try
            {

                //Sentencia Lambda
                ALUMNOS MiAlumno = BaseDatosInadecoGestion.ALUMNOS.Single(p => p.DNI_ALUMNO == textDNIALUMNO.Text);
                BaseDatosInadecoGestion.ALUMNOS.DeleteOnSubmit(MiAlumno);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridAlumnos();
                MessageBox.Show("EL ALUMNO CON DNI " + textDNIALUMNO.Text + " HA SIDO DADO DE BAJA CORRECTAMENTE");
                reset();

            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE BAJA EL ALUMNO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //MODIFICAR LOS DATOS DEL ALUMNO POR SU DNI_ALUMNO
        private void btnMODIFICAALUMNO_Click(object sender, EventArgs e)
        {
            try
            {
                //Sentencia Lambda
                ALUMNOS MiAlumno = BaseDatosInadecoGestion.ALUMNOS.Single(p => p.DNI_ALUMNO == textDNIALUMNO.Text);
                MiAlumno.DNI_ALUMNO = textDNIALUMNO.Text;
                MiAlumno.NOMBRE = textNOMBRE.Text;
                MiAlumno.PRIMER_APELLIDO = textPRIMER_APELLIDO.Text;
                MiAlumno.SEGUNDO_APELLIDO = textSEGUNDO_APELLIDO.Text;
                MiAlumno.DIRECCION = textDIRECCION.Text;
                MiAlumno.CIUDAD = textCIUDAD.Text;
                MiAlumno.CODIGO_POSTAL = int.Parse(textCODIGO_POSTAL.Text);
                MiAlumno.PROVINCIA = textPROVINCIA.Text;
                MiAlumno.TELEFONO = textTELEFONO.Text;
                MiAlumno.EMAIL = textEMAIL.Text;
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridAlumnos();
                MessageBox.Show("EL ALUMNO CON DNI " + textDNIALUMNO.Text + " HAN SIDO MODIFICADO SUS DATOS CORRECTAMENTE");
                reset();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO MODIFICAR LOS DATOS DEL ALUMNO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //RESET REFRESCAR (LIMPIAR) TODOS LOS CAMPOS DEL FORMULARIO ALUMNOS
        private void btnREFRESCARCAMPOSALUMNO_Click(object sender, EventArgs e)
        {
            textDNIALUMNO.Text = "";
            textNOMBRE.Text = "";
            textPRIMER_APELLIDO.Text = "";
            textSEGUNDO_APELLIDO.Text = "";
            textDIRECCION.Text = "";
            textCIUDAD.Text = "";
            textCODIGO_POSTAL.Text = "";
            textPROVINCIA.Text = "";
            textTELEFONO.Text = "";
            textEMAIL.Text = "";
            textBUSCARALUMNO.Text = "";
        }

        //BUSCAR EL ALUMNO POR SU DNI Y LO CARGA EN EL GRIDDATOSALUMNOS
        private void btnBUSCARALUMNO_Click(object sender, EventArgs e)
        {
            try
            {
                var Buscar = from ALUMNOS in BaseDatosInadecoGestion.ALUMNOS where
                ALUMNOS.DNI_ALUMNO == textBUSCARALUMNO.Text select ALUMNOS;
                GRIDDATOSALUMNOS.DataSource = Buscar;
                int numero = Buscar.Count();
                textNUMEROTOTALALUMNOS.Text = numero.ToString();

            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO HACER LA BUSQUEDA DEL ALUMNO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }
    }
}
