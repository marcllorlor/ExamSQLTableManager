namespace Plantilla_Examen_Marc_Llorca.FORMS
{
    partial class FrmAMCicles
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
            this.lbIdFamilia = new System.Windows.Forms.Label();
            this.cbIdFamilia = new System.Windows.Forms.ComboBox();
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbidGrau = new System.Windows.Forms.Label();
            this.cbIdGrau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNHores = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNHores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdFamilia
            // 
            this.lbIdFamilia.AutoSize = true;
            this.lbIdFamilia.BackColor = System.Drawing.Color.Gray;
            this.lbIdFamilia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdFamilia.ForeColor = System.Drawing.Color.White;
            this.lbIdFamilia.Location = new System.Drawing.Point(13, 117);
            this.lbIdFamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdFamilia.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbIdFamilia.Name = "lbIdFamilia";
            this.lbIdFamilia.Padding = new System.Windows.Forms.Padding(4);
            this.lbIdFamilia.Size = new System.Drawing.Size(123, 26);
            this.lbIdFamilia.TabIndex = 32;
            this.lbIdFamilia.Text = "Id Familia";
            // 
            // cbIdFamilia
            // 
            this.cbIdFamilia.FormattingEnabled = true;
            this.cbIdFamilia.Location = new System.Drawing.Point(156, 119);
            this.cbIdFamilia.Name = "cbIdFamilia";
            this.cbIdFamilia.Size = new System.Drawing.Size(121, 24);
            this.cbIdFamilia.TabIndex = 31;
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Tomato;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(351, 263);
            this.btNo.Margin = new System.Windows.Forms.Padding(4);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(128, 44);
            this.btNo.TabIndex = 30;
            this.btNo.Text = "&Descartar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(191, 263);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(128, 44);
            this.btOK.TabIndex = 29;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(156, 68);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.MaxLength = 100;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(540, 26);
            this.tbNom.TabIndex = 28;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.Gray;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(13, 69);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(4);
            this.lbNom.Size = new System.Drawing.Size(123, 26);
            this.lbNom.TabIndex = 27;
            this.lbNom.Text = "Nom";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(156, 18);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.MaxLength = 10;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 26);
            this.tbId.TabIndex = 26;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Gray;
            this.lbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(13, 20);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(4);
            this.lbId.Size = new System.Drawing.Size(107, 26);
            this.lbId.TabIndex = 25;
            this.lbId.Text = "Identificador";
            // 
            // lbidGrau
            // 
            this.lbidGrau.AutoSize = true;
            this.lbidGrau.BackColor = System.Drawing.Color.Gray;
            this.lbidGrau.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidGrau.ForeColor = System.Drawing.Color.White;
            this.lbidGrau.Location = new System.Drawing.Point(13, 163);
            this.lbidGrau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbidGrau.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbidGrau.Name = "lbidGrau";
            this.lbidGrau.Padding = new System.Windows.Forms.Padding(4);
            this.lbidGrau.Size = new System.Drawing.Size(123, 26);
            this.lbidGrau.TabIndex = 34;
            this.lbidGrau.Text = "Id Grau";
            // 
            // cbIdGrau
            // 
            this.cbIdGrau.FormattingEnabled = true;
            this.cbIdGrau.Location = new System.Drawing.Point(156, 165);
            this.cbIdGrau.Name = "cbIdGrau";
            this.cbIdGrau.Size = new System.Drawing.Size(121, 24);
            this.cbIdGrau.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(123, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Numero Hores";
            // 
            // nudNHores
            // 
            this.nudNHores.Location = new System.Drawing.Point(156, 220);
            this.nudNHores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNHores.Name = "nudNHores";
            this.nudNHores.Size = new System.Drawing.Size(145, 22);
            this.nudNHores.TabIndex = 36;
            this.nudNHores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmAMCicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 352);
            this.Controls.Add(this.nudNHores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbidGrau);
            this.Controls.Add(this.cbIdGrau);
            this.Controls.Add(this.lbIdFamilia);
            this.Controls.Add(this.cbIdFamilia);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmAMCicles";
            this.Text = "FrmAMCicles";
            this.Load += new System.EventHandler(this.FrmAMCicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNHores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdFamilia;
        private System.Windows.Forms.ComboBox cbIdFamilia;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbidGrau;
        private System.Windows.Forms.ComboBox cbIdGrau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNHores;
    }
}