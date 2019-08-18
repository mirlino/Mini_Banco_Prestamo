namespace Banco
{
    partial class Prestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmS = new System.Windows.Forms.Button();
            this.lblPersonalData = new System.Windows.Forms.Label();
            this.lblDataInformation = new System.Windows.Forms.Label();
            this.pDatosPersonales = new System.Windows.Forms.Panel();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbRaza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pDetallesPrestamo = new System.Windows.Forms.Panel();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pDatosPersonales.SuspendLayout();
            this.pDetallesPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(21, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(151, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido, ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(695, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnConfirmS
            // 
            this.btnConfirmS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmS.Location = new System.Drawing.Point(330, 334);
            this.btnConfirmS.Name = "btnConfirmS";
            this.btnConfirmS.Size = new System.Drawing.Size(115, 67);
            this.btnConfirmS.TabIndex = 2;
            this.btnConfirmS.Text = "Confirmar Solicitud";
            this.btnConfirmS.UseVisualStyleBackColor = true;
            this.btnConfirmS.Click += new System.EventHandler(this.BtnConfirmS_Click);
            // 
            // lblPersonalData
            // 
            this.lblPersonalData.AutoSize = true;
            this.lblPersonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalData.Location = new System.Drawing.Point(42, 99);
            this.lblPersonalData.Name = "lblPersonalData";
            this.lblPersonalData.Size = new System.Drawing.Size(156, 20);
            this.lblPersonalData.TabIndex = 3;
            this.lblPersonalData.Text = "Datos Personales:";
            // 
            // lblDataInformation
            // 
            this.lblDataInformation.AutoSize = true;
            this.lblDataInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInformation.Location = new System.Drawing.Point(404, 99);
            this.lblDataInformation.Name = "lblDataInformation";
            this.lblDataInformation.Size = new System.Drawing.Size(181, 20);
            this.lblDataInformation.TabIndex = 4;
            this.lblDataInformation.Text = "Detalles de Prestamo";
            // 
            // pDatosPersonales
            // 
            this.pDatosPersonales.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pDatosPersonales.Controls.Add(this.cbOrigen);
            this.pDatosPersonales.Controls.Add(this.cbRaza);
            this.pDatosPersonales.Controls.Add(this.label2);
            this.pDatosPersonales.Controls.Add(this.label1);
            this.errorProvider1.SetIconAlignment(this.pDatosPersonales, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.pDatosPersonales.Location = new System.Drawing.Point(46, 127);
            this.pDatosPersonales.Name = "pDatosPersonales";
            this.pDatosPersonales.Size = new System.Drawing.Size(336, 131);
            this.pDatosPersonales.TabIndex = 5;
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(177, 76);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(137, 21);
            this.cbOrigen.TabIndex = 3;
            // 
            // cbRaza
            // 
            this.cbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRaza.FormattingEnabled = true;
            this.cbRaza.Location = new System.Drawing.Point(177, 26);
            this.cbRaza.Name = "cbRaza";
            this.cbRaza.Size = new System.Drawing.Size(137, 21);
            this.cbRaza.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Luegar de origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raza:";
            // 
            // pDetallesPrestamo
            // 
            this.pDetallesPrestamo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pDetallesPrestamo.Controls.Add(this.txtPrestamo);
            this.pDetallesPrestamo.Controls.Add(this.cbCuotas);
            this.pDetallesPrestamo.Controls.Add(this.label4);
            this.pDetallesPrestamo.Controls.Add(this.label3);
            this.pDetallesPrestamo.Location = new System.Drawing.Point(408, 127);
            this.pDetallesPrestamo.Name = "pDetallesPrestamo";
            this.pDetallesPrestamo.Size = new System.Drawing.Size(323, 131);
            this.pDetallesPrestamo.TabIndex = 6;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(177, 29);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(127, 20);
            this.txtPrestamo.TabIndex = 3;
            // 
            // cbCuotas
            // 
            this.cbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Location = new System.Drawing.Point(177, 79);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(127, 21);
            this.cbCuotas.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cuotas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monto Prestamo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pDetallesPrestamo);
            this.Controls.Add(this.pDatosPersonales);
            this.Controls.Add(this.lblDataInformation);
            this.Controls.Add(this.lblPersonalData);
            this.Controls.Add(this.btnConfirmS);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.pDatosPersonales.ResumeLayout(false);
            this.pDatosPersonales.PerformLayout();
            this.pDetallesPrestamo.ResumeLayout(false);
            this.pDetallesPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmS;
        private System.Windows.Forms.Label lblPersonalData;
        private System.Windows.Forms.Label lblDataInformation;
        private System.Windows.Forms.Panel pDatosPersonales;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDetallesPrestamo;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}