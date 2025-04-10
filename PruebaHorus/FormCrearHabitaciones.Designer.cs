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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            labelAñadir = new Label();
            label4 = new Label();
            textAñadirTipo = new TextBox();
            labelNombreTipo = new Label();
            buttonCerrarTipo = new Button();
            buttonGuardarTipo = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 73);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Num Habitacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 113);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Piso";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 23);
            textBox3.TabIndex = 9;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(132, 143);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 151);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 11;
            label3.Text = "Tipo Habitacion";
            // 
            // button1
            // 
            button1.Location = new Point(132, 185);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 12;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelAñadir
            // 
            labelAñadir.AutoSize = true;
            labelAñadir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAñadir.Location = new Point(259, 143);
            labelAñadir.Name = "labelAñadir";
            labelAñadir.Size = new Size(61, 21);
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
            label4.Location = new Point(72, 9);
            label4.Name = "label4";
            label4.Size = new Size(232, 35);
            label4.TabIndex = 14;
            label4.Text = "Crear Habitacion";
            // 
            // textAñadirTipo
            // 
            textAñadirTipo.Location = new Point(259, 186);
            textAñadirTipo.Name = "textAñadirTipo";
            textAñadirTipo.Size = new Size(100, 23);
            textAñadirTipo.TabIndex = 15;
            textAñadirTipo.Visible = false;
            // 
            // labelNombreTipo
            // 
            labelNombreTipo.AutoSize = true;
            labelNombreTipo.Location = new Point(259, 168);
            labelNombreTipo.Name = "labelNombreTipo";
            labelNombreTipo.Size = new Size(78, 15);
            labelNombreTipo.TabIndex = 16;
            labelNombreTipo.Text = "Nombre Tipo";
            labelNombreTipo.Visible = false;
            // 
            // buttonCerrarTipo
            // 
            buttonCerrarTipo.Location = new Point(274, 215);
            buttonCerrarTipo.Name = "buttonCerrarTipo";
            buttonCerrarTipo.Size = new Size(76, 23);
            buttonCerrarTipo.TabIndex = 17;
            buttonCerrarTipo.Text = "Cerrar";
            buttonCerrarTipo.UseVisualStyleBackColor = true;
            buttonCerrarTipo.Visible = false;
            buttonCerrarTipo.Click += buttonCerrarTipo_Click;
            // 
            // buttonGuardarTipo
            // 
            buttonGuardarTipo.Location = new Point(274, 240);
            buttonGuardarTipo.Name = "buttonGuardarTipo";
            buttonGuardarTipo.Size = new Size(76, 23);
            buttonGuardarTipo.TabIndex = 18;
            buttonGuardarTipo.Text = "Guardar";
            buttonGuardarTipo.UseVisualStyleBackColor = true;
            buttonGuardarTipo.Visible = false;
            buttonGuardarTipo.Click += buttonGuardarTipo_Click;
            // 
            // FormCrearHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 277);
            Controls.Add(buttonGuardarTipo);
            Controls.Add(buttonCerrarTipo);
            Controls.Add(labelNombreTipo);
            Controls.Add(textAñadirTipo);
            Controls.Add(label4);
            Controls.Add(labelAñadir);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBoxTipo);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormCrearHabitaciones";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private ComboBox comboBoxTipo;
        private Label label3;
        private Button button1;
        private Label labelAñadir;
        private Label label4;
        private TextBox textAñadirTipo;
        private Label labelNombreTipo;
        private Button buttonCerrarTipo;
        private Button buttonGuardarTipo;
    }
}