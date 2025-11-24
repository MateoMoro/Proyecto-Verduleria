namespace Proyecto_Final.Proyecto.Menu.Ventas
{
    partial class FormVentas
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
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MontoTotal = new System.Windows.Forms.TextBox();
            this.textBox_NumeroFactura = new System.Windows.Forms.TextBox();
            this.textBox_MontoCambio = new System.Windows.Forms.TextBox();
            this.textBox_MontoPago = new System.Windows.Forms.TextBox();
            this.comboBox_IDUsuario = new System.Windows.Forms.ComboBox();
            this.comboBox_IDCliente = new System.Windows.Forms.ComboBox();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.OliveDrab;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(12, 379);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Agregar.TabIndex = 27;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(554, 361);
            this.dataGridView1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "Monto Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Monto Cambio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Monto Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID de Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Numero de Factura";
            // 
            // textBox_MontoTotal
            // 
            this.textBox_MontoTotal.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MontoTotal.Location = new System.Drawing.Point(12, 294);
            this.textBox_MontoTotal.Name = "textBox_MontoTotal";
            this.textBox_MontoTotal.Size = new System.Drawing.Size(300, 27);
            this.textBox_MontoTotal.TabIndex = 25;
            // 
            // textBox_NumeroFactura
            // 
            this.textBox_NumeroFactura.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumeroFactura.Location = new System.Drawing.Point(12, 34);
            this.textBox_NumeroFactura.Name = "textBox_NumeroFactura";
            this.textBox_NumeroFactura.Size = new System.Drawing.Size(300, 27);
            this.textBox_NumeroFactura.TabIndex = 20;
            // 
            // textBox_MontoCambio
            // 
            this.textBox_MontoCambio.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MontoCambio.Location = new System.Drawing.Point(12, 242);
            this.textBox_MontoCambio.Name = "textBox_MontoCambio";
            this.textBox_MontoCambio.Size = new System.Drawing.Size(300, 27);
            this.textBox_MontoCambio.TabIndex = 24;
            // 
            // textBox_MontoPago
            // 
            this.textBox_MontoPago.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MontoPago.Location = new System.Drawing.Point(12, 190);
            this.textBox_MontoPago.Name = "textBox_MontoPago";
            this.textBox_MontoPago.Size = new System.Drawing.Size(300, 27);
            this.textBox_MontoPago.TabIndex = 23;
            // 
            // comboBox_IDUsuario
            // 
            this.comboBox_IDUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_IDUsuario.FormattingEnabled = true;
            this.comboBox_IDUsuario.Location = new System.Drawing.Point(12, 86);
            this.comboBox_IDUsuario.Name = "comboBox_IDUsuario";
            this.comboBox_IDUsuario.Size = new System.Drawing.Size(300, 27);
            this.comboBox_IDUsuario.TabIndex = 21;
            this.comboBox_IDUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDUsuario_SelectedIndexChanged);
            // 
            // comboBox_IDCliente
            // 
            this.comboBox_IDCliente.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_IDCliente.FormattingEnabled = true;
            this.comboBox_IDCliente.Location = new System.Drawing.Point(12, 138);
            this.comboBox_IDCliente.Name = "comboBox_IDCliente";
            this.comboBox_IDCliente.Size = new System.Drawing.Size(300, 27);
            this.comboBox_IDCliente.TabIndex = 22;
            this.comboBox_IDCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox_IDCliente_SelectedIndexChanged);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Location = new System.Drawing.Point(273, 379);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(125, 35);
            this.Btn_Borrar.TabIndex = 29;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.Orange;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(143, 379);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(124, 35);
            this.Btn_Modificar.TabIndex = 28;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha";
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.DimGray;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Volver.Location = new System.Drawing.Point(747, 379);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(125, 35);
            this.Btn_Volver.TabIndex = 30;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.comboBox_IDCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MontoTotal);
            this.Controls.Add(this.textBox_NumeroFactura);
            this.Controls.Add(this.textBox_MontoCambio);
            this.Controls.Add(this.textBox_MontoPago);
            this.Controls.Add(this.comboBox_IDUsuario);
            this.Controls.Add(this.Btn_Agregar);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MontoTotal;
        private System.Windows.Forms.TextBox textBox_NumeroFactura;
        private System.Windows.Forms.TextBox textBox_MontoCambio;
        private System.Windows.Forms.TextBox textBox_MontoPago;
        private System.Windows.Forms.ComboBox comboBox_IDUsuario;
        private System.Windows.Forms.ComboBox comboBox_IDCliente;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Volver;
    }
}