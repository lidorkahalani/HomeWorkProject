using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class AddNewTaskPopUp : Form
    {
        AdminUser admin = new AdminUser();
        TeacherUser teacher = new TeacherUser();
        int userType;

        public AddNewTaskPopUp(User user)
        {
            InitializeComponent();
            userType = user.UserType;
            // get permissions
            if (user.UserType == 1)
                admin = admin.getAdmin(user.Email, user.Password);
            else if (user.UserType == 2)
                teacher = teacher.getTeacher(user.Email, user.Password);
            else
            {
                MessageBox.Show("Error");
                this.Close();
            }
            //limit deadline date - today is minimum
            deadLineField.MinDate = DateTime.Today;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {//add check for empty or double task name
            string taskName = txtTaskName.Text;
            if (taskName.Equals(""))
            {
                MessageBox.Show("Cannot Add Empty Task");
                return;
            }

            deadLineField.Format = DateTimePickerFormat.Custom;
            deadLineField.CustomFormat = "dd/MM/yyyy";
            DateTime deadline = deadLineField.Value;

            if (userType == 1)
            {
                if (admin.addNewTask(taskName, deadline))
                {
                    MessageBox.Show("Successfully Added Task!");
                    fAdminMenu fAdminScreen = new fAdminMenu(admin);
                    fAdminScreen.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Task Already Exist!");
                }
            }
            else if (userType == 2)
            {
                if (teacher.addNewTask(taskName, deadline))
                {
                    MessageBox.Show("Successfully Added Task!");


                    fTeacherScreen fTeacherScreen = new fTeacherScreen(teacher);
                    fTeacherScreen.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Task Already Exist!");
                }
            }




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (userType == 1)
            {
                fAdminMenu adminMenu = new fAdminMenu(admin);
                adminMenu.Show();
            }
            else if (userType == 2)
            {
                fTeacherScreen teacherMenu = new fTeacherScreen(teacher);
                teacherMenu.Show();
            }
        }
    }
}
