using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IIElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IPIElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements;
using MongoDB.Bson.Serialization.Attributes;

namespace Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos
{
    public class Imposto
    {
        public ICMS ICMS { get; set; }
        public IPI IPI { get; set; }
        public II II { get; set; }
        public PIS PIS { get; set; }
        public COFINS COFINS { get; set; }
    }
}
