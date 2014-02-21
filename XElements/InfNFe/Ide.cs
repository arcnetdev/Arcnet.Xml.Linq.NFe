using System;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe
{
    /// <summary>
    /// Manual Contribuinte v_5.00
    /// Grupo das informações de identificação da NF-e
    /// </summary>
    public class Ide
    {
        /// <summary>
        /// Código da UF do emitente do Documento Fiscal
        /// </summary>
        public string cUF { get; set; }
        /// <summary>
        /// Código Numérico que compõe a Chave de Acesso
        /// </summary>
        public string cNF { get; set; }
        /// <summary>
        /// Descrição da Natureza da Operação
        /// </summary>
        public string natOP { get; set; }
        /// <summary>
        /// Indicador da forma de pagamento
        /// </summary>
        public string indPag { get; set; }
        /// <summary>
        /// Código do Modelo do Documento Fiscal
        /// </summary>
        public string mod { get; set; }
        /// <summary>
        /// Série do Documento Fiscal
        /// </summary>
        public string serie { get; set; }
        /// <summary>
        /// Número do Documento Fiscal
        ///  </summary>
        public string nNF { get; set; }
        /// <summary>
        /// Data de emissão do Documento Fiscal
        /// </summary>
        public DateTime dEmi { get; set; }
        /// <summary>
        /// Data de Saída ou da Entrada da Mercadoria/Produto
        /// </summary>
        public DateTime dSaiEnt { get; set; }
        /// <summary>
        /// Hora de Saída ou da Entrada da Mercadoria/Produto
        /// </summary>
        public string hSaiEnt { get; set; }
        /// <summary>
        /// Tipo de Operação
        /// </summary>
        public string tpNF { get; set; }
        /// <summary>
        /// Código do Município de Ocorrência do Fato Gerador
        /// </summary>
        public string cMunFG { get; set; }
        /// <summary>
        /// Formato de Impressão do DANFE
        /// </summary>
        public string tpImp { get; set; }
        /// <summary>
        /// Tipo de Emissão da NF-e
        /// </summary>
        public string tpEmis { get; set; }
        /// <summary>
        /// Dígito Verificador da Chave de Acesso da NF-e
        /// </summary>
        public string cDV { get; set; }
        /// <summary>
        /// Identificação do Ambiente
        /// </summary>
        public string tpAmb { get; set; }
        /// <summary>
        /// Finalidade de emissão da NF-e
        /// </summary>
        public string finNFe { get; set; }
        /// <summary>
        /// Processo de emissão da NF-e
        /// </summary>
        public string procEmi { get; set; }
        /// <summary>
        /// Versão do Processo de emissão da NF-e
        /// </summary>
        public string verProc { get; set; }
        /// <summary>
        /// Data e Hora da entrada em contingência
        /// </summary>
        public string dhCont { get; set; }
        /// <summary>
        /// Justificativa da entrada em contingência
        /// </summary>
        public string xJust { get; set; }
    }
}
