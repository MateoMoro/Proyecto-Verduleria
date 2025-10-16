namespace Proyecto_FInal
{
    partial class Principal
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
            this.Btn_CBUsuario = new System.Windows.Forms.Button();
            this.Btn_Compras = new System.Windows.Forms.Button();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_CBUsuario
            // 
            this.Btn_CBUsuario.Location = new System.Drawing.Point(125, 186);
            this.Btn_CBUsuario.Name = "Btn_CBUsuario";
            this.Btn_CBUsuario.Size = new System.Drawing.Size(138, 23);
            this.Btn_CBUsuario.TabIndex = 0;
            this.Btn_CBUsuario.Text = "Crear o Borrar Usuario";
            this.Btn_CBUsuario.UseVisualStyleBackColor = true;
            this.Btn_CBUsuario.Click += new System.EventHandler(this.Btn_CBUsuario_Click);
            // 
            // Btn_Compras
            // 
            this.Btn_Compras.Location = new System.Drawing.Point(548, 186);
            this.Btn_Compras.Name = "Btn_Compras";
            this.Btn_Compras.Size = new System.Drawing.Size(138, 23);
            this.Btn_Compras.TabIndex = 1;
            this.Btn_Compras.Text = "Acceder a Finanzas";
            this.Btn_Compras.UseVisualStyleBackColor = true;
            this.Btn_Compras.Click += new System.EventHandler(this.Btn_Compras_Click);
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Location = new System.Drawing.Point(125, 145);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(138, 23);
            this.Btn_Inventario.TabIndex = 2;
            this.Btn_Inventario.Text = "Acceder al Inventario";
            this.Btn_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Inventario);
            this.Controls.Add(this.Btn_Compras);
            this.Controls.Add(this.Btn_CBUsuario);
            this.Name = "Principal";
            this.Text = "Pagina Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_CBUsuario;
        private System.Windows.Forms.Button Btn_Compras;
        private System.Windows.Forms.Button Btn_Inventario;
    }
}