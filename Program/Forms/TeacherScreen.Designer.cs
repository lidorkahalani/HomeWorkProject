namespace Program
{
    partial class fTeacherScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTeacherScreen));
            this.labTeacher = new System.Windows.Forms.Label();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnWhoFinish = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnWhoDidntFinish = new System.Windows.Forms.Button();
            this.TaskGridView = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labTeacher
            // 
            this.labTeacher.AutoSize = true;
            this.labTeacher.BackColor = System.Drawing.Color.Transparent;
            this.labTeacher.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTeacher.ForeColor = System.Drawing.Color.Teal;
            this.labTeacher.Location = new System.Drawing.Point(239, 9);
            this.labTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTeacher.Name = "labTeacher";
            this.labTeacher.Size = new System.Drawing.Size(554, 69);
            this.labTeacher.TabIndex = 0;
            this.labTeacher.Text = "Welcome Teacher";
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNewTask.CausesValidation = false;
            this.btnAddNewTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTask.Location = new System.Drawing.Point(30, 143);
            this.btnAddNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(175, 46);
            this.btnAddNewTask.TabIndex = 1;
            this.btnAddNewTask.Text = "Add Task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteTask.CausesValidation = false;
            this.btnDeleteTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Location = new System.Drawing.Point(30, 212);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(175, 46);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnWhoFinish
            // 
            this.btnWhoFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWhoFinish.CausesValidation = false;
            this.btnWhoFinish.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhoFinish.Location = new System.Drawing.Point(30, 301);
            this.btnWhoFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhoFinish.Name = "btnWhoFinish";
            this.btnWhoFinish.Size = new System.Drawing.Size(175, 61);
            this.btnWhoFinish.TabIndex = 3;
            this.btnWhoFinish.Text = "Who Finished?";
            this.btnWhoFinish.UseVisualStyleBackColor = false;
            this.btnWhoFinish.Click += new System.EventHandler(this.btnWhoFinish_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.CausesValidation = false;
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(961, 401);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(105, 54);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnWhoDidntFinish
            // 
            this.btnWhoDidntFinish.CausesValidation = false;
            this.btnWhoDidntFinish.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhoDidntFinish.Location = new System.Drawing.Point(30, 370);
            this.btnWhoDidntFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhoDidntFinish.Name = "btnWhoDidntFinish";
            this.btnWhoDidntFinish.Size = new System.Drawing.Size(175, 61);
            this.btnWhoDidntFinish.TabIndex = 5;
            this.btnWhoDidntFinish.Text = "Who Didn\'t Finish?";
            this.btnWhoDidntFinish.UseVisualStyleBackColor = true;
            this.btnWhoDidntFinish.Click += new System.EventHandler(this.btnWhoDidntFinish_Click);
            // 
            // TaskGridView
            // 
            this.TaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskName,
            this.DeadLine});
            this.TaskGridView.Location = new System.Drawing.Point(239, 116);
            this.TaskGridView.Margin = new System.Windows.Forms.Padding(4);
            this.TaskGridView.Name = "TaskGridView";
            this.TaskGridView.Size = new System.Drawing.Size(685, 339);
            this.TaskGridView.TabIndex = 6;
            this.TaskGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskGridView_CellContentClick);
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "TaskID";
            this.TaskID.Name = "TaskID";
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "TaskName";
            this.TaskName.Name = "TaskName";
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.Name = "DeadLine";
            // 
            // UserGridView
            // 
            this.UserGridView.CausesValidation = false;
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Email});
            this.UserGridView.Location = new System.Drawing.Point(239, 116);
            this.UserGridView.Margin = new System.Windows.Forms.Padding(4);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.Size = new System.Drawing.Size(685, 339);
            this.UserGridView.TabIndex = 7;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(239, 81);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditProfile.CausesValidation = false;
            this.btnEditProfile.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(961, 43);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(105, 68);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // fTeacherScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1079, 630);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.UserGridView);
            this.Controls.Add(this.TaskGridView);
            this.Controls.Add(this.btnWhoDidntFinish);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnWhoFinish);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.labTeacher);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTeacherScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework Share";
            this.Load += new System.EventHandler(this.fTeacherScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTeacher;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnWhoFinish;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnWhoDidntFinish;
        private System.Windows.Forms.DataGridView TaskGridView;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.Button btnEditProfile;
    }
}