
namespace Menu_Inicio_IU
{
    partial class frmSucursales
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
            this.dgvSuc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodSuc = new System.Windows.Forms.TextBox();
            this.txtTelSuc = new System.Windows.Forms.TextBox();
            this.txtDirSuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModSuc = new System.Windows.Forms.Button();
            this.btnBajaSuc = new System.Windows.Forms.Button();
            this.btnAltaSuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSuc
            // 
            this.dgvSuc.AllowUserToAddRows = false;
            this.dgvSuc.AllowUserToDeleteRows = false;
            this.dgvSuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuc.Location = new System.Drawing.Point(27, 51);
            this.dgvSuc.Name = "dgvSuc";
            this.dgvSuc.ReadOnly = true;
            this.dgvSuc.RowHeadersWidth = 102;
            this.dgvSuc.RowTemplate.Height = 40;
            this.dgvSuc.Size = new System.Drawing.Size(1069, 428);
            this.dgvSuc.TabIndex = 0;
            this.dgvSuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuc_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodSuc
            // 
            this.txtCodSuc.Location = new System.Drawing.Point(44, 561);
            this.txtCodSuc.Name = "txtCodSuc";
            this.txtCodSuc.Size = new System.Drawing.Size(162, 38);
            this.txtCodSuc.TabIndex = 2;
            // 
            // txtTelSuc
            // 
            this.txtTelSuc.Location = new System.Drawing.Point(256, 563);
            this.txtTelSuc.Name = "txtTelSuc";
            this.txtTelSuc.Size = new System.Drawing.Size(231, 38);
            this.txtTelSuc.TabIndex = 3;
            // 
            // txtDirSuc
            // 
            this.txtDirSuc.Location = new System.Drawing.Point(550, 563);
            this.txtDirSuc.Name = "txtDirSuc";
            this.txtDirSuc.Size = new System.Drawing.Size(551, 38);
            this.txtDirSuc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección";
            // 
            // btnModSuc
            // 
            this.btnModSuc.Location = new System.Drawing.Point(450, 661);
            this.btnModSuc.Name = "btnModSuc";
            this.btnModSuc.Size = new System.Drawing.Size(185, 55);
            this.btnModSuc.TabIndex = 8;
            this.btnModSuc.Text = "Modificar";
            this.btnModSuc.UseVisualStyleBackColor = true;
            this.btnModSuc.Click += new System.EventHandler(this.btnModSuc_Click);
            // 
            // btnBajaSuc
            // 
            this.btnBajaSuc.Location = new System.Drawing.Point(241, 661);
            this.btnBajaSuc.Name = "btnBajaSuc";
            this.btnBajaSuc.Size = new System.Drawing.Size(185, 55);
            this.btnBajaSuc.TabIndex = 9;
            this.btnBajaSuc.Text = "Baja";
            this.btnBajaSuc.UseVisualStyleBackColor = true;
            this.btnBajaSuc.Click += new System.EventHandler(this.btnBajaSuc_Click);
            // 
            // btnAltaSuc
            // 
            this.btnAltaSuc.Location = new System.Drawing.Point(32, 661);
            this.btnAltaSuc.Name = "btnAltaSuc";
            this.btnAltaSuc.Size = new System.Drawing.Size(185, 55);
            this.btnAltaSuc.TabIndex = 10;
            this.btnAltaSuc.Text = "Alta";
            this.btnAltaSuc.UseVisualStyleBackColor = true;
            this.btnAltaSuc.Click += new System.EventHandler(this.btnAltaSuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.dgvSuc);
            this.groupBox1.Controls.Add(this.btnAltaSuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodSuc);
            this.groupBox1.Controls.Add(this.btnBajaSuc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnModSuc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelSuc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDirSuc);
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 765);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sucursales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(659, 661);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(185, 55);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 825);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSucursales";
            this.Text = ".:Listado Sucursales:.";
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodSuc;
        private System.Windows.Forms.TextBox txtTelSuc;
        private System.Windows.Forms.TextBox txtDirSuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModSuc;
        private System.Windows.Forms.Button btnBajaSuc;
        private System.Windows.Forms.Button btnAltaSuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
    }
}