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

            var query = @"SELECT Id, Title, Description, Priority, DueDate, UserId, Completed FROM Tasks WHERE UserId = @UserId";

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
    }
}
