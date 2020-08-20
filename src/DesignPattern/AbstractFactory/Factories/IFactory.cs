using AbstractFactory.t_department;
using AbstractFactory.t_user;

namespace AbstractFactory.Factories
{
    interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
