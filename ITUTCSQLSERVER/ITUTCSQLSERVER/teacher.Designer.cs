namespace ITUTCSQLSERVER
{
    partial class teacher
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
            this.txtTEACHER_NAME = new System.Windows.Forms.TextBox();
            this.txtTEACHER_LASTNAME = new System.Windows.Forms.TextBox();
            this.txtTEACHER_TEL = new System.Windows.Forms.TextBox();
            this.txtTEACHER_ADVISOR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "จัดการข้อมูลบุคลากร";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อบุคลากร";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "นามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "เบอร์โทร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ที่ปรึกษาแผนก";
            // 
            // txtTEACHER_NAME
            // 
            this.txtTEACHER_NAME.Location = new System.Drawing.Point(105, 63);
            this.txtTEACHER_NAME.Name = "txtTEACHER_NAME";
            this.txtTEACHER_NAME.Size = new System.Drawing.Size(166, 20);
            this.txtTEACHER_NAME.TabIndex = 5;
            // 
            // txtTEACHER_LASTNAME
            // 
            this.txtTEACHER_LASTNAME.Location = new System.Drawing.Point(105, 106);
            this.txtTEACHER_LASTNAME.Name = "txtTEACHER_LASTNAME";
            this.txtTEACHER_LASTNAME.Size = new System.Drawing.Size(166, 20);
            this.txtTEACHER_LASTNAME.TabIndex = 6;
            // 
            // txtTEACHER_TEL
            // 
            this.txtTEACHER_TEL.Location = new System.Drawing.Point(105, 144);
            this.txtTEACHER_TEL.Name = "txtTEACHER_TEL";
            this.txtTEACHER_TEL.Size = new System.Drawing.Size(166, 20);
            this.txtTEACHER_TEL.TabIndex = 7;
            // 
            // txtTEACHER_ADVISOR
            // 
            this.txtTEACHER_ADVISOR.Location = new System.Drawing.Point(105, 179);
            this.txtTEACHER_ADVISOR.Name = "txtTEACHER_ADVISOR";
            this.txtTEACHER_ADVISOR.Size = new System.Drawing.Size(166, 20);
            this.txtTEACHER_ADVISOR.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "ยกเลิก";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button2_MouseClick);
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 303);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTEACHER_ADVISOR);
            this.Controls.Add(this.txtTEACHER_TEL);
            this.Controls.Add(this.txtTEACHER_LASTNAME);
            this.Controls.Add(this.txtTEACHER_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "teacher";
            this.Text = "teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTEACHER_NAME;
        private System.Windows.Forms.TextBox txtTEACHER_LASTNAME;
        private System.Windows.Forms.TextBox txtTEACHER_TEL;
        private System.Windows.Forms.TextBox txtTEACHER_ADVISOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}