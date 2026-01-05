using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDesk.Models;

namespace TaskDesk.Repositories
{
    internal class TaskRepository
    {
        public async Task<List<TaskItem>> GetAllByUserAsync(int userId)
        {
            var tasks = new List<TaskItem>();

            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"SELECT Id, Title, Description, Priority, DueDate, UserId, Completed FROM Tasks WHERE UserId = @UserId AND Completed = 0";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserId", userId);

            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                tasks.Add(new Models.TaskItem
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Title = reader.GetString(reader.GetOrdinal("Title")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                    Priority = reader.GetInt32(reader.GetOrdinal("Priority")),
                    DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate")),
                    UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                    Completed = reader.GetBoolean(reader.GetOrdinal("Completed"))
                });
            }

            return tasks;
        }
      
        public async Task<List<TaskItem>> GetCompletedTasksAsync(int userId)
        {
            var tasks = new List<TaskItem>();

            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"SELECT Id, Title, Description, Priority, DueDate, UserId, Completed FROM Tasks WHERE UserId = @UserId AND Completed = 1";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserId", userId);

            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                tasks.Add(new Models.TaskItem
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Title = reader.GetString(reader.GetOrdinal("Title")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                    Priority = reader.GetInt32(reader.GetOrdinal("Priority")),
                    DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DueDate")),
                    UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                    Completed = reader.GetBoolean(reader.GetOrdinal("Completed"))
                });
            }

            return tasks;

        }

        public async Task<TaskItem> AddAsync(TaskItem task)
        {
            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"INSERT INTO Tasks (Title, Description, Priority, DueDate, UserId, Completed) VALUES (@Title, @Description, @Priority, @DueDate, @UserId, 0); SELECT SCOPE_IDENTITY();";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", task.Title);
            command.Parameters.AddWithValue("@Description", task.Description);
            command.Parameters.AddWithValue("@Priority", task.Priority);
            command.Parameters.AddWithValue("@DueDate", (object?)task.DueDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@UserId", task.UserId);

            var result = await command.ExecuteScalarAsync();
            task.Id = Convert.ToInt32(result);

            return task;
        }

        public async Task<TaskItem> UpdateAsync(TaskItem task)
        {
            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"UPDATE Tasks SET Title = @Title, Description = @Description, Priority = @Priority, DueDate = @DueDate WHERE Id = @Id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", task.Title);
            command.Parameters.AddWithValue("@Description", task.Description);
            command.Parameters.AddWithValue("@Priority", task.Priority);
            command.Parameters.AddWithValue("@DueDate", (object?)task.DueDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@Id", task.Id);

            await command.ExecuteNonQueryAsync();
            return task;
        }

        public async Task MarkAsCompletedAsync(int taskId)
        {
            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"UPDATE Tasks SET Completed = 1 WHERE Id = @Id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", taskId);

            await command.ExecuteNonQueryAsync();
        }

        public async Task MarkAsIncompleteAsync(int taskId)
        {
            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"UPDATE Tasks SET Completed = 0 WHERE Id = @Id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", taskId);

            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int taskId)
        {
            using var connection = Data.Database.GetConnection();
            await connection.OpenAsync();

            var query = @"DELETE FROM Tasks WHERE Id = @Id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", taskId);

            await command.ExecuteNonQueryAsync();
        }
    }
}
