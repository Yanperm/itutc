namespace ITUTCSQLSERVER
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSTUDENT_NAME = new System.Windows.Forms.TextBox();
            this.txtSTUDENT_LASTNAME = new System.Windows.Forms.TextBox();
            this.txtSTUDENT_TEL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "จัดการข้อมูลนักศึกษา";
            this.label1.Click += new System.EventHandler(this.lebel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อนักศึกษา";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "นามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "เบอร์โทร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtSTUDENT_NAME
            // 
            this.txtSTUDENT_NAME.Location = new System.Drawing.Point(128, 79);
            this.txtSTUDENT_NAME.Name = "txtSTUDENT_NAME";
            this.txtSTUDENT_NAME.Size = new System.Drawing.Size(197, 20);
            this.txtSTUDENT_NAME.TabIndex = 5;
            // 
            // txtSTUDENT_LASTNAME
            // 
            this.txtSTUDENT_LASTNAME.Location = new System.Drawing.Point(127, 130);
            this.txtSTUDENT_LASTNAME.Name = "txtSTUDENT_LASTNAME";
            this.txtSTUDENT_LASTNAME.Size = new System.Drawing.Size(196, 20);
            this.txtSTUDENT_LASTNAME.TabIndex = 6;
            // 
            // txtSTUDENT_TEL
            // 
            this.txtSTUDENT_TEL.Location = new System.Drawing.Point(127, 181);
            this.txtSTUDENT_TEL.Name = "txtSTUDENT_TEL";
            this.txtSTUDENT_TEL.Size = new System.Drawing.Size(198, 20);
            this.txtSTUDENT_TEL.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseClick);
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSTUDENT_TEL);
            this.Controls.Add(this.txtSTUDENT_LASTNAME);
            this.Controls.Add(this.txtSTUDENT_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSTUDENT_NAME;
        private System.Windows.Forms.TextBox txtSTUDENT_LASTNAME;
        private System.Windows.Forms.TextBox txtSTUDENT_TEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}