namespace PruebaHorus
{
    partial class Form1
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
            comboBoxHab = new ComboBox();
            label1 = new Label();
            TextModhab = new TextBox();
            TextModPiso = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxHab
            // 
            comboBoxHab.FormattingEnabled = true;
            comboBoxHab.Location = new Point(12, 326);
            comboBoxHab.Name = "comboBoxHab";
            comboBoxHab.Size = new Size(121, 23);
            comboBoxHab.TabIndex = 0;
            comboBoxHab.Text = "Elige la Habitacion";
            comboBoxHab.SelectedIndexChanged += comboBoxHab_SelectedIndexChanged;
            comboBoxHab.SelectionChangeCommitted += HabSelecionada;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 293);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 1;
            label1.Text = "Modificar";
            // 
            // TextModhab
            // 
            TextModhab.Location = new Point(152, 326);
            TextModhab.Name = "TextModhab";
            TextModhab.Size = new Size(100, 23);
            TextModhab.TabIndex = 2;
            TextModhab.TextChanged += TextModhab_TextChanged;
            // 
            // TextModPiso
            // 
            TextModPiso.Location = new Point(268, 326);
            TextModPiso.Name = "TextModPiso";
            TextModPiso.Size = new Size(100, 23);
            TextModPiso.TabIndex = 3;
            TextModPiso.TextChanged += TextModPiso_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 293);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 6;
            label3.Text = "Piso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(152, 293);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 7;
            label4.Text = "#Hab";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 361);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TextModPiso);
            Controls.Add(TextModhab);
            Controls.Add(label1);
            Controls.Add(comboBoxHab);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxHab;
        private Label label1;
        private TextBox TextModhab;
        private TextBox TextModPiso;
        private Label label3;
        private Label label4;
    }
}
