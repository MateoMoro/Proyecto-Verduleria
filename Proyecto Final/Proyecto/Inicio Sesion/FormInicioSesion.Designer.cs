namespace Proyecto_Final.Proyecto.Inicio_Sesion
{
    partial class FormInicioSesion
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Contraseña = new System.Windows.Forms.TextBox();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Contraseña
            // 
            this.textBox_Contraseña.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Contraseña.Location = new System.Drawing.Point(187, 45);
            this.textBox_Contraseña.Name = "textBox_Contraseña";
            this.textBox_Contraseña.PasswordChar = '*';
            this.textBox_Contraseña.Size = new System.Drawing.Size(210, 27);
            this.textBox_Contraseña.TabIndex = 11;
            this.textBox_Contraseña.UseSystemPasswordChar = true;
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Usuario.Location = new System.Drawing.Point(187, 12);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(210, 27);
            this.textBox_Usuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "CONTRASEÑA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Orange;
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(8, 124);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(126, 25);
            this.Btn_Salir.TabIndex = 12;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Silver;
            this.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(140, 124);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 25);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Green;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Location = new System.Drawing.Point(271, 124);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(126, 25);
            this.Btn_Login.TabIndex = 14;
            this.Btn_Login.Text = "LOGIN";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Contraseña);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Login);
            this.Name = "FormInicioSesion";
            this.Text = "FormInicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Contraseña;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Login;
    }
}