﻿namespace DuAn
{
    partial class Qmk1
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
            button1 = new Button();
            txtmkmoi2 = new TextBox();
            mail1 = new TextBox();
            txtmkmoi1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(301, 262);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 9;
            button1.Text = "Tiếp Tục";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtmkmoi2
            // 
            txtmkmoi2.Location = new Point(202, 186);
            txtmkmoi2.Margin = new Padding(3, 4, 3, 4);
            txtmkmoi2.Name = "txtmkmoi2";
            txtmkmoi2.Size = new Size(377, 27);
            txtmkmoi2.TabIndex = 6;
            // 
            // mail1
            // 
            mail1.Location = new Point(202, 68);
            mail1.Margin = new Padding(3, 4, 3, 4);
            mail1.Name = "mail1";
            mail1.Size = new Size(377, 27);
            mail1.TabIndex = 7;
            // 
            // txtmkmoi1
            // 
            txtmkmoi1.Location = new Point(202, 130);
            txtmkmoi1.Margin = new Padding(3, 4, 3, 4);
            txtmkmoi1.Name = "txtmkmoi1";
            txtmkmoi1.Size = new Size(377, 27);
            txtmkmoi1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 72);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "ĐIền lại mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 190);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 4;
            label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 134);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Mật Khẩu Mới";
            // 
            // Qmk1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button1);
            Controls.Add(txtmkmoi2);
            Controls.Add(mail1);
            Controls.Add(txtmkmoi1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Qmk1";
            Text = "Qmk1";
            Load += Qmk1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtmkmoi2;
        private TextBox mail1;
        private TextBox txtmkmoi1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}