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
    public partial class FrmCURSOS : Form
    {
        public FrmCURSOS()
        {
            InitializeComponent();
        }

        //CREAMOS EL DATACLASSES1DATACONTEXT DE LA BASE DE DATOS INADECO_GESTION
        DataClasses1DataContext BaseDatosInadecoGestion = new DataClasses1DataContext();
        private void FrmCURSOS_Load(object sender, EventArgs e)
        {
            cargarGridCursos();
        }

        //CARGAR EL GRID DE LOS DATOS DE CURSOS Y CUENTA EL NUMERO TOTAL DE CURSOS REGISTRADOS EN EL TEXTNUMEROTOTALCURSOS LOS MUESTRA
        void cargarGridCursos()
        {
            try
            {
                var CargaGridCursos = from cursos in BaseDatosInadecoGestion.CURSOS select cursos;
                GRIDDATOSCURSOS.DataSource = CargaGridCursos;
                int numero = CargaGridCursos.Count();
                textNUMEROTOTALCURSOS.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS DE CURSOS");
            }

        }

        //METODO RESET LIMPIAR DATOS DE TODOS LOS CAMPOS DEL FORMULARIO CURSOS
        void reset()
        {
            try
            {
                textID_CURSO.Text = "";
                textNOMBRECURSO.Text = "";
                dateTimePickerFECHAINICIO.Text = "";
                dateTimePickerFECHAFINALIZACION.Text = "";
                textHORARIO.Text = "";
                textDNIALUMNO.Text = "";
                textDNIPROFESOR.Text = "";
                textIDAULA.Text = "";
                textBUSCARCURSO.Text = "";
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO RESETEAR LOS CAMPOS");
            }
        }

        //DAR DE ALTA UN CURSO
        private void btnALTACURSO_Click(object sender, EventArgs e)
        {
            try
            {
                CURSOS MiCurso = new CURSOS();
                MiCurso.ID_CURSO = textID_CURSO.Text;
                MiCurso.NOMBRE_CURSO = textNOMBRECURSO.Text;
                MiCurso.FECHA_INICIO = dateTimePickerFECHAINICIO.Value;
                MiCurso.FECHA_FINALIZACION = dateTimePickerFECHAFINALIZACION.Value;
                MiCurso.HORARIO = textHORARIO.Text;
                MiCurso.DNI_ALUMNO = textDNIALUMNO.Text;
                MiCurso.DNI_PROFESOR = textDNIPROFESOR.Text;
                MiCurso.ID_AULA = int.Parse(textIDAULA.Text);
                BaseDatosInadecoGestion.CURSOS.InsertOnSubmit(MiCurso);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridCursos();
                MessageBox.Show("EL CURSO " + textID_CURSO.Text + " " + textNOMBRECURSO.Text + " HA SIDO DADO DE ALTA CORRECTAMENTE");
                reset();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE ALTA EL CURSO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }


        //DAR DE BAJA UN CURSO POR SU ID_CURSO
        private void btnBAJACURSO_Click(object sender, EventArgs e)
        {
            try
            {

                //Sentencia Lambda
                CURSOS MiCurso = BaseDatosInadecoGestion.CURSOS.Single(p => p.ID_CURSO == textID_CURSO.Text);
                BaseDatosInadecoGestion.CURSOS.DeleteOnSubmit(MiCurso);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridCursos();
                MessageBox.Show("EL CURSO CON ID_CURSO " + textID_CURSO.Text + " HA SIDO DADO DE BAJA CORRECTAMENTE");
                reset();

            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE BAJA EL CURSO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //MODIFICAR LOS DATOS DEL CURSO POR SU ID_CURSO
        private void btnMODIFICACURSO_Click(object sender, EventArgs e)
        {
            try 
            {
                //Sentencia Lambda
                CURSOS MiCurso = BaseDatosInadecoGestion.CURSOS.Single(p => p.ID_CURSO== textID_CURSO.Text);
                MiCurso.ID_CURSO = textID_CURSO.Text;
                MiCurso.NOMBRE_CURSO = textNOMBRECURSO.Text;
                MiCurso.FECHA_INICIO = dateTimePickerFECHAINICIO.Value;
                MiCurso.FECHA_FINALIZACION = dateTimePickerFECHAFINALIZACION.Value;
                MiCurso.HORARIO = textHORARIO.Text;
                MiCurso.DNI_ALUMNO = textDNIALUMNO.Text;
                MiCurso.DNI_PROFESOR = textDNIPROFESOR.Text;
                MiCurso.ID_AULA = int.Parse(textIDAULA.Text);
                BaseDatosInadecoGestion.SubmitChanges();
                cargarGridCursos();
                MessageBox.Show("EL CURSO CON ID_CURSO " + textID_CURSO.Text + " HAN SIDO MODIFICADO SUS DATOS CORRECTAMENTE");
                reset();
            }
            catch 
            {
                MessageBox.Show("NO SE HA PODIDO MODIFICAR LOS DATOS DEL CURSO, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }
        }

        //RESET REFRESCAR (LIMPIAR) TODOS LOS CAMPOS DEL FORMULARIO CURSO
        private void btnREFRESCARCAMPOSALUMNO_Click(object sender, EventArgs e)
        {
            textID_CURSO.Text = "";
            textNOMBRECURSO.Text = "";
            dateTimePickerFECHAINICIO.Text = "";
            dateTimePickerFECHAFINALIZACION.Text = "";
            textHORARIO.Text = "";
            textDNIALUMNO.Text = "";
            textDNIPROFESOR.Text = "";
            textIDAULA.Text = "";
            textBUSCARCURSO.Text = "";
        }

        //BUSCAR EL PROFESOR POR SU ID_CURSO Y LO CARGA EN EL GRIDDATOSCURSOS
        private void btnBUSCARCURSO_Click(object sender, EventArgs e)
        {
            try
            {
                var Buscar = from CURSOS in BaseDatosInadecoGestion.CURSOS where
                CURSOS.ID_CURSO == textBUSCARCURSO.Text select CURSOS;
                GRIDDATOSCURSOS.DataSource = Buscar;
                int numero = Buscar.Count();
                textNUMEROTOTALCURSOS.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO HACER LA BUSQUEDA DEL PROFESOR, POR FAVOR REVISE LOS DATOS INTRODUCIDOS");
            }

        }
    }
}
