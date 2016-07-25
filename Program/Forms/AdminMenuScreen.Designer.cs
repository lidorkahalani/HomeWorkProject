namespace Program.Forms
{
    partial class fAdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdminMenu));
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnSwitchLayout = new System.Windows.Forms.Button();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowTask
            // 
            this.btnShowTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // btnMarkTask
            // 
            this.btnMarkTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(10)))), ((int)(((byte)(240)))), ((int)(((byte)(10)))));
            this.btnMarkTask.Location = new System.Drawing.Point(76, 233);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNewTask.CausesValidation = false;
            this.btnAddNewTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTask.Location = new System.Drawing.Point(947, 99);
            this.btnAddNewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(105, 49);
            this.btnAddNewTask.TabIndex = 6;
            this.btnAddNewTask.Text = "Add Task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddUser.CausesValidation = false;
            this.btnAddUser.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(947, 99);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(105, 49);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteTask.CausesValidation = false;
            this.btnDeleteTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Location = new System.Drawing.Point(947, 241);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(105, 60);
            this.btnDeleteTask.TabIndex = 9;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRemoveUser.CausesValidation = false;
            this.btnRemoveUser.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(947, 163);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(105, 60);
            this.btnRemoveUser.TabIndex = 10;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditTask.CausesValidation = false;
            this.btnEditTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.Location = new System.Drawing.Point(947, 163);
            this.btnEditTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(105, 60);
            this.btnEditTask.TabIndex = 12;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnSwitchLayout
            // 
            this.btnSwitchLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSwitchLayout.CausesValidation = false;
            this.btnSwitchLayout.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchLayout.Location = new System.Drawing.Point(112, 371);
            this.btnSwitchLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitchLayout.Name = "btnSwitchLayout";
            this.btnSwitchLayout.Size = new System.Drawing.Size(105, 75);
            this.btnSwitchLayout.TabIndex = 13;
            this.btnSwitchLayout.Text = "Manage Group";
            this.btnSwitchLayout.UseVisualStyleBackColor = false;
            this.btnSwitchLayout.Click += new System.EventHandler(this.btnSwitchLayout_Click);
            // 
            // usersGridView
            // 
            this.usersGridView.CausesValidation = false;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Email,
            this.UserType});
            this.usersGridView.Location = new System.Drawing.Point(223, 112);
            this.usersGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.RowTemplate.Height = 24;
            this.usersGridView.Size = new System.Drawing.Size(683, 334);
            this.usersGridView.TabIndex = 14;
            this.usersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "User Name";
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // UserType
            // 
            this.UserType.HeaderText = "User Type";
            this.UserType.Name = "UserType";
            // 
            // fAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1079, 630);
            this.Controls.Add(this.usersGridView);
            this.Controls.Add(this.btnSwitchLayout);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnAddNewTask);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fAdminMenu";
            this.Text = "Homework Share";
            this.Load += new System.EventHandler(this.fAdminMenu_Load);
            this.Controls.SetChildIndex(this.btnShowTask, 0);
            this.Controls.SetChildIndex(this.btnMarkTask, 0);
            this.Controls.SetChildIndex(this.btnAddNewTask, 0);
            this.Controls.SetChildIndex(this.btnAddUser, 0);
            this.Controls.SetChildIndex(this.btnDeleteTask, 0);
            this.Controls.SetChildIndex(this.btnRemoveUser, 0);
            this.Controls.SetChildIndex(this.btnEditTask, 0);
            this.Controls.SetChildIndex(this.btnSwitchLayout, 0);
            this.Controls.SetChildIndex(this.usersGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnSwitchLayout;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
    }
}
