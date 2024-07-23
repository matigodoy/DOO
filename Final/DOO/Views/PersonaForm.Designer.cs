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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetPersona
            // 
            btnGetPersona.Location = new Point(599, 115);
            btnGetPersona.Name = "btnGetPersona";
            btnGetPersona.Size = new Size(99, 23);
            btnGetPersona.TabIndex = 0;
            btnGetPersona.Text = "Buscar Persona";
            btnGetPersona.UseVisualStyleBackColor = true;
            btnGetPersona.Click += btnGetPersona_Click;
            // 
            // btnInsertPersona
            // 
            btnInsertPersona.Location = new Point(319, 160);
            btnInsertPersona.Name = "btnInsertPersona";
            btnInsertPersona.Size = new Size(99, 23);
            btnInsertPersona.TabIndex = 1;
            btnInsertPersona.Text = "Crear Persona";
            btnInsertPersona.UseVisualStyleBackColor = true;
            btnInsertPersona.Click += btnInsertPersona_Click;
            // 
            // textBuscarPersona
            // 
            textBuscarPersona.Location = new Point(515, 160);
            textBuscarPersona.Name = "textBuscarPersona";
            textBuscarPersona.Size = new Size(262, 23);
            textBuscarPersona.TabIndex = 2;
            // 
            // textNombrePersona
            // 
            textNombrePersona.Location = new Point(33, 27);
            textNombrePersona.Name = "textNombrePersona";
            textNombrePersona.Size = new Size(169, 23);
            textNombrePersona.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(802, 152);
            dataGridView1.TabIndex = 4;
            // 
            // textApellidoPersona
            // 
            textApellidoPersona.Location = new Point(33, 71);
            textApellidoPersona.Name = "textApellidoPersona";
            textApellidoPersona.Size = new Size(169, 23);
            textApellidoPersona.TabIndex = 5;
            // 
            // textDocumentoPersona
            // 
            textDocumentoPersona.Location = new Point(33, 160);
            textDocumentoPersona.Name = "textDocumentoPersona";
            textDocumentoPersona.Size = new Size(169, 23);
            textDocumentoPersona.TabIndex = 6;
            // 
            // textTipoDocumentoPersona
            // 
            textTipoDocumentoPersona.Location = new Point(33, 116);
            textTipoDocumentoPersona.Name = "textTipoDocumentoPersona";
            textTipoDocumentoPersona.Size = new Size(169, 23);
            textTipoDocumentoPersona.TabIndex = 7;
            // 
            // textTelefonoPersona
            // 
            textTelefonoPersona.Location = new Point(33, 204);
            textTelefonoPersona.Name = "textTelefonoPersona";
            textTelefonoPersona.Size = new Size(169, 23);
            textTelefonoPersona.TabIndex = 8;
            // 
            // textDireccionPersona
            // 
            textDireccionPersona.Location = new Point(33, 248);
            textDireccionPersona.Name = "textDireccionPersona";
            textDireccionPersona.Size = new Size(169, 23);
            textDireccionPersona.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 230);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "Barrio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 274);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "Calle";
            // 
            // textCallePersona
            // 
            textCallePersona.Location = new Point(33, 292);
            textCallePersona.Name = "textCallePersona";
            textCallePersona.Size = new Size(169, 23);
            textCallePersona.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 186);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 97);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "Tipo Documento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 142);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 15;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 9);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 16;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 53);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 17;
            label7.Text = "Apellido";
            // 
            // textZonaPersona
            // 
            textZonaPersona.Location = new Point(249, 292);
            textZonaPersona.Name = "textZonaPersona";
            textZonaPersona.Size = new Size(169, 23);
            textZonaPersona.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 274);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 19;
            label8.Text = "Zona";
            // 
            // PersonaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 485);
            Controls.Add(label8);
            Controls.Add(textZonaPersona);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textCallePersona);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textDireccionPersona);
            Controls.Add(textTelefonoPersona);
            Controls.Add(textTipoDocumentoPersona);
            Controls.Add(textDocumentoPersona);
            Controls.Add(textApellidoPersona);
            Controls.Add(dataGridView1);
            Controls.Add(textNombrePersona);
            Controls.Add(textBuscarPersona);
            Controls.Add(btnInsertPersona);
            Controls.Add(btnGetPersona);
            Name = "PersonaForm";
            Text = "Persona";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}