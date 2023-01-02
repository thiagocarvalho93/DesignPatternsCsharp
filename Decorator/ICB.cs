namespace DesignPatterns.Decorator
{
    public class ICB : ImpostoDoProduto
    {
        public ICB()
        {
        }

        public ICB(ImpostoDoProduto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Produto produto) => (produto.Valor * 0.1) + CalcularOutroImposto(produto);
    }
}