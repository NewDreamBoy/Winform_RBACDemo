using RBACDemo.Models;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RBACDemo.DAL
{
    public class RolePermissionDAL
    {
        // 获取某角色所有权限ID
        public List<int> GetPermissionsByRole(int roleId)
        {
            var permissionIds = new List<int>();
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT PermissionId FROM RolePermissions WHERE RoleId=@RoleId;", conn);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        permissionIds.Add(reader.GetInt32(0));
                    }
                }
            }
            return permissionIds;
        }

        // 给角色分配权限（增加关联）
        public void AddRolePermission(int roleId, int permissionId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO RolePermissions(RoleId, PermissionId) VALUES(@RoleId, @PermissionId);", conn);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                cmd.ExecuteNonQuery();
            }
        }

        // 移除角色某权限关联
        public void RemoveRolePermission(int roleId, int permissionId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM RolePermissions WHERE RoleId=@RoleId AND PermissionId=@PermissionId;", conn);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}