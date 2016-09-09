namespace Aplicacion9Estacionamiento
{
    partial class FrmGestionAutomovil
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
            this.components = new System.ComponentModel.Container();
            this.menuStripGA = new System.Windows.Forms.MenuStrip();
            this.nuevosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripGA.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripGA
            // 
            this.menuStripGA.AllowMerge = false;
            this.menuStripGA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosVehiculosToolStripMenuItem,
            this.borrarVehiculosToolStripMenuItem,
            this.modificarVehiculosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStripGA.Location = new System.Drawing.Point(0, 0);
            this.menuStripGA.Name = "menuStripGA";
            this.menuStripGA.Size = new System.Drawing.Size(523, 24);
            this.menuStripGA.TabIndex = 0;
            this.menuStripGA.Text = "menuStrip1";
            // 
            // nuevosVehiculosToolStripMenuItem
            // 
            this.nuevosVehiculosToolStripMenuItem.Name = "nuevosVehiculosToolStripMenuItem";
            this.nuevosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.nuevosVehiculosToolStripMenuItem.Text = "Nuevos Vehiculos";
            // 
            // borrarVehiculosToolStripMenuItem
            // 
            this.borrarVehiculosToolStripMenuItem.Name = "borrarVehiculosToolStripMenuItem";
            this.borrarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.borrarVehiculosToolStripMenuItem.Text = "Borrar Vehiculos";
            // 
            // modificarVehiculosToolStripMenuItem
            // 
            this.modificarVehiculosToolStripMenuItem.Name = "modificarVehiculosToolStripMenuItem";
            this.modificarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.modificarVehiculosToolStripMenuItem.Text = "Modificar Vehiculos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.salirToolStripMenuItem.Text = "Salir de Adm. de Vehiculos";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmGestionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.menuStripGA);
            this.Name = "FrmGestionAutomovil";
            this.Text = "Gestion Automovil";
            this.Load += new System.EventHandler(this.FrmGestionAutomovil_Load);
            this.menuStripGA.ResumeLayout(false);
            this.menuStripGA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGA;
        private System.Windows.Forms.ToolStripMenuItem nuevosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}