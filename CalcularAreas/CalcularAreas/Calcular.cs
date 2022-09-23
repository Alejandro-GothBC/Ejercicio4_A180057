using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularAreas
{
    public class Calcular
    {
        public decimal N1 { get; set; }
        public decimal N2 { get; set; }
        
        public decimal AreaCuadrado()
        {
            return N1 * N1;
        }

        public decimal AreaTriangulo()
        {
            return N1 * N2 / 2; 
        }

        public decimal AreaCirculo()
        {
            decimal Pi = 3.141592M;
            return Pi * (N1 * N1);
        }
    }
}