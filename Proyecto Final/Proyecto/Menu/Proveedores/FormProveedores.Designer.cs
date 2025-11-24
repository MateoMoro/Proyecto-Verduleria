namespace Proyecto_Final.Proyecto.Menu.Proveedores
{
    partial class FormProveedores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_RazonSocial = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 333);
            this.dataGridView1.TabIndex = 28;
            // 
            // textBox_RazonSocial
            // 
            this.textBox_RazonSocial.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RazonSocial.Location = new System.Drawing.Point(12, 138);
            this.textBox_RazonSocial.Name = "textBox_RazonSocial";
            this.textBox_RazonSocial.Size = new System.Drawing.Size(300, 27);
            this.textBox_RazonSocial.TabIndex = 22;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(12, 34);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(300, 27);
            this.textBox_ID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID";
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(732, 351);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(140, 35);
            this.Btn_Volver.TabIndex = 28;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(304, 351);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(140, 35);
            this.Btn_Borrar.TabIndex = 27;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(158, 350);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(140, 36);
            this.Btn_Modificar.TabIndex = 26;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.OliveDrab;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 350);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(140, 35);
            this.Btn_Agregar.TabIndex = 25;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Correo.Location = new System.Drawing.Point(12, 190);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(300, 27);
            this.textBox_Correo.TabIndex = 23;
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Documento.Location = new System.Drawing.Point(12, 86);
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(300, 27);
            this.textBox_Documento.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Documento";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Telefono.Location = new System.Drawing.Point(12, 242);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(300, 27);
            this.textBox_Telefono.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Telefono";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Correo);
            this.Controls.Add(this.textBox_Documento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_RazonSocial);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_RazonSocial;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Label label5;
    }
}