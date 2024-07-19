namespace DOO
{
    partial class Home
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
            txtProductoId = new TextBox();
            btnGetProducto = new Button();
            txtNombre = new TextBox();
            btnInsertProducto = new Button();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dataGridView1.Location = new Point(34, 368);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(751, 136);
            dataGridView1.TabIndex = 0;
            // 
            // txtProductoId
            // 
            txtProductoId.Location = new Point(122, 118);
            txtProductoId.Margin = new Padding(3, 2, 3, 2);
            txtProductoId.Name = "txtProductoId";
            txtProductoId.Size = new Size(359, 23);
            txtProductoId.TabIndex = 1;
            // 
            // btnGetProducto
            // 
            btnGetProducto.Location = new Point(528, 115);
            btnGetProducto.Margin = new Padding(3, 2, 3, 2);
            btnGetProducto.Name = "btnGetProducto";
            btnGetProducto.Size = new Size(248, 26);
            btnGetProducto.TabIndex = 2;
            btnGetProducto.Text = "Obtener";
            btnGetProducto.UseVisualStyleBackColor = true;
            btnGetProducto.Click += btnGetProducto_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(88, 230);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(432, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnInsertProducto
            // 
            btnInsertProducto.Location = new Point(538, 230);
            btnInsertProducto.Margin = new Padding(3, 2, 3, 2);
            btnInsertProducto.Name = "btnInsertProducto";
            btnInsertProducto.Size = new Size(82, 22);
            btnInsertProducto.TabIndex = 4;
            btnInsertProducto.Text = "Crear";
            btnInsertProducto.UseVisualStyleBackColor = true;
            btnInsertProducto.Click += btnInsertProducto_Click;
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 560);
            Controls.Add(btnInsertProducto);
            Controls.Add(txtNombre);
            Controls.Add(btnGetProducto);
            Controls.Add(txtProductoId);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
