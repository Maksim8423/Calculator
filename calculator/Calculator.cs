namespace calculator
{
    internal class Calculator
    {

        public double A { get; set; }
        public double B { get; set; }

        public double Plus()
        {
            return A + B;
        }
        public double Minus()
        {
            return A - B;
        }
        public double Multiplication()
        {
            return A * B;
        }
        public double Division()
        {
            return A / B;
        }

    }
}
