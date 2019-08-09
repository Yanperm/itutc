using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITUTCSQLSERVER
{
	public partial class Project : Form
	{
		public Project()
		{
			InitializeComponent();
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void Label3_Click(object sender, EventArgs e)
		{

		}

		private void Label4_Click(object sender, EventArgs e)
		{

		}

		private void Project_Load(object sender, EventArgs e)
		{

		}

		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonSAVE_Click(object sender, EventArgs e)
        {
            String PROJECTNAME = txtPROJECTNAME.Text;
            String STUDENTID = txtSTUDENTID.Text;
            String TEACHERID = txtTEACHERID.Text;
            String STATUS = this.txtSTATUS.SelectedItem.ToString();


            Manager.InsertProject(PROJECTNAME, STUDENTID, TEACHERID, STATUS);
            MessageBox.Show("บันทึก", "แจ้งเตือน");
        }

        private void TxtSTATUS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
