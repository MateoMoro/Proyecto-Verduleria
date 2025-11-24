namespace Proyecto_Final.Proyecto.Menu.Compras
{
    partial class FormCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.comboBox_IDProveedor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MontoTotal = new System.Windows.Forms.TextBox();
            this.textBox_NumeroFactura = new System.Windows.Forms.TextBox();
            this.comboBox_IDUsuario = new System.Windows.Forms.ComboBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(278, 332);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Borrar.TabIndex = 47;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(147, 332);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Modificar.TabIndex = 46;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // comboBox_IDProveedor
            // 
            this.comboBox_IDProveedor.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_IDProveedor.FormattingEnabled = true;
            this.comboBox_IDProveedor.Location = new System.Drawing.Point(12, 138);
            this.comboBox_IDProveedor.Name = "comboBox_IDProveedor";
            this.comboBox_IDProveedor.Size = new System.Drawing.Size(300, 27);
            this.comboBox_IDProveedor.TabIndex = 42;
            this.comboBox_IDProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDProveedor_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(554, 314);
            this.dataGridView1.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Monto Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "ID del Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Numero de Factura";
            // 
            // textBox_MontoTotal
            // 
            this.textBox_MontoTotal.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MontoTotal.Location = new System.Drawing.Point(12, 190);
            this.textBox_MontoTotal.Name = "textBox_MontoTotal";
            this.textBox_MontoTotal.Size = new System.Drawing.Size(300, 27);
            this.textBox_MontoTotal.TabIndex = 43;
            // 
            // textBox_NumeroFactura
            // 
            this.textBox_NumeroFactura.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumeroFactura.Location = new System.Drawing.Point(12, 34);
            this.textBox_NumeroFactura.Name = "textBox_NumeroFactura";
            this.textBox_NumeroFactura.Size = new System.Drawing.Size(300, 27);
            this.textBox_NumeroFactura.TabIndex = 40;
            // 
            // comboBox_IDUsuario
            // 
            this.comboBox_IDUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_IDUsuario.FormattingEnabled = true;
            this.comboBox_IDUsuario.Location = new System.Drawing.Point(12, 86);
            this.comboBox_IDUsuario.Name = "comboBox_IDUsuario";
            this.comboBox_IDUsuario.Size = new System.Drawing.Size(300, 27);
            this.comboBox_IDUsuario.TabIndex = 41;
            this.comboBox_IDUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDUsuario_SelectedIndexChanged);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.OliveDrab;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(16, 332);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Agregar.TabIndex = 45;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(747, 332);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(125, 35);
            this.Btn_Volver.TabIndex = 48;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.comboBox_IDProveedor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MontoTotal);
            this.Controls.Add(this.textBox_NumeroFactura);
            this.Controls.Add(this.comboBox_IDUsuario);
            this.Controls.Add(this.Btn_Agregar);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.ComboBox comboBox_IDProveedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MontoTotal;
        private System.Windows.Forms.TextBox textBox_NumeroFactura;
        private System.Windows.Forms.ComboBox comboBox_IDUsuario;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Volver;
    }
}