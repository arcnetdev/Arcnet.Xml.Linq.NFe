namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements
{
    /// <summary>
    /// Grupo de COFINS tributado pela alíquota
    /// <para>ID: S02</para>
    /// <para>Pai: S01</para>
    /// <para>Obs: CST = 01 ou 02</para>
    /// </summary>
    
    class COFINSAliq: COFINS
    {
        /// <summary>
        /// Código de Situação Tributária da COFINS
        /// <para>Obs: 01 – Operação Tributável (base de cálculo = valor da operação 
        /// alíquota normal (cumulativo/não cumulativo));
        /// 02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada));</para>
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
        /// Valor da COFINS
        /// </summary>
        public string vCOFINS { get; set; }

    }
}
