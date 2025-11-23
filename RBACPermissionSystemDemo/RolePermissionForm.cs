using RBACDemo.DAL;
using RBACDemo.Models;
using System.Windows.Forms;

namespace RBACPermissionSystemDemo
{
    public partial class RolePermissionForm : Form
    {
        #region 字段

        private RoleDAL roleDal = new RoleDAL();
        private PermissionDAL permissionDal = new PermissionDAL();
        private RolePermissionDAL rolePermissionDal = new RolePermissionDAL();

        #endregion 字段

        #region 构造函数

        public RolePermissionForm()
        {
            InitializeComponent();
        }

        #endregion 构造函数

        #region 窗体事件

        private void RolePermissionForm_Load(object sender, System.EventArgs e)
        {
            LoadRoles();
            LoadPermissions();
        }

        #endregion 窗体事件

        #region 方法

        /// <summary>
        /// 加载角色列表
        /// </summary>
        private void LoadRoles()
        {
            listBoxRoles.DataSource = roleDal.GetAllRoles();
            listBoxRoles.DisplayMember = "RoleName";
            listBoxRoles.ValueMember = "RoleId";
        }

        /// <summary>
        /// 加载权限列表
        /// </summary>
        private void LoadPermissions()
        {
            checkedListBoxPermissions.DataSource = permissionDal.GetAllPermissions();
            checkedListBoxPermissions.DisplayMember = "PermissionName";
            checkedListBoxPermissions.ValueMember = "PermissionId";
        }

        /// <summary>
        /// 角色选择变化时，更新权限勾选状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxRoles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdatePermissionChecks();
        }

        /// <summary>
        /// 根据选中的角色，更新权限勾选状态
        /// </summary>
        private void UpdatePermissionChecks()
        {
            if (listBoxRoles.SelectedItem == null) return;
            var role = (Role)listBoxRoles.SelectedItem;
            var selectedIds = rolePermissionDal.GetPermissionsByRole(role.RoleId);
            for (int i = 0; i < checkedListBoxPermissions.Items.Count; i++)
            {
                var perm = (Permission)checkedListBoxPermissions.Items[i];
                checkedListBoxPermissions.SetItemChecked(i, selectedIds.Contains(perm.PermissionId));
            }
        }

        #endregion 方法

        #region 控件事件

        /// <summary>
        /// 保存权限分配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (listBoxRoles.SelectedItem == null) return;
            var role = (Role)listBoxRoles.SelectedItem;
            var allPermissions = permissionDal.GetAllPermissions();

            // 先移除这个角色所有权限
            foreach (var perm in allPermissions)
            {
                rolePermissionDal.RemoveRolePermission(role.RoleId, perm.PermissionId);
            }
            // 再添加已勾选的权限
            foreach (int index in checkedListBoxPermissions.CheckedIndices)
            {
                var perm = (Permission)checkedListBoxPermissions.Items[index];
                rolePermissionDal.AddRolePermission(role.RoleId, perm.PermissionId);
            }
            MessageBox.Show("权限分配已保存！");
            UpdatePermissionChecks();
        }

        #endregion 控件事件
    }
}