using RBACDemo.Models;
using System.Data.SQLite;

using System.IO;

namespace RBACDemo.DAL
{
    public static class DbInitializer
    {
        private static string dbFile = "../../database/RBACDemoDB.db";
        private static string connectionString = Comm.ConnectionString;

        public static void Initialize()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string script = @"
CREATE TABLE Users (UserId INTEGER PRIMARY KEY AUTOINCREMENT, UserName TEXT NOT NULL UNIQUE, PasswordHash TEXT NOT NULL, IsActive INTEGER NOT NULL DEFAULT 1);
CREATE TABLE Roles (RoleId INTEGER PRIMARY KEY AUTOINCREMENT, RoleName TEXT NOT NULL UNIQUE, Description TEXT);
CREATE TABLE Permissions (PermissionId INTEGER PRIMARY KEY AUTOINCREMENT, PermissionName TEXT NOT NULL UNIQUE, Description TEXT);
CREATE TABLE UserRoles (UserRoleId INTEGER PRIMARY KEY AUTOINCREMENT, UserId INTEGER NOT NULL, RoleId INTEGER NOT NULL, FOREIGN KEY(UserId) REFERENCES Users(UserId), FOREIGN KEY(RoleId) REFERENCES Roles(RoleId));
CREATE TABLE RolePermissions (RolePermissionId INTEGER PRIMARY KEY AUTOINCREMENT, RoleId INTEGER NOT NULL, PermissionId INTEGER NOT NULL, FOREIGN KEY(RoleId) REFERENCES Roles(RoleId), FOREIGN KEY(PermissionId) REFERENCES Permissions(PermissionId));
";
                    var cmd = new SQLiteCommand(script, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}