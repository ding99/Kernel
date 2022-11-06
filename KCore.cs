namespace Kernel {
    public class KCore {

        public double Add (double a, double b) {
            Console.WriteLine($"-- Addition for {a}, {b}");
            return a + b;
        }

        public double Multiple(double a, double b) {
            Console.WriteLine(($"-- Multiplication for {a}, {b}"));
            return a * b;
        }

    }
}