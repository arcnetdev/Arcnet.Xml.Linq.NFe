namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    public class ICMS60 : ICMS
    {
        /// <summary>
        /// Tributação do ICMS
        /// <para>Id: N08</para>
        /// <para>Pai: N01</para>
        /// <para>Obs: Tributação do ICMS – 60 - ICMS cobrado anteriormente por substituição tributária</para>
        /// </summary>
        public string CST { get; set; }
        ///<summary>
        ///Valor da BC do ICMS ST retido
        ///Valor da BC do ICMS ST cobrado anteriormente por ST (v2.0)  
        /// </summary>
        public string vBCSTRet { get; set; }

        ///<summary>
        ///Valor do ICMS ST retido
        ///Valor do ICMS ST cobrado anteriormente por ST (v2.0) 
        /// </summary>
        public string vICMSSTRet { get; set; }
    }
}
