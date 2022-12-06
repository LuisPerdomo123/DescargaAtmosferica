namespace AppBaseDatosLEPO
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodDes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listSubes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdeltat = new System.Windows.Forms.TextBox();
            this.txtNoRegis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTasaAsc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTiem50 = new System.Windows.Forms.TextBox();
            this.txtMag50 = new System.Windows.Forms.TextBox();
            this.txtTiem90 = new System.Windows.Forms.TextBox();
            this.txtMag90 = new System.Windows.Forms.TextBox();
            this.txtTiem10 = new System.Windows.Forms.TextBox();
            this.txtMag10 = new System.Windows.Forms.TextBox();
            this.txtTPico = new System.Windows.Forms.TextBox();
            this.txtMagPico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Crear2 = new System.Windows.Forms.Button();
            this.buscar2 = new System.Windows.Forms.Button();
            this.actual2 = new System.Windows.Forms.Button();
            this.elim2 = new System.Windows.Forms.Button();
            this.lblResul2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de descarga";
            // 
            // lblCodDes
            // 
            this.lblCodDes.AutoSize = true;
            this.lblCodDes.Location = new System.Drawing.Point(159, 35);
            this.lblCodDes.Name = "lblCodDes";
            this.lblCodDes.Size = new System.Drawing.Size(0, 13);
            this.lblCodDes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSubes
            // 
            this.listSubes.FormattingEnabled = true;
            this.listSubes.Items.AddRange(new object[] {
            "AV_PRIMERA",
            "CHARQUITO",
            "TORCA",
            "TUNAL"});
            this.listSubes.Location = new System.Drawing.Point(204, 65);
            this.listSubes.Name = "listSubes";
            this.listSubes.Size = new System.Drawing.Size(121, 21);
            this.listSubes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecionar subestación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delta tiempo registro [us]";
            // 
            // txtdeltat
            // 
            this.txtdeltat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtdeltat.Location = new System.Drawing.Point(204, 94);
            this.txtdeltat.Name = "txtdeltat";
            this.txtdeltat.Size = new System.Drawing.Size(100, 20);
            this.txtdeltat.TabIndex = 6;
            // 
            // txtNoRegis
            // 
            this.txtNoRegis.Location = new System.Drawing.Point(204, 120);
            this.txtNoRegis.Name = "txtNoRegis";
            this.txtNoRegis.Size = new System.Drawing.Size(100, 20);
            this.txtNoRegis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de registro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(31, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 126);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.txtTasaAsc);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtTiem50);
            this.panel2.Controls.Add(this.txtMag50);
            this.panel2.Controls.Add(this.txtTiem90);
            this.panel2.Controls.Add(this.txtMag90);
            this.panel2.Controls.Add(this.txtTiem10);
            this.panel2.Controls.Add(this.txtMag10);
            this.panel2.Controls.Add(this.txtTPico);
            this.panel2.Controls.Add(this.txtMagPico);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(31, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 280);
            this.panel2.TabIndex = 10;
            // 
            // txtTasaAsc
            // 
            this.txtTasaAsc.Location = new System.Drawing.Point(173, 247);
            this.txtTasaAsc.Name = "txtTasaAsc";
            this.txtTasaAsc.Size = new System.Drawing.Size(100, 20);
            this.txtTasaAsc.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tasa de ascenso";
            // 
            // txtTiem50
            // 
            this.txtTiem50.Location = new System.Drawing.Point(173, 220);
            this.txtTiem50.Name = "txtTiem50";
            this.txtTiem50.Size = new System.Drawing.Size(100, 20);
            this.txtTiem50.TabIndex = 15;
            // 
            // txtMag50
            // 
            this.txtMag50.Location = new System.Drawing.Point(173, 194);
            this.txtMag50.Name = "txtMag50";
            this.txtMag50.Size = new System.Drawing.Size(100, 20);
            this.txtMag50.TabIndex = 14;
            // 
            // txtTiem90
            // 
            this.txtTiem90.Location = new System.Drawing.Point(173, 167);
            this.txtTiem90.Name = "txtTiem90";
            this.txtTiem90.Size = new System.Drawing.Size(100, 20);
            this.txtTiem90.TabIndex = 13;
            // 
            // txtMag90
            // 
            this.txtMag90.Location = new System.Drawing.Point(173, 139);
            this.txtMag90.Name = "txtMag90";
            this.txtMag90.Size = new System.Drawing.Size(100, 20);
            this.txtMag90.TabIndex = 12;
            // 
            // txtTiem10
            // 
            this.txtTiem10.Location = new System.Drawing.Point(173, 108);
            this.txtTiem10.Name = "txtTiem10";
            this.txtTiem10.Size = new System.Drawing.Size(100, 20);
            this.txtTiem10.TabIndex = 11;
            // 
            // txtMag10
            // 
            this.txtMag10.Location = new System.Drawing.Point(173, 77);
            this.txtMag10.Name = "txtMag10";
            this.txtMag10.Size = new System.Drawing.Size(100, 20);
            this.txtMag10.TabIndex = 10;
            // 
            // txtTPico
            // 
            this.txtTPico.Location = new System.Drawing.Point(173, 45);
            this.txtTPico.Name = "txtTPico";
            this.txtTPico.Size = new System.Drawing.Size(100, 20);
            this.txtTPico.TabIndex = 9;
            // 
            // txtMagPico
            // 
            this.txtMagPico.Location = new System.Drawing.Point(173, 17);
            this.txtMagPico.Name = "txtMagPico";
            this.txtMagPico.Size = new System.Drawing.Size(100, 20);
            this.txtMagPico.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tiempo 50 % [us]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Magnitud 50 %  [kA]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tiempo 90 % [us]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Magnitud 90% [kA]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tiempo 10 % [us]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Magnitud 10% [kA]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tiempo Pico [us]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Magnitud Pico [kA]";
            // 
            // Crear2
            // 
            this.Crear2.Location = new System.Drawing.Point(389, 35);
            this.Crear2.Name = "Crear2";
            this.Crear2.Size = new System.Drawing.Size(34, 23);
            this.Crear2.TabIndex = 11;
            this.Crear2.Text = "C";
            this.Crear2.UseVisualStyleBackColor = true;
            this.Crear2.Click += new System.EventHandler(this.Crear2_Click);
            // 
            // buscar2
            // 
            this.buscar2.Location = new System.Drawing.Point(389, 64);
            this.buscar2.Name = "buscar2";
            this.buscar2.Size = new System.Drawing.Size(34, 23);
            this.buscar2.TabIndex = 12;
            this.buscar2.Text = "R";
            this.buscar2.UseVisualStyleBackColor = true;
            this.buscar2.Click += new System.EventHandler(this.buscar2_Click);
            // 
            // actual2
            // 
            this.actual2.Location = new System.Drawing.Point(389, 93);
            this.actual2.Name = "actual2";
            this.actual2.Size = new System.Drawing.Size(34, 23);
            this.actual2.TabIndex = 13;
            this.actual2.Text = "U";
            this.actual2.UseVisualStyleBackColor = true;
            this.actual2.Click += new System.EventHandler(this.actual2_Click);
            // 
            // elim2
            // 
            this.elim2.Location = new System.Drawing.Point(389, 122);
            this.elim2.Name = "elim2";
            this.elim2.Size = new System.Drawing.Size(34, 23);
            this.elim2.TabIndex = 14;
            this.elim2.Text = "D";
            this.elim2.UseVisualStyleBackColor = true;
            this.elim2.Click += new System.EventHandler(this.elim2_Click);
            // 
            // lblResul2
            // 
            this.lblResul2.AutoSize = true;
            this.lblResul2.Location = new System.Drawing.Point(438, 69);
            this.lblResul2.Name = "lblResul2";
            this.lblResul2.Size = new System.Drawing.Size(61, 13);
            this.lblResul2.TabIndex = 15;
            this.lblResul2.Text = "Resultado: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblResul2);
            this.Controls.Add(this.elim2);
            this.Controls.Add(this.actual2);
            this.Controls.Add(this.buscar2);
            this.Controls.Add(this.Crear2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoRegis);
            this.Controls.Add(this.txtdeltat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSubes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "REGISTRO SOBRETENSIÓN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodDes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox listSubes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdeltat;
        private System.Windows.Forms.TextBox txtNoRegis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTiem50;
        private System.Windows.Forms.TextBox txtMag50;
        private System.Windows.Forms.TextBox txtTiem90;
        private System.Windows.Forms.TextBox txtMag90;
        private System.Windows.Forms.TextBox txtTiem10;
        private System.Windows.Forms.TextBox txtMag10;
        private System.Windows.Forms.TextBox txtTPico;
        private System.Windows.Forms.TextBox txtMagPico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Crear2;
        private System.Windows.Forms.Button buscar2;
        private System.Windows.Forms.Button actual2;
        private System.Windows.Forms.Button elim2;
        private System.Windows.Forms.TextBox txtTasaAsc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblResul2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}