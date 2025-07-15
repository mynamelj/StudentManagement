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
    //依赖
   
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository ;
        }
        public async Task<bool> DeleteStudentAsync(int id)
        {
            return await _studentRepository.DeleteAsync(id);
        }
        public async Task<bool> DeleteStudentAsync(List<Student> students)
        {
            return await _studentRepository.DeleteAsync(students);
        }

        public async Task<DataTable> DynamicQueryAsync(Student student, DateTime start_date, DateTime end_date)
        {
            return await _studentRepository.DynamicQuery(student, start_date, end_date);
        }

        public async Task<DataTable> GetAllStudentsAsync()
        {
            // 调用仓库方法获取所有学生信息
            return await  _studentRepository.GetAllAsync();
        }

        public async Task<bool> InsertStudentAsync(Student student)
        {
            return await _studentRepository.InsertAsync(student);
        }
        public async Task<bool> InsertStudentAsync(List<Student> students)
        {
            return await _studentRepository.InsertAsync(students);
        }

        public async Task<bool> SaveChangesAsync(DataTable studentstable)
        {
            return await _studentRepository.SaveChangesAsync(studentstable);
        }

        public async Task<bool> UpdateStudentAsync(Student student)
        {
          
            return await _studentRepository.UpdateAsync(student);
        }

        public async Task<bool> UpdateStudentAsync(List<Student> students)
        {
            return await _studentRepository.UpdateAsync(students);
        }
    }
}
