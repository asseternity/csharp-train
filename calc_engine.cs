namespace Calculator
{
    class CalcEngine
    {
        public static float Adding(float op1, float op2)
        {
            float result = op1 + op2;
            return result;
        }
        public static float Subtracting(float op1, float op2)
        {
            float result = op1 - op2;
            return result;
        }
        public static float Multiplying(float op1, float op2)
        {
            float result = op1 * op2;
            return result;
        }
        public static float Dividing(float op1, float op2)
        {
            float result = op1 / op2;
            return result;
        }
    }
}