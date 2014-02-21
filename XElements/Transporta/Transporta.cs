namespace Arcnet.Xml.Linq.NFe.XElements.Transporta
{
    /// <summary>
    /// Manual_de_Orientação_Contribuinte_v_5.00
    /// Grupo Transportador
    /// </summary>
    class Transporta
    {
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        
        /// <summary>
        /// Razão Social ou nome
        /// </summary>
        public string xNome { get; set; }

        
        /// <summary>
        /// INscrição Estadual
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        /// Endereço Completo
        /// </summary>
        public string xEnder { get; set; }

        public string UF { get; set; }
        /// <summary>
        /// Grupo de Retenção do ICMS do transporte
        /// </summary>
        public string retTransp { get; set; }

        /// <summary>
        /// Valor do Serviço
        /// </summary>
        public decimal vServ { get; set; }

        /// <summary>
        /// BC da Retenção do ICMS
        /// </summary>
        public string vBCRet { get; set; }

        /// <summary>
        /// Alíquota da Retenção
        /// </summary>
        public decimal pICMSRet { get; set; }
        /// <summary>
        /// Valor do ICMS Retido
        /// </summary>
        public decimal vICMSRet { get; set; }

        public string CFOP { get; set; }
        /// <summary>
        /// Código do Municipio de ocorrencia do fato gerador do ICMS do Transpote
        /// </summary>
        public string xMunFG { get; set; }

        /// <summary>
        /// Grupo Veiculo
        /// </summary>
        public VeicTransp VeicTransp { get; set; }
    }
}
