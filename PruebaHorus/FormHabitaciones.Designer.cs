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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cONFIGURACIONToolStripMenuItem = new ToolStripMenuItem();
            cREARHABITACIONToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 31);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, cONFIGURACIONToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(656, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            cONFIGURACIONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cREARHABITACIONToolStripMenuItem });
            cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            cONFIGURACIONToolStripMenuItem.Size = new Size(114, 20);
            cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACION";
            // 
            // cREARHABITACIONToolStripMenuItem
            // 
            cREARHABITACIONToolStripMenuItem.Name = "cREARHABITACIONToolStripMenuItem";
            cREARHABITACIONToolStripMenuItem.Size = new Size(183, 22);
            cREARHABITACIONToolStripMenuItem.Text = "CREAR HABITACION";
            cREARHABITACIONToolStripMenuItem.Click += cREARHABITACIONToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 361);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
        private ToolStripMenuItem cREARHABITACIONToolStripMenuItem;
    }
}
