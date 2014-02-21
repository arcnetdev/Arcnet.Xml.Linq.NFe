namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Partilha do ICMS entre a UF de origem e UF de destino ou a UF definida na legislação. 
    /// Operação interestadual para consumidor final com partilha do ICMS  devido na operação entre a UF de origem e a UF do destinatário ou a UF definida na legislação. (Ex. UF da concessionária de entrega do  veículos) (v2.0) 
    /// <para>Id: N10a</para>
    /// <para>Pai: N01</para>
    /// <para>Obs: Operação interestadual para consumidor final com partilha do ICMS devido na operação entre a UF de origem e a UF do destinatário ou a UF definida na legislação. (Ex. UF da concessionária de entrega do veículos) (v2.0)</para>
    /// </summary>
    public class ICMSPart : ICMS
    {

        /// <summary>
        /// Tributação do ICMS
        /// </summary>
        public string CST { get; set; }
        ///<summary>
        ///Modalidade de determinação da BC do ICMS 
        ///0 - Margem Valor Agregado (%); 1 - Pauta (Valor); 2 - Preço Tabelado Máx. (valor); 3 - valor da operação. (v2.0) 
        /// </summary>
        public string modBC { get; set; }


        ///<summary>
        ///Valor da BC do ICMS
        /// </summary>
        public string vBC { get; set; }

        ///<summary>
        ///Percentual da Redução de BC
        /// </summary>
        public string pRedBC { get; set; }

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
        ///Valor do ICMS ST(v2.0) 
        /// </summary>
        public string vICMSST { get; set; }

        ///<summary>
        ///Percentual  da BC operação própria 
        ///Percentual para determinação do valor  da Base de Cálculo da operação própria. (v2.0) 
        /// </summary>
        public string pBCOp { get; set; }

        ///<summary>
        ///UF para qual é devido o ICMS ST
        ///Sigla da UF para qual é devido o ICMS ST da operação. (v2.0) 
        /// </summary>
        public string UFST { get; set; }
    }
}
