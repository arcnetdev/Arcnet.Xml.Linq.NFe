using MongoDB.Bson.Serialization.Attributes;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements
{
    /// <summary>
    /// Grupo do COFINS
    /// <para>ID: S01</para>
    /// <para>Pai: M01</para>
    /// <para>Obs: Informar apenas um dos grupos S02, S03, S04 ou S04 
    /// com base valor atribuído ao campo S06 – CST do COFINS</para>
    /// </summary>
    [BsonKnownTypes(typeof(COFINSNT),typeof(COFINSAliq), typeof(COFINSOutr),typeof(COFINSST))]
    public class COFINS
    {
    }
}
