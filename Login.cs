using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using phonebook;

namespace my
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_visitor fv = new Form_visitor();
            fv.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (password.Text == "123456")
            {
                Form_Main f = new Form_Main();
                f.ShowDialog();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
