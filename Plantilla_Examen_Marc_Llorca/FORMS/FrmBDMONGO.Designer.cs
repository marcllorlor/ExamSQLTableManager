namespace Plantilla_Examen_Marc_Llorca.FORMS
{
    partial class FrmBDMONGO
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
            this.tbNomBD = new System.Windows.Forms.TextBox();
            this.lbNomBD = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbCadena = new System.Windows.Forms.TextBox();
            this.lbCadena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNomBD
            // 
            this.tbNomBD.Location = new System.Drawing.Point(24, 99);
            this.tbNomBD.Name = "tbNomBD";
            this.tbNomBD.Size = new System.Drawing.Size(196, 22);
            this.tbNomBD.TabIndex = 11;
            // 
            // lbNomBD
            // 
            this.lbNomBD.AutoSize = true;
            this.lbNomBD.Location = new System.Drawing.Point(21, 81);
            this.lbNomBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomBD.Name = "lbNomBD";
            this.lbNomBD.Size = new System.Drawing.Size(134, 16);
            this.lbNomBD.TabIndex = 10;
            this.lbNomBD.Text = "Nom Base de Dades";
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(418, 145);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(107, 34);
            this.btNo.TabIndex = 9;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(288, 145);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(107, 34);
            this.btOK.TabIndex = 8;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbCadena
            // 
            this.tbCadena.Location = new System.Drawing.Point(21, 43);
            this.tbCadena.Name = "tbCadena";
            this.tbCadena.Size = new System.Drawing.Size(737, 22);
            this.tbCadena.TabIndex = 7;
            // 
            // lbCadena
            // 
            this.lbCadena.AutoSize = true;
            this.lbCadena.Location = new System.Drawing.Point(18, 25);
            this.lbCadena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadena.Name = "lbCadena";
            this.lbCadena.Size = new System.Drawing.Size(131, 16);
            this.lbCadena.TabIndex = 6;
            this.lbCadena.Text = "Cadena de connexió";
            // 
            // FrmBDMONGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.tbNomBD);
            this.Controls.Add(this.lbNomBD);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCadena);
            this.Controls.Add(this.lbCadena);
            this.Name = "FrmBDMONGO";
            this.Text = "FrmBDMONGO";
            this.Load += new System.EventHandler(this.FrmBDMONGO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomBD;
        private System.Windows.Forms.Label lbNomBD;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbCadena;
        private System.Windows.Forms.Label lbCadena;
    }
}