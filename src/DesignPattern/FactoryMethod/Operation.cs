namespace FactoryMethod
{
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public virtual double GetResult() {
            return 0;
        }
    }
}
