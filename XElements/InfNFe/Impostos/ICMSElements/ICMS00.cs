namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo de Tributação do ICMS = 00
    /// <para>Id: N02</para>
    /// <para>Pai: N01</para>
    /// </summary>
    public class ICMS00 : ICMS
    {

        /// <summary>
        /// Tributação do ICMS
        /// </summary>
        public string CST { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS
        /// </summary>
        public string modBC { get; set; }

        /// <summary>
        /// Valor da BC do ICMS 
        /// </summary>
        public string vBC { get; set; }

        /// <summary>
        /// Alíquota do imposto
        /// </summary>
        public string pICMS { get; set; }

        /// <summary>
        /// Valor do ICMS
        /// </summary>
        public string vICMS { get; set; }
    }
}
