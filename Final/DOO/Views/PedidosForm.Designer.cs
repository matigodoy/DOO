namespace DOO.Views
{
    partial class Pedidos
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
            linkLabel1 = new LinkLabel();
            groupBox2 = new GroupBox();
            btnSelectClient = new Button();
            cbCliente = new ComboBox();
            btnInsertProducto = new Button();
            dgvProductos = new DataGridView();
            Eliminar = new DataGridViewImageColumn();
            cbProducto = new ComboBox();
            Productos = new GroupBox();
            btnSave = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            Productos.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "< Regresar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSelectClient);
            groupBox2.Controls.Add(cbCliente);
            groupBox2.Location = new Point(12, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 92);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cliente";
            // 
            // btnSelectClient
            // 
            btnSelectClient.Location = new Point(271, 36);
            btnSelectClient.Margin = new Padding(3, 2, 3, 2);
            btnSelectClient.Name = "btnSelectClient";
            btnSelectClient.Size = new Size(131, 26);
            btnSelectClient.TabIndex = 27;
            btnSelectClient.Text = "Seleccionar";
            btnSelectClient.UseVisualStyleBackColor = true;
            btnSelectClient.Click += btnSelectClient_Click;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(15, 36);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(250, 23);
            cbCliente.TabIndex = 6;
            cbCliente.Text = "Seleccione un cliente";
            // 
            // btnInsertProducto
            // 
            btnInsertProducto.Location = new Point(271, 33);
            btnInsertProducto.Margin = new Padding(3, 2, 3, 2);
            btnInsertProducto.Name = "btnInsertProducto";
            btnInsertProducto.Size = new Size(131, 26);
            btnInsertProducto.TabIndex = 5;
            btnInsertProducto.Text = "Agregar producto";
            btnInsertProducto.UseVisualStyleBackColor = true;
            btnInsertProducto.Click += btnInsertProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Eliminar });
            dgvProductos.Location = new Point(15, 76);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(387, 312);
            dgvProductos.TabIndex = 26;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.delete_custom__1_;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // cbProducto
            // 
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(15, 35);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(250, 23);
            cbProducto.TabIndex = 7;
            cbProducto.Text = "Seleccione un producto";
            // 
            // Productos
            // 
            Productos.Controls.Add(cbProducto);
            Productos.Controls.Add(btnInsertProducto);
            Productos.Controls.Add(dgvProductos);
            Productos.Location = new Point(12, 149);
            Productos.Name = "Productos";
            Productos.Size = new Size(420, 404);
            Productos.TabIndex = 29;
            Productos.TabStop = false;
            Productos.Text = "Productos";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(283, 571);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 26);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 619);
            Controls.Add(btnSave);
            Controls.Add(Productos);
            Controls.Add(groupBox2);
            Controls.Add(linkLabel1);
            Name = "Pedidos";
            Text = "Pedidos";
            Load += Pedidos_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            Productos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private GroupBox groupBox2;
        private Button btnInsertProducto;
        private DataGridView dgvProductos;
        private ComboBox cbCliente;
        private DataGridViewImageColumn Eliminar;
        private ComboBox cbProducto;
        private GroupBox Productos;
        private Button btnSave;
        private Button btnSelectClient;
    }
}