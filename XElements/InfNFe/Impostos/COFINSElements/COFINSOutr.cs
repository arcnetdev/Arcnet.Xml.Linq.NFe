namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements
{
    /// <summary>
    /// Grupo de COFINS Outras Operações
    /// <para>Id: S04</para>
    /// <para>Pai: S01</para>
    /// </summary>
    class COFINSOutr : COFINS
    {
        /// <summary>
        /// Código de Situação Tributária da COFINS
        /// </summary>
        public string CST { get; set; }
        /// <summary>
        /// Valor da Base de Cálculo da COFINS
        /// </summary>
        public string vBC { get; set; }
        /// <summary>
        /// Alíquota da COFINS (em percentual)
        /// </summary>
        public string pCOFINS { get; set; }
        /// <summary>
        /// Quantidade Vendida
        /// </summary>
        public string qBCProd { get; set; }
        /// <summary>
        /// Alíquota da COFINS (em reais)
        /// </summary>
        public string vAliqProd { get; set; }
        /// <summary>
        /// Valor da COFINS
        /// </summary>
        public string vCOFINS { get; set; }


    }
}
