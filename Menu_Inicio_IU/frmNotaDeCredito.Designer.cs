
namespace Menu_Inicio_IU
{
    partial class frmNotaDeCredito
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNC = new System.Windows.Forms.DataGridView();
            this.uC_User1 = new Menu_Inicio_IU.UC_User();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumFac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de la Nota de Crédito";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(26, 394);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(495, 38);
            this.dtpFecha.TabIndex = 6;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(344, 469);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(177, 65);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(39, 469);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(177, 65);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(26, 249);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(495, 38);
            this.txtMonto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto:";
            // 
            // txtNumFac
            // 
            this.txtNumFac.Location = new System.Drawing.Point(26, 127);
            this.txtNumFac.Name = "txtNumFac";
            this.txtNumFac.Size = new System.Drawing.Size(495, 38);
            this.txtNumFac.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Factura:";
            // 
            // dgvNC
            // 
            this.dgvNC.AllowUserToAddRows = false;
            this.dgvNC.AllowUserToDeleteRows = false;
            this.dgvNC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNC.Location = new System.Drawing.Point(695, 67);
            this.dgvNC.Name = "dgvNC";
            this.dgvNC.ReadOnly = true;
            this.dgvNC.RowHeadersWidth = 102;
            this.dgvNC.RowTemplate.Height = 40;
            this.dgvNC.Size = new System.Drawing.Size(1233, 729);
            this.dgvNC.TabIndex = 1;
            // 
            // uC_User1
            // 
            this.uC_User1.Location = new System.Drawing.Point(56, 44);
            this.uC_User1.Name = "uC_User1";
            this.uC_User1.Size = new System.Drawing.Size(288, 145);
            this.uC_User1.TabIndex = 2;
            // 
            // frmNotaDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 834);
            this.Controls.Add(this.uC_User1);
            this.Controls.Add(this.dgvNC);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNotaDeCredito";
            this.Text = "Nota De Credito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNotaDeCredito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFac;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private UC_User uC_User1;
    }
}