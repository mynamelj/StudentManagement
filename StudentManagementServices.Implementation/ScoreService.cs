using StudentManagement.Core.Models;
using StudentManagementData.Abstractions;
using StudentManagementServices.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementServices.Implementation
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _scoreRepository;

        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public async Task<bool> DeleteScoreAsync(int studentId, int courseId)
        {
            return await _scoreRepository.DeleteScoreAsync(studentId, courseId);
        }

        public async Task<bool> DeleteScoreAsync(List<Score> scores)
        {
            return await _scoreRepository.DeleteScoreAsync(scores);
        }

        public async Task<DataTable> DynamicQueryAsync(int? studentId, string cname, int? minScore, int? maxScore)
        {
            return await _scoreRepository.DynamicQueryAsync(studentId, cname, minScore, maxScore);
        }

        public async Task<DataTable> GetAllScoresAsync()
        {
            return await _scoreRepository.GetAllScoresAsync();
        }

        public async Task<bool> InsertScoreAsync(Score score)
        {
            return await _scoreRepository.InsertScoreAsync(score);
        }

        public async Task<bool> InsertScoreAsync(List<Score> scores)
        {
            return await _scoreRepository.InsertScoreAsync(scores);
        }

        public async Task<bool> SaveChangesAsync(DataTable scoreTable)
        {
            return await _scoreRepository.SaveChangesAsync(scoreTable);
        }

        public async Task<bool> UpdateScoreAsync(Score score)
        {
            return await _scoreRepository.UpdateScoreAsync(score);
        }

        public async Task<bool> UpdateScoreAsync(List<Score> scores)
        {
            return await _scoreRepository.UpdateScoreAsync(scores);
        }
    }
}