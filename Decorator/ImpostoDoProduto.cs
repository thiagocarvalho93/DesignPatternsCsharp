namespace DesignPatterns.Decorator
{
    public abstract class ImpostoDoProduto
    {
        private ImpostoDoProduto? _outroImposto { get; set; }

        protected ImpostoDoProduto(ImpostoDoProduto outroImposto) => _outroImposto = outroImposto;

        protected ImpostoDoProduto() => _outroImposto = null;

        public abstract double Calcular(Produto produto);

        protected double CalcularOutroImposto(Produto produto)
        {
            if (_outroImposto == null) return 0;
            return _outroImposto.Calcular(produto);
        }
    }
}