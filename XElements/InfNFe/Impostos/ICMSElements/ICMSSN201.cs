namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo CRT=1 – Simples Nacional e CSOSN=201
    /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=101 (v.2.0)
    /// <para>Id: </para>
    /// <para>Pai: </para>
    /// <para>Obs: </para>
    /// </summary>
    public class ICMSSN201 : ICMS
    {
        /// <summary>
        /// Código de Situação da Operação – Simples Nacional
        /// 201- Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária (v.2.0)
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
        
        /// <summary>
        /// Alíquota aplicável de cálculo do crédito (SIMPLES NACIONAL).
        /// </summary>
        public string pCredSN { get; set; }

        /// <summary>
        /// Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (SIMPLES NACIONAL)
        /// </summary>
        public string vCredICMSSN { get; set; }
    }
}
