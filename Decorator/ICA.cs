namespace DesignPatterns.Decorator
{
    public class ICA : ImpostoDoProduto
    {
        public ICA()
        {
        }

        public ICA(ImpostoDoProduto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Produto produto) => (produto.Valor * 0.15) + CalcularOutroImposto(produto);
    }
}