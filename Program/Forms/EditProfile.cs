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
    public partial class EditProfile : Form
    {
        SimpleUser Current=new SimpleUser();
        string prevEmail;
        HashSet<User> users = new HashSet<User>();
        InputValidation iv = new InputValidation();

        public EditProfile(SimpleUser current)
        {
            InitializeComponent();
            this.Current = current;
            prevEmail = Current.Email;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            users = DataBase.Instance.getAllUsers(-1);
            if (!iv.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email not valid");
                return;

            }
            
            foreach (User u in users)
            {
                if (Current.Email.Equals(txtEmail.Text))
                        break;
                if (u.Email.Equals(txtEmail.Text))
                {
                    MessageBox.Show("User with that email alredy exist");
                    return;
                }
            }
            
            if (!iv.isValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Password not valid");
                return;

            }
            if (!txtPassword.Text.Equals(txtRePassword.Text))
            {

                MessageBox.Show("Passwords not Match");
                return;

            }
            if (!iv.isValidUsername(txtUserName.Text))
            {
                MessageBox.Show("User Name not valid");
                return;

            }
            Current.Password = txtPassword.Text;
            Current.Email = txtEmail.Text;
            Current.UserName = txtUserName.Text;

            if (Current.editProfile(Current, prevEmail))
            {
                MessageBox.Show("successfully edit profile");
                this.Close();
            }
            else
                MessageBox.Show("Edit profile failed!");


        }

        private void btnExitUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            this.txtUserName.Text = Current.UserName;
            this.txtEmail.Text = Current.Email;
            this.txtPassword.Text = Current.Password;
        }
    }
}
