namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo CRT=1 – Simples Nacional e CSOSN = 500
    /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=500 (v.2.0)
    /// <para>Id: </para>
    /// <para>Pai: </para>
    /// <para>Obs: </para>
    /// </summary>
    public class ICMSSN500 : ICMS
    {
        
        public string CSOSN { get; set; }

        /// <summary>
        /// Valor da BC do ICMS ST retido
        /// Valor da BC do ICMS ST cobrado anteriormente por ST (v2.0). O valor pode ser omitido quando a legislação não exigir a sua informação.(NT 2011/004)
        /// </summary>
        public string vBCSTRet { get; set; }

        /// <summary>
        /// Valor do ICMS ST retido
        /// Valor do ICMS ST cobrado anteriormente por ST (v2.0). O valor pode ser omitido quando a legislação não exigir a sua informação.(NT 2011/004)
        /// </summary>
        public string vICMSSTRet { get; set; }
    }
}
