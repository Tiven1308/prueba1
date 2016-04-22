namespace Caballito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApuesta = new System.Windows.Forms.TextBox();
            this.cbxCaballo = new System.Windows.Forms.ComboBox();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.lbTotaldinero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 334);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(18, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "................................................................................." +
    "................................................................................" +
    "..........................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "................................................................................." +
    "................................................................................" +
    "..........................";
            // 
            // txtApuesta
            // 
            this.txtApuesta.Location = new System.Drawing.Point(322, 434);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(323, 20);
            this.txtApuesta.TabIndex = 2;
            // 
            // cbxCaballo
            // 
            this.cbxCaballo.FormattingEnabled = true;
            this.cbxCaballo.Items.AddRange(new object[] {
            "Caballo 1",
            "Caballo 2",
            "Caballo 3",
            "Caballo 4"});
            this.cbxCaballo.Location = new System.Drawing.Point(406, 469);
            this.cbxCaballo.Name = "cbxCaballo";
            this.cbxCaballo.Size = new System.Drawing.Size(239, 21);
            this.cbxCaballo.TabIndex = 3;
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarCarrera.Location = new System.Drawing.Point(424, 387);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(221, 31);
            this.btnIniciarCarrera.TabIndex = 4;
            this.btnIniciarCarrera.Text = "Iniciar Carrera ";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTotaldinero
            // 
            this.lbTotaldinero.AutoSize = true;
            this.lbTotaldinero.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotaldinero.Location = new System.Drawing.Point(203, 388);
            this.lbTotaldinero.Name = "lbTotaldinero";
            this.lbTotaldinero.Size = new System.Drawing.Size(94, 30);
            this.lbTotaldinero.TabIndex = 5;
            this.lbTotaldinero.Text = "20000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(18, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "................................................................................." +
    "................................................................................" +
    "..........................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(18, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(568, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "................................................................................." +
    "................................................................................" +
    "..........................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(20, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Apuesta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(20, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingrese El Valor Apostar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(20, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lista De Caballos Participantes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(537, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "..............";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(537, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "..............";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(537, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "..............";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(537, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "..............";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(547, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Meta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(547, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Meta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(547, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Meta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(547, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Meta";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(119, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 33);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(95, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 32);
            this.panel3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(674, 502);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotaldinero);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.cbxCaballo);
            this.Controls.Add(this.txtApuesta);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApuesta;
        private System.Windows.Forms.ComboBox cbxCaballo;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Label lbTotaldinero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

