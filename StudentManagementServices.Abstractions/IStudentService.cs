using StudentManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementServices.Abstractions
{
    public interface IStudentService
    {
        Task<bool> UpdateStudentAsync(Student student);
        Task<bool> UpdateStudentAsync(List<Student> students);

        Task<DataTable> GetAllStudentsAsync();
        Task<DataTable> DynamicQueryAsync(Student student, DateTime start_date, DateTime end_date);

        Task<bool> DeleteStudentAsync(int id);
        Task<bool> DeleteStudentAsync(List<Student> students);

        Task<bool> InsertStudentAsync(Student student);
        Task<bool> InsertStudentAsync(List<Student> students);
        Task<bool> SaveChangesAsync(DataTable studentstable);
    }
}
