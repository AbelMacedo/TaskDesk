using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TaskDesk.Models;

namespace TaskDesk.Repositories
{
    internal class UserRepository
    {
        public async Task<User?> LoginAsync(String email, String password)
        {
            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"SELECT Id, Name, Surnames, Email, PasswordHash, CreatedAt FROM Users WHERE Email = @Email";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);

            using var reader = await command.ExecuteReaderAsync();

            if(!await reader.ReadAsync())
                return null;

            var passwordHash = reader.GetString(reader.GetOrdinal("PasswordHash"));

            if(passwordHash != HashPassword(password))
                return null;

            return new User
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Surnames = reader.GetString(reader.GetOrdinal("Surnames")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                PasswordHash = passwordHash,
                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
            };
        }

        public async Task<bool> RegisterAsync(String email, String password, String name, String surnames)
        {
            try
            {
                using var connection = Data.Database.GetConnection();
                await connection.OpenAsync();

                var query = @"INSERT INTO Users (Email, PasswordHash, CreatedAt, Name, Surnames) VALUES (@Email, @PasswordHash, @CreatedAt, @Name, @Surnames)";

                using var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", HashPassword(password));
                command.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surnames", surnames);

                return await command.ExecuteNonQueryAsync() > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private String HashPassword(String password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
