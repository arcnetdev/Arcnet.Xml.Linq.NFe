using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe
{
    /// <summary>
    /// Manual Contribuinte v_5.00
    /// Grupo do detalhamento de Produtos e Serviços da NF-e
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Código do produto ou serviço
        /// </summary>
        public string cProd { get; set; }
        /// <summary>
        /// GTIN (Global Trade Item Number) do produto, 
        /// antigo código EAN ou código de barras
        /// </summary>
        public string cEAN {get; set; }
        /// <summary>
        /// Descrição do produto ou serviço
        /// </summary>
        public string xProd { get; set; }
        /// <summary>
        /// Código NCM com 8 dígitos ou 2 dígitos (gênero)
        /// </summary>
        public string NCM { get; set; }
        /// <summary>
        /// EX_TIPI
        /// </summary>
        public string EXTIPI { get; set; }
        /// <summary>
        /// Código Fiscal de Operações e Prestações
        /// </summary>
        public string CFOP { get; set; }
        /// <summary>
        /// Unidade Comercial
        /// </summary>
        public string uCom { get; set; }
        /// <summary>
        /// Quantidade Comercial
        /// </summary>
        public string qCom { get; set; }
        /// <summary>
        /// Valor Unitário de Comercialização
        /// </summary>
        public string vUnCom { get; set; }
        /// <summary>
        /// Valor Total Bruto dos Produtos ou Serviços
        /// </summary>
        public string vProd { get; set; }
        /// <summary>
        /// GTIN (Global Trade Item Number) da unidade tributável, 
        /// antigo código EAN ou código de barras
        /// </summary>
        public string cEANTrib { get; set; }
        /// <summary>
        /// Unidade Tributável
        /// </summary>
        public string uTrib { get; set; }
        /// <summary>
        /// Quantidade Tributável
        /// </summary>
        public string qTrib { get; set; }
        /// <summary>
        /// Valor Unitário de tributação
        /// </summary>
        public string vUnTrib { get; set; }
        /// <summary>
        /// Valor Total do Frete
        /// </summary>
        public string vFrete { get; set; }
        /// <summary>
        /// Valor Total do Seguro
        /// </summary>
        public string vSeg { get; set; }
        /// <summary>
        /// Valor do Desconto
        /// </summary>
        public string vDesc { get; set; }
        /// <summary>
        /// Outras despesas acessórias
        /// </summary>
        public string vOutro { get; set; }
        /// <summary>
        /// Indica se valor do Item (vProd) 
        /// entra no valor total da NF-e (vProd)
        /// </summary>
        public string indTot { get; set; }

        public Imposto Imposto { get; set; }
    }
}
