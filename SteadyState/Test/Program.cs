using System.Numerics;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimplePowerSystem();
        }

        static void SimplePowerSystem()
        {
            var Zbr = new Complex(10, 20);
            var Ybr = 1 / Zbr;
            var Bsh = 0.135 * Math.Pow(10, -3);

            var Yown = Ybr + Complex.ImaginaryOne * Bsh / 2;

            var Rcalc = Yown.Real / (Math.Pow(Yown.Real, 2) + Math.Pow(Yown.Imaginary, 2));
            var Xcalc = Yown.Imaginary / (Math.Pow(Yown.Real, 2) + Math.Pow(Yown.Imaginary, 2));

            var Uinit = new Complex(110 * 1000, 0);
            var maxError = 0.003 * 1000;


        }

        static Complex GetError(Complex yOwn, Complex yBr, Complex s, Complex u, Complex uBase)
        {
            var real = yOwn.Real * u.Real + yOwn.Imaginary * u.Imaginary - yBr.Real * uBase.Magnitude + ((s.Real * u.Real + s.Imaginary * u.Imaginary) / (Math.Pow(u.Real, 2) + Math.Pow(u.Imaginary, 2)));
            var im = - yOwn.Imaginary * u.Real + yOwn.Real * u.Imaginary + yBr.Imaginary * uBase.Magnitude + ((s.Real * u.Imaginary - s.Imaginary * u.Real) / (Math.Pow(u.Real, 2) + Math.Pow(u.Imaginary, 2)));
        }
    }
}
