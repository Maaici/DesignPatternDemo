using System;

namespace SimpleFactory.operations
{
    public class OperationDiv : Operation
    {
        public override double GetResult(double numberA, double numberB)
        {
            if (numberB == 0) {
                throw new Exception(" 除数不能为 0 ！");
            }
            return numberA / numberB;
        }
    }
}
