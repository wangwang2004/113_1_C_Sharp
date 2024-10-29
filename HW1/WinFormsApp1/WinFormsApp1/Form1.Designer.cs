namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lblshow = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources._2223;
            button1.Location = new Point(12, 23);
            button1.Name = "button1";
            button1.Size = new Size(140, 196);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(158, 23);
            button2.Name = "button2";
            button2.Size = new Size(137, 196);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft JhengHei UI", 9F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(301, 12);
            button3.Name = "button3";
            button3.Size = new Size(266, 356);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft JhengHei UI", 9F);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(584, 23);
            button4.Name = "button4";
            button4.Size = new Size(201, 230);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft JhengHei UI", 9F);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(825, 23);
            button5.Name = "button5";
            button5.Size = new Size(206, 286);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.FixedSingle;
            lblshow.Font = new Font("Microsoft JhengHei UI", 15F);
            lblshow.Location = new Point(231, 437);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(554, 53);
            lblshow.TabIndex = 5;
            lblshow.Click += label1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(446, 546);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 6;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 725);
            Controls.Add(button6);
            Controls.Add(lblshow);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lblshow;
        private Button button6;
    }
}
