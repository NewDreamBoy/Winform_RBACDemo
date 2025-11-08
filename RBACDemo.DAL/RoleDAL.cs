using RBACDemo.Models;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RBACDemo.DAL
{
    public class RoleDAL
    {
        // 获取全部角色
        public List<Role> GetAllRoles()
        {
            var roles = new List<Role>();
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT RoleId, RoleName, Description FROM Roles;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var role = new Role
                        {
                            RoleId = reader.GetInt32(0),
                            RoleName = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2)
                        };
                        roles.Add(role);
                    }
                }
            }
            return roles;
        }

        // 新增角色
        public void AddRole(Role role)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Roles(RoleName, Description) VALUES(@RoleName, @Description);", conn);
                cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                cmd.Parameters.AddWithValue("@Description", role.Description ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        // 删除角色
        public void DeleteRole(int roleId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Roles WHERE RoleId=@RoleId;", conn);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                cmd.ExecuteNonQuery();
            }
        }

        // 更新角色
        public void UpdateRole(Role role)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Roles SET RoleName=@RoleName, Description=@Description WHERE RoleId=@RoleId;", conn);
                cmd.Parameters.AddWithValue("@RoleName", role.RoleName);
                cmd.Parameters.AddWithValue("@Description", role.Description ?? "");
                cmd.Parameters.AddWithValue("@RoleId", role.RoleId);
                cmd.ExecuteNonQuery();
            }
        }

        // 通过ID获取角色
        public Role GetRoleById(int roleId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT RoleId, RoleName, Description FROM Roles WHERE RoleId=@RoleId;", conn);
                cmd.Parameters.AddWithValue("@RoleId", roleId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Role
                        {
                            RoleId = reader.GetInt32(0),
                            RoleName = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2)
                        };
                    }
                }
            }
            return null;
        }
    }
}