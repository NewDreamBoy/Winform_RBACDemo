using RBACDemo.Models;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RBACDemo.DAL
{
    public class UserRoleDAL
    {
        // 获取某用户的所有角色ID
        public List<int> GetRolesByUser(int userId)
        {
            var roleIds = new List<int>();
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT RoleId FROM UserRoles WHERE UserId=@UserId;", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roleIds.Add(reader.GetInt32(0));
                    }
                }
            }
            return roleIds;
        }

        // 给用户分配角色（新增关联）
        public void AddUserRole(int userId, int roleId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO UserRoles(UserId, RoleId) VALUES(@UserId, @RoleId);", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.ExecuteNonQuery();
            }
        }

        // 移除用户某个角色关联
        public void RemoveUserRole(int userId, int roleId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM UserRoles WHERE UserId=@UserId AND RoleId=@RoleId;", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.ExecuteNonQuery();
            }
        }

        // 移除某用户所有角色（用于先清空再保存的场景）
        public void RemoveAllRolesForUser(int userId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM UserRoles WHERE UserId=@UserId;", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }
        }

        // 获取某角色下所有用户ID（备用）
        public List<int> GetUsersByRole(int roleId)
        {
            var userIds = new List<int>();
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT UserId FROM UserRoles WHERE RoleId=@RoleId;", conn);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userIds.Add(reader.GetInt32(0));
                    }
                }
            }
            return userIds;
        }
    }
}