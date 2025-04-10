namespace PruebaHorus
{
    partial class FormCrearHabitaciones
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
            textBoxNumHab = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNumPiso = new TextBox();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            buttonCrearHab = new Button();
            labelAñadir = new Label();
            label4 = new Label();
            textAñadirTipo = new TextBox();
            labelNombreTipo = new Label();
            buttonCerrarTipo = new Button();
            buttonGuardarTipo = new Button();
            SuspendLayout();
            // 
            // textBoxNumHab
            // 
            textBoxNumHab.Location = new Point(151, 82);
            textBoxNumHab.Margin = new Padding(3, 4, 3, 4);
            textBoxNumHab.Name = "textBoxNumHab";
            textBoxNumHab.Size = new Size(234, 26);
            textBoxNumHab.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 92);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 4;
            label1.Text = "Num Habitacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 143);
            label2.Name = "label2";
            label2.Size = new Size(34, 19);
            label2.TabIndex = 5;
            label2.Text = "Piso";
            // 
            // textBoxNumPiso
            // 
            textBoxNumPiso.Location = new Point(151, 133);
            textBoxNumPiso.Margin = new Padding(3, 4, 3, 4);
            textBoxNumPiso.Name = "textBoxNumPiso";
            textBoxNumPiso.Size = new Size(234, 26);
            textBoxNumPiso.TabIndex = 9;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(151, 181);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 27);
            comboBoxTipo.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 191);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 11;
            label3.Text = "Tipo Habitacion";
            // 
            // buttonCrearHab
            // 
            buttonCrearHab.Location = new Point(151, 234);
            buttonCrearHab.Margin = new Padding(3, 4, 3, 4);
            buttonCrearHab.Name = "buttonCrearHab";
            buttonCrearHab.Size = new Size(86, 30);
            buttonCrearHab.TabIndex = 12;
            buttonCrearHab.Text = "Crear";
            buttonCrearHab.UseVisualStyleBackColor = true;
            buttonCrearHab.Click += buttonCrearHab_Click;
            // 
            // labelAñadir
            // 
            labelAñadir.AutoSize = true;
            labelAñadir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAñadir.Location = new Point(296, 181);
            labelAñadir.Name = "labelAñadir";
            labelAñadir.Size = new Size(72, 25);
            labelAñadir.TabIndex = 13;
            labelAñadir.Text = "Añadir";
            labelAñadir.DoubleClick += labelAñadir_DoubleClick;
            labelAñadir.MouseEnter += labelAñadir_MouseEnter;
            labelAñadir.MouseLeave += labelAñadir_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 11);
            label4.Name = "label4";
            label4.Size = new Size(268, 39);
            label4.TabIndex = 14;
            label4.Text = "Crear Habitacion";
            // 
            // textAñadirTipo
            // 
            textAñadirTipo.Location = new Point(296, 236);
            textAñadirTipo.Margin = new Padding(3, 4, 3, 4);
            textAñadirTipo.Name = "textAñadirTipo";
            textAñadirTipo.Size = new Size(114, 26);
            textAñadirTipo.TabIndex = 15;
            textAñadirTipo.Visible = false;
            // 
            // labelNombreTipo
            // 
            labelNombreTipo.AutoSize = true;
            labelNombreTipo.Location = new Point(296, 213);
            labelNombreTipo.Name = "labelNombreTipo";
            labelNombreTipo.Size = new Size(89, 19);
            labelNombreTipo.TabIndex = 16;
            labelNombreTipo.Text = "Nombre Tipo";
            labelNombreTipo.Visible = false;
            // 
            // buttonCerrarTipo
            // 
            buttonCerrarTipo.Location = new Point(313, 272);
            buttonCerrarTipo.Margin = new Padding(3, 4, 3, 4);
            buttonCerrarTipo.Name = "buttonCerrarTipo";
            buttonCerrarTipo.Size = new Size(87, 29);
            buttonCerrarTipo.TabIndex = 17;
            buttonCerrarTipo.Text = "Cerrar";
            buttonCerrarTipo.UseVisualStyleBackColor = true;
            buttonCerrarTipo.Visible = false;
            buttonCerrarTipo.Click += buttonCerrarTipo_Click;
            // 
            // buttonGuardarTipo
            // 
            buttonGuardarTipo.Location = new Point(313, 304);
            buttonGuardarTipo.Margin = new Padding(3, 4, 3, 4);
            buttonGuardarTipo.Name = "buttonGuardarTipo";
            buttonGuardarTipo.Size = new Size(87, 29);
            buttonGuardarTipo.TabIndex = 18;
            buttonGuardarTipo.Text = "Guardar";
            buttonGuardarTipo.UseVisualStyleBackColor = true;
            buttonGuardarTipo.Visible = false;
            buttonGuardarTipo.Click += buttonGuardarTipo_Click;
            // 
            // FormCrearHabitaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 351);
            Controls.Add(buttonGuardarTipo);
            Controls.Add(buttonCerrarTipo);
            Controls.Add(labelNombreTipo);
            Controls.Add(textAñadirTipo);
            Controls.Add(label4);
            Controls.Add(labelAñadir);
            Controls.Add(buttonCrearHab);
            Controls.Add(label3);
            Controls.Add(comboBoxTipo);
            Controls.Add(textBoxNumPiso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNumHab);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCrearHabitaciones";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumHab;
        private Label label1;
        private Label label2;
        private TextBox textBoxNumPiso;
        private ComboBox comboBoxTipo;
        private Label label3;
        private Button buttonCrearHab;
        private Label labelAñadir;
        private Label label4;
        private TextBox textAñadirTipo;
        private Label labelNombreTipo;
        private Button buttonCerrarTipo;
        private Button buttonGuardarTipo;
    }
}