
namespace Menu_Inicio_IU
{
    partial class UC_User
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuestoLogin = new System.Windows.Forms.TextBox();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "USUARIO:";
            // 
            // txtPuestoLogin
            // 
            this.txtPuestoLogin.Enabled = false;
            this.txtPuestoLogin.Location = new System.Drawing.Point(16, 87);
            this.txtPuestoLogin.Name = "txtPuestoLogin";
            this.txtPuestoLogin.Size = new System.Drawing.Size(255, 38);
            this.txtPuestoLogin.TabIndex = 49;
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Enabled = false;
            this.txtUserLogin.Location = new System.Drawing.Point(16, 43);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(255, 38);
            this.txtUserLogin.TabIndex = 48;
            // 
            // UC_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuestoLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Name = "UC_User";
            this.Size = new System.Drawing.Size(288, 145);
            this.Load += new System.EventHandler(this.UC_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuestoLogin;
        private System.Windows.Forms.TextBox txtUserLogin;
    }
}
