namespace Lab16_NapChongToanTu
{
    public class Fraction
    {
        int Numerator;
        int Denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public void Show()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }


        public static Fraction operator +(Fraction f1, Fraction f2)
        {

        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {

        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {

        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {

        }

        public static Fraction operator ==(Fraction f1, Fraction f2)
        {

        }

        public static Fraction operator !=(Fraction f1, Fraction f2)
        {

        }
    }
}
