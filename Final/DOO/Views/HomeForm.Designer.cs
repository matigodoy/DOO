namespace DOO.Views
{
    partial class HomeForm
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
            label1 = new Label();
            label2 = new Label();
            btnProductos = new Button();
            groupBox1 = new GroupBox();
            btnClientes = new Button();
            btnPedidos = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 1;
            label2.Text = "¿Que harás hoy?";
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(18, 43);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(191, 134);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += this.button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPedidos);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnProductos);
            groupBox1.Location = new Point(12, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 204);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menú principal";
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(246, 43);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(191, 134);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += this.button2_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(483, 43);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(191, 134);
            btnPedidos.TabIndex = 4;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += this.button3_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 360);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnProductos;
        private GroupBox groupBox1;
        private Button btnPedidos;
        private Button btnClientes;
    }
}