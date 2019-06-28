using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormGetApi_2
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        Student student = new Student();

        private void BtnSerialize_Click(object sender, EventArgs e)
        {
            student.name = txtName.Text;
            student.lastName = txtLastName.Text;
            student.age = int.Parse(txtAge.Text);
            student.isMale = chkMale.Checked;

            string[] fellows = txtFriends.Text.Split('\n');
            foreach (var friend in fellows)
            {
                student.friends.Add(friend);
            }

            string content = JsonConvert.SerializeObject(student);

            File.AppendAllText(@"C:\Users\managnostou\Desktop\Folder\student.json", content);
        }
    }
}
