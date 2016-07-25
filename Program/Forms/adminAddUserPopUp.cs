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
    public partial class adminAddUserPopUp : Form
    {
        AdminUser newAdmin = new AdminUser();
        public adminAddUserPopUp(AdminUser admin)
        {

            InitializeComponent();
            newAdmin = newAdmin.getAdmin(admin.Email, admin.Password);
        }

        private void adminAddUserPopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (newAdmin.addUserToGroup(txtEmail.Text))
                {
                    this.Close();
                    MessageBox.Show("User successfuly added to your group!");
                }
            else
                MessageBox.Show("User with that email was not found!");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
