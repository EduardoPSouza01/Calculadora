using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    internal class CalculadoraLogica
    {
        public double Operando1 { get; set; } 
        public double Operando2 { get; set; }
        public string Operacao { get; set; } = string.Empty;

        public double Calcular()
        {
            return Operacao switch
            {
                "+" => Operando1 + Operando2,
                "-" => Operando1 - Operando2,
                "x" => Operando1 * Operando2,
                "÷" => Operando2 != 0 ? Operando1 / Operando2 : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Operação inválida"),
            };
        }

    }
}
