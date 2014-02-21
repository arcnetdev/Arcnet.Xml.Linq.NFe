namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements
{
    /// <summary>
    /// Grupo de PIS tributado por Qtde
    /// </summary>
    public class PISQtde : PIS
    {
        /// <summary>
        /// Código de Situação Tributária do PIS
        /// </summary>
        public string CST { get; set; }
        /// <summary>
        /// Quantidade Vendida
        /// </summary>
        public string qBCProd { get; set; }
        /// <summary>
        /// Alíquota do PIS (em reais)
        /// </summary>
        public string vAliqProd { get; set; }
        /// <summary>
        /// Valor do PIS
        /// </summary>
        public string vPIS { get; set; }
    }
}
