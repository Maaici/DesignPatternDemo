using System;

namespace FactoryMethod.operations
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0) {
                throw new Exception(" 除数不能为 0 ！");
            }
            return NumberA / NumberB;
        }
    }
}
