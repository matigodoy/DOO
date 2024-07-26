namespace DOO
{
    partial class ProductosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            txtProductoId = new TextBox();
            btnGetProducto = new Button();
            txtNombre = new TextBox();
            btnInsertProducto = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dataGridView1.Location = new Point(469, 57);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.pencil_custom;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Width = 97;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.delete_custom__1_;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // txtProductoId
            // 
            txtProductoId.Location = new Point(15, 33);
            txtProductoId.Margin = new Padding(3, 2, 3, 2);
            txtProductoId.Name = "txtProductoId";
            txtProductoId.PlaceholderText = "Nombre del producto";
            txtProductoId.Size = new Size(261, 23);
            txtProductoId.TabIndex = 1;
            // 
            // btnGetProducto
            // 
            btnGetProducto.Location = new Point(282, 33);
            btnGetProducto.Margin = new Padding(3, 2, 3, 2);
            btnGetProducto.Name = "btnGetProducto";
            btnGetProducto.Size = new Size(120, 26);
            btnGetProducto.TabIndex = 2;
            btnGetProducto.Text = "Buscar";
            btnGetProducto.UseVisualStyleBackColor = true;
            btnGetProducto.Click += btnGetProducto_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 34);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre. ej: \"Galletitas\"";
            txtNombre.Size = new Size(387, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnInsertProducto
            // 
            btnInsertProducto.Location = new Point(320, 125);
            btnInsertProducto.Margin = new Padding(3, 2, 3, 2);
            btnInsertProducto.Name = "btnInsertProducto";
            btnInsertProducto.Size = new Size(82, 22);
            btnInsertProducto.TabIndex = 5;
            btnInsertProducto.Text = "Guardar";
            btnInsertProducto.UseVisualStyleBackColor = true;
            btnInsertProducto.Click += btnInsertProducto_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "< Regresar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProductoId);
            groupBox1.Controls.Add(btnGetProducto);
            groupBox1.Location = new Point(34, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 80);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda por nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(btnInsertProducto);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Location = new Point(34, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 162);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formulario de creación/edición";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(15, 80);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio. ej: 400";
            txtPrecio.Size = new Size(387, 23);
            txtPrecio.TabIndex = 4;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 325);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductosForm";
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtProductoId;
        private Button btnGetProducto;
        private TextBox txtNombre;
        private Button btnInsertProducto;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPrecio;
    }
}
