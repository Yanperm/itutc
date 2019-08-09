namespace ITUTCSQLSERVER
{
	partial class Project
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
            this.ad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPROJECTNAME = new System.Windows.Forms.TextBox();
            this.txtSTUDENTID = new System.Windows.Forms.TextBox();
            this.txtTEACHERID = new System.Windows.Forms.TextBox();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.txtSTATUS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.Location = new System.Drawing.Point(22, 9);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(120, 25);
            this.ad.TabIndex = 0;
            this.ad.Text = "จัดการโปรเจค";
            this.ad.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อโปรเจค";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "รหัสนักศึกษา";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "รหัสครูที่ปรึกษา";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "สถานะความคืบหน้าโรเจค";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtPROJECTNAME
            // 
            this.txtPROJECTNAME.Location = new System.Drawing.Point(205, 51);
            this.txtPROJECTNAME.Name = "txtPROJECTNAME";
            this.txtPROJECTNAME.Size = new System.Drawing.Size(156, 20);
            this.txtPROJECTNAME.TabIndex = 5;
            // 
            // txtSTUDENTID
            // 
            this.txtSTUDENTID.Location = new System.Drawing.Point(205, 97);
            this.txtSTUDENTID.Name = "txtSTUDENTID";
            this.txtSTUDENTID.Size = new System.Drawing.Size(156, 20);
            this.txtSTUDENTID.TabIndex = 6;
            // 
            // txtTEACHERID
            // 
            this.txtTEACHERID.Location = new System.Drawing.Point(205, 149);
            this.txtTEACHERID.Name = "txtTEACHERID";
            this.txtTEACHERID.Size = new System.Drawing.Size(156, 20);
            this.txtTEACHERID.TabIndex = 7;
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.Location = new System.Drawing.Point(141, 228);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(61, 32);
            this.buttonSAVE.TabIndex = 10;
            this.buttonSAVE.Text = "ตกลง";
            this.buttonSAVE.UseVisualStyleBackColor = true;
            this.buttonSAVE.Click += new System.EventHandler(this.ButtonSAVE_Click);
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(306, 227);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(55, 34);
            this.buttonCLEAR.TabIndex = 11;
            this.buttonCLEAR.Text = "ยกเลิก";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            // 
            // txtSTATUS
            // 
            this.txtSTATUS.FormattingEnabled = true;
            this.txtSTATUS.Items.AddRange(new object[] {
            "เสร็จสมบูรณ์",
            "ยังไม่เสร็จสมบูรณ์"});
            this.txtSTATUS.Location = new System.Drawing.Point(205, 189);
            this.txtSTATUS.Name = "txtSTATUS";
            this.txtSTATUS.Size = new System.Drawing.Size(121, 21);
            this.txtSTATUS.TabIndex = 12;
            this.txtSTATUS.SelectedIndexChanged += new System.EventHandler(this.TxtSTATUS_SelectedIndexChanged);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 289);
            this.Controls.Add(this.txtSTATUS);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.buttonSAVE);
            this.Controls.Add(this.txtTEACHERID);
            this.Controls.Add(this.txtSTUDENTID);
            this.Controls.Add(this.txtPROJECTNAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ad);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPROJECTNAME;
		private System.Windows.Forms.TextBox txtSTUDENTID;
		private System.Windows.Forms.TextBox txtTEACHERID;
		private System.Windows.Forms.Button buttonSAVE;
		private System.Windows.Forms.Button buttonCLEAR;
        private System.Windows.Forms.ComboBox txtSTATUS;
    }
}