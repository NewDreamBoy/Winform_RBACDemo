namespace RBACPermissionSystemDemo
{
    partial class UserForm
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
            this.tlp_CoreLayoutArea = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_TopLayoutArea = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.chk_Active = new System.Windows.Forms.CheckBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tlp_CoreLayoutArea.SuspendLayout();
            this.tlp_TopLayoutArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_CoreLayoutArea
            // 
            this.tlp_CoreLayoutArea.ColumnCount = 1;
            this.tlp_CoreLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_CoreLayoutArea.Controls.Add(this.tlp_TopLayoutArea, 0, 0);
            this.tlp_CoreLayoutArea.Controls.Add(this.dataGridView1, 0, 1);
            this.tlp_CoreLayoutArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_CoreLayoutArea.Location = new System.Drawing.Point(0, 0);
            this.tlp_CoreLayoutArea.Name = "tlp_CoreLayoutArea";
            this.tlp_CoreLayoutArea.RowCount = 2;
            this.tlp_CoreLayoutArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_CoreLayoutArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_CoreLayoutArea.Size = new System.Drawing.Size(933, 638);
            this.tlp_CoreLayoutArea.TabIndex = 0;
            // 
            // tlp_TopLayoutArea
            // 
            this.tlp_TopLayoutArea.ColumnCount = 10;
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_TopLayoutArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_TopLayoutArea.Controls.Add(this.lbl_Password, 2, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.txt_Password, 3, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.lbl_UserName, 0, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.txt_UserName, 1, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.btn_Refresh, 8, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.btn_Delete, 7, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.btn_Update, 6, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.btn_Add, 5, 0);
            this.tlp_TopLayoutArea.Controls.Add(this.chk_Active, 4, 0);
            this.tlp_TopLayoutArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TopLayoutArea.Location = new System.Drawing.Point(3, 3);
            this.tlp_TopLayoutArea.Name = "tlp_TopLayoutArea";
            this.tlp_TopLayoutArea.RowCount = 1;
            this.tlp_TopLayoutArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_TopLayoutArea.Size = new System.Drawing.Size(927, 57);
            this.tlp_TopLayoutArea.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(927, 569);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserName.Location = new System.Drawing.Point(60, 17);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(96, 23);
            this.txt_UserName.TabIndex = 0;
            // 
            // chk_Active
            // 
            this.chk_Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_Active.AutoSize = true;
            this.chk_Active.Location = new System.Drawing.Point(327, 18);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(75, 21);
            this.chk_Active.TabIndex = 1;
            this.chk_Active.Text = "是否启用";
            this.chk_Active.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Location = new System.Drawing.Point(419, 17);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "新增";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(6, 20);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(44, 17);
            this.lbl_UserName.TabIndex = 3;
            this.lbl_UserName.Text = "用户名";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Location = new System.Drawing.Point(519, 17);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Location = new System.Drawing.Point(619, 17);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Location = new System.Drawing.Point(719, 17);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "刷新";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Location = new System.Drawing.Point(203, 17);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(116, 23);
            this.txt_Password.TabIndex = 7;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(163, 20);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(32, 17);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "密码";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 638);
            this.Controls.Add(this.tlp_CoreLayoutArea);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tlp_CoreLayoutArea.ResumeLayout(false);
            this.tlp_TopLayoutArea.ResumeLayout(false);
            this.tlp_TopLayoutArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_CoreLayoutArea;
        private System.Windows.Forms.TableLayoutPanel tlp_TopLayoutArea;
        private System.Windows.Forms.CheckBox chk_Active;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
    }
}