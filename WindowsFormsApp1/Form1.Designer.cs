
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltipos = new System.Windows.Forms.Label();
            this.lblcant = new System.Windows.Forms.Label();
            this.lblPdra = new System.Windows.Forms.Label();
            this.lblCto = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.lblArena = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnpresupuesto = new System.Windows.Forms.Button();
            this.cbArena = new System.Windows.Forms.ComboBox();
            this.cbCtotp = new System.Windows.Forms.ComboBox();
            this.cbCto = new System.Windows.Forms.ComboBox();
            this.cbCaltp = new System.Windows.Forms.ComboBox();
            this.cbCal = new System.Windows.Forms.ComboBox();
            this.cbArenatp = new System.Windows.Forms.ComboBox();
            this.cbPdratp = new System.Windows.Forms.ComboBox();
            this.cbPdra = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.preciolblPdra = new System.Windows.Forms.Label();
            this.preciolblCto = new System.Windows.Forms.Label();
            this.preciolblcal = new System.Windows.Forms.Label();
            this.preciolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lbltipos
            // 
            this.lbltipos.AutoSize = true;
            this.lbltipos.Location = new System.Drawing.Point(69, 205);
            this.lbltipos.Name = "lbltipos";
            this.lbltipos.Size = new System.Drawing.Size(29, 13);
            this.lbltipos.TabIndex = 1;
            this.lbltipos.Text = "tipos";
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(69, 171);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(48, 13);
            this.lblcant.TabIndex = 2;
            this.lblcant.Text = "cantidad";
            // 
            // lblPdra
            // 
            this.lblPdra.AutoSize = true;
            this.lblPdra.Location = new System.Drawing.Point(360, 131);
            this.lblPdra.Name = "lblPdra";
            this.lblPdra.Size = new System.Drawing.Size(37, 13);
            this.lblPdra.TabIndex = 3;
            this.lblPdra.Text = "Piedra";
            // 
            // lblCto
            // 
            this.lblCto.AutoSize = true;
            this.lblCto.Location = new System.Drawing.Point(275, 131);
            this.lblCto.Name = "lblCto";
            this.lblCto.Size = new System.Drawing.Size(49, 13);
            this.lblCto.TabIndex = 4;
            this.lblCto.Text = "Cemento";
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(196, 131);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(22, 13);
            this.lblCal.TabIndex = 5;
            this.lblCal.Text = "Cal";
            // 
            // lblArena
            // 
            this.lblArena.AutoSize = true;
            this.lblArena.Location = new System.Drawing.Point(134, 131);
            this.lblArena.Name = "lblArena";
            this.lblArena.Size = new System.Drawing.Size(35, 13);
            this.lblArena.TabIndex = 6;
            this.lblArena.Text = "Arena";
            this.lblArena.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(561, 241);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(561, 278);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnpresupuesto
            // 
            this.btnpresupuesto.Location = new System.Drawing.Point(189, 278);
            this.btnpresupuesto.Name = "btnpresupuesto";
            this.btnpresupuesto.Size = new System.Drawing.Size(75, 23);
            this.btnpresupuesto.TabIndex = 10;
            this.btnpresupuesto.Text = "presupuestar";
            this.btnpresupuesto.UseVisualStyleBackColor = true;
            // 
            // cbArena
            // 
            this.cbArena.FormattingEnabled = true;
            this.cbArena.Location = new System.Drawing.Point(123, 163);
            this.cbArena.Name = "cbArena";
            this.cbArena.Size = new System.Drawing.Size(75, 21);
            this.cbArena.TabIndex = 11;
            this.cbArena.SelectedIndexChanged += new System.EventHandler(this.cbArena_SelectedIndexChanged);
            // 
            // cbCtotp
            // 
            this.cbCtotp.FormattingEnabled = true;
            this.cbCtotp.Location = new System.Drawing.Point(278, 197);
            this.cbCtotp.Name = "cbCtotp";
            this.cbCtotp.Size = new System.Drawing.Size(75, 21);
            this.cbCtotp.TabIndex = 12;
            this.cbCtotp.SelectedIndexChanged += new System.EventHandler(this.cbCtotp_SelectedIndexChanged);
            // 
            // cbCto
            // 
            this.cbCto.FormattingEnabled = true;
            this.cbCto.Location = new System.Drawing.Point(278, 163);
            this.cbCto.Name = "cbCto";
            this.cbCto.Size = new System.Drawing.Size(75, 21);
            this.cbCto.TabIndex = 13;
            this.cbCto.SelectedIndexChanged += new System.EventHandler(this.cbCto_SelectedIndexChanged);
            // 
            // cbCaltp
            // 
            this.cbCaltp.FormattingEnabled = true;
            this.cbCaltp.Location = new System.Drawing.Point(199, 197);
            this.cbCaltp.Name = "cbCaltp";
            this.cbCaltp.Size = new System.Drawing.Size(75, 21);
            this.cbCaltp.TabIndex = 14;
            this.cbCaltp.SelectedIndexChanged += new System.EventHandler(this.cbCaltp_SelectedIndexChanged);
            // 
            // cbCal
            // 
            this.cbCal.FormattingEnabled = true;
            this.cbCal.Location = new System.Drawing.Point(199, 163);
            this.cbCal.Name = "cbCal";
            this.cbCal.Size = new System.Drawing.Size(75, 21);
            this.cbCal.TabIndex = 15;
            this.cbCal.SelectedIndexChanged += new System.EventHandler(this.cbCal_SelectedIndexChanged);
            // 
            // cbArenatp
            // 
            this.cbArenatp.FormattingEnabled = true;
            this.cbArenatp.Location = new System.Drawing.Point(123, 197);
            this.cbArenatp.Name = "cbArenatp";
            this.cbArenatp.Size = new System.Drawing.Size(75, 21);
            this.cbArenatp.TabIndex = 16;
            this.cbArenatp.SelectedIndexChanged += new System.EventHandler(this.cbArenatp_SelectedIndexChanged);
            // 
            // cbPdratp
            // 
            this.cbPdratp.FormattingEnabled = true;
            this.cbPdratp.Location = new System.Drawing.Point(359, 197);
            this.cbPdratp.Name = "cbPdratp";
            this.cbPdratp.Size = new System.Drawing.Size(75, 21);
            this.cbPdratp.TabIndex = 17;
            this.cbPdratp.SelectedIndexChanged += new System.EventHandler(this.cbPdratp_SelectedIndexChanged);
            // 
            // cbPdra
            // 
            this.cbPdra.FormattingEnabled = true;
            this.cbPdra.Location = new System.Drawing.Point(359, 163);
            this.cbPdra.Name = "cbPdra";
            this.cbPdra.Size = new System.Drawing.Size(75, 21);
            this.cbPdra.TabIndex = 18;
            this.cbPdra.SelectedIndexChanged += new System.EventHandler(this.cbPdra_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(86, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(278, 278);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.txtPresupuesto.TabIndex = 21;
            // 
            // preciolblPdra
            // 
            this.preciolblPdra.AutoSize = true;
            this.preciolblPdra.Location = new System.Drawing.Point(356, 227);
            this.preciolblPdra.Name = "preciolblPdra";
            this.preciolblPdra.Size = new System.Drawing.Size(36, 13);
            this.preciolblPdra.TabIndex = 22;
            this.preciolblPdra.Text = "precio";
            this.preciolblPdra.Click += new System.EventHandler(this.preciolblPdra_Click);
            // 
            // preciolblCto
            // 
            this.preciolblCto.AutoSize = true;
            this.preciolblCto.Location = new System.Drawing.Point(275, 227);
            this.preciolblCto.Name = "preciolblCto";
            this.preciolblCto.Size = new System.Drawing.Size(36, 13);
            this.preciolblCto.TabIndex = 23;
            this.preciolblCto.Text = "precio";
            this.preciolblCto.Click += new System.EventHandler(this.label3_Click);
            // 
            // preciolblcal
            // 
            this.preciolblcal.AutoSize = true;
            this.preciolblcal.Location = new System.Drawing.Point(196, 227);
            this.preciolblcal.Name = "preciolblcal";
            this.preciolblcal.Size = new System.Drawing.Size(36, 13);
            this.preciolblcal.TabIndex = 24;
            this.preciolblcal.Text = "precio";
            this.preciolblcal.Click += new System.EventHandler(this.preciolblcal_Click);
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.Location = new System.Drawing.Point(120, 227);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(36, 13);
            this.preciolbl.TabIndex = 25;
            this.preciolbl.Text = "precio";
            this.preciolbl.Click += new System.EventHandler(this.preciolbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preciolbl);
            this.Controls.Add(this.preciolblcal);
            this.Controls.Add(this.preciolblCto);
            this.Controls.Add(this.preciolblPdra);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbPdra);
            this.Controls.Add(this.cbPdratp);
            this.Controls.Add(this.cbArenatp);
            this.Controls.Add(this.cbCal);
            this.Controls.Add(this.cbCaltp);
            this.Controls.Add(this.cbCto);
            this.Controls.Add(this.cbCtotp);
            this.Controls.Add(this.cbArena);
            this.Controls.Add(this.btnpresupuesto);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblArena);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.lblCto);
            this.Controls.Add(this.lblPdra);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.lbltipos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltipos;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Label lblPdra;
        private System.Windows.Forms.Label lblCto;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Label lblArena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnpresupuesto;
        private System.Windows.Forms.ComboBox cbArena;
        private System.Windows.Forms.ComboBox cbCtotp;
        private System.Windows.Forms.ComboBox cbCto;
        private System.Windows.Forms.ComboBox cbCaltp;
        private System.Windows.Forms.ComboBox cbCal;
        private System.Windows.Forms.ComboBox cbArenatp;
        private System.Windows.Forms.ComboBox cbPdratp;
        private System.Windows.Forms.ComboBox cbPdra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label preciolblPdra;
        private System.Windows.Forms.Label preciolblCto;
        private System.Windows.Forms.Label preciolblcal;
        private System.Windows.Forms.Label preciolbl;
    }
}

