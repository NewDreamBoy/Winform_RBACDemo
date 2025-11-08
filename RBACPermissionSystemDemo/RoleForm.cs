using RBACDemo.DAL;
using RBACDemo.Models;
using System;
using System.Windows.Forms;

namespace RBACPermissionSystemDemo
{
    public partial class RoleForm : Form
    {
        #region 字段

        private RoleDAL _roleDal = new RoleDAL();

        #endregion 字段

        #region 构造函数

        public RoleForm()
        {
            InitializeComponent();
        }

        #endregion 构造函数

        #region 窗体事件

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        #endregion 窗体事件

        #region 控件事件

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Role.Text)) return;

            var role = new Role
            {
                RoleName = txt_Role.Text.Trim(),
                Description = txt_Description.Text.Trim()
            };

            _roleDal.AddRole(role);
            LoadRoles();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int roleId = (int)dataGridView1.CurrentRow.Cells["RoleId"].Value;

            var role = new Role
            {
                RoleId = roleId,
                RoleName = txt_Role.Text.Trim(),
                Description = txt_Description.Text.Trim()
            };
            _roleDal.UpdateRole(role);
            LoadRoles();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int roleId = (int)dataGridView1.CurrentRow.Cells["RoleId"].Value;
            _roleDal.DeleteRole(roleId);
            LoadRoles();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            txt_Role.Text = dataGridView1.CurrentRow.Cells["RoleName"].Value.ToString();
            txt_Description.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        #endregion 控件事件

        #region 方法

        private void LoadRoles()
        {
            dataGridView1.DataSource = _roleDal.GetAllRoles();
        }

        #endregion 方法
    }
}