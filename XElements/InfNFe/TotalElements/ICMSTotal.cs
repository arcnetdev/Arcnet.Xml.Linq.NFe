namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.TotalElements
{
    /// <summary>
    /// Manual Contribuinte v_5.00
    /// Grupo de Valores Totais referentes ao ICMS
    /// </summary>
    public class ICMSTotal
    {
        /// <summary>
        /// Base de Cálculo do ICMS
        /// </summary>
        public string vBC { get; set; }
        /// <summary>
        /// Valor Total do ICMS
        /// </summary>
        public string vICMS { get; set; }
        /// <summary>
        /// Base de Cálculo do ICMS ST
        /// </summary>
        public string vBCST { get; set; }
        /// <summary>
        /// Valor Total do ICMS ST
        /// </summary>
        public string vST { get; set; }
        /// <summary>
        /// Valor Total dos produtos e serviços
        /// </summary>
        public string vProd { get; set; }
        /// <summary>
        /// Valor Total do Frete
        /// </summary>
        public string vFrete { get; set; }
        /// <summary>
        /// Valor Total do Seguro
        /// </summary>
        public string vSeg { get; set; }
        /// <summary>
        /// Valor Total do Desconto
        /// </summary>
        public string vDesc { get; set; }
        /// <summary>
        /// Valor Total do Imposto de Importação
        /// </summary>
        public string vII { get; set; }
        /// <summary>
        /// Valor Total do IPI
        /// </summary>
        public string vIPI { get; set; }
        /// <summary>
        /// Valor do PIS
        /// </summary>
        public string vPIS { get; set; }
        /// <summary>
        /// Valor do COFINS
        /// </summary>
        public string vCOFINS { get; set; }
        /// <summary>
        /// Outras Despesas acessórias
        /// </summary>
        public string vOutro { get; set; }
        /// <summary>
        /// Valor Total da NF-e
        /// </summary>
        public decimal vNF { get; set; }
    }
}
