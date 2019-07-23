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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void Lebel1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String STUDENT_NAME = txtSTUDENT_NAME.Text;
            String STUDENT_LASTNAME = txtSTUDENT_LASTNAME.Text;
            String STUDENT_TEL = txtSTUDENT_TEL.Text;
            Manager.InsertStudent(STUDENT_NAME, STUDENT_LASTNAME, STUDENT_TEL);
            MessageBox.Show("บันทึก", "แจ้งเตือน");
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void Student_Load_1(object sender, EventArgs e)
        {

        }
    }
}
