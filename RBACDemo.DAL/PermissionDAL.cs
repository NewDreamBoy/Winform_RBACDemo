using RBACDemo.Models;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RBACDemo.DAL
{
    public class PermissionDAL
    {
        public List<Permission> GetAllPermissions()
        {
            var permissions = new List<Permission>();
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT PermissionId, PermissionName, Description FROM Permissions;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var p = new Permission
                        {
                            PermissionId = reader.GetInt32(0),
                            PermissionName = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? "" : reader.GetString(2)
                        };
                        permissions.Add(p);
                    }
                }
            }
            return permissions;
        }

        public void AddPermission(Permission permission)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Permissions(PermissionName, Description) VALUES(@PermissionName, @Description);", conn);
                cmd.Parameters.AddWithValue("@PermissionName", permission.PermissionName);
                cmd.Parameters.AddWithValue("@Description", permission.Description ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePermission(Permission permission)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Permissions SET PermissionName=@PermissionName, Description=@Description WHERE PermissionId=@PermissionId;", conn);
                cmd.Parameters.AddWithValue("@PermissionName", permission.PermissionName);
                cmd.Parameters.AddWithValue("@Description", permission.Description ?? "");
                cmd.Parameters.AddWithValue("@PermissionId", permission.PermissionId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePermission(int permissionId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Permissions WHERE PermissionId=@PermissionId;", conn);
                cmd.Parameters.AddWithValue("@PermissionId", permissionId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}