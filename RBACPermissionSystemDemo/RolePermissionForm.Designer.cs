namespace RBACPermissionSystemDemo
{
    partial class RolePermissionForm
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
            this.listBoxRoles = new System.Windows.Forms.ListBox();
            this.checkedListBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listBoxRoles
            // 
            this.listBoxRoles.FormattingEnabled = true;
            this.listBoxRoles.ItemHeight = 12;
            this.listBoxRoles.Location = new System.Drawing.Point(12, 62);
            this.listBoxRoles.Name = "listBoxRoles";
            this.listBoxRoles.Size = new System.Drawing.Size(266, 556);
            this.listBoxRoles.TabIndex = 0;
            // 
            // checkedListBoxPermissions
            // 
            this.checkedListBoxPermissions.FormattingEnabled = true;
            this.checkedListBoxPermissions.Location = new System.Drawing.Point(439, 62);
            this.checkedListBoxPermissions.Name = "checkedListBoxPermissions";
            this.checkedListBoxPermissions.Size = new System.Drawing.Size(438, 564);
            this.checkedListBoxPermissions.TabIndex = 1;
            // 
            // RolePermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 638);
            this.Controls.Add(this.checkedListBoxPermissions);
            this.Controls.Add(this.listBoxRoles);
            this.Name = "RolePermissionForm";
            this.Text = "RolePermissionForm";
            this.Load += new System.EventHandler(this.RolePermissionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRoles;
        private System.Windows.Forms.CheckedListBox checkedListBoxPermissions;
    }
}