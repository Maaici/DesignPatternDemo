

using FactoryMethod.operations;

namespace FactoryMethod.Factories
{
    public class SubFactory : IFactory
    {
        public Operation GetOperation()
        {
            return new OperationSub();
        }
    }
}
