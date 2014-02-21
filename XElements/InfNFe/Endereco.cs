namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe
{
    /// <summary>
    /// Manual Contribuinte v_5.00
    /// Grupo de endereço do Destinatário ou Emitente da NF-e
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// Logradouro do Endereco
        /// </summary>
        public string xLgr { get; set; }
        /// <summary>
        /// Número
        /// </summary>
        public string nro { get; set; }
        /// <summary>
        /// Complemento
        /// </summary>
        public string xCpl { get; set; }
        /// <summary>
        /// Bairro
        /// </summary>
        public string xBairro { get; set; }
        /// <summary>
        /// Código do município
        /// </summary>
        public string cMun { get; set; }
        /// <summary>
        /// Nome do município
        /// </summary>
        public string xMun { get; set; }
        /// <summary>
        /// Sigla da UF
        /// </summary>
        public string UF { get; set; }
        /// <summary>
        /// Código do CEP
        /// </summary>
        public string CEP { get; set; }
        /// <summary>
        /// Código do País
        /// </summary>
        public string cPais { get; set; }
        /// <summary>
        /// Nome do País
        /// </summary>
        public string xPais { get; set; }
        /// <summary>
        /// Telefone
        /// </summary>
        public string fone { get; set; }
    }
}
