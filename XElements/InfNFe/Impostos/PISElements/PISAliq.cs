namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements
{
    /// <summary>
    /// Grupo de PIS tributado pela alíquota
    /// </summary>
    public class PISAliq : PIS
    {
        /// <summary>
        /// Código de Situação Tributária do PIS
        /// </summary>
        public string CST { get; set; }
        /// <summary>
        /// Valor da Base de Cálculo do PIS
        /// </summary>
        public string vBC { get; set; } 
        /// <summary>
        /// Alíquota do PIS (em percentual)
        /// </summary>
        public string pPIS { get; set; }
        /// <summary>
        /// Valor do PIS
        /// </summary>
        public string vPIS { get; set; }
    }
}
