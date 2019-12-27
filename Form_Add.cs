﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phonebook
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_studengid.Text == "")
            {
                MessageBox.Show("未填写学号，请重新填写");
                return;
            }
            if (StudentInfoBLL.ExistId(Int32.Parse(txt_studengid.Text)))
            {
               MessageBox.Show("学号已存在!");
               return;
            }
            StudentInfo studentinfo = new StudentInfo();
            studentinfo.StudentID = Int32.Parse(txt_studengid.Text);
            studentinfo.Name = txt_name.Text;
            if (rd_man.Checked)
                studentinfo.Sex = "男";
            else
                studentinfo.Sex = "女";
            studentinfo.Age = Int32.Parse(txt_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dt_birthdate.Text);
            studentinfo.Phone = txt_phone.Text;
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;
            if (StudentInfoBLL.AddStudentInfo(studentinfo))
               MessageBox.Show("添加成功");
                this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {

        }

        private void txt_profession_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dt_birthdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dt_birthdate.Text);
            string hours = date.Hour.ToString();
            string minute = date.Minute.ToString();
            string second = date.Second.ToString();
        }

    }
}
