using RBACDemo.DAL;
using System.Windows.Forms;

namespace RBACPermissionSystemDemo
{
    public partial class RolePermissionForm : Form
    {
        private RoleDAL roleDal = new RoleDAL();
        private PermissionDAL permissionDal = new PermissionDAL();
        private RolePermissionDAL rolePermissionDal = new RolePermissionDAL();

        public RolePermissionForm()
        {
            InitializeComponent();
        }

        private void RolePermissionForm_Load(object sender, System.EventArgs e)
        {
            LoadRoles();
            LoadPermissions();
        }

        private void LoadRoles()
        {
            listBoxRoles.DataSource = roleDal.GetAllRoles();
            listBoxRoles.DisplayMember = "RoleName";
            listBoxRoles.ValueMember = "RoleId";
        }

        private void LoadPermissions()
        {
            checkedListBoxPermissions.DataSource = permissionDal.GetAllPermissions();
            checkedListBoxPermissions.DisplayMember = "PermissionName";
            checkedListBoxPermissions.ValueMember = "PermissionId";
        }
    }
}