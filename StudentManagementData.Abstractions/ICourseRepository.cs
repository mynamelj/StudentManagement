using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementData.Abstractions
{
    public interface ICourseRepository
    {
        /// <summary>
        /// 获取所有课程信息
        /// </summary>
        /// <returns>返回包含所有课程信息的 DataTable</returns>
        Task<DataTable> GetAllCoursesAsync();
        /// <summary>
        /// 动态查询课程信息
        /// </summary>
        /// <param name="courseId">课程ID</param>
        /// <param name="courseName">课程名称</param>
        /// <returns>返回符合条件的课程信息 DataTable</returns>
        Task<DataTable> DynamicQueryAsync(int? courseId, string courseName);
        /// <summary>
        /// 保存课程变更
        /// </summary>
        /// <param name="courseTable">包含课程信息的 DataTable</param>
        /// <returns>返回是否保存成功</returns>
        Task<bool> SaveChangesAsync(DataTable courseTable);
        Task<List<string>> GetAllCourseNameAsync();
    }
}
