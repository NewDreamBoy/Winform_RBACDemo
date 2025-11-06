using RBACDemo.DAL;
using RBACDemo.Models;
using System;
using System.Windows.Forms;

namespace RBACPermissionSystemDemo
{
    public partial class UserForm : Form
    {
        private UserDAL userDal = new UserDAL();

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_UserName.Text)) return;

            var user = new User
            {
                UserName = txt_UserName.Text.Trim(),
                PasswordHash = txt_Password.Text.Trim(), // 真实系统应加密
                IsActive = chk_Active.Checked
            };

            userDal.AddUser(user);
            LoadUsers();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int userId = (int)dataGridView1.CurrentRow.Cells["UserId"].Value;

            var user = new User
            {
                UserId = userId,
                UserName = txt_UserName.Text.Trim(),
                PasswordHash = txt_Password.Text.Trim(),
                IsActive = chk_Active.Checked
            };
            userDal.UpdateUser(user);
            LoadUsers();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int userId = (int)dataGridView1.CurrentRow.Cells["UserId"].Value;
            userDal.DeleteUser(userId);
            LoadUsers();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            txt_UserName.Text = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
            txt_Password.Text = dataGridView1.CurrentRow.Cells["PasswordHash"].Value.ToString();
            var cellValue = dataGridView1.CurrentRow.Cells["IsActive"].Value;
            if (cellValue is bool)
                chk_Active.Checked = (bool)cellValue;
            else if (cellValue is int)
                chk_Active.Checked = ((int)cellValue) == 1;
            else
                chk_Active.Checked = false;

        }

        private void LoadUsers()
        {
            dataGridView1.DataSource = userDal.GetAllUsers();
        }
    }
}