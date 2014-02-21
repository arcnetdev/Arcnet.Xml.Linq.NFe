namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IPIElements
{
    /// <summary>
    /// <para>Grupo do IPI</para>
    /// <para>Informar apenas quando o item for sujeito ao IPI</para>
    /// <para>ID: O01</para>    
    /// <para>Pai: M01</para>
    /// </summary>
    public class IPI
    {
        /// <summary>
        /// Classe de enquadramento do IPI para Cigarros e Bebidas
        /// </summary>
        public string clEnq { get; set; }

        /// <summary>
        /// CNPJ do produtor da mercadoria, quando diferente do emitente. Somente para os casos de exportação direta ou indireta.
        /// </summary>
        public string CNPJProd { get; set; }

        /// <summary>
        /// Código do selo de controle IPI
        /// </summary>
        public string cSelo { get; set; }
        /// <summary>
        /// Quantidade de selo de controle
        /// </summary>
        public string qSelo { get; set; }

        /// <summary>
        /// Código de Enquadramento Legal do IPI
        /// </summary>
        public string cEnq { get; set; }

        public object IPIBase { get; set; }

    }
}
