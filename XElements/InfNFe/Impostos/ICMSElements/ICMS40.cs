namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    public class ICMS40 : ICMS
    {
        /// <summary>
        /// Tributação do ICMS
        /// <para>Id: N06</para>
        /// <para>Pai: N01</para>
        /// <para>Obs: Tributação do ICMS</para>
        /// <para>40- Isenta</para>
        /// <para>41 - Não tributada</para>
        /// <para>50 - Suspensão</para>
        /// </summary>
        public string CST { get; set; }

        ///<summary>
        ///O valor do ICMS desonerado será informado apenas nas operações:
        ///a) com produtos beneficiados com a desoneração condicional do ICMS.
        ///b) destinadas à SUFRAMA, informando-se o valor que seria devido se não houvesse isenção.
        ///c) de venda a órgãos da administração pública direta e suas fundações e
        ///autarquias com isenção do ICMS. (NT 2011/004)
        /// </summary>
        public string vICMS { get; set; }

        /// <summary>
        /// Motivo da desoneração do ICMS
        /// Este campo será preenchido quando o campo anterior estiver preenchido.
        /// Informar o motivo da desoneração:
        /// 1 – Táxi;
        /// 2 – Deficiente Físico;
        /// 3 – Produtor Agropecuário;
        /// 4 – Frotista/Locadora;
        /// 5 – Diplomático/Consular;
        /// 6 – Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio (Resolução 714/88 e 790/94 – CONTRAN e suas alterações);
        /// 7 – SUFRAMA;
        /// 8 – Venda a Órgãos Públicos
        /// 9 – outros. (NT 2011/004)
        /// </summary>
        public string motDesICMS { get; set; }
    }
}
