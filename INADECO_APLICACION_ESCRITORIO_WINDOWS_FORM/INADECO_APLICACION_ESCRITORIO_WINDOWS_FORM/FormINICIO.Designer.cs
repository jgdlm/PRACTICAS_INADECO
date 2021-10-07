
namespace INADECO_APLICACION_ESCRITORIO_WINDOWS_FORM
{
    partial class FrmINICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmINICIO));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFESORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURSOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aULASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CARGARTODOSDATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.archivoToolStripMenuItem.Text = "MENU PRINCIPAL";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUMNOSToolStripMenuItem,
            this.pROFESORESToolStripMenuItem,
            this.cURSOSToolStripMenuItem,
            this.aULASToolStripMenuItem,
            this.CARGARTODOSDATOSToolStripMenuItem});
            this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // aLUMNOSToolStripMenuItem
            // 
            this.aLUMNOSToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.aLUMNOSToolStripMenuItem.Name = "aLUMNOSToolStripMenuItem";
            this.aLUMNOSToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aLUMNOSToolStripMenuItem.Text = "ALUMNOS";
            this.aLUMNOSToolStripMenuItem.Click += new System.EventHandler(this.aLUMNOSToolStripMenuItem_Click);
            // 
            // pROFESORESToolStripMenuItem
            // 
            this.pROFESORESToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.pROFESORESToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.pROFESORESToolStripMenuItem.Name = "pROFESORESToolStripMenuItem";
            this.pROFESORESToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.pROFESORESToolStripMenuItem.Text = "PROFESORES";
            this.pROFESORESToolStripMenuItem.Click += new System.EventHandler(this.pROFESORESToolStripMenuItem_Click);
            // 
            // cURSOSToolStripMenuItem
            // 
            this.cURSOSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cURSOSToolStripMenuItem.Name = "cURSOSToolStripMenuItem";
            this.cURSOSToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cURSOSToolStripMenuItem.Text = "CURSOS";
            this.cURSOSToolStripMenuItem.Click += new System.EventHandler(this.cURSOSToolStripMenuItem_Click);
            // 
            // aULASToolStripMenuItem
            // 
            this.aULASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.aULASToolStripMenuItem.Name = "aULASToolStripMenuItem";
            this.aULASToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aULASToolStripMenuItem.Text = "AULAS";
            this.aULASToolStripMenuItem.Click += new System.EventHandler(this.aULASToolStripMenuItem_Click);
            // 
            // CARGARTODOSDATOSToolStripMenuItem
            // 
            this.CARGARTODOSDATOSToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.CARGARTODOSDATOSToolStripMenuItem.Name = "CARGARTODOSDATOSToolStripMenuItem";
            this.CARGARTODOSDATOSToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.CARGARTODOSDATOSToolStripMenuItem.Text = "CARGARTODOSDATOS";
            this.CARGARTODOSDATOSToolStripMenuItem.Click += new System.EventHandler(this.CARGARTODOSDATOSToolStripMenuItem_Click);
            // 
            // FrmINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::INADECO_APLICACION_ESCRITORIO_WINDOWS_FORM.Properties.Resources.INADECO_MDI;
            this.ClientSize = new System.Drawing.Size(1131, 749);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmINICIO";
            this.Text = "INADECO GESTION (MENU PRINCIPAL)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFESORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURSOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aULASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CARGARTODOSDATOSToolStripMenuItem;
    }
}