namespace RBACPermissionSystemDemo
{
    partial class MainForm
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
            this.btn_UserManagement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RoleManage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.Location = new System.Drawing.Point(24, 34);
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Size = new System.Drawing.Size(75, 23);
            this.btn_UserManagement.TabIndex = 0;
            this.btn_UserManagement.Text = "用户管理";
            this.btn_UserManagement.UseVisualStyleBackColor = true;
            this.btn_UserManagement.Click += new System.EventHandler(this.Btn_UserManagement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RoleManage);
            this.groupBox1.Controls.Add(this.btn_UserManagement);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_RoleManage
            // 
            this.btn_RoleManage.Location = new System.Drawing.Point(125, 34);
            this.btn_RoleManage.Name = "btn_RoleManage";
            this.btn_RoleManage.Size = new System.Drawing.Size(75, 23);
            this.btn_RoleManage.TabIndex = 1;
            this.btn_RoleManage.Text = "角色管理";
            this.btn_RoleManage.UseVisualStyleBackColor = true;
            this.btn_RoleManage.Click += new System.EventHandler(this.Btn_RoleManage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UserManagement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_RoleManage;
    }
}