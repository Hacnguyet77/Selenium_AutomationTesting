namespace Selenium_AutomationTesting
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
            bntGoogle = new Button();
            bntFacebook = new Button();
            bntSourceDemo = new Button();
            GK = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bntGoogle
            // 
            bntGoogle.Location = new Point(27, 196);
            bntGoogle.Name = "bntGoogle";
            bntGoogle.Size = new Size(140, 50);
            bntGoogle.TabIndex = 0;
            bntGoogle.Text = "Mở Google";
            bntGoogle.UseVisualStyleBackColor = true;
            bntGoogle.Click += bntGoogle_Click;
            // 
            // bntFacebook
            // 
            bntFacebook.Location = new Point(216, 196);
            bntFacebook.Name = "bntFacebook";
            bntFacebook.Size = new Size(140, 50);
            bntFacebook.TabIndex = 1;
            bntFacebook.Text = "Mở Facebook";
            bntFacebook.UseVisualStyleBackColor = true;
            bntFacebook.Click += bntFacebook_Click;
            // 
            // bntSourceDemo
            // 
            bntSourceDemo.Location = new Point(428, 196);
            bntSourceDemo.Name = "bntSourceDemo";
            bntSourceDemo.Size = new Size(140, 50);
            bntSourceDemo.TabIndex = 2;
            bntSourceDemo.Text = "Test Đăng nhập";
            bntSourceDemo.UseVisualStyleBackColor = true;
            bntSourceDemo.Click += bntSourceDemo_Click;
            // 
            // GK
            // 
            GK.Location = new Point(617, 196);
            GK.Name = "GK";
            GK.Size = new Size(140, 50);
            GK.TabIndex = 3;
            GK.Text = "Test web bán hàng";
            GK.UseVisualStyleBackColor = true;
            GK.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 40);
            label1.Name = "label1";
            label1.Size = new Size(217, 54);
            label1.TabIndex = 4;
            label1.Text = "KIỂM THỬ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 347);
            Controls.Add(label1);
            Controls.Add(GK);
            Controls.Add(bntSourceDemo);
            Controls.Add(bntFacebook);
            Controls.Add(bntGoogle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntGoogle;
        private Button bntFacebook;
        private Button bntSourceDemo;
        private Button GK;
        private Label label1;
    }
}