namespace Program.Forms
{
    partial class EditTaskPopUp
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.labTaskName = new System.Windows.Forms.Label();
            this.labDeadLine = new System.Windows.Forms.Label();
            this.deadLineField = new System.Windows.Forms.DateTimePicker();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClose.CausesValidation = false;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(301, 258);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 44);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labTaskName
            // 
            this.labTaskName.AutoSize = true;
            this.labTaskName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaskName.Location = new System.Drawing.Point(58, 56);
            this.labTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTaskName.Name = "labTaskName";
            this.labTaskName.Size = new System.Drawing.Size(100, 24);
            this.labTaskName.TabIndex = 11;
            this.labTaskName.Text = "Task Name";
            // 
            // labDeadLine
            // 
            this.labDeadLine.AutoSize = true;
            this.labDeadLine.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDeadLine.Location = new System.Drawing.Point(70, 149);
            this.labDeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDeadLine.Name = "labDeadLine";
            this.labDeadLine.Size = new System.Drawing.Size(88, 24);
            this.labDeadLine.TabIndex = 10;
            this.labDeadLine.Text = "Dead Line";
            // 
            // deadLineField
            // 
            this.deadLineField.CausesValidation = false;
            this.deadLineField.Font = new System.Drawing.Font("Aharoni", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadLineField.Location = new System.Drawing.Point(176, 151);
            this.deadLineField.Margin = new System.Windows.Forms.Padding(4);
            this.deadLineField.Name = "deadLineField";
            this.deadLineField.Size = new System.Drawing.Size(263, 24);
            this.deadLineField.TabIndex = 9;
            this.deadLineField.DropDown += new System.EventHandler(this.deadLineField_DropDown);
            // 
            // txtTaskName
            // 
            this.txtTaskName.CausesValidation = false;
            this.txtTaskName.Location = new System.Drawing.Point(176, 59);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(263, 22);
            this.txtTaskName.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOk.CausesValidation = false;
            this.btnOk.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(132, 258);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 44);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // EditTaskPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 395);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labTaskName);
            this.Controls.Add(this.labDeadLine);
            this.Controls.Add(this.deadLineField);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditTaskPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labTaskName;
        private System.Windows.Forms.Label labDeadLine;
        private System.Windows.Forms.DateTimePicker deadLineField;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Button btnOk;
    }
}