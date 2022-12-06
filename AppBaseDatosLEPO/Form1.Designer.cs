namespace AppBaseDatosLEPO
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnBor = new System.Windows.Forms.Button();
            this.txtFO = new System.Windows.Forms.TextBox();
            this.lblForOn = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblMag = new System.Windows.Forms.Label();
            this.lblImpCan = new System.Windows.Forms.Label();
            this.lblPorImp = new System.Windows.Forms.Label();
            this.lblImpLin = new System.Windows.Forms.Label();
            this.lblLonLin = new System.Windows.Forms.Label();
            this.lblLinImp = new System.Windows.Forms.Label();
            this.txtImpCan = new System.Windows.Forms.TextBox();
            this.txtPImp = new System.Windows.Forms.TextBox();
            this.txtImpLin = new System.Windows.Forms.TextBox();
            this.txtLonLin = new System.Windows.Forms.TextBox();
            this.txtLinImp = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lbCodDes = new System.Windows.Forms.Label();
            this.txtCodDes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 241);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(426, 290);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(40, 23);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "C";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(472, 290);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(40, 23);
            this.btnLeer.TabIndex = 20;
            this.btnLeer.Text = "R";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(518, 290);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(40, 23);
            this.btnMod.TabIndex = 21;
            this.btnMod.Text = "U";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnBor
            // 
            this.btnBor.Location = new System.Drawing.Point(564, 290);
            this.btnBor.Name = "btnBor";
            this.btnBor.Size = new System.Drawing.Size(40, 23);
            this.btnBor.TabIndex = 22;
            this.btnBor.Text = "D";
            this.btnBor.UseVisualStyleBackColor = true;
            this.btnBor.Click += new System.EventHandler(this.btnBor_Click);
            // 
            // txtFO
            // 
            this.txtFO.Location = new System.Drawing.Point(271, 33);
            this.txtFO.Name = "txtFO";
            this.txtFO.Size = new System.Drawing.Size(100, 20);
            this.txtFO.TabIndex = 0;
            // 
            // lblForOn
            // 
            this.lblForOn.AutoSize = true;
            this.lblForOn.Location = new System.Drawing.Point(42, 36);
            this.lblForOn.Name = "lblForOn";
            this.lblForOn.Size = new System.Drawing.Size(80, 13);
            this.lblForOn.TabIndex = 1;
            this.lblForOn.Text = "Forma de Onda";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(271, 59);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 2;
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(42, 62);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(73, 13);
            this.lblMag.TabIndex = 3;
            this.lblMag.Text = "Magnitud [kA]";
            // 
            // lblImpCan
            // 
            this.lblImpCan.AutoSize = true;
            this.lblImpCan.Location = new System.Drawing.Point(42, 89);
            this.lblImpCan.Name = "lblImpCan";
            this.lblImpCan.Size = new System.Drawing.Size(173, 13);
            this.lblImpCan.TabIndex = 4;
            this.lblImpCan.Text = "Impedancia Canal de Descarga [Ω]";
            this.lblImpCan.Click += new System.EventHandler(this.lblImpCan_Click);
            // 
            // lblPorImp
            // 
            this.lblPorImp.AutoSize = true;
            this.lblPorImp.Location = new System.Drawing.Point(42, 115);
            this.lblPorImp.Name = "lblPorImp";
            this.lblPorImp.Size = new System.Drawing.Size(93, 13);
            this.lblPorImp.TabIndex = 5;
            this.lblPorImp.Text = "Impacto Línea [%]";
            // 
            // lblImpLin
            // 
            this.lblImpLin.AutoSize = true;
            this.lblImpLin.Location = new System.Drawing.Point(42, 145);
            this.lblImpLin.Name = "lblImpLin";
            this.lblImpLin.Size = new System.Drawing.Size(110, 13);
            this.lblImpLin.TabIndex = 6;
            this.lblImpLin.Text = "Impedancia Línea [Ω]";
            // 
            // lblLonLin
            // 
            this.lblLonLin.AutoSize = true;
            this.lblLonLin.Location = new System.Drawing.Point(42, 171);
            this.lblLonLin.Name = "lblLonLin";
            this.lblLonLin.Size = new System.Drawing.Size(128, 13);
            this.lblLonLin.TabIndex = 7;
            this.lblLonLin.Text = "Longitud de la Línea [km]";
            // 
            // lblLinImp
            // 
            this.lblLinImp.AutoSize = true;
            this.lblLinImp.Location = new System.Drawing.Point(42, 197);
            this.lblLinImp.Name = "lblLinImp";
            this.lblLinImp.Size = new System.Drawing.Size(88, 13);
            this.lblLinImp.TabIndex = 8;
            this.lblLinImp.Text = "Línea Impactada";
            // 
            // txtImpCan
            // 
            this.txtImpCan.Location = new System.Drawing.Point(271, 86);
            this.txtImpCan.Name = "txtImpCan";
            this.txtImpCan.Size = new System.Drawing.Size(100, 20);
            this.txtImpCan.TabIndex = 9;
            // 
            // txtPImp
            // 
            this.txtPImp.Location = new System.Drawing.Point(270, 112);
            this.txtPImp.Name = "txtPImp";
            this.txtPImp.Size = new System.Drawing.Size(100, 20);
            this.txtPImp.TabIndex = 10;
            // 
            // txtImpLin
            // 
            this.txtImpLin.Location = new System.Drawing.Point(271, 142);
            this.txtImpLin.Name = "txtImpLin";
            this.txtImpLin.Size = new System.Drawing.Size(100, 20);
            this.txtImpLin.TabIndex = 11;
            // 
            // txtLonLin
            // 
            this.txtLonLin.Location = new System.Drawing.Point(270, 168);
            this.txtLonLin.Name = "txtLonLin";
            this.txtLonLin.Size = new System.Drawing.Size(100, 20);
            this.txtLonLin.TabIndex = 12;
            // 
            // txtLinImp
            // 
            this.txtLinImp.Location = new System.Drawing.Point(270, 194);
            this.txtLinImp.Name = "txtLinImp";
            this.txtLinImp.Size = new System.Drawing.Size(100, 20);
            this.txtLinImp.TabIndex = 13;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(587, 31);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "Resultado";
            // 
            // lbCodDes
            // 
            this.lbCodDes.AutoSize = true;
            this.lbCodDes.Location = new System.Drawing.Point(42, 5);
            this.lbCodDes.Name = "lbCodDes";
            this.lbCodDes.Size = new System.Drawing.Size(104, 13);
            this.lbCodDes.TabIndex = 17;
            this.lbCodDes.Text = "Código de Descarga";
            // 
            // txtCodDes
            // 
            this.txtCodDes.Location = new System.Drawing.Point(270, 2);
            this.txtCodDes.Name = "txtCodDes";
            this.txtCodDes.Size = new System.Drawing.Size(100, 20);
            this.txtCodDes.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(497, 58);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 23;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txtCodDes);
            this.panel1.Controls.Add(this.lbCodDes);
            this.panel1.Controls.Add(this.txtLinImp);
            this.panel1.Controls.Add(this.txtLonLin);
            this.panel1.Controls.Add(this.txtImpLin);
            this.panel1.Controls.Add(this.txtPImp);
            this.panel1.Controls.Add(this.txtImpCan);
            this.panel1.Controls.Add(this.lblLinImp);
            this.panel1.Controls.Add(this.lblLonLin);
            this.panel1.Controls.Add(this.lblImpLin);
            this.panel1.Controls.Add(this.lblPorImp);
            this.panel1.Controls.Add(this.lblImpCan);
            this.panel1.Controls.Add(this.lblMag);
            this.panel1.Controls.Add(this.txtM);
            this.panel1.Controls.Add(this.lblForOn);
            this.panel1.Controls.Add(this.txtFO);
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 238);
            this.panel1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnBor);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "REGISTRO DESCARGA ELÉCTRICA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnBor;
        private System.Windows.Forms.TextBox txtFO;
        private System.Windows.Forms.Label lblForOn;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.Label lblImpCan;
        private System.Windows.Forms.Label lblPorImp;
        private System.Windows.Forms.Label lblImpLin;
        private System.Windows.Forms.Label lblLonLin;
        private System.Windows.Forms.Label lblLinImp;
        private System.Windows.Forms.TextBox txtImpCan;
        private System.Windows.Forms.TextBox txtPImp;
        private System.Windows.Forms.TextBox txtImpLin;
        private System.Windows.Forms.TextBox txtLonLin;
        private System.Windows.Forms.TextBox txtLinImp;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lbCodDes;
        private System.Windows.Forms.TextBox txtCodDes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Panel panel1;
    }
}

