using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementData.Abstractions
{
    public interface IDbConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
