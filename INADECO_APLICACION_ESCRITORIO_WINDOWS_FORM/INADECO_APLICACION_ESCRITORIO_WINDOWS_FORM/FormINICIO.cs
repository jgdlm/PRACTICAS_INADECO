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
    public partial class FrmINICIO : Form
    {
        //DECLARO VARIABLES con sus names de formulario PARA LOS DISTINTOS FORMULARIOS (ALUMNOS, PROFESORES, CURSOS, AULAS, CARGARTODOS)
        FrmALUMNOS alumnos;
        FrmPROFESORES profesores;
        FrmCURSOS cursos;
        FrmAULAS aulas;
        FrmCARGARTODOSDATOS cargartodosdatos;
        public FrmINICIO()
        {
            InitializeComponent();
        }

        //VENTANA DE FORMULARIO ALUMNOS
        private void aLUMNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alumnos == null)
            {
                alumnos = new FrmALUMNOS();
                alumnos.MdiParent = this;
                alumnos.FormClosed += new FormClosedEventHandler(alumnos_FormClosed);
                alumnos.Show();
            }
            else
            {
                alumnos.Activate();
            }
        }

        void alumnos_FormClosed(object sender, EventArgs e) 
        {
            alumnos = null;
        
        }

        //VENTANA DE FORMULARIO PROFESORES
        private void pROFESORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (profesores == null)
            {
                profesores = new FrmPROFESORES();
                profesores.MdiParent = this;
                profesores.FormClosed += new FormClosedEventHandler(profesores_FormClosed);
                profesores.Show();
            }
            else
            {
                profesores.Activate();
            }
        }
        void profesores_FormClosed(object sender, EventArgs e)
        {
            profesores = null;

        }

        //VENTANA DE FORMULARIO CURSOS
        private void cURSOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cursos == null)
            {
                cursos = new FrmCURSOS();
                cursos.MdiParent = this;
                cursos.FormClosed += new FormClosedEventHandler(cursos_FormClosed);
                cursos.Show();
            }
            else
            {
                cursos.Activate();
            }
        }

        void cursos_FormClosed(object sender, EventArgs e)
        {
            cursos = null;

        }

        //VENTANA DE FORMULARIO AULAS
        private void aULASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aulas == null)
            {
                aulas = new FrmAULAS();
                aulas.MdiParent = this;
                aulas.FormClosed += new FormClosedEventHandler(aulas_FormClosed);
                aulas.Show();
            }
            else
            {
                aulas.Activate();
            }
        }

        void aulas_FormClosed(object sender, EventArgs e)
        {
            aulas = null;

        }

        //VENTANA DE FORMULARIO CARGARTODOSDATOS
        private void CARGARTODOSDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cargartodosdatos == null)
            {
                cargartodosdatos = new FrmCARGARTODOSDATOS();
                cargartodosdatos.MdiParent = this;
                cargartodosdatos.FormClosed += new FormClosedEventHandler(cargartodosdatos_FormClosed);
                cargartodosdatos.Show();
            }
            else
            {
                cargartodosdatos.Activate();
            }
        }

        void cargartodosdatos_FormClosed(object sender, EventArgs e)
        {
            cargartodosdatos = null;

        }
    }
}
