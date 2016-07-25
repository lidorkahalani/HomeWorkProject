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

    public partial class fMainProgram : Form

    {
        static HashSet<SimpleUser> Users = new HashSet<SimpleUser>();
        static AdminUser admin = new AdminUser();
        static TeacherUser teacher = new TeacherUser();
        static SimpleUser simpleUser = new SimpleUser();


        public fMainProgram()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);    //close all forms = Exit
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            fSignUpScreen signUpScreen = new fSignUpScreen();
            this.Hide();
            signUpScreen.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int userType = 0;
            if (DataBase.Instance.LogIn(email, password)!=null) //if received a valid user from Database
            {
                userType = DataBase.Instance.LogIn(email, password).UserType;   //get the UserType from received user
                //  relevant user will be applied
                if (userType == 1)
                {
                    admin = admin.getAdmin(email, password);
                }
                else if (userType == 2)
                {
                    teacher = teacher.getTeacher(email, password);
                }
                else if (userType == 3)
                {
                    simpleUser = simpleUser.getUser(email, password);
                }
            }
            //open relevant screen according to the user type
            switch (userType)
            {
                case 0: //in case Login failed
                    MessageBox.Show("email or password not match!");
                    break;
                case 1:
                    fAdminMenu adminScreen = new fAdminMenu(admin);
                    adminScreen.Show();
                    this.Hide();
                    break;
                case 2:
                    fTeacherScreen teacherScreen = new fTeacherScreen(teacher);
                    teacherScreen.Show();
                    this.Hide();
                    break;
                case 3:
                    fSimpleUserScreen simpleUserScreen = new fSimpleUserScreen(simpleUser);
                    simpleUserScreen.Show();
                    this.Hide();
                    break;
                default:
                    break;

            }
        }

        private void fMainProgram_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtEmail;  //get focus to email textBox

        }
    }
}
