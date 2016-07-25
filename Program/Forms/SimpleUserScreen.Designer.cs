using System;
using System.Windows.Forms;

namespace Program
{
    partial class fSimpleUserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSimpleUserScreen));
            this.labCurrentUserName = new System.Windows.Forms.Label();
            this.btnShowTask = new System.Windows.Forms.Button();
            this.btnMarkTask = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labCurrentUserName
            // 
            this.labCurrentUserName.AutoSize = true;
            this.labCurrentUserName.BackColor = System.Drawing.Color.Transparent;
            this.labCurrentUserName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentUserName.ForeColor = System.Drawing.Color.Teal;
            this.labCurrentUserName.Location = new System.Drawing.Point(224, 1);
            this.labCurrentUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCurrentUserName.Name = "labCurrentUserName";
            this.labCurrentUserName.Size = new System.Drawing.Size(455, 69);
            this.labCurrentUserName.TabIndex = 0;
            this.labCurrentUserName.Text = "Welcome User";
            // 
            // btnShowTask
            // 
            this.btnShowTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowTask.CausesValidation = false;
            this.btnShowTask.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTask.Location = new System.Drawing.Point(224, 74);
            this.btnShowTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowTask.Name = "btnShowTask";
            this.btnShowTask.Size = new System.Drawing.Size(161, 30);
            this.btnShowTask.TabIndex = 1;
            this.btnShowTask.Text = "Show Done Tasks";
            this.btnShowTask.UseVisualStyleBackColor = false;
            this.btnShowTask.Click += new System.EventHandler(this.btnShowTask_Click);
            // 
            // btnMarkTask
            // 
            this.btnMarkTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMarkTask.CausesValidation = false;
            this.btnMarkTask.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkTask.Location = new System.Drawing.Point(72, 245);
            this.btnMarkTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkTask.Name = "btnMarkTask";
            this.btnMarkTask.Size = new System.Drawing.Size(144, 76);
            this.btnMarkTask.TabIndex = 2;
            this.btnMarkTask.Text = "Done";
            this.btnMarkTask.UseVisualStyleBackColor = false;
            this.btnMarkTask.Click += new System.EventHandler(this.btnMarkTask_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditProfile.CausesValidation = false;
            this.btnEditProfile.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(947, 13);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(105, 68);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.CausesValidation = false;
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(947, 418);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(105, 51);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // taskGridView
            // 
            this.taskGridView.BackgroundColor = System.Drawing.Color.White;
            this.taskGridView.CausesValidation = false;
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.TaskName,
            this.Status,
            this.DeadLine});
            this.taskGridView.Location = new System.Drawing.Point(224, 112);
            this.taskGridView.Margin = new System.Windows.Forms.Padding(4);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.Size = new System.Drawing.Size(682, 334);
            this.taskGridView.TabIndex = 5;
            this.taskGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskGridView_CellContentClick);
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
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.Name = "DeadLine";
            // 
            // fSimpleUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1079, 630);
            this.Controls.Add(this.taskGridView);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnMarkTask);
            this.Controls.Add(this.btnShowTask);
            this.Controls.Add(this.labCurrentUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fSimpleUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework Share";
            this.Load += new System.EventHandler(this.fSimpleUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void taskGridView_RowsAdded(object sender, DataGridViewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labCurrentUserName;
        protected System.Windows.Forms.Button btnShowTask;
        protected System.Windows.Forms.Button btnMarkTask;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        protected System.Windows.Forms.DataGridView taskGridView;
    }
}