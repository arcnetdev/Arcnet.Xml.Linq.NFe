using MongoDB.Bson.Serialization.Attributes;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements
{
    /// <summary>
    /// Grupo do ICMS da Operação própria e ST
    /// <para>ID: N01</para>
    /// <para>PAI: M01</para>
    /// <para>Obs: Informar apenas um dos grupos N02, N03, N04, N05, N06, N07, N08, N09, N10,
    ///  N10a, N10b, N10c, N10d, N10e, N10f, N10g ou N10h com base no conteúdo informado na TAG Tributação do ICMS. (v2.0)</para>
    /// </summary>
    [BsonKnownTypes(
    typeof(ICMS00), typeof(ICMS10), typeof(ICMS20), typeof(ICMS30), typeof(ICMS40), typeof(ICMS51),
    typeof(ICMS60), typeof(ICMS70), typeof(ICMS90), typeof(ICMSPart), typeof(ICMSSN101), typeof(ICMSSN102),
    typeof(ICMSSN201), typeof(ICMSSN202), typeof(ICMSSN202), typeof(ICMSSN500), typeof(ICMSSN900), typeof(ICMSST))]
    public class ICMS
    {
        /// <summary>
        /// Origem da mercadoria
        /// </summary>
        public string orig { get; set; }

    }
}
