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
    
    public partial class fSignUpScreen : Form
    {
        HashSet<User> users = new HashSet<User>();

        public fSignUpScreen()
        {
            InitializeComponent();
        }

        private void fSignUpScreen_Load(object sender, EventArgs e)
        {
            foreach (User u in DataBase.Instance.getAllUsers(-1))
            {
                users.Add(u);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userType = cmbUserType.Text; 
            string userName=txtUserName.Text;
            string password=txtPassword.Text;
            string email=txtEmail.Text;
            users = DataBase.Instance.getAllUsers(-1);

            InputValidation iv = new InputValidation();


            if (userType == "")
            {
                MessageBox.Show("Please choose user type");
                return;
            }

            if(!iv.isValidEmail(email))
            {
                MessageBox.Show("Email not valid");
                return;

            }
            foreach(User u in users)
            {
                if (u.Email.Equals(email))
                {
                    MessageBox.Show("User with that email alredy exist");
                    return;
                }
            }
            if (!iv.isValidPassword(password))
            {
                MessageBox.Show("Password not valid");
                return;

            }
            if(!password.Equals(txtReEnterPas.Text))
            {

                MessageBox.Show("Passwords not Match");
                return;

            }
            if (!iv.isValidUsername(userName))
            {
                MessageBox.Show("User Name not valid");
                return;

            }
            switch(userType)
            {
                case "Admin":
                    AdminUser newAdmin = new AdminUser(userName,password,email);
                    newAdmin.AddUser();
                    break;
                case "Teacher":
                    TeacherUser newTeacher = new TeacherUser(userName, password, email);
                    newTeacher.AddUser();
                    break;
                case "User":
                    SimpleUser newSimpleUser = new SimpleUser(userName, password, email);
                    newSimpleUser.AddUser();
                    break;
                default:
                    MessageBox.Show("Unkwon user type!");
                    break;
            }
            MessageBox.Show("successfully signed in! please log in...");
            fMainProgram mainScreen = new fMainProgram();
            this.Close();
            mainScreen.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            fMainProgram mainScreen = new fMainProgram();
            this.Close();
            mainScreen.Show();
        }

    }
}
