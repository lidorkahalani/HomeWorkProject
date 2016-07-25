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
    public partial class fSimpleUserScreen : Form
    {
        private AdminUser currentAdmin = new AdminUser();
        private SimpleUser currentUser = new SimpleUser();
        private HashSet<Task> tasks = new HashSet<Task>();
        protected DataGridViewRow taskRow=new DataGridViewRow() ;
        protected static bool showDoneTasksFlag = false;
      //  protected static bool showUserLayoutFlag = false;   //used for admin screen - therefore 'protected', indicates

        public fSimpleUserScreen()
        {
            InitializeComponent();
        }

        public fSimpleUserScreen(User user)
        {
            InitializeComponent();
            //recevie user permissions
            if (user.UserType == 3)//simpleUser indicator
            {

                currentUser = (SimpleUser)user;
                currentUser.getTasks(); //set user's tasks from DB
                tasks = currentUser.LocalTasks; //copy of all user's tasks into local tasks HashSet
                labCurrentUserName.Text = "Welcome " + currentUser.UserName;    //set the 'Welcome' label
            }
            else if (user.UserType == 1)
            {

                currentAdmin = (AdminUser)user;
                currentAdmin.getTasks();    //set user's tasks from DB
                tasks = currentAdmin.LocalTasks;    //copy of all user's tasks into local tasks HashSet
                labCurrentUserName.Text = "Welcome " + currentAdmin.UserName;   //set the 'Welcome' label
            }

        }     

        protected void fSimpleUserScreen_Load(object sender, EventArgs e)   //initial load of the window
        {
            btnMarkTask.BackColor = Color.FromArgb(150, 10, 240, 10);   //set 'markTask' button color
            btnShowTask.BackColor = Color.FromArgb(150, 0, 128, 128);   //set 'show/hide done tasks' button color
            LoadTasksGrid(showDoneTasksFlag);   //load tasks grid
        }

        protected virtual void taskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)    //event of click on tasks grid's cell
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
                btnMarkTask.BackColor = Color.FromArgb(150,10, 240, 10);   //green

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)    //close this window and open main window
        {
            fMainProgram mainMenu = new fMainProgram();
            this.Close();
            mainMenu.Show();
            
        }

        protected void btnMarkTask_Click(object sender, EventArgs e)    //event of click on MarkTask button
        {
            //check if the click was on valid cell
            long taskID = -1;
            try {   //try to get the taskID
                 taskID = Convert.ToInt64(taskRow.Cells["TaskID"].FormattedValue.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            if(taskID < 0)  //if taskID remained -1: a valid cell was NOT clicked, so return
            {
                return;
            }


            if (taskRow.Cells["Status"].FormattedValue.ToString().Equals("Not Done"))   //if selected task is NOT DONE
            {
                //mark task as DONE according to user type
                if (currentUser.UserType == 3)
                {
                    if (currentUser.markTask(true, taskID)) //call markTask method with 'true' in order to mark as DONE
                        MessageBox.Show("successfuly marked!");
                    else
                        MessageBox.Show("Mark failed");
                }
                else if (currentAdmin.UserType == 1)
                {
                    if (currentAdmin.markTask(true, taskID))    //call markTask method with 'true' in order to mark as DONE
                        MessageBox.Show("successfuly marked!");
                    else
                        MessageBox.Show("Mark failed");
                }
            }
            else  //if selected task is DONE
            {
                //mark task as NOT DONE according to user type
                if (currentUser.UserType == 3)
                    if (currentUser.markTask(false, taskID))    //call markTask method with 'false' in order to mark as NOT DONE
                        MessageBox.Show("successfuly marked!");
                    else
                        MessageBox.Show("Mark failed");
                else if (currentAdmin.UserType == 1)
                    if (currentAdmin.markTask(false, taskID))   //call markTask method with 'false' in order to mark as NOT DONE
                        MessageBox.Show("successfuly marked!");
                    else
                        MessageBox.Show("Mark failed");

            }
            LoadTasksGrid(showDoneTasksFlag);   //refresh tasks grid
        }

        public void LoadTasksGrid(bool showDoneTasks)   //fill the tasks grid and show/hide done tasks according to 'showDoneTasks' flag
        {
            // receive user's tasks
            if (currentAdmin.UserType == 1)
            {
                currentAdmin.getTasks();
                tasks = currentAdmin.LocalTasks;
            }
            else if (currentUser.UserType == 3)
            {
                currentUser.getTasks();
                tasks = currentUser.LocalTasks;
            }
            // clear the grid for previous tasks
            taskGridView.Rows.Clear();
            foreach (Task t in tasks)
            {
               //convert true/false to done/not done string
                string status;
                if (t.Status)
                    status = "Done";
                else
                    status = "Not Done";
                //create the row string
                string[] row = new string[] { t.TaskID.ToString(), t.TaskName, status, t.Deadline.ToString("dd/MM/yyyy") };
                //show/hide done task's according to 'showDoneTasks' flag
                if (showDoneTasksFlag)
                    taskGridView.Rows.Add(row);
                else {
                    if(!t.Status)
                        taskGridView.Rows.Add(row);
                }
                //set deadline cell color according to if deadline has passed or is today (otherwise - default color)
                foreach (DataGridViewRow d in taskGridView.Rows)
                {
                    if(!d.Cells["DeadLine"].FormattedValue.ToString().Equals(""))
                        if(DateTime.Now.Date.CompareTo(DateTime.Parse(d.Cells["DeadLine"].FormattedValue.ToString())) > 0)  //deadline has passed
                        {
                            d.Cells["DeadLine"].Style.BackColor = Color.Red;
                        }
                        else if (DateTime.Now.Date.CompareTo(DateTime.Parse(d.Cells["DeadLine"].FormattedValue.ToString())) == 0)    //deadline is today
                        {
                            d.Cells["DeadLine"].Style.BackColor = Color.Orange;
                        }
                }
            }
            //set the 'show/hide done tasks' button color and text
            if (!showDoneTasksFlag)
            {
                btnShowTask.BackColor = Color.FromArgb(150, 0 ,128 ,128);    //blue
                btnShowTask.Text = "Show Done Tasks";
            }
            else {
                btnShowTask.BackColor = Color.FromArgb(70, 0, 128, 128); //other blue
                btnShowTask.Text = "Hide Done Tasks";
            }


        }

        protected void btnShowTask_Click(object sender, EventArgs e)    //event of show/hide done tasks toggle button click
        {
            LoadTasksGrid(!showDoneTasksFlag);  //load tasks grid
            showDoneTasksFlag = !showDoneTasksFlag; //toggle the 'showDoneTasksFlag' boolean
        }

        private void btnEditProfile_Click(object sender, EventArgs e)   // event of click on EditProfile button
        {
            //open EditProfile window with the relevant user
            if (currentUser.UserType == 3)
            {
                EditProfile editProfile = new EditProfile(currentUser);
                editProfile.Show();
            }
            else if (currentAdmin.UserType == 1)
            {
                EditProfile editProfile = new EditProfile(currentAdmin);
                editProfile.Show();
            }
        }

    }
}
