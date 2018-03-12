
namespace ASP_1
{
    public class Calculate
    {
        public int add(int Value1, int Value2)
        {
            return Value1 + Value2;
        }
        public int subtract(int Value1, int Value2)
        {
            return Value1 - Value2;
        }
        public int multiply(int Value1, int Value2)
        {
            return Value1 * Value2;
        }
        public double divide(int Value1, int Value2)
        {
            return Value1 / Value2;
        }
        public string percentage(int Value1, int Value2)
        {
            Value1 = Value1 * 100;

            return divide(Value1, Value2) + "%";
        }
    }
}