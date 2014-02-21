namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo de Tributação do ICMS = 10
    /// <para>Id: N03</para>
    /// <para>Pai: N01</para>
    /// <para>Obs: Tributação do ICMS - 10 - Tributada e com cobrança do ICMS por substituição tributária</para>
    /// </summary>
    public class ICMS10 : ICMS
    {
        /// <summary>
        /// Tributação do ICMS = 10
        /// </summary>
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS
        /// </summary>
        public string modBC { get; set; }


        ///<summary>
        /// Valor da BC do ICMS
        /// </summary>
        public string vBC { get; set; }

        ///<summary>
        ///Alíquota do imposto
        /// </summary>
        public string pICMS { get; set; }

        ///<summary>
        /// Valor do ICMS 
        /// </summary>
        public string vICMS { get; set; }

        ///<summary>
        /// Modalidade de determinação da BC do ICMS ST
        /// </summary>
        public string modBCST { get; set; }

        ///<summary>
        /// Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        public string pMVAST { get; set; }

        ///<summary>
        /// Percentual da Redução de BC do ICMS ST
        /// </summary>
        public string pRedBCST { get; set; }

        ///<summary>
        /// Valor da BC do ICMS ST
        /// </summary>
        public string vBCST { get; set; }

        ///<summary>
        /// Alíquota do imposto do ICMS ST
        /// </summary>
        public string pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST
        /// </summary>
        public string vICMSST { get; set; }
    }
}

