namespace Proyecto_Final.Proyecto.Menu.Detalles_Ventas
{
    partial class FormDetallesVentas
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IdDetalleVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.comboBox_IDProducto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PrecioVenta = new System.Windows.Forms.TextBox();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.comboBox_IDVenta = new System.Windows.Forms.ComboBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SubTotal = new System.Windows.Forms.TextBox();
            this.Btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 89;
            this.label4.Text = "ID Detalle Venta";
            this.label4.UseMnemonic = false;
            // 
            // textBox_IdDetalleVenta
            // 
            this.textBox_IdDetalleVenta.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IdDetalleVenta.Location = new System.Drawing.Point(12, 34);
            this.textBox_IdDetalleVenta.Name = "textBox_IdDetalleVenta";
            this.textBox_IdDetalleVenta.Size = new System.Drawing.Size(300, 27);
            this.textBox_IdDetalleVenta.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 87;
            this.label1.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 86;
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(274, 379);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Borrar.TabIndex = 89;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(143, 379);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Modificar.TabIndex = 88;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // comboBox_IDProducto
            // 
            this.comboBox_IDProducto.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_IDProducto.FormattingEnabled = true;
            this.comboBox_IDProducto.Location = new System.Drawing.Point(12, 138);
            this.comboBox_IDProducto.Name = "comboBox_IDProducto";
            this.comboBox_IDProducto.Size = new System.Drawing.Size(300, 27);
            this.comboBox_IDProducto.TabIndex = 82;
            this.comboBox_IDProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDProducto_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(554, 361);
            this.dataGridView1.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 81;
            this.label8.Text = "Precio Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 80;
            this.label5.Text = "ID del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 79;
            this.label3.Text = "ID de Venta";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "Cantidad";
            // 
            // textBox_PrecioVenta
            // 
            this.textBox_PrecioVenta.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PrecioVenta.Location = new System.Drawing.Point(12, 190);
            this.textBox_PrecioVenta.Name = "textBox_PrecioVenta";
            this.textBox_PrecioVenta.Size = new System.Drawing.Size(300, 27);
            this.textBox_PrecioVenta.TabIndex = 83;
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cantidad.Location = new System.Drawing.Point(12, 242);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(300, 27);
            this.textBox_Cantidad.TabIndex = 84;
            // 
            // comboBox_IDVenta
            // 
            this.comboBox_IDVenta.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_IDVenta.FormattingEnabled = true;
            this.comboBox_IDVenta.Location = new System.Drawing.Point(12, 86);
            this.comboBox_IDVenta.Name = "comboBox_IDVenta";
            this.comboBox_IDVenta.Size = new System.Drawing.Size(300, 27);
            this.comboBox_IDVenta.TabIndex = 81;
            this.comboBox_IDVenta.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDVenta_SelectedIndexChanged);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.OliveDrab;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 379);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Agregar.TabIndex = 87;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 91;
            this.label6.Text = "SubTotal";
            // 
            // textBox_SubTotal
            // 
            this.textBox_SubTotal.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SubTotal.Location = new System.Drawing.Point(12, 294);
            this.textBox_SubTotal.Name = "textBox_SubTotal";
            this.textBox_SubTotal.Size = new System.Drawing.Size(300, 27);
            this.textBox_SubTotal.TabIndex = 85;
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(747, 379);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(125, 35);
            this.Btn_Volver.TabIndex = 90;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // FormDetallesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_SubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_IdDetalleVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.comboBox_IDProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_PrecioVenta);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.comboBox_IDVenta);
            this.Controls.Add(this.Btn_Agregar);
            this.Name = "FormDetallesVentas";
            this.Text = "FormDetallesVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IdDetalleVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.ComboBox comboBox_IDProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PrecioVenta;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.ComboBox comboBox_IDVenta;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SubTotal;
        private System.Windows.Forms.Button Btn_Volver;
    }
}