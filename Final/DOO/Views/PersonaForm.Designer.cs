namespace DOO.Views
{
    partial class PersonaForm
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
            btnGetPersona = new Button();
            btnInsertPersona = new Button();
            textBuscarPersona = new TextBox();
            textNombrePersona = new TextBox();
            dataGridView1 = new DataGridView();
            textApellidoPersona = new TextBox();
            textDocumentoPersona = new TextBox();
            textTipoDocumentoPersona = new TextBox();
            textTelefonoPersona = new TextBox();
            textDireccionPersona = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textCallePersona = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textZonaPersona = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetPersona
            // 
            btnGetPersona.Location = new Point(307, 48);
            btnGetPersona.Name = "btnGetPersona";
            btnGetPersona.Size = new Size(99, 23);
            btnGetPersona.TabIndex = 2;
            btnGetPersona.Text = "Buscar";
            btnGetPersona.UseVisualStyleBackColor = true;
            btnGetPersona.Click += btnGetPersona_Click;
            // 
            // btnInsertPersona
            // 
            btnInsertPersona.Location = new Point(265, 263);
            btnInsertPersona.Name = "btnInsertPersona";
            btnInsertPersona.Size = new Size(124, 32);
            btnInsertPersona.TabIndex = 10;
            btnInsertPersona.Text = "Guardar";
            btnInsertPersona.UseVisualStyleBackColor = true;
            btnInsertPersona.Click += btnInsertPersona_Click;
            // 
            // textBuscarPersona
            // 
            textBuscarPersona.Location = new Point(21, 49);
            textBuscarPersona.Name = "textBuscarPersona";
            textBuscarPersona.Size = new Size(262, 23);
            textBuscarPersona.TabIndex = 1;
            textBuscarPersona.TextChanged += textBuscarPersona_TextChanged;
            // 
            // textNombrePersona
            // 
            textNombrePersona.Location = new Point(21, 54);
            textNombrePersona.Name = "textNombrePersona";
            textNombrePersona.Size = new Size(169, 23);
            textNombrePersona.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(481, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(612, 447);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textApellidoPersona
            // 
            textApellidoPersona.Location = new Point(220, 54);
            textApellidoPersona.Name = "textApellidoPersona";
            textApellidoPersona.Size = new Size(169, 23);
            textApellidoPersona.TabIndex = 4;
            // 
            // textDocumentoPersona
            // 
            textDocumentoPersona.Location = new Point(220, 108);
            textDocumentoPersona.Name = "textDocumentoPersona";
            textDocumentoPersona.Size = new Size(169, 23);
            textDocumentoPersona.TabIndex = 6;
            // 
            // textTipoDocumentoPersona
            // 
            textTipoDocumentoPersona.Location = new Point(21, 109);
            textTipoDocumentoPersona.Name = "textTipoDocumentoPersona";
            textTipoDocumentoPersona.Size = new Size(169, 23);
            textTipoDocumentoPersona.TabIndex = 5;
            // 
            // textTelefonoPersona
            // 
            textTelefonoPersona.Location = new Point(21, 165);
            textTelefonoPersona.Name = "textTelefonoPersona";
            textTelefonoPersona.Size = new Size(169, 23);
            textTelefonoPersona.TabIndex = 7;
            // 
            // textDireccionPersona
            // 
            textDireccionPersona.Location = new Point(220, 165);
            textDireccionPersona.Name = "textDireccionPersona";
            textDireccionPersona.Size = new Size(169, 23);
            textDireccionPersona.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 147);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "Barrio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 206);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "Calle";
            // 
            // textCallePersona
            // 
            textCallePersona.Location = new Point(21, 224);
            textCallePersona.Name = "textCallePersona";
            textCallePersona.Size = new Size(169, 23);
            textCallePersona.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 147);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 90);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 90);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 15;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 36);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 16;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 36);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 17;
            label7.Text = "Apellido";
            // 
            // textZonaPersona
            // 
            textZonaPersona.Location = new Point(220, 224);
            textZonaPersona.Name = "textZonaPersona";
            textZonaPersona.Size = new Size(169, 23);
            textZonaPersona.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(220, 206);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 19;
            label8.Text = "Zona";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetPersona);
            groupBox1.Controls.Add(textBuscarPersona);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 109);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Búsqueda de personas";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnInsertPersona);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textNombrePersona);
            groupBox2.Controls.Add(textZonaPersona);
            groupBox2.Controls.Add(textApellidoPersona);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textDocumentoPersona);
            groupBox2.Controls.Add(textTipoDocumentoPersona);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textTelefonoPersona);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textDireccionPersona);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textCallePersona);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 139);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(463, 329);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Persona";
            // 
            // PersonaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 487);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "PersonaForm";
            Text = "Persona";
            Load += PersonaForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetPersona;
        private Button btnInsertPersona;
        private TextBox textBuscarPersona;
        private TextBox textNombrePersona;
        private DataGridView dataGridView1;
        private TextBox textApellidoPersona;
        private TextBox textDocumentoPersona;
        private TextBox textTipoDocumentoPersona;
        private TextBox textTelefonoPersona;
        private TextBox textDireccionPersona;
        private Label label1;
        private Label label2;
        private TextBox textCallePersona;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textZonaPersona;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}