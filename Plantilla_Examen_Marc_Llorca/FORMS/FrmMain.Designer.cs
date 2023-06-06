namespace Plantilla_Examen_Marc_Llorca
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexioBDSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexioBDMongoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciclesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.ciclesToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexioBDSQLToolStripMenuItem,
            this.connexioBDMongoToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // connexioBDSQLToolStripMenuItem
            // 
            this.connexioBDSQLToolStripMenuItem.Name = "connexioBDSQLToolStripMenuItem";
            this.connexioBDSQLToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.connexioBDSQLToolStripMenuItem.Text = "Connexio BD SQL";
            this.connexioBDSQLToolStripMenuItem.Click += new System.EventHandler(this.connexioBDSQLToolStripMenuItem_Click);
            // 
            // connexioBDMongoToolStripMenuItem
            // 
            this.connexioBDMongoToolStripMenuItem.Name = "connexioBDMongoToolStripMenuItem";
            this.connexioBDMongoToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.connexioBDMongoToolStripMenuItem.Text = "Connexio BD Mongo";
            this.connexioBDMongoToolStripMenuItem.Click += new System.EventHandler(this.connexioBDMongoToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // ciclesToolStripMenuItem
            // 
            this.ciclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciclesToolStripMenuItem1,
            this.modulsToolStripMenuItem});
            this.ciclesToolStripMenuItem.Name = "ciclesToolStripMenuItem";
            this.ciclesToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ciclesToolStripMenuItem.Text = "Dades";
            // 
            // ciclesToolStripMenuItem1
            // 
            this.ciclesToolStripMenuItem1.Name = "ciclesToolStripMenuItem1";
            this.ciclesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ciclesToolStripMenuItem1.Text = "Cicles";
            this.ciclesToolStripMenuItem1.Click += new System.EventHandler(this.ciclesToolStripMenuItem1_Click);
            // 
            // modulsToolStripMenuItem
            // 
            this.modulsToolStripMenuItem.Name = "modulsToolStripMenuItem";
            this.modulsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modulsToolStripMenuItem.Text = "Moduls";
            this.modulsToolStripMenuItem.Click += new System.EventHandler(this.modulsToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Plantilla_Marc_Llorca";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexioBDSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexioBDMongoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciclesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modulsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
    }
}

