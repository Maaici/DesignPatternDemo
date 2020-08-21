namespace AbstractFactory.Factories
{
    interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
