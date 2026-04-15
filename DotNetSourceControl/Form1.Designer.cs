namespace DotNetSourceControl
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
            btnGreeting = new Button();
            textBox1 = new TextBox();
            lblLabal1 = new Label();
            lblSubtotal = new Label();
            txtSubtotal = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(232, 178);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(238, 103);
            btnGreeting.TabIndex = 0;
            btnGreeting.Text = "Clic This Buttun";
            btnGreeting.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblLabal1
            // 
            lblLabal1.AutoSize = true;
            lblLabal1.Location = new Point(59, 108);
            lblLabal1.Name = "lblLabal1";
            lblLabal1.Size = new Size(0, 41);
            lblLabal1.TabIndex = 2;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(107, 28);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(129, 41);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(242, 25);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(250, 47);
            txtSubtotal.TabIndex = 4;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 102);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 5;
            label1.Text = "tax Rate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(lblLabal1);
            Controls.Add(textBox1);
            Controls.Add(btnGreeting);
            Name = "Form1";
            Text = "Source Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGreeting;
        private TextBox textBox1;
        private Label lblLabal1;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Label label1;
    }
}
