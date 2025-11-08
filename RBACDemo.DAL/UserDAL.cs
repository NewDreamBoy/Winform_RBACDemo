using RBACDemo.Models;
using System.Collections.Generic;
using System.Data.SQLite;

namespace RBACDemo.DAL
{
    public class UserDAL
    {
        // 查询所有用户
        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT UserId, UserName, PasswordHash, IsActive FROM Users;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User
                        {
                            UserId = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            PasswordHash = reader.GetString(2),
                            IsActive = reader.GetInt32(3) == 1
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        // 新增用户
        public void AddUser(User user)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Users(UserName, PasswordHash, IsActive) VALUES(@UserName, @PasswordHash, @IsActive);", conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
        }

        // 用户删除
        public void DeleteUser(int userId)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Users WHERE UserId=@UserId;", conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();
            }
        }

        // 用户更新
        public void UpdateUser(User user)
        {
            using (var conn = new SQLiteConnection(Comm.ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Users SET UserName=@UserName, PasswordHash=@PasswordHash, IsActive=@IsActive WHERE UserId=@UserId;", conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                cmd.Parameters.AddWithValue("@IsActive", user.IsActive ? 1 : 0);
                cmd.Parameters.AddWithValue("@UserId", user.UserId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}