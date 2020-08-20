using AbstractFactory.t_department;
using AbstractFactory.t_user;

namespace AbstractFactory.Factories
{
    public class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}
