using Program.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class fTeacherScreen : Form
    {


        HashSet<User> users = new HashSet<User>();
        DataGridViewRow taskRow = new DataGridViewRow();
        private TeacherUser currentTeacher = new TeacherUser();
        private HashSet<Task> tasks;


        public fTeacherScreen(TeacherUser teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
            currentTeacher.getTasks();
            tasks = currentTeacher.LocalTasks;
            this.labTeacher.Text = "Welcome" + " " + currentTeacher.UserName;
            btnBack.Hide();

        }

        private void fTeacherScreen_Load(object sender, EventArgs e)
        {
            LoadTasksGrid();
            UserGridView.Hide();
            btnDeleteTask.Hide();
            btnWhoDidntFinish.Hide();
            btnWhoFinish.Hide();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            fMainProgram mainMenu = new fMainProgram();
            this.Close();
            mainMenu.Show();
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            if (currentTeacher.ClassID != 0)
            {
                this.Close(); //to refresh tasks grid
                AddNewTaskPopUp addNewTaskPopUp = new AddNewTaskPopUp(currentTeacher);
                addNewTaskPopUp.Show();
            }
            else
            {
                MessageBox.Show("Adding tasks only possible if you are part of a group");
            }
        }

        public void LoadTasksGrid()
        {

            TaskGridView.Rows.Clear();
            foreach (Task t in tasks)
            {
   
                string[] row = new string[] { t.TaskID.ToString(), t.TaskName, t.Deadline.ToString("dd/MM/yyyy") };
                TaskGridView.Rows.Add(row);
            }
           
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this task?";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (taskRow.Index < 0)
                    return;
                long taskID = -1;
                try
                {   //check if the click on 
                    taskID = Convert.ToInt64(taskRow.Cells["TaskID"].FormattedValue.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                if (taskID < 0)
                {
                    return;
                }

                taskID = Convert.ToInt64(taskRow.Cells["TaskID"].FormattedValue.ToString());
                if (currentTeacher.deleteTask(taskID))
                    MessageBox.Show("Task deleted");
                else
                    MessageBox.Show("Task delete failed");
                currentTeacher.getTasks();
                LoadTasksGrid();
            }
        }

        private void btnWhoFinish_Click(object sender, EventArgs e)
        {
            if (taskRow.Index < 0)
                return;
            HashSet<User> users= currentTeacher.showWhoFinishTaskByID(Int64.Parse(taskRow.Cells["TaskID"].FormattedValue.ToString()),true);
            LoadUsersGrid(users);
            TaskGridView.Hide();
            UserGridView.Show();
        }

        private void btnWhoDidntFinish_Click(object sender, EventArgs e)
        {
            if (taskRow.Index < 0)
                return;
            HashSet<User> users = currentTeacher.showWhoFinishTaskByID(Int64.Parse(taskRow.Cells["TaskID"].FormattedValue.ToString()), false);
            LoadUsersGrid(users);
            TaskGridView.Hide();
            UserGridView.Show();
        }
        
        private void LoadUsersGrid(HashSet<User>users)
        {
            UserGridView.Rows.Clear();
            string userType = "";

            foreach (User u in users)
            {
                if (u.GetType() == typeof(AdminUser))
                    userType = "Admin";
                else if (u.GetType() == typeof(SimpleUser))
                    userType = "User";
                else if (u.GetType() == typeof(TeacherUser))
                    userType = "Teacher";

                string[] row = new string[] { u.UserName.ToString(), u.Email, userType };
                UserGridView.Rows.Add(row);
            }
            btnBack.Show();
        }

        private void TaskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            taskRow= TaskGridView.Rows[e.RowIndex];
            btnDeleteTask.Show();
            btnWhoDidntFinish.Show();
            btnWhoFinish.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TaskGridView.Show();
            UserGridView.Hide();
            btnBack.Hide();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(currentTeacher);
            editProfile.Show();
        }
    }
}
