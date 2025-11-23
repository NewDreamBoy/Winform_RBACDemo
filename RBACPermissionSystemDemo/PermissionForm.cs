using RBACDemo.DAL;
using RBACDemo.Models;
using System.Windows.Forms;

namespace RBACPermissionSystemDemo
{
    
    /// <summary>
    /// 权限管理
    /// </summary>
    public partial class PermissionForm : Form
    {
        #region 字段

        private PermissionDAL _permissionDal = new PermissionDAL();

        #endregion 字段

        #region 构造函数

        public PermissionForm()
        {
            InitializeComponent();
        }

        #endregion 构造函数

        #region 窗体事件

        private void PermissionForm_Load(object sender, System.EventArgs e)
        {
            LoadPermissions();
        }

        #endregion 窗体事件

        #region 控件事件

        private void Btn_Add_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PermissionName.Text)) return;

            var permission = new Permission
            {
                PermissionName = txt_PermissionName.Text.Trim(),
                Description = txt_Description.Text.Trim()
            };
            _permissionDal.AddPermission(permission);
            LoadPermissions();
        }

        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int permissionId = (int)dataGridView1.CurrentRow.Cells["PermissionId"].Value;

            var permission = new Permission
            {
                PermissionId = permissionId,
                PermissionName = txt_PermissionName.Text.Trim(),
                Description = txt_Description.Text.Trim()
            };
            _permissionDal.UpdatePermission(permission);
            LoadPermissions();
        }

        private void Btn_Delete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int permissionId = (int)dataGridView1.CurrentRow.Cells["PermissionId"].Value;
            _permissionDal.DeletePermission(permissionId);
            LoadPermissions();
        }

        private void Btn_Refresh_Click(object sender, System.EventArgs e)
        {
            LoadPermissions();
        }

        private void DataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            txt_PermissionName.Text = dataGridView1.CurrentRow.Cells["PermissionName"].Value.ToString();
            txt_Description.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        #endregion 控件事件

        #region 方法

        private void LoadPermissions()
        {
            dataGridView1.DataSource = _permissionDal.GetAllPermissions();
        }

        #endregion 方法
    }
}