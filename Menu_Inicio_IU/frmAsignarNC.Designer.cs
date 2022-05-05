
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResp
            // 
            this.dgvResp.AllowUserToAddRows = false;
            this.dgvResp.AllowUserToDeleteRows = false;
            this.dgvResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResp.Location = new System.Drawing.Point(58, 106);
            this.dgvResp.Name = "dgvResp";
            this.dgvResp.ReadOnly = true;
            this.dgvResp.RowHeadersWidth = 102;
            this.dgvResp.RowTemplate.Height = 40;
            this.dgvResp.Size = new System.Drawing.Size(705, 578);
            this.dgvResp.TabIndex = 0;
            // 
            // dgvAsigados
            // 
            this.dgvAsigados.AllowUserToAddRows = false;
            this.dgvAsigados.AllowUserToDeleteRows = false;
            this.dgvAsigados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigados.Location = new System.Drawing.Point(1188, 106);
            this.dgvAsigados.Name = "dgvAsigados";
            this.dgvAsigados.ReadOnly = true;
            this.dgvAsigados.RowHeadersWidth = 102;
            this.dgvAsigados.RowTemplate.Height = 40;
            this.dgvAsigados.Size = new System.Drawing.Size(705, 578);
            this.dgvAsigados.TabIndex = 1;
            // 
            // cmbListaNC
            // 
            this.cmbListaNC.FormattingEnabled = true;
            this.cmbListaNC.Location = new System.Drawing.Point(812, 236);
            this.cmbListaNC.Name = "cmbListaNC";
            this.cmbListaNC.Size = new System.Drawing.Size(322, 39);
            this.cmbListaNC.TabIndex = 2;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(855, 319);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(238, 61);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(855, 406);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(238, 62);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista Responsables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1182, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nota de Créditos Asignadas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(855, 622);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(238, 62);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmAsignarNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 734);
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
    }
}