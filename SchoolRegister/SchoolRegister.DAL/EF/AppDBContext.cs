using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.DAL.EF
{
    class AppDBContext
    {
        private readonly ConnectionStringDto _connectionStringDto;

        public AppDBContext(ConnectionStringDto connectionString)
        {
            _connectionStringDto = connectionString;
        }
        protected override void OnConfiguring()
        {

        }
    }
}
