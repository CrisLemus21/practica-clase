
namespace clase102.vista
{
    partial class menuAplicacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioOprofesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicasionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioEstudianteToolStripMenuItem,
            this.formularioOprofesorToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // formularioEstudianteToolStripMenuItem
            // 
            this.formularioEstudianteToolStripMenuItem.Name = "formularioEstudianteToolStripMenuItem";
            this.formularioEstudianteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioEstudianteToolStripMenuItem.Text = "Formulario estudiante";
            this.formularioEstudianteToolStripMenuItem.Click += new System.EventHandler(this.formularioEstudianteToolStripMenuItem_Click);
            // 
            // formularioOprofesorToolStripMenuItem
            // 
            this.formularioOprofesorToolStripMenuItem.Name = "formularioOprofesorToolStripMenuItem";
            this.formularioOprofesorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioOprofesorToolStripMenuItem.Text = "formulario oprofesor";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicasionToolStripMenuItem,
            this.divicionToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sumaToolStripMenuItem.Text = "suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.restaToolStripMenuItem.Text = "resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicasionToolStripMenuItem
            // 
            this.multiplicasionToolStripMenuItem.Name = "multiplicasionToolStripMenuItem";
            this.multiplicasionToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.multiplicasionToolStripMenuItem.Text = "multiplicasion";
            this.multiplicasionToolStripMenuItem.Click += new System.EventHandler(this.multiplicasionToolStripMenuItem_Click);
            // 
            // divicionToolStripMenuItem
            // 
            this.divicionToolStripMenuItem.Name = "divicionToolStripMenuItem";
            this.divicionToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.divicionToolStripMenuItem.Text = "divicion";
            this.divicionToolStripMenuItem.Click += new System.EventHandler(this.divicionToolStripMenuItem_Click);
            // 
            // menuAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuAplicacion";
            this.Text = "menuAplicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioOprofesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicasionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divicionToolStripMenuItem;
    }
}