
namespace INADECO_APLICACION_ESCRITORIO_WINDOWS_FORM
{
    partial class FrmCARGARTODOSDATOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCARGARTODOSDATOS));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCURSOS = new System.Windows.Forms.GroupBox();
            this.labelTABLATODOSDATOS = new System.Windows.Forms.Label();
            this.GRIDTODOSDATOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCURSOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDTODOSDATOS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INADECO_APLICACION_ESCRITORIO_WINDOWS_FORM.Properties.Resources.INADECO_22;
            this.pictureBox1.Location = new System.Drawing.Point(502, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxCURSOS
            // 
            this.groupBoxCURSOS.Controls.Add(this.labelTABLATODOSDATOS);
            this.groupBoxCURSOS.Controls.Add(this.GRIDTODOSDATOS);
            this.groupBoxCURSOS.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxCURSOS.Location = new System.Drawing.Point(12, 142);
            this.groupBoxCURSOS.Name = "groupBoxCURSOS";
            this.groupBoxCURSOS.Size = new System.Drawing.Size(1346, 595);
            this.groupBoxCURSOS.TabIndex = 6;
            this.groupBoxCURSOS.TabStop = false;
            this.groupBoxCURSOS.Text = "CARGAR TODOS LOS DATOS";
            // 
            // labelTABLATODOSDATOS
            // 
            this.labelTABLATODOSDATOS.AutoSize = true;
            this.labelTABLATODOSDATOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTABLATODOSDATOS.ForeColor = System.Drawing.Color.Navy;
            this.labelTABLATODOSDATOS.Location = new System.Drawing.Point(16, 32);
            this.labelTABLATODOSDATOS.Name = "labelTABLATODOSDATOS";
            this.labelTABLATODOSDATOS.Size = new System.Drawing.Size(532, 16);
            this.labelTABLATODOSDATOS.TabIndex = 30;
            this.labelTABLATODOSDATOS.Text = "TABLA TODOS LOS DATOS: (ALUMNOS, PROFESORES, CURSOS, AULAS)";
            // 
            // GRIDTODOSDATOS
            // 
            this.GRIDTODOSDATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDTODOSDATOS.Location = new System.Drawing.Point(19, 65);
            this.GRIDTODOSDATOS.Name = "GRIDTODOSDATOS";
            this.GRIDTODOSDATOS.Size = new System.Drawing.Size(1309, 524);
            this.GRIDTODOSDATOS.TabIndex = 29;
            // 
            // FrmCARGARTODOSDATOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBoxCURSOS);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCARGARTODOSDATOS";
            this.Text = "CARGARTODOSDATOS";
            this.Load += new System.EventHandler(this.FrmCARGARTODOSDATOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCURSOS.ResumeLayout(false);
            this.groupBoxCURSOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDTODOSDATOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxCURSOS;
        private System.Windows.Forms.Label labelTABLATODOSDATOS;
        private System.Windows.Forms.DataGridView GRIDTODOSDATOS;
    }
}