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
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
        }
        public Task<DataTable> DynamicQueryAsync(int? courseId, string courseName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetAllCourseNameAsync()
        {
            var courseNames = await courseRepository.GetAllCourseNameAsync();
            return courseNames.ToList();
            
        }


        public Task<DataTable> GetAllCoursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync(DataTable courseTable)
        {
            throw new NotImplementedException();
        }
    }
}
