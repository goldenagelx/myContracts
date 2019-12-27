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
    public partial class Form_visitor : Form
    {
        public Form_visitor()
        {
            InitializeComponent();
        }

        private void Form_visitor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Add formadd = new Form_Add();
            formadd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Search formsearch = new Form_Search();
            formsearch.ShowDialog();
        }
    }
}
