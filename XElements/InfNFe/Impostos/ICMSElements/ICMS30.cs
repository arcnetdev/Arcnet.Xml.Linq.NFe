namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
        public class ICMS30 : ICMS
        {

            /// <summary>
            /// Tributação do ICMS
            /// <para>Id: N05</para>
            /// <para>Pai: N01</para>
            /// <para>Obs: Tributação do ICMS – 30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária</para>
            /// </summary>
            public string CST { get; set; }
            ///<summary>
            ///Modalidade de determinação da BC do ICMS 
            ///0 - Margem Valor Agregado (%); 1 - Pauta (Valor); 2 - Preço Tabelado Máx. (valor); 3 - valor da operação. 
            /// </summary>
            public string modBCST { get; set; }

            /// <summary>
            /// Percentual da margem de valor Adicionado do ICMS ST
            /// 0 – Preço tabelado ou máximo sugerido;
            /// 1 - Lista Negativa (valor);
            /// 2 - Lista Positiva (valor);
            /// 3 - Lista Neutra (valor);
            /// 4 - Margem Valor Agregado (%);
            /// 5 - Pauta (valor);
            /// </summary>
            public string pMVAST { get; set; }
            ///<summary>
            ///Percentual da Redução de BC
            /// </summary>
            public string pRedBCST { get; set; }

            ///<summary>
            ///Valor da BC do ICMS
            /// </summary>
            public string vBCST { get; set; }

            ///<summary>
            ///Alíquota do imposto
            /// </summary>
            public string pICMSST { get; set; }

            ///<summary>
            ///Alíquota do imposto
            /// </summary>
            public string vICMSST { get; set; }
        }
    }

