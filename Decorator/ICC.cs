using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class ICC : ImpostoDoProduto
    {
        public ICC()
        {
        }

        public ICC(ImpostoDoProduto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Produto produto) => (produto.Valor * 0.05) + CalcularOutroImposto(produto);
    }
}