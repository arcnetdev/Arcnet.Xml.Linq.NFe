namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// ICMS ST – repasse de ICMS ST retido anteriormente em operações interestaduais com repasses através do Substituto Tributário 
    /// Grupo de informação do ICMS ST devido para a UF de destino, nas operações interestaduais de produtos que tiveram retenção antecipada de ICMS por ST na UF do remetente. Repasse via Substituto Tributário. (v2.0)
    /// <para>Id: </para>
    /// <para>Pai: </para>
    /// <para>Obs: </para>
    /// </summary>
    public class ICMSST : ICMS
    {

        /// <summary>
        /// Tributação do ICMS
        /// </summary>
        public string CST { get; set; }
        ///<summary>
        ///Valor do BC do ICMS ST retido na UF remetente 
        ///Informar o valor da BC do ICMS ST retido na UF remetente (v2.0) 
        /// </summary>
        public string vBCSTRet { get; set; }

        ///<summary>
        ///Valor do ICMS ST retido na UF remetente
        /// Informar o valor do ICMS ST retido na UF remetente (iv2.0) 
        /// </summary>
        public string vICMSSTRet { get; set; }

        ///<summary>
        ///Valor da BC do ICMS ST da UF destino 
        ///Informar o valor da BC do ICMS ST da UF destino (v2.0)
        /// </summary>
        public string vBCSTDest { get; set; }

        ///<summary>
        ///Valor do ICMS ST da UF destino
        ///Informar o valor da BC do ICMS ST da UF destino (v2.0)
        /// </summary>
        public string vICMSSTDest { get; set; }
    }
}
