using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class EditTaskPopUp : Form
    {
        TeacherUser teacher=new TeacherUser();
        AdminUser admin=new AdminUser();
        string taskID;
        int userType;
        public EditTaskPopUp(DataGridViewRow allRow,User current)
        {
            InitializeComponent();
            userType = current.UserType;
            // get permissions
            if (current.UserType == 1)
            {
                admin = admin.getAdmin(current.Email, current.Password);
            }

            else if (current.UserType == 2)
            {
                teacher = teacher.getTeacher(current.Email, current.Password);
            }          
            else
                return;

            try {
                taskID = allRow.Cells["TaskID"].FormattedValue.ToString();
                txtTaskName.Text = allRow.Cells["TaskName"].FormattedValue.ToString();
                deadLineField.Value = Convert.ToDateTime(allRow.Cells["DeadLine"].FormattedValue.ToString());

            } catch(ArgumentException ar) {
                Console.WriteLine(ar.StackTrace);
                return;
            }



        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool indicator=false;
            if (userType == 1)
            {
                indicator = admin.editTask(new Task(Int64.Parse(taskID), txtTaskName.Text,deadLineField.Value,admin.ClassID));
            }
            else if (userType == 2)
            {
                indicator = teacher.editTask(new Task(Int64.Parse(taskID), txtTaskName.Text, deadLineField.Value,teacher.ClassID));
            }
            else
                return;
            if (indicator)
            {
                MessageBox.Show("Update Task successfully!");
            }
            else
                MessageBox.Show("Failed to Update Task!");

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deadLineField_DropDown(object sender, EventArgs e)
        {
          
            //limit deadline date - today is minimum
            deadLineField.MinDate = DateTime.Today;
        }
    }
}
