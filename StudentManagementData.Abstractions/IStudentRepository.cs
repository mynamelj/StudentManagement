using StudentManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementData.Abstractions
{
    public interface IStudentRepository
    {
        Task<DataTable> GetAllAsync(); // 返回全部学生信息
        Task<DataTable> DynamicQuery(Student student, DateTime start_date, DateTime end_date);
        Task<bool> InsertAsync(Student student); // 插入新学生
        Task<bool> InsertAsync(List<Student> students);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteAsync(List<Student> students);
        Task<bool> UpdateAsync(Student student);
        Task<bool> UpdateAsync(List<Student> students);

        Task<bool> SaveChangesAsync(DataTable studentstable);
    }
}