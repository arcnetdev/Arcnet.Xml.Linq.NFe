namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    public class ICMS70 : ICMS
    {

        /// <summary>
        /// Tributação do ICMS
        /// <para>Id: N09</para>
        /// <para>Pai: N01</para>
        /// <para>Obs: Tributação do ICMS - 70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária</para>
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
        ///Percentual da Redução de BC
        /// </summary>
        public string vBC { get; set; }

        ///<summary>
        ///Alíquota do imposto
        /// </summary>
        public string pICMS { get; set; }


        ///<summary>
        ///Valor do ICMS
        /// </summary>
        public string vICMS { get; set; }

        ///<summary>
        ///Modalidade de determinação da BC do ICMS ST 
        ///0 – Preço tabelado ou máximo  sugerido; 1 - Lista Negativa (valor); 2 - Lista Positiva (valor); 3 - Lista Neutra (valor); 4 - Margem Valor Agregado (%); 5 - Pauta (valor);
        /// </summary>
        public string modBCST { get; set; }

        ///<summary>
        ///Percentual da margem de valor Adicionado do ICMS ST 
        /// </summary>
        public string pMVAST { get; set; }

        ///<summary>
        ///Percentual da Redução de BC do ICMS ST 
        /// </summary>
        public string pRedBCST { get; set; }

        ///<summary>
        ///Valor da BC do ICMS ST
        /// </summary>
        public string vBCST { get; set; }
        ///<summary>
        ///Alíquota do imposto do ICMS ST 
        /// </summary>
        public string pICMSST { get; set; }

        ///<summary>
        ///Valor do ICMS ST
        /// </summary>
        public string vICMSST { get; set; }
    }
}
