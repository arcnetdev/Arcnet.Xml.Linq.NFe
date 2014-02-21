namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
        /// <summary>
        /// GGrupo de Tributação do ICMS = 20 
        /// <para>Id: N04</para>
        /// <para>Pai: N01</para>
        ///<para>Tributação do ICMS  – 20 - Com redução de base de cálculo</para>
        /// </summary>
        public class ICMS20 : ICMS
        {
            /// <summary>
            /// Tributação do ICMS
            /// </summary>
            public string CST { get; set; }
            ///<summary>
            ///Modalidade de determinação da BC do ICMS 
            ///0 - Margem Valor Agregado (%); 1 - Pauta (Valor); 2 - Preço Tabelado Máx. (valor); 3 - valor da operação. 
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
            ///Alíquota do imposto
            /// </summary>
            public string pICMS { get; set; }

            ///<summary>
            ///Alíquota do imposto
            /// </summary>
            public string vICMS { get; set; }
        }
    }

