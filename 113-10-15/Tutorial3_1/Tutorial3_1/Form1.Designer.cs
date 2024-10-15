namespace Tutorial3_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDayOFweek = new TextBox();
            txtDate = new TextBox();
            txtMonth = new TextBox();
            txtyear = new TextBox();
            lblshow = new Label();
            btnshowDate = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(78, 57);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(78, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(78, 206);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(78, 270);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtDayOFweek
            // 
            txtDayOFweek.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDayOFweek.Location = new Point(198, 57);
            txtDayOFweek.Name = "txtDayOFweek";
            txtDayOFweek.Size = new Size(204, 48);
            txtDayOFweek.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDate.Location = new Point(198, 118);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(204, 48);
            txtDate.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 24F);
            txtMonth.Location = new Point(198, 184);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(204, 48);
            txtMonth.TabIndex = 6;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 24F);
            txtyear.Location = new Point(198, 263);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(204, 48);
            txtyear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblshow.Location = new Point(106, 355);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(592, 64);
            lblshow.TabIndex = 8;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnshowDate
            // 
            btnshowDate.Location = new Point(62, 502);
            btnshowDate.Name = "btnshowDate";
            btnshowDate.Size = new Size(75, 23);
            btnshowDate.TabIndex = 9;
            btnshowDate.Text = "顯示完整日期";
            btnshowDate.UseVisualStyleBackColor = true;
            btnshowDate.Click += btnshowDate_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(220, 502);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 10;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(372, 502);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(75, 23);
            btnexit.TabIndex = 11;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshowDate);
            Controls.Add(lblshow);
            Controls.Add(txtyear);
            Controls.Add(txtMonth);
            Controls.Add(txtDate);
            Controls.Add(txtDayOFweek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDayOFweek;
        private TextBox txtDate;
        private TextBox txtMonth;
        private TextBox txtyear;
        private Label lblshow;
        private Button btnshowDate;
        private Button btnclear;
        private Button btnexit;
    }
}
