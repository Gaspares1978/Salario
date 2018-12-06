using System;
using System.Globalization;

namespace Teste2
{
    class Funcionario
    {
       public  String Nome;
       public  Double salarioBruto;
       public  Double Desconto;
         public  double salarioLiquido()
        {
           return  salarioBruto - Desconto;
            
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome 
                + "="+ "$" 
                + salarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
