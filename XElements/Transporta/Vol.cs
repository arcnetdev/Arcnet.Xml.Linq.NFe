namespace Arcnet.Xml.Linq.NFe.XElements.Transporta
{
    /// <summary>
    /// Manual_de_Orientação_Contribuinte_v_5.00
    /// Volumes
    /// Id:X26
    /// </summary>
    class Vol
    {
        /// <summary>
        /// Quantidade de volumes transportados
        /// </summary>
        public int qVol { get; set; }

        /// <summary>
        /// Espécie dos volumes transportados
        /// </summary>
        public string esp { get; set; }

        /// <summary>
        /// Marca dos Volumes Transportados
        /// </summary>
        public string marca { get; set; }

        /// <summary>
        /// Numeração dos Volumes Transportados
        /// </summary>
        public int nVol { get; set; }

        /// <summary>
        /// Peso Liquido(em Kg)
        /// </summary>
        public decimal pesoL { get; set; }

        /// <summary>
        /// Peso Bruto(em Kg)
        /// </summary>
        public decimal pesoB { get; set; }
    }
}
