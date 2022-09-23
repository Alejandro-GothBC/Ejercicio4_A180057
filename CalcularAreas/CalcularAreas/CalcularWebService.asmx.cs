using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Services;

namespace CalcularAreas
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        /// <summary>
        /// Método que solicita la logitud del lado de un cuadrado y devuelve su área
        /// </summary>
        /// <param name="Lado">Decimal</param>
        /// <returns>Área del cuadrado</returns>
        [WebMethod(Description ="Método que devuelve el área de un cuadrado con base en la longitud de un lado.")]
        public decimal AreaCuadrado(decimal Lado)
        {
            Calcular c = new Calcular();
            c.N1 = Lado;
            return c.AreaCuadrado();
        }

        /// <summary>
        /// Método que solicita la base y la altura de un triángulo
        /// </summary>
        /// <param name="Base">Decimal</param>
        /// <param name="Altura">Decimal</param>
        /// <returns>Área del triángulo</returns>
        [WebMethod(Description ="Método que devuelve el área de un triángulo con la longitud de la base y la altura.")]
        public decimal AreaTriangulo(decimal Base, decimal Altura)
        {
            Calcular c = new Calcular();
            c.N1 = Base;
            c.N2 = Altura;
            return c.AreaTriangulo();
        }

        /// <summary>
        /// Método que solicita el radio de un círculo
        /// </summary>
        /// <param name="Radio">Decimal</param>
        /// <returns>Área del círculo</returns>
        [WebMethod(Description ="Método que devuelve el área de un círculo con base en el radio.")]
        public decimal AreaCirculo(decimal Radio)
        {
            Calcular c = new Calcular();
            c.N1 = Radio;
            return c.AreaCirculo();
        }
    }
}
