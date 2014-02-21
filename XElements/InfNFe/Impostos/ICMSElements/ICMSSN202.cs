namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo CRT=1 – Simples Nacional e CSOSN=202 ou 203
    /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=202 ou 203 (v.2.0)
    /// <para>Id: </para>
    /// <para>Pai: </para>
    /// <para>Obs: </para>
    /// </summary>
    public class ICMSSN202 : ICMS
    {
       
        /// <summary>
        /// 202- Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária 
        /// 203- Isenção do ICMS nos Simples Nacional para faixa de receita bruta e com cobrança do ICMS por Substituição Tributária (v.2.0)
        /// </summary>
        public string CSOSN { get; set; }

        /// <summary>
        /// Modalidade de determinação da BC do ICMS ST
        /// 0 – Preço tabelado ou máximo sugerido;
        /// 1 - Lista Negativa (valor);
        /// 2 - Lista Positiva (valor);
        /// 3 - Lista Neutra (valor);
        /// 4 - Margem Valor Agregado (%);
        /// 5 - Pauta (valor); (v.2.0)
        /// </summary>
        public string modBCST { get; set; }
        /// <summary>
        /// Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        public string pMVAST { get; set; }
        /// <summary>
        /// Percentual da Redução de BC do ICMS ST
        /// </summary>
        public string pRedBCST { get; set; }
        /// <summary>
        /// Valor da BC do ICMS ST
        /// </summary>
        public string vBCST { get; set; }

        /// <summary>
        /// Alíquota do imposto do ICMS ST
        /// </summary>
        public string pICMSST { get; set; }

        /// <summary>
        /// Valor do ICMS ST
        /// Valor do ICMS ST retido (v.2.0)
        /// </summary>
        public string vICMSST { get; set; }
    }
}
