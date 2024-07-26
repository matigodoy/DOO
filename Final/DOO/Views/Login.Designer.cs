namespace DOO.Views
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtPwd = new TextBox();
            txtUser = new TextBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPwd);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(97, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 81);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(55, 97);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.PlaceholderText = "*****************";
            txtPwd.Size = new Size(208, 23);
            txtPwd.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(55, 55);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Ej: admin";
            txtUser.Size = new Size(208, 23);
            txtUser.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(55, 142);
            button1.Name = "button1";
            button1.Size = new Size(208, 23);
            button1.TabIndex = 3;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 343);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Autenticación";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private ImageList imageList1;
        private Label label2;
        private Label label1;
        private TextBox txtPwd;
        private TextBox txtUser;
    }
}