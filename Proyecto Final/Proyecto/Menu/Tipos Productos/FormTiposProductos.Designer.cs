namespace Proyecto_Final.Proyecto.Menu.Tipos_Productos
{
    partial class FormTiposProductos
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
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 314);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Descripcion.Location = new System.Drawing.Point(12, 86);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(300, 27);
            this.textBox_Descripcion.TabIndex = 11;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(12, 34);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(300, 27);
            this.textBox_ID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(747, 332);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(125, 35);
            this.Btn_Volver.TabIndex = 15;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(274, 332);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Borrar.TabIndex = 14;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(143, 331);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(125, 36);
            this.Btn_Modificar.TabIndex = 13;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.OliveDrab;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 331);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // FormTiposProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Name = "FormTiposProductos";
            this.Text = "FormTiposProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
    }
}