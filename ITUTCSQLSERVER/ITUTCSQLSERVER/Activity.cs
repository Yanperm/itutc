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
    public partial class Activity : Form
    {
        public Activity()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            String ACTIVITY_ID = txtACTIVITYID.Text;
            String ACTIVITY_NAME = txtACTIVITYNAME.Text;
            String ACTIVITYID_DATE = txtACTIVITYDATE.Text;
            String ACTIVITY_STATUS = txtACTIVITYSTATUS.Text;

            //label5.Text = ACTIVITY_ID;
            //label6.Text = ACTIVITY_NAME;
            ///label7.Text = ACTIVITYID_DATE;
            //label8.Text = ACTIVITY_STATUS;

            Manager.InsertActivity(ACTIVITY_ID, ACTIVITY_NAME, ACTIVITYID_DATE, ACTIVITY_STATUS);
            MessageBox.Show("บันทึก", "แจ้งเตือน");
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Activity_Load(object sender, EventArgs e)
        {

        }
    }
}
