namespace Plantilla_Examen_Marc_Llorca.FORMS
{
    partial class FrmCicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCicles));
            this.dgCicles = new System.Windows.Forms.DataGridView();
            this.lbCicles = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btNou = new System.Windows.Forms.Button();
            this.cbFiltreIdFamilia = new System.Windows.Forms.ComboBox();
            this.lbPobl = new System.Windows.Forms.Label();
            this.cbTotesFamilies = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCicles
            // 
            this.dgCicles.AllowUserToAddRows = false;
            this.dgCicles.AllowUserToDeleteRows = false;
            this.dgCicles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgCicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCicles.Location = new System.Drawing.Point(24, 49);
            this.dgCicles.Margin = new System.Windows.Forms.Padding(4);
            this.dgCicles.MultiSelect = false;
            this.dgCicles.Name = "dgCicles";
            this.dgCicles.ReadOnly = true;
            this.dgCicles.RowHeadersVisible = false;
            this.dgCicles.RowHeadersWidth = 51;
            this.dgCicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCicles.Size = new System.Drawing.Size(498, 500);
            this.dgCicles.TabIndex = 33;
            this.dgCicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCicles_CellDoubleClick);
            // 
            // lbCicles
            // 
            this.lbCicles.AutoSize = true;
            this.lbCicles.BackColor = System.Drawing.Color.Orange;
            this.lbCicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCicles.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCicles.Location = new System.Drawing.Point(24, 17);
            this.lbCicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCicles.MinimumSize = new System.Drawing.Size(500, 2);
            this.lbCicles.Name = "lbCicles";
            this.lbCicles.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbCicles.Size = new System.Drawing.Size(500, 34);
            this.lbCicles.TabIndex = 34;
            this.lbCicles.Text = "cicles";
            this.lbCicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.Color.Transparent;
            this.btDel.FlatAppearance.BorderSize = 0;
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDel.ForeColor = System.Drawing.Color.White;
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.Location = new System.Drawing.Point(530, 475);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 70);
            this.btDel.TabIndex = 29;
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btNou
            // 
            this.btNou.BackColor = System.Drawing.Color.Transparent;
            this.btNou.FlatAppearance.BorderSize = 0;
            this.btNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNou.ForeColor = System.Drawing.Color.Transparent;
            this.btNou.Image = ((System.Drawing.Image)(resources.GetObject("btNou.Image")));
            this.btNou.Location = new System.Drawing.Point(530, 412);
            this.btNou.Margin = new System.Windows.Forms.Padding(4);
            this.btNou.Name = "btNou";
            this.btNou.Size = new System.Drawing.Size(75, 70);
            this.btNou.TabIndex = 28;
            this.btNou.UseVisualStyleBackColor = false;
            this.btNou.Click += new System.EventHandler(this.btNou_Click);
            // 
            // cbFiltreIdFamilia
            // 
            this.cbFiltreIdFamilia.FormattingEnabled = true;
            this.cbFiltreIdFamilia.Location = new System.Drawing.Point(35, 602);
            this.cbFiltreIdFamilia.Name = "cbFiltreIdFamilia";
            this.cbFiltreIdFamilia.Size = new System.Drawing.Size(144, 24);
            this.cbFiltreIdFamilia.TabIndex = 35;
            // 
            // lbPobl
            // 
            this.lbPobl.AutoSize = true;
            this.lbPobl.BackColor = System.Drawing.Color.Gray;
            this.lbPobl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPobl.ForeColor = System.Drawing.Color.White;
            this.lbPobl.Location = new System.Drawing.Point(32, 565);
            this.lbPobl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPobl.Name = "lbPobl";
            this.lbPobl.Padding = new System.Windows.Forms.Padding(4);
            this.lbPobl.Size = new System.Drawing.Size(160, 26);
            this.lbPobl.TabIndex = 30;
            this.lbPobl.Text = "Introdueix un prefix";
            // 
            // cbTotesFamilies
            // 
            this.cbTotesFamilies.AutoSize = true;
            this.cbTotesFamilies.Checked = true;
            this.cbTotesFamilies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTotesFamilies.Location = new System.Drawing.Point(207, 602);
            this.cbTotesFamilies.Name = "cbTotesFamilies";
            this.cbTotesFamilies.Size = new System.Drawing.Size(137, 20);
            this.cbTotesFamilies.TabIndex = 36;
            this.cbTotesFamilies.Text = "TOTES FAMILIES";
            this.cbTotesFamilies.UseVisualStyleBackColor = true;
            this.cbTotesFamilies.CheckedChanged += new System.EventHandler(this.cbTotesFamilies_CheckedChanged);
            // 
            // FrmCicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 638);
            this.Controls.Add(this.cbTotesFamilies);
            this.Controls.Add(this.cbFiltreIdFamilia);
            this.Controls.Add(this.dgCicles);
            this.Controls.Add(this.lbCicles);
            this.Controls.Add(this.lbPobl);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNou);
            this.Name = "FrmCicles";
            this.Text = "FrmCicles";
            this.Load += new System.EventHandler(this.FrmCicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCicles;
        private System.Windows.Forms.Label lbCicles;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btNou;
        private System.Windows.Forms.ComboBox cbFiltreIdFamilia;
        private System.Windows.Forms.Label lbPobl;
        private System.Windows.Forms.CheckBox cbTotesFamilies;
    }
}