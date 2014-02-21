namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    public class ICMS51 : ICMS
    {

        /// <summary>
        /// Tributação do ICMS
        /// <para>Id: N07</para>
        /// <para>Pai: N01</para>
        /// <para>Obs: Tributação do ICMS – 60 - ICMS cobrado anteriormente por substituição tributária</para>
        /// </summary>
        public string CST { get; set; }
       ///<summary>
       ///Modalidade de determinação da BC do ICMS 
       ///0 - Margem Valor Agregado (%); 1 - Pauta (Valor); 2 - Preço Tabelado Máx. (valor); 3 - valor da operação
       /// </summary>
        public string modBC { get; set; }

       ///<summary>
       ///Percentual da Redução de BC
       /// </summary>
        public string pRedBC { get; set; }

       ///<summary>
       ///Valor da BC do ICMS
       /// </summary>
        public string vBC { get; set; }

       ///<summary>
       ///Percentual da Redução de BC
       /// </summary>
        public string pICMS { get; set; }

       ///<summary>
       ///Valor do ICMS
       /// </summary>
        public string vICMS { get; set; }
    }
}
