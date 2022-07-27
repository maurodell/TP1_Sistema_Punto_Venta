
namespace Menu_Inicio_IU
{
    partial class frmAsignarNC
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
            this.dgvResp = new System.Windows.Forms.DataGridView();
            this.dgvAsigados = new System.Windows.Forms.DataGridView();
            this.cmbListaNC = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uC_User1 = new Menu_Inicio_IU.UC_User();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResp
            // 
            this.dgvResp.AllowUserToAddRows = false;
            this.dgvResp.AllowUserToDeleteRows = false;
            this.dgvResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResp.Location = new System.Drawing.Point(55, 242);
            this.dgvResp.Name = "dgvResp";
            this.dgvResp.ReadOnly = true;
            this.dgvResp.RowHeadersWidth = 102;
            this.dgvResp.RowTemplate.Height = 40;
            this.dgvResp.Size = new System.Drawing.Size(937, 578);
            this.dgvResp.TabIndex = 0;
            this.dgvResp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResp_CellClick);
            // 
            // dgvAsigados
            // 
            this.dgvAsigados.AllowUserToAddRows = false;
            this.dgvAsigados.AllowUserToDeleteRows = false;
            this.dgvAsigados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigados.Location = new System.Drawing.Point(1371, 242);
            this.dgvAsigados.Name = "dgvAsigados";
            this.dgvAsigados.ReadOnly = true;
            this.dgvAsigados.RowHeadersWidth = 102;
            this.dgvAsigados.RowTemplate.Height = 40;
            this.dgvAsigados.Size = new System.Drawing.Size(953, 578);
            this.dgvAsigados.TabIndex = 1;
            // 
            // cmbListaNC
            // 
            this.cmbListaNC.FormattingEnabled = true;
            this.cmbListaNC.Location = new System.Drawing.Point(1020, 372);
            this.cmbListaNC.Name = "cmbListaNC";
            this.cmbListaNC.Size = new System.Drawing.Size(322, 39);
            this.cmbListaNC.TabIndex = 2;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(1063, 455);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(238, 61);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(1063, 542);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(238, 62);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista Responsables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1390, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nota de Créditos Asignadas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1063, 758);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(238, 62);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Número Factura:";
            // 
            // uC_User1
            // 
            this.uC_User1.Location = new System.Drawing.Point(43, 27);
            this.uC_User1.Name = "uC_User1";
            this.uC_User1.Size = new System.Drawing.Size(288, 145);
            this.uC_User1.TabIndex = 9;
            // 
            // frmAsignarNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2374, 842);
            this.Controls.Add(this.uC_User1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cmbListaNC);
            this.Controls.Add(this.dgvAsigados);
            this.Controls.Add(this.dgvResp);
            this.Name = "frmAsignarNC";
            this.Text = "Asignación De Resposables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAsignarNC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResp;
        private System.Windows.Forms.DataGridView dgvAsigados;
        private System.Windows.Forms.ComboBox cmbListaNC;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private UC_User uC_User1;
    }
}