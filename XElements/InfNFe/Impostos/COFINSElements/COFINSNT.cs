namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements
{
    /// <summary>
    /// Grupo de COFINS não tributado
    /// <para>Obs: 04 - Operação Tributável (tributação monofásica (alíquota zero));</para>
    /// <para> 06 - Operação Tributável (alíquota zero);</para>
    /// <para> 07 - Operação Isenta da Contribuição;</para>
    /// <para> 08 - Operação Sem Incidência da Contribuição;</para>
    /// <para> 09 - Operação com Suspensão da Contribuição;</para>
    /// </summary>
    class COFINSNT: COFINS
    {
        /// <summary>
        /// Código de Situação Tributária da COFINS
        /// </summary>
        public string CST { get; set; }
    }
}
