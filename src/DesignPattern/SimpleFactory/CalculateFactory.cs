using SimpleFactory.operations;

namespace SimpleFactory
{
    public class CalculateFactory
    {
            public static Operation GetCalculate(string op)
            {
                Operation calculate = null;
                switch (op)
                {
                    case "+":
                        calculate = new OperationAdd();
                        break;
                    case "-":
                        calculate = new OperationSub();
                        break;
                    case "*":
                        calculate = new OperationMul();
                        break;
                    case "/":
                        calculate = new OperationDiv();
                        break;
                    default:
                        calculate = new OperationAdd();
                        break;
                }
                return calculate;
            }
    }
}
