﻿namespace ITUTCSQLSERVER
{
    partial class student
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTUDENTNAME = new System.Windows.Forms.TextBox();
            this.txtSTUDENTLASTNAME = new System.Windows.Forms.TextBox();
            this.txtSTUDENTTELL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "นามสกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "เบอร์โทร";
            // 
            // txtSTUDENTNAME
            // 
            this.txtSTUDENTNAME.Location = new System.Drawing.Point(144, 73);
            this.txtSTUDENTNAME.Name = "txtSTUDENTNAME";
            this.txtSTUDENTNAME.Size = new System.Drawing.Size(100, 20);
            this.txtSTUDENTNAME.TabIndex = 3;
            this.txtSTUDENTNAME.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtSTUDENTLASTNAME
            // 
            this.txtSTUDENTLASTNAME.Location = new System.Drawing.Point(144, 121);
            this.txtSTUDENTLASTNAME.Name = "txtSTUDENTLASTNAME";
            this.txtSTUDENTLASTNAME.Size = new System.Drawing.Size(100, 20);
            this.txtSTUDENTLASTNAME.TabIndex = 4;
            this.txtSTUDENTLASTNAME.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtSTUDENTTELL
            // 
            this.txtSTUDENTTELL.Location = new System.Drawing.Point(144, 171);
            this.txtSTUDENTTELL.Name = "txtSTUDENTTELL";
            this.txtSTUDENTTELL.Size = new System.Drawing.Size(100, 20);
            this.txtSTUDENTTELL.TabIndex = 5;
            this.txtSTUDENTTELL.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ตกลง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "ข้อมูลนักศึกษา";
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSTUDENTTELL);
            this.Controls.Add(this.txtSTUDENTLASTNAME);
            this.Controls.Add(this.txtSTUDENTNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "student";
            this.Text = "student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSTUDENTNAME;
        private System.Windows.Forms.TextBox txtSTUDENTLASTNAME;
        private System.Windows.Forms.TextBox txtSTUDENTTELL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}