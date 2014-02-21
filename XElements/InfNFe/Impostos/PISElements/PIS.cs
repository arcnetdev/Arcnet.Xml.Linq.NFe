using MongoDB.Bson.Serialization.Attributes;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements
{
    /// <summary>
    /// Grupo do PIS
    /// </summary>
    [BsonKnownTypes(typeof(PISAliq), typeof(PISNT), typeof(PISOutr), typeof(PISST))]
    public class PIS
    {
    }
}
