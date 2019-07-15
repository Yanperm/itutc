namespace ITUTCSQLSERVER
{
    partial class Activity
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtACTIVITYID = new System.Windows.Forms.TextBox();
            this.txtACTIVITYNAME = new System.Windows.Forms.TextBox();
            this.txtACTIVITYDATE = new System.Windows.Forms.TextBox();
            this.txtACTIVITYSTATUS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageDatabaseToolStripMenuItem
            // 
            this.manageDatabaseToolStripMenuItem.Name = "manageDatabaseToolStripMenuItem";
            this.manageDatabaseToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.manageDatabaseToolStripMenuItem.Text = "Manage Database";
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Location = new System.Drawing.Point(183, 250);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(75, 23);
            this.buttonSAVE.TabIndex = 4;
            this.buttonSAVE.Text = "บันทึกข้อมูล";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.Label3_Click);
            this.buttonSAVE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อกิจกรรม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสกิจกรรม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "วันที่";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "สถานะ";
            // 
            // txtACTIVITYID
            // 
            this.txtACTIVITYID.Location = new System.Drawing.Point(183, 65);
            this.txtACTIVITYID.Name = "txtACTIVITYID";
            this.txtACTIVITYID.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYID.TabIndex = 0;
            // 
            // txtACTIVITYNAME
            // 
            this.txtACTIVITYNAME.Location = new System.Drawing.Point(183, 106);
            this.txtACTIVITYNAME.Name = "txtACTIVITYNAME";
            this.txtACTIVITYNAME.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYNAME.TabIndex = 1;
            // 
            // txtACTIVITYDATE
            // 
            this.txtACTIVITYDATE.Location = new System.Drawing.Point(183, 147);
            this.txtACTIVITYDATE.Name = "txtACTIVITYDATE";
            this.txtACTIVITYDATE.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYDATE.TabIndex = 2;
            // 
            // txtACTIVITYSTATUS
            // 
            this.txtACTIVITYSTATUS.Location = new System.Drawing.Point(183, 186);
            this.txtACTIVITYSTATUS.Name = "txtACTIVITYSTATUS";
            this.txtACTIVITYSTATUS.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYSTATUS.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 322);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtACTIVITYSTATUS);
            this.Controls.Add(this.txtACTIVITYDATE);
            this.Controls.Add(this.txtACTIVITYNAME);
            this.Controls.Add(this.txtACTIVITYID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Activity";
            this.Text = "Activity";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtACTIVITYID;
        private System.Windows.Forms.TextBox txtACTIVITYNAME;
        private System.Windows.Forms.TextBox txtACTIVITYDATE;
        private System.Windows.Forms.TextBox txtACTIVITYSTATUS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}