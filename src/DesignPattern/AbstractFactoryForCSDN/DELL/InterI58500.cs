using System;

namespace AbstractFactoryForCSDN.DELL
{
    public class InterI58500 : ICentralProcessingUnit
    {
        public void ExecutionProgram()
        {
            Console.WriteLine("DELL电脑：I585006核新处理器，跑代码稳稳的幸福！");
        }
    }
}
