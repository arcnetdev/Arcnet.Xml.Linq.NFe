
using MongoDB.Bson.Serialization.Attributes;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe
{
    /// <summary>
    /// Manual_de_Orientação_Contribuinte_v_5.00
    /// Grupo de endereço do Destinatário da NF-e
    /// </summary>
    public class Destinatario
    {
        /// <summary>
        /// CNPJ do Destinantario
        /// </summary>
        public string CNPJ { get; set; }
        /// <summary>
        /// Razão Social ou nome do destinatário
        /// </summary>
        public string xNome { get; set; }
        /// <summary>
        /// Identificação do Endereço
        /// </summary>
        /// 
        [BsonElement("enderDest")]
        public Endereco Endereco { get; set; }
        /// <summary>
        /// INscrição Estadual
        /// </summary>
        public string IE { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}
