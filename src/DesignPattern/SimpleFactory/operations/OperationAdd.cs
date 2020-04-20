namespace SimpleFactory.operations
{
    public class OperationAdd : Operation
    {
        public override double GetResult(double numberA, double numberB)
        {
            return numberA + numberB;
        }
    }
}
