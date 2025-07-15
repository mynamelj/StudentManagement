using StudentManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementData.Abstractions
{
    public interface IScoreRepository
    {
        Task<DataTable> GetAllScoresAsync();
        Task<DataTable> DynamicQueryAsync(int? studentId, string cname, int? minScore, int? maxScore);
        Task<bool> SaveChangesAsync(DataTable scoreTable);
        Task<bool> UpdateScoreAsync(Score score);
        Task<bool> UpdateScoreAsync(List<Score> scores);
        Task<bool> DeleteScoreAsync(int studentId, int courseId);
        Task<bool> DeleteScoreAsync(List<Score> scores);
        Task<bool> InsertScoreAsync(Score score);
        Task<bool> InsertScoreAsync(List<Score> scores);

    }
}