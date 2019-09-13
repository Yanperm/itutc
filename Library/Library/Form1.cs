using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String Book_id = id.Text;
          

            Manager.Deletebook(Book_id);
            MessageBox.Show("ลบสำเร็จ", "แจ้งเตือน");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String Book_id = id.Text;
            String Book_name = name.Text;
            String Book_amount = amount.Text;
            String Book_cat = cat.Text;


            Manager.Insertbook(Book_id, Book_name, Book_amount, Book_cat);
            MessageBox.Show("เพิ่มสำเร็จ", "แจ้งเตือน");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String Book_id = id.Text;
            String Book_name = name.Text;
            String Book_amount = amount.Text;
            String Book_cat = cat.Text;


            Manager.Updatebook(Book_id, Book_name, Book_amount, Book_cat);
            MessageBox.Show("แก้ไขสำเร็จ", "แจ้งเตือน");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            amount.Text = "";
            cat.Text = "";
        }
    }
}
