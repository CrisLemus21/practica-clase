using clase102.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase102.Negocio
{
    class ClsOperaciones
    {
        public double suma(operacion Suma)
        {
            Suma.Resultado = Suma.Dato1 + Suma.Dato2;

            return Suma.Resultado;
        }
        public double resta(operacion Resta)
        {
            Resta.Resultado = Resta.Dato1 - Resta.Dato2;

            return Resta.Resultado;
        }
        public double divicion(operacion divi)
        {
            divi.Resultado = divi.Dato1 / divi.Dato2;

            return divi.Resultado;
        }
        public double multiplicacion(operacion multi)
        {
            multi.Resultado = multi.Dato1 * multi.Dato2;

            return multi.Resultado;
        }



    }
}
