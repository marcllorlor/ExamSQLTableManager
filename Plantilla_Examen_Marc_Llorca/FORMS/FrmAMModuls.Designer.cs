namespace Plantilla_Examen_Marc_Llorca.FORMS
{
    partial class FrmAMModuls
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
            this.lbIdCicle = new System.Windows.Forms.Label();
            this.cbIdCicle = new System.Windows.Forms.ComboBox();
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.nudNHores = new System.Windows.Forms.NumericUpDown();
            this.lbNHores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNHores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdCicle
            // 
            this.lbIdCicle.AutoSize = true;
            this.lbIdCicle.BackColor = System.Drawing.Color.Gray;
            this.lbIdCicle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCicle.ForeColor = System.Drawing.Color.White;
            this.lbIdCicle.Location = new System.Drawing.Point(13, 116);
            this.lbIdCicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdCicle.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbIdCicle.Name = "lbIdCicle";
            this.lbIdCicle.Padding = new System.Windows.Forms.Padding(4);
            this.lbIdCicle.Size = new System.Drawing.Size(123, 26);
            this.lbIdCicle.TabIndex = 40;
            this.lbIdCicle.Text = "Id Cicle";
            // 
            // cbIdCicle
            // 
            this.cbIdCicle.FormattingEnabled = true;
            this.cbIdCicle.Location = new System.Drawing.Point(156, 118);
            this.cbIdCicle.Name = "cbIdCicle";
            this.cbIdCicle.Size = new System.Drawing.Size(121, 24);
            this.cbIdCicle.TabIndex = 39;
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Tomato;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(385, 220);
            this.btNo.Margin = new System.Windows.Forms.Padding(4);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(128, 44);
            this.btNo.TabIndex = 38;
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
            this.btOK.Location = new System.Drawing.Point(225, 220);
            this.btOK.Margin = new System.Windows.Forms.Padding(4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(128, 44);
            this.btOK.TabIndex = 37;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(156, 67);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.MaxLength = 100;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(540, 26);
            this.tbNom.TabIndex = 36;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.Gray;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(13, 68);
            this.lbNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNom.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(4);
            this.lbNom.Size = new System.Drawing.Size(123, 26);
            this.lbNom.TabIndex = 35;
            this.lbNom.Text = "Nom";
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.Location = new System.Drawing.Point(156, 17);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.MaxLength = 10;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(145, 26);
            this.tbId.TabIndex = 34;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.Gray;
            this.lbId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(13, 19);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbId.Name = "lbId";
            this.lbId.Padding = new System.Windows.Forms.Padding(4);
            this.lbId.Size = new System.Drawing.Size(107, 26);
            this.lbId.TabIndex = 33;
            this.lbId.Text = "Identificador";
            // 
            // nudNHores
            // 
            this.nudNHores.Location = new System.Drawing.Point(156, 172);
            this.nudNHores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNHores.Name = "nudNHores";
            this.nudNHores.Size = new System.Drawing.Size(120, 22);
            this.nudNHores.TabIndex = 41;
            this.nudNHores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNHores
            // 
            this.lbNHores.AutoSize = true;
            this.lbNHores.BackColor = System.Drawing.Color.Gray;
            this.lbNHores.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNHores.ForeColor = System.Drawing.Color.White;
            this.lbNHores.Location = new System.Drawing.Point(13, 172);
            this.lbNHores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNHores.MinimumSize = new System.Drawing.Size(123, 0);
            this.lbNHores.Name = "lbNHores";
            this.lbNHores.Padding = new System.Windows.Forms.Padding(4);
            this.lbNHores.Size = new System.Drawing.Size(125, 26);
            this.lbNHores.TabIndex = 42;
            this.lbNHores.Text = "Numero Hores";
            // 
            // FrmAMModuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 353);
            this.Controls.Add(this.lbNHores);
            this.Controls.Add(this.nudNHores);
            this.Controls.Add(this.lbIdCicle);
            this.Controls.Add(this.cbIdCicle);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "FrmAMModuls";
            this.Text = "FrmAMModuls";
            this.Load += new System.EventHandler(this.FrmAMModuls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNHores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdCicle;
        private System.Windows.Forms.ComboBox cbIdCicle;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.NumericUpDown nudNHores;
        private System.Windows.Forms.Label lbNHores;
    }
}