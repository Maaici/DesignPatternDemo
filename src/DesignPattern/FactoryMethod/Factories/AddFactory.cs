using FactoryMethod.operations;

namespace FactoryMethod.Factories
{
    public class AddFactory : IFactory
    {
        public Operation GetOperation()
        {
            return new OperationAdd();
        }
    }
}
