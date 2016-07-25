namespace Program.Forms
{
    partial class AddNewTaskPopUp
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.deadLineField = new System.Windows.Forms.DateTimePicker();
            this.labDeadLine = new System.Windows.Forms.Label();
            this.labTaskName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(45, 235);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 44);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(150, 42);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(143, 22);
            this.txtTaskName.TabIndex = 1;
            // 
            // deadLineField
            // 
            this.deadLineField.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deadLineField.Location = new System.Drawing.Point(150, 96);
            this.deadLineField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deadLineField.Name = "deadLineField";
            this.deadLineField.Size = new System.Drawing.Size(216, 24);
            this.deadLineField.TabIndex = 3;
            // 
            // labDeadLine
            // 
            this.labDeadLine.AutoSize = true;
            this.labDeadLine.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDeadLine.Location = new System.Drawing.Point(26, 96);
            this.labDeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDeadLine.Name = "labDeadLine";
            this.labDeadLine.Size = new System.Drawing.Size(88, 24);
            this.labDeadLine.TabIndex = 4;
            this.labDeadLine.Text = "Dead Line";
            // 
            // labTaskName
            // 
            this.labTaskName.AutoSize = true;
            this.labTaskName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaskName.Location = new System.Drawing.Point(26, 42);
            this.labTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTaskName.Name = "labTaskName";
            this.labTaskName.Size = new System.Drawing.Size(100, 24);
            this.labTaskName.TabIndex = 5;
            this.labTaskName.Text = "Task Name";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(223, 235);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddNewTaskPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labTaskName);
            this.Controls.Add(this.labDeadLine);
            this.Controls.Add(this.deadLineField);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewTaskPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.DateTimePicker deadLineField;
        private System.Windows.Forms.Label labDeadLine;
        private System.Windows.Forms.Label labTaskName;
        private System.Windows.Forms.Button btnClose;
    }
}