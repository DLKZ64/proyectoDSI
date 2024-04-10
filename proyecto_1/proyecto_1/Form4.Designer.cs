
namespace proyecto_1
{
    partial class FrmRegTrab
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
            this.lblIngresarTrab = new System.Windows.Forms.Label();
            this.btnRegresarTrab = new System.Windows.Forms.Button();
            this.txtContraTrab = new System.Windows.Forms.TextBox();
            this.txtNombresTrab = new System.Windows.Forms.TextBox();
            this.txtApellidosTrab = new System.Windows.Forms.TextBox();
            this.txtCorreoTrab = new System.Windows.Forms.TextBox();
            this.pnlIngreTrab = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.pnlIngreTrab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresarTrab
            // 
            this.lblIngresarTrab.AutoSize = true;
            this.lblIngresarTrab.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresarTrab.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarTrab.ForeColor = System.Drawing.Color.White;
            this.lblIngresarTrab.Location = new System.Drawing.Point(29, 31);
            this.lblIngresarTrab.Name = "lblIngresarTrab";
            this.lblIngresarTrab.Size = new System.Drawing.Size(423, 49);
            this.lblIngresarTrab.TabIndex = 17;
            this.lblIngresarTrab.Text = "Ingresar trabajador";
            // 
            // btnRegresarTrab
            // 
            this.btnRegresarTrab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.btnRegresarTrab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresarTrab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnRegresarTrab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRegresarTrab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnRegresarTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarTrab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarTrab.ForeColor = System.Drawing.Color.White;
            this.btnRegresarTrab.Location = new System.Drawing.Point(715, 367);
            this.btnRegresarTrab.Name = "btnRegresarTrab";
            this.btnRegresarTrab.Size = new System.Drawing.Size(161, 40);
            this.btnRegresarTrab.TabIndex = 24;
            this.btnRegresarTrab.Text = "Regresar";
            this.btnRegresarTrab.UseVisualStyleBackColor = false;
            this.btnRegresarTrab.Click += new System.EventHandler(this.btnRegresarTrab_Click);
            // 
            // txtContraTrab
            // 
            this.txtContraTrab.BackColor = System.Drawing.Color.White;
            this.txtContraTrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraTrab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraTrab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.txtContraTrab.Location = new System.Drawing.Point(38, 328);
            this.txtContraTrab.Name = "txtContraTrab";
            this.txtContraTrab.Size = new System.Drawing.Size(408, 25);
            this.txtContraTrab.TabIndex = 23;
            this.txtContraTrab.Text = "Contraseña";
            // 
            // txtNombresTrab
            // 
            this.txtNombresTrab.BackColor = System.Drawing.Color.White;
            this.txtNombresTrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresTrab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresTrab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.txtNombresTrab.Location = new System.Drawing.Point(38, 99);
            this.txtNombresTrab.Name = "txtNombresTrab";
            this.txtNombresTrab.Size = new System.Drawing.Size(408, 25);
            this.txtNombresTrab.TabIndex = 22;
            this.txtNombresTrab.Text = "Nombre/s";
            this.txtNombresTrab.TextChanged += new System.EventHandler(this.txtNombresTrab_TextChanged);
            // 
            // txtApellidosTrab
            // 
            this.txtApellidosTrab.BackColor = System.Drawing.Color.White;
            this.txtApellidosTrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidosTrab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosTrab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.txtApellidosTrab.Location = new System.Drawing.Point(38, 172);
            this.txtApellidosTrab.Name = "txtApellidosTrab";
            this.txtApellidosTrab.Size = new System.Drawing.Size(408, 25);
            this.txtApellidosTrab.TabIndex = 21;
            this.txtApellidosTrab.Text = "Apellidos";
            // 
            // txtCorreoTrab
            // 
            this.txtCorreoTrab.BackColor = System.Drawing.Color.White;
            this.txtCorreoTrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoTrab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoTrab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(149)))), ((int)(((byte)(90)))));
            this.txtCorreoTrab.Location = new System.Drawing.Point(38, 251);
            this.txtCorreoTrab.Name = "txtCorreoTrab";
            this.txtCorreoTrab.Size = new System.Drawing.Size(408, 25);
            this.txtCorreoTrab.TabIndex = 20;
            this.txtCorreoTrab.Text = "Correo";
            // 
            // pnlIngreTrab
            // 
            this.pnlIngreTrab.BackColor = System.Drawing.Color.DarkGray;
            this.pnlIngreTrab.Controls.Add(this.btnMinimizar);
            this.pnlIngreTrab.Controls.Add(this.btncerrar);
            this.pnlIngreTrab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIngreTrab.Location = new System.Drawing.Point(0, 0);
            this.pnlIngreTrab.Name = "pnlIngreTrab";
            this.pnlIngreTrab.Size = new System.Drawing.Size(888, 28);
            this.pnlIngreTrab.TabIndex = 25;
            this.pnlIngreTrab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlIngreTrab_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(190)))), ((int)(((byte)(63)))));
            this.btnMinimizar.Location = new System.Drawing.Point(811, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 23);
            this.btnMinimizar.TabIndex = 23;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Red;
            this.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(190)))), ((int)(((byte)(63)))));
            this.btncerrar.Location = new System.Drawing.Point(851, 2);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(34, 23);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            // 
            // FrmRegTrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(888, 421);
            this.Controls.Add(this.pnlIngreTrab);
            this.Controls.Add(this.btnRegresarTrab);
            this.Controls.Add(this.txtContraTrab);
            this.Controls.Add(this.txtNombresTrab);
            this.Controls.Add(this.txtApellidosTrab);
            this.Controls.Add(this.txtCorreoTrab);
            this.Controls.Add(this.lblIngresarTrab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegTrab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FrmRegTrab_Load);
            this.pnlIngreTrab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarTrab;
        private System.Windows.Forms.Button btnRegresarTrab;
        private System.Windows.Forms.TextBox txtContraTrab;
        private System.Windows.Forms.TextBox txtNombresTrab;
        private System.Windows.Forms.TextBox txtApellidosTrab;
        private System.Windows.Forms.TextBox txtCorreoTrab;
        private System.Windows.Forms.Panel pnlIngreTrab;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btncerrar;
    }
}