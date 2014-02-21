namespace Arcnet.Xml.Linq.NFe.XElements.Transporta
{
    /// <summary>
    /// Manual_de_Orientação_Contribuinte_v_5.00
    /// Grupo de Informações do Transporte da NF-e
    /// Id: X01 Pai: A1
    /// </summary>
    class Transp
    {
        /// <summary>
        /// Modalidade do frete
        /// </summary>
        public int modFrete { get; set; }

        /// <summary>
        /// Grupo Transportador
        /// </summary>
        public Transporta Transporta { get; set; }
        /// <summary>
        /// Grupo Reboque
        /// </summary>
        public Reboque Reboque { get; set; }

        /// <summary>
        /// Grupo Volumes
        /// </summary>
        public Vol Vol { get; set; }
    }
}
