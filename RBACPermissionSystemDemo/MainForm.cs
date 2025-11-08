using System;
using System.Windows.Forms;

namespace RBACPermissionSystemDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void Btn_UserManagement_Click(object sender, EventArgs e)
        {
            using (var from = new UserForm())
            {
                from.ShowDialog();
            }
        }

        private void Btn_RoleManage_Click(object sender, EventArgs e)
        {
            using (var from = new RoleForm())
            {
                from.ShowDialog();
            }
        }
    }
}