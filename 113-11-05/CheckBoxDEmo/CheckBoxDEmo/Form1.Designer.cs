﻿namespace CheckBoxDEmo
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(104, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 320);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "主餐";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton4.Location = new Point(115, 234);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 32);
            radioButton4.TabIndex = 7;
            radioButton4.Text = "比薩";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton3.Location = new Point(115, 179);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(74, 32);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "牛排";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton2.Location = new Point(115, 114);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 32);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "炸雞";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton1.Location = new Point(115, 51);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 32);
            radioButton1.TabIndex = 4;
            radioButton1.Text = "漢堡";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(483, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 221);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "飲料";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton5.Location = new Point(45, 45);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(74, 32);
            radioButton5.TabIndex = 5;
            radioButton5.Text = "可樂";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton7.Location = new Point(45, 149);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(96, 32);
            radioButton7.TabIndex = 9;
            radioButton7.Text = "冰咖啡";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Microsoft JhengHei UI", 16F);
            radioButton6.Location = new Point(45, 91);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(74, 32);
            radioButton6.TabIndex = 8;
            radioButton6.Text = "雪碧";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
    }
}
