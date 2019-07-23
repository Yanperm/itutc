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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
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
            this.buttonSAVE.Location = new System.Drawing.Point(91, 155);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(100, 23);
            this.buttonSAVE.TabIndex = 4;
            this.buttonSAVE.Text = "บันทึกข้อมูล";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.Label3_Click);
            this.buttonSAVE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อกิจกรรม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสกิจกรรม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "วันที่";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "สถานะ";
            // 
            // txtACTIVITYID
            // 
            this.txtACTIVITYID.Location = new System.Drawing.Point(91, 37);
            this.txtACTIVITYID.Name = "txtACTIVITYID";
            this.txtACTIVITYID.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYID.TabIndex = 0;
            // 
            // txtACTIVITYNAME
            // 
            this.txtACTIVITYNAME.Location = new System.Drawing.Point(91, 71);
            this.txtACTIVITYNAME.Name = "txtACTIVITYNAME";
            this.txtACTIVITYNAME.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYNAME.TabIndex = 1;
            // 
            // txtACTIVITYDATE
            // 
            this.txtACTIVITYDATE.Location = new System.Drawing.Point(91, 103);
            this.txtACTIVITYDATE.Name = "txtACTIVITYDATE";
            this.txtACTIVITYDATE.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYDATE.TabIndex = 2;
            // 
            // txtACTIVITYSTATUS
            // 
            this.txtACTIVITYSTATUS.Location = new System.Drawing.Point(91, 129);
            this.txtACTIVITYSTATUS.Name = "txtACTIVITYSTATUS";
            this.txtACTIVITYSTATUS.Size = new System.Drawing.Size(100, 20);
            this.txtACTIVITYSTATUS.TabIndex = 3;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 209);
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
            this.Load += new System.EventHandler(this.Activity_Load);
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
    }
}