namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements
{
    public class PISOutr : PIS
    {
        /// <summary>
        /// Código de Situação Tributária do PIS
        /// </summary>
        public string CST { get; set; }
        /// <summary>
        /// Valor da Base de Cálculo do PIS
        /// </summary>
        public string vBC { get; set; }
        /// <summary>
        /// Alíquota do PIS (em percentual)
        /// </summary>
        public string pPIS { get; set; }
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
