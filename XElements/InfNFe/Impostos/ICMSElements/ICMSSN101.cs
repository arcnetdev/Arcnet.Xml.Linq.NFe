namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo CRT=1 – Simples Nacional e CSOSN=101
    /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=101 (v.2.0)
    /// <para>Id: N10c</para>
    /// <para>Pai: N01</para>
    /// <para>Obs: Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=101 (v.2.0)</para>
    /// </summary>
    public class ICMSSN101 : ICMS
    {
        /// <summary>
        /// 101- Tributada pelo Simples Nacional com permissão de crédito. (v.2.0)
        /// </summary>
        public string CSOSN { get; set; }
        /// <summary>
        /// Alíquota aplicável de cálculo do crédito (Simples Nacional).
        /// </summary>
        public string pCredSN { get; set; }
        /// <summary>
        /// Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional)
        /// </summary>
        public string vCredICMSSN { get; set; }
    }
}
