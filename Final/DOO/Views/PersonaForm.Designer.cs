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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetPersona
            // 
            btnGetPersona.Location = new Point(557, 115);
            btnGetPersona.Name = "btnGetPersona";
            btnGetPersona.Size = new Size(99, 23);
            btnGetPersona.TabIndex = 0;
            btnGetPersona.Text = "Buscar Persona";
            btnGetPersona.UseVisualStyleBackColor = true;
            btnGetPersona.Click += btnGetPersona_Click;
            // 
            // btnInsertPersona
            // 
            btnInsertPersona.Location = new Point(263, 115);
            btnInsertPersona.Name = "btnInsertPersona";
            btnInsertPersona.Size = new Size(99, 23);
            btnInsertPersona.TabIndex = 1;
            btnInsertPersona.Text = "Crear Persona";
            btnInsertPersona.UseVisualStyleBackColor = true;
            btnInsertPersona.Click += btnInsertPersona_Click;
            // 
            // textBuscarPersona
            // 
            textBuscarPersona.Location = new Point(463, 163);
            textBuscarPersona.Name = "textBuscarPersona";
            textBuscarPersona.Size = new Size(262, 23);
            textBuscarPersona.TabIndex = 2;
            // 
            // textNombrePersona
            // 
            textNombrePersona.Location = new Point(40, 14);
            textNombrePersona.Name = "textNombrePersona";
            textNombrePersona.Size = new Size(169, 23);
            textNombrePersona.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 4;
            // 
            // textApellidoPersona
            // 
            textApellidoPersona.Location = new Point(40, 69);
            textApellidoPersona.Name = "textApellidoPersona";
            textApellidoPersona.Size = new Size(169, 23);
            textApellidoPersona.TabIndex = 5;
            // 
            // textDocumentoPersona
            // 
            textDocumentoPersona.Location = new Point(40, 115);
            textDocumentoPersona.Name = "textDocumentoPersona";
            textDocumentoPersona.Size = new Size(169, 23);
            textDocumentoPersona.TabIndex = 6;
            // 
            // textTipoDocumentoPersona
            // 
            textTipoDocumentoPersona.Location = new Point(40, 163);
            textTipoDocumentoPersona.Name = "textTipoDocumentoPersona";
            textTipoDocumentoPersona.Size = new Size(169, 23);
            textTipoDocumentoPersona.TabIndex = 7;
            // 
            // textTelefonoPersona
            // 
            textTelefonoPersona.Location = new Point(40, 214);
            textTelefonoPersona.Name = "textTelefonoPersona";
            textTelefonoPersona.Size = new Size(169, 23);
            textTelefonoPersona.TabIndex = 8;
            // 
            // textDireccionPersona
            // 
            textDireccionPersona.Location = new Point(40, 259);
            textDireccionPersona.Name = "textDireccionPersona";
            textDireccionPersona.Size = new Size(169, 23);
            textDireccionPersona.TabIndex = 9;
            // 
            // PersonaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}