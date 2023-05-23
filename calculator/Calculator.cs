namespace calculator
{
    internal class Calculator
    {
        private double A,B;
        public Calculator(double a, double b) 
        {
            this.A = a; this.B = b;
        }


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
