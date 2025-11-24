namespace Proyecto_Final.Proyecto.Menu.Productos
{
    partial class FormProductos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.textBox_PrecioCompra = new System.Windows.Forms.TextBox();
            this.textBox_Codigo = new System.Windows.Forms.TextBox();
            this.textBox_PrecioVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 27);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Descripcion.Location = new System.Drawing.Point(12, 138);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(300, 27);
            this.textBox_Descripcion.TabIndex = 3;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(12, 86);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(300, 27);
            this.textBox_Nombre.TabIndex = 2;
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Stock.Location = new System.Drawing.Point(12, 242);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(300, 27);
            this.textBox_Stock.TabIndex = 5;
            // 
            // textBox_PrecioCompra
            // 
            this.textBox_PrecioCompra.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrecioCompra.Location = new System.Drawing.Point(12, 294);
            this.textBox_PrecioCompra.Name = "textBox_PrecioCompra";
            this.textBox_PrecioCompra.Size = new System.Drawing.Size(300, 27);
            this.textBox_PrecioCompra.TabIndex = 6;
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Codigo.Location = new System.Drawing.Point(12, 34);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.Size = new System.Drawing.Size(300, 27);
            this.textBox_Codigo.TabIndex = 1;
            // 
            // textBox_PrecioVenta
            // 
            this.textBox_PrecioVenta.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrecioVenta.Location = new System.Drawing.Point(12, 346);
            this.textBox_PrecioVenta.Name = "textBox_PrecioVenta";
            this.textBox_PrecioVenta.Size = new System.Drawing.Size(300, 27);
            this.textBox_PrecioVenta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio Venta";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.OliveDrab;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 379);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Agregar.TabIndex = 8;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(143, 380);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(124, 35);
            this.Btn_Modificar.TabIndex = 9;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(273, 380);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(124, 35);
            this.Btn_Borrar.TabIndex = 10;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(554, 362);
            this.dataGridView1.TabIndex = 19;
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(747, 380);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(125, 35);
            this.Btn_Volver.TabIndex = 11;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PrecioVenta);
            this.Controls.Add(this.textBox_Codigo);
            this.Controls.Add(this.textBox_PrecioCompra);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.TextBox textBox_PrecioCompra;
        private System.Windows.Forms.TextBox textBox_Codigo;
        private System.Windows.Forms.TextBox textBox_PrecioVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Volver;
    }
}