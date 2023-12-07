namespace WindowsFormsComponents
{
    partial class FormMain
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
            flatTitleBar1 = new CustomControl.FlatTitleBar();
            containerBox1 = new CustomControl.ContainerBox();
            containerBox2 = new CustomControl.ContainerBox();
            numericBox4 = new CustomControl.NumericBox();
            numericBox3 = new CustomControl.NumericBox();
            numericBox2 = new CustomControl.NumericBox();
            numericBox1 = new CustomControl.NumericBox();
            panel1.SuspendLayout();
            containerBox1.SuspendLayout();
            containerBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(containerBox1);
            panel1.Controls.Add(flatTitleBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 600);
            panel1.TabIndex = 0;
            // 
            // flatTitleBar1
            // 
            flatTitleBar1.BackColor = Color.FromArgb(50, 50, 50);
            flatTitleBar1.Dock = DockStyle.Top;
            flatTitleBar1.Location = new Point(0, 0);
            flatTitleBar1.Margin = new Padding(0);
            flatTitleBar1.Name = "flatTitleBar1";
            flatTitleBar1.Size = new Size(798, 40);
            flatTitleBar1.TabIndex = 0;
            // 
            // containerBox1
            // 
            containerBox1.BackColor = Color.White;
            containerBox1.BorderStyle = BorderStyle.FixedSingle;
            containerBox1.Controls.Add(containerBox2);
            containerBox1.Controls.Add(numericBox2);
            containerBox1.Controls.Add(numericBox1);
            containerBox1.Location = new Point(24, 66);
            containerBox1.MaximumSize = new Size(250, 250);
            containerBox1.MinimumSize = new Size(128, 26);
            containerBox1.Name = "containerBox1";
            containerBox1.Size = new Size(250, 250);
            containerBox1.TabIndex = 2;
            // 
            // containerBox2
            // 
            containerBox2.BackColor = Color.White;
            containerBox2.BorderStyle = BorderStyle.FixedSingle;
            containerBox2.Controls.Add(numericBox4);
            containerBox2.Controls.Add(numericBox3);
            containerBox2.Location = new Point(17, 130);
            containerBox2.MaximumSize = new Size(250, 250);
            containerBox2.MinimumSize = new Size(128, 26);
            containerBox2.Name = "containerBox2";
            containerBox2.Size = new Size(215, 99);
            containerBox2.TabIndex = 4;
            // 
            // numericBox4
            // 
            numericBox4.Location = new Point(12, 65);
            numericBox4.Name = "numericBox4";
            numericBox4.Size = new Size(120, 23);
            numericBox4.TabIndex = 2;
            // 
            // numericBox3
            // 
            numericBox3.Location = new Point(12, 36);
            numericBox3.Name = "numericBox3";
            numericBox3.Size = new Size(120, 23);
            numericBox3.TabIndex = 2;
            // 
            // numericBox2
            // 
            numericBox2.Location = new Point(17, 84);
            numericBox2.Name = "numericBox2";
            numericBox2.Size = new Size(120, 23);
            numericBox2.TabIndex = 3;
            // 
            // numericBox1
            // 
            numericBox1.Location = new Point(17, 44);
            numericBox1.Name = "numericBox1";
            numericBox1.Size = new Size(120, 23);
            numericBox1.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            panel1.ResumeLayout(false);
            containerBox1.ResumeLayout(false);
            containerBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomControl.ContainerBox containerBox1;
        private CustomControl.ContainerBox containerBox2;
        private CustomControl.NumericBox numericBox4;
        private CustomControl.NumericBox numericBox3;
        private CustomControl.NumericBox numericBox2;
        private CustomControl.NumericBox numericBox1;
        private CustomControl.FlatTitleBar flatTitleBar1;
    }
}