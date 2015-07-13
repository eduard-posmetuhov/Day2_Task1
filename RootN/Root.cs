using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootN
{
    public class Root
    {
        public static double FindRoot(double N, int n, int e)
        {
            if (n % 2 == 0 && N < 0)
                throw new InvalidOperationException("Нет решения");
            if (n<0)
                throw new ArgumentException("Степень должна быть положительная");
            double x=2,nx=1;
            double eps = Math.Pow(10,-e);
            while (Math.Abs(x - nx) > eps)
            {
                 x = nx;
                 nx = ((n-1)*nx+N/Math.Pow(nx,n-1))/n;
                 
            }
            return x;            
        }
    }
}
