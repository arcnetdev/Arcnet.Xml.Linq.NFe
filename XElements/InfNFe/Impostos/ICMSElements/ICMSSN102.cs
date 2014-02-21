namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo CRT=1 – Simples Nacional e CSOSN=102, 103, 300 ou 400
    /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=102, 103, 300 ou 400 (v.2.0)
    /// <para>Id: N10d</para>
    /// <para>Pai: N01</para>
    /// <para>Obs: Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=102, 103, 300 ou 400 (v.2.0)</para>
    /// </summary>
    public class ICMSSN102 : ICMS
    {
        /// <summary>
        /// Código de Situação da Operação – Simples Nacional
        /// 102- Tributada pelo Simples Nacional sem permissão de crédito.
        /// 103 – Isenção do ICMS no Simples Nacional para faixa de receita bruta.
        /// 300 – Imune.
        /// 400 – Não tributada pelo Simples Nacional (v.2.0) (v.2.0)
        /// </summary>
        public string CSOSN { get; set; }
    }
}
