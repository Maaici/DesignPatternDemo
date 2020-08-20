using AbstractFactory.t_department;
using AbstractFactory.t_user;
using System;

namespace AbstractFactory.Factories
{
    public class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}
