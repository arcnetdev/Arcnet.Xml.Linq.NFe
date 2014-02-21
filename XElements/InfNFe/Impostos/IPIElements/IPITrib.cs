namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IPIElements
{
    /// <summary>
    /// Grupo do CST 00, 49, 50 e 99
    /// <para>Id: O07</para>
    /// <para>Pai: O01</para>
    /// <para>Obs: Informar apenas um dos grupos O07 ou O08 com base valor atribuído ao campo O09 – CST do IPI</para>
    /// </summary>
    public class IPITrib : IPIBase
    {
        /// <summary>
        /// Código da situação tributária do IPI
        /// </summary>
        public string CST { get; set; }
        /// <summary>
        /// Valor da BC do IPI
        /// </summary>
        public string vBC { get; set; }
        /// <summary>
        /// Alíquota do IPI
        /// </summary>
        public string pIPI { get; set; }
        /// <summary>
        /// Quantidade total na unidade padrão para tributação (somente para os produtos tributados por unidade)
        /// </summary>
        public string qUnid { get; set; }

        /// <summary>
        /// Valor por Unidade Tributável
        /// </summary>
        public string vUnid { get; set; }

        /// <summary>
        /// Valor IPI
        /// </summary>
        public string vIPI { get; set; }




    }
}
