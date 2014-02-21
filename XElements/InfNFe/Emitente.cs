using MongoDB.Bson.Serialization.Attributes;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe
{
    /// <summary>
    /// Manual_de_Orientação_Contribuinte_v_5.00
    /// Grupo de identificação do emitente da NF-e
    /// </summary>
    public class Emitente
    {
        /// <summary>
        /// CNPJ do emitente
        /// </summary>
        public string CNPJ { get; set; }
        /// <summary>
        /// Razão Social ou Nome do emitente
        /// </summary>
        public string xNome { get; set; }
        /// <summary>
        /// Nome fantasia
        /// </summary>
        public string xFant { get; set; }
        /// <summary>
        /// Grupo do Endereço do emitente
        /// </summary>
        [BsonElement("enderEmit")]
        public Endereco Endereco { get; set; }
        /// <summary>
        /// Inscrição Estadual
        /// </summary>
        public string IE { get; set; }
        /// <summary>
        /// Código de Regime Tributário
        /// </summary>
        public string CRT { get; set; }
    }
}
