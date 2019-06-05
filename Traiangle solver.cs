using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public static class Traiangle_solver
    {
public static string Analyze(int tr1, int tr2, int tr3)
        {
            string triangleType= string.Empty ;
            if (tr1 > 0 && tr2 > 0 && tr3 > 0)
            {
                if ((tr1 + tr2) > tr3 && (tr2 + tr3) > tr1 && (tr1 + tr3) > tr2)
                {
                    if (tr1 == tr2 && tr1 == tr3)
                    {
                        triangleType = "Equilateral triangle";
                    }
                    else if (tr1 == tr2 || tr1 == tr3 || tr2 == tr3)
                    {

                        triangleType = "Isosceles triangle";
                    }
                    else
                    {
                        triangleType = "Scalene triangle";
                    }
                }
                else
                {
                    triangleType="Triangle cannot be formed";
                

                }

            }
            else
            {
                triangleType="Invalid triangle dimensions";
            }

            
            return triangleType;
        }
    }
}
