using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Program.Forms
{
    public partial class fAdminMenu : Program.fSimpleUserScreen
    {
        private AdminUser admin = new AdminUser();
        private HashSet<User> users = new HashSet<User>();
        protected DataGridViewRow userRow = new DataGridViewRow();
        private static bool showUserLayoutFlag = false;   //indicates if to show users grid or tasks grid
        public fAdminMenu()  // must have this empty constructor in order to be able to see designer view
        {
            InitializeComponent();
        }


        public fAdminMenu(AdminUser admin) : base(admin)
        {
            InitializeComponent();
            this.admin = admin;
            btnDeleteTask.Hide();
        }

        private void fAdminMenu_Load(object sender, EventArgs e)
        {
            usersGridView.Hide();
            LoadLayout(showUserLayoutFlag);
        }

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNewTaskPopUp addNewTaskPopUp = new AddNewTaskPopUp(admin);
            addNewTaskPopUp.Show();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (taskRow.Index < 0)
                return;
            string taskName = taskRow.Cells["TaskName"].FormattedValue.ToString();
            string message = "Delete '"+taskName+"' Task?";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                long taskID = Convert.ToInt64(taskRow.Cells["TaskID"].FormattedValue.ToString());
                if (admin.deleteTask(taskID))
                    MessageBox.Show("Successfully Deleted Task");
                else
                    MessageBox.Show("Failed To Delete Task");
                admin.getTasks();
                LoadTasksGrid(showDoneTasksFlag);

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //open AddUser pop up window
            adminAddUserPopUp adminAddUser = new adminAddUserPopUp(admin);
            adminAddUser.Show();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            string userType = "";
            string userName = "";
            //check if a valid cell was selected
            if (userRow.Index < 0)
                return;
            // prevent Admin from removing him-self from the group
            // by checking if selected user's email equals to current admin's email
            if (userRow.Cells["Email"].FormattedValue.ToString().Equals(admin.Email))
            {
                MessageBox.Show("Cannot remove yourself from group");
                return;
            }
            if (userRow.Cells["UserType"].FormattedValue.ToString().Equals("Teacher"))
                userType = "Teacher";
            else if (userRow.Cells["UserType"].FormattedValue.ToString().Equals("User"))
                userType = "User";
            else if (userRow.Cells["UserType"].FormattedValue.ToString().Equals("Admin"))
                userType = "Admin";
            userName = userRow.Cells["UserName"].FormattedValue.ToString();
            //create prompt dialog with OK and Cancel buttons
            string message = "Remove " + userType + " '"+userName+"' From Your Group?";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)  //if OK was clicked
            {
                //parse the email
                string email = userRow.Cells["Email"].FormattedValue.ToString();
                //try to remove user from group in DB
                if (admin.removeUserFromGroup(email))
                    MessageBox.Show(userType + "Successfully Removed");
                else
                    MessageBox.Show(userType + "Failed To Remove");
            }

        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            //check if valid task cell was clicked
            if (taskRow.Index < 0)
                return;
            //open EditTask pop up window
            EditTaskPopUp editTask = new EditTaskPopUp(taskRow, admin);
            editTask.Show();

        }

        protected override void taskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            taskRow = taskGridView.Rows[e.RowIndex];
            if (taskRow.Cells["Status"].FormattedValue.ToString().Equals("Done"))
            {
                btnMarkTask.Text = "Undone";
                btnMarkTask.BackColor = Color.FromArgb(150, 240, 10, 10); //red
            }
            else
            {
                btnMarkTask.Text = "Done";
                btnMarkTask.BackColor = Color.FromArgb(150, 10, 240, 10);   //green
            }
            btnDeleteTask.Show();

        }

        private void btnSwitchLayout_Click(object sender, EventArgs e)
        {
            showUserLayoutFlag = !showUserLayoutFlag;
            LoadLayout(showUserLayoutFlag);
        }

        public void LoadLayout(bool showDoneTasks)  //toggle users layout and tasks layout
        {
            if (showUserLayoutFlag)             //Manage Users Layout
            {
                LoadUsersGrid();
                btnSwitchLayout.Text = "Manage Tasks";
                usersGridView.Show();
                btnAddUser.Show();
                btnRemoveUser.Show();
                btnMarkTask.Enabled = false;
                btnShowTask.Enabled = false;
                taskGridView.Hide();
                btnAddNewTask.Hide();
                btnEditTask.Hide();
                btnDeleteTask.Hide();
            }
            else
            {                                       //Manage Tasks Layout
                LoadTasksGrid(showDoneTasks);
                btnSwitchLayout.Text = "Manage Users";
                usersGridView.Hide();
                btnAddUser.Hide();
                btnRemoveUser.Hide();
                btnMarkTask.Enabled = true;
                btnShowTask.Enabled = true;
                taskGridView.Show();
                btnAddNewTask.Show();
                btnEditTask.Show();
                btnDeleteTask.Show();
            }
        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userRow = usersGridView.Rows[e.RowIndex];
        }

        private void LoadUsersGrid()
        {
            users.Clear();
            users = admin.getAllUsers();
            usersGridView.Rows.Clear();
            string userType = "";

            foreach (User u in users)
            {
                if (u.UserType == 1)
                    userType = "Admin";
                else if (u.UserType == 2)
                    userType = "Teacher";
                else if (u.UserType == 3)
                    userType = "User";

                string[] row = new string[] { u.UserName.ToString(), u.Email, userType };
                usersGridView.Rows.Add(row);
            }
        }

    }
}
