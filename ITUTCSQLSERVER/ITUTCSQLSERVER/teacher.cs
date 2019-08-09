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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String TEACHER_NAME = txtTEACHER_NAME.Text;
            String TEACHER_LASTNAME = txtTEACHER_LASTNAME.Text;
            String TEACHER_TEL = txtTEACHER_TEL.Text;
            String TEACHER_ADVISOR = txtTEACHER_ADVISOR.Text;
            Manager.InsertTeacher(TEACHER_NAME, TEACHER_LASTNAME, TEACHER_TEL, TEACHER_ADVISOR);
            MessageBox.Show("บันทึก", "แจ้งเตือน");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
