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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 181);
            dataGridView1.TabIndex = 0;
            // 
            // txtProductoId
            // 
            txtProductoId.Location = new Point(139, 157);
            txtProductoId.Name = "txtProductoId";
            txtProductoId.Size = new Size(410, 27);
            txtProductoId.TabIndex = 1;
            // 
            // btnGetProducto
            // 
            btnGetProducto.Location = new Point(604, 153);
            btnGetProducto.Name = "btnGetProducto";
            btnGetProducto.Size = new Size(283, 35);
            btnGetProducto.TabIndex = 2;
            btnGetProducto.Text = "Obtener";
            btnGetProducto.UseVisualStyleBackColor = true;
            btnGetProducto.Click += btnGetProducto_Click_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 307);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(493, 27);
            txtNombre.TabIndex = 3;
            // 
            // btnInsertProducto
            // 
            btnInsertProducto.Location = new Point(615, 306);
            btnInsertProducto.Name = "btnInsertProducto";
            btnInsertProducto.Size = new Size(94, 29);
            btnInsertProducto.TabIndex = 4;
            btnInsertProducto.Text = "Crear";
            btnInsertProducto.UseVisualStyleBackColor = true;
            btnInsertProducto.Click += btnInsertProducto_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 747);
            Controls.Add(btnInsertProducto);
            Controls.Add(txtNombre);
            Controls.Add(btnGetProducto);
            Controls.Add(txtProductoId);
            Controls.Add(dataGridView1);
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
    }
}
