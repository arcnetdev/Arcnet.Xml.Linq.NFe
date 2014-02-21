using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IIElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IPIElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements;
using Arcnet.Xml.Linq.NFe.XElements.InfNFe.TotalElements;
using Arcnet.Xml.Linq.NFe.XElements.ProtNFe;


namespace Arcnet.Xml.Linq.NFe
{
    public class XDocumentNFe
    {
        private readonly IEnumerable<XElement> XElements;
        private const string namespaceICMS = "Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.ICMSElements.";
        private const string namespaceIPI = "Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.IPIElements.";
        private const string namespacePIS = "Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.PISElements.";
        private const string namespaceCOFINS = "Arcnet.Xml.Linq.NFe.XElements.InfNFe.Impostos.COFINSElements.";

        public static XDocumentNFe Load(Stream stream)
        {
            return new XDocumentNFe(stream);
        }

        private XDocumentNFe(Stream stream)
        {
            XElements = XDocument.Load(stream).Descendants();

            // VERIFICA SE A NF-e POSSUI A TAG <infProt>
            GetDescendantsByElementName("infProt");

            // RESETA A POSIÇÃO DA STREAM PARA POSSSIBILITAR NOVAS LEITURAS.
            stream.Position = 0;
        }

        public IEnumerable<Produto> GetProdutos()
        {
            var listaProdutos = new List<Produto>();
            foreach (var detElements in GetElementsByName("det"))
            {
                var prodElements = GetDescendantsByElementName(detElements, "prod");
                var cProd = GetValueByElementName(prodElements, "cProd");
                var cEAN = GetValueByElementName(prodElements, "cEAN");
                var xProd = GetValueByElementName(prodElements, "xProd");
                var NCM = GetValueByElementName(prodElements, "NCM");
                var EXTIPI = GetValueByElementName(prodElements, "EXTIPI");
                var CFOP = GetValueByElementName(prodElements, "CFOP");
                var uCom = GetValueByElementName(prodElements, "uCom");
                var qCom = GetValueByElementName(prodElements, "qCom");
                var vUnCom = GetValueByElementName(prodElements, "vUnCom");
                var vProd = GetValueByElementName(prodElements, "vProd");
                var cEANTrib = GetValueByElementName(prodElements, "cEANTrib");
                var uTrib = GetValueByElementName(prodElements, "uTrib");
                var qTrib = GetValueByElementName(prodElements, "qTrib");
                var vUnTrib = GetValueByElementName(prodElements, "vUnTrib");
                var vFrete = GetValueByElementName(prodElements, "vFrete");
                var vSeg = GetValueByElementName(prodElements, "vSeg");
                var vDesc = GetValueByElementName(prodElements, "vSeg");
                var vOutro = GetValueByElementName(prodElements, "vOutro");
                var indTot = GetValueByElementName(prodElements, "indTot");
                var impostoElements = GetDescendantsByElementName(detElements, "imposto");
                listaProdutos.Add(new Produto()
                    {
                        cProd = cProd,
                        cEAN = cEAN,
                        xProd = xProd,
                        NCM = NCM,
                        EXTIPI = EXTIPI,
                        CFOP = CFOP,
                        uCom = uCom,
                        qCom = qCom,
                        vUnCom = vUnCom,
                        vProd = vProd,
                        cEANTrib = cEANTrib,
                        uTrib = uTrib,
                        qTrib = qTrib,
                        vUnTrib = vUnTrib,
                        vFrete = vFrete,
                        vSeg = vSeg,
                        vDesc = vDesc,
                        vOutro = vOutro,
                        indTot = indTot,
                        Imposto = new Imposto()
                            {
                                ICMS = (ICMS)GetICMS(impostoElements),
                                IPI = GetIPI(impostoElements),
                                II = GetII(impostoElements),
                                PIS = (PIS)GetPIS(impostoElements),
                                COFINS = (COFINS)GetCOFINS(impostoElements)
                            },
                    });
            }
            return listaProdutos;
        }

        private object GetCOFINS(IEnumerable<XElement> impostoElements)
        {
            var COFINS = GetDescendantsByElementName(impostoElements, "COFINS");
            if (COFINS != null)
            {
                var classNameCOFINS = COFINS.First().Name.LocalName;
                var COFINSInstance = CreateInstance(namespaceCOFINS + classNameCOFINS);
                SetPropertiesByElements(COFINS, COFINSInstance);
                return COFINSInstance;
            }
            return null;
        }

        private object GetPIS(IEnumerable<XElement> impostoElements)
        {
            var PIS = GetDescendantsByElementName(impostoElements, "PIS");
            if (PIS != null)
            {
                var classNamePIS = PIS.First().Name.LocalName;
                var PISInstance = CreateInstance(namespacePIS + classNamePIS);
                SetPropertiesByElements(PIS, PISInstance);
                return PISInstance;
            }
            return null;
        }

        private object GetICMS(IEnumerable<XElement> impostoElements)
        {
            var ICMS = GetDescendantsByElementName(impostoElements, "ICMS");
            if (ICMS != null)
            {
                var classNameICMS = ICMS.First().Name.LocalName;
                var ICMSIntance = CreateInstance(namespaceICMS + classNameICMS);
                SetPropertiesByElements(ICMS, ICMSIntance);
                return ICMSIntance;
            }
            return null;
        }

        private II GetII(IEnumerable<XElement> impostoElements)
        {
            var II = GetDescendantsByElementName(impostoElements, "II");
            if (II != null)
            {
                var IIInstance = new II()
                {
                    vBC = GetValueByElementName(II, "vBC"),
                    vDespAdu = GetValueByElementName(II, "vDespAdu"),
                    vII = GetValueByElementName(II, "vII"),
                    vIOF = GetValueByElementName(II, "vIOF")
                };
                return IIInstance;
            }
            return null;
        }

        private IPI GetIPI(IEnumerable<XElement> impostoElements)
        {
            //Pega os descendentes de <IPI>
            var IPI = GetDescendantsByElementName(impostoElements, "IPI");
            if (IPI != null)
            {
                var clEnq = GetValueByElementName(IPI, "clEnq");
                var cSelo = GetValueByElementName(IPI, "cSelo");
                var qSelo = GetValueByElementName(IPI, "qSelo");
                var cEnq = GetValueByElementName(IPI, "cEnq");

                var IPIInstance = new IPI()
                {
                    clEnq = clEnq,
                    cSelo = cSelo,
                    qSelo = qSelo,
                    cEnq = cEnq,
                };

                //Pega a respectiva tag de <IPI + "x"> dentro de <IPI>
                var IPIx = IPI.SingleOrDefault(x => x.Name.LocalName.StartsWith("IPI"));
                if (IPIx != null)
                {
                    var classNameIPIBase = IPIx.Name.LocalName;

                    //Pega os descendentes do respectivo <IPI + "x">
                    var IPIBase = GetDescendantsByElementName(IPI, classNameIPIBase);

                    //Instancia o objeto de <IPI + "x">
                    var IPIBaseInstance = CreateInstance(namespaceIPI + classNameIPIBase);

                    //Atribui valores para as propriedas de IPIBaseInstance
                    SetPropertiesByElements(IPIBase, IPIBaseInstance);
                    IPIInstance.IPIBase = IPIBaseInstance;
                }
                return IPIInstance;
            }
            return null;
        }

        public Destinatario GetDestinatario()
        {
            var dest = GetDescendantsByElementName("dest");
            if (dest != null)
            {
                var CNPJ = GetValueByElementName(dest, "CNPJ");
                var xNome = GetValueByElementName(dest, "xNome");
                var IE = GetValueByElementName(dest, "IE");
                var email = GetValueByElementName(dest, "email");
                return new Destinatario()
                {
                    CNPJ = CNPJ,
                    xNome = xNome,
                    IE = IE,
                    Email = email,
                    Endereco = GetEndereco(InfNFeEndereco.Destinatario)
                };
            }
            return null;
        }

        public Emitente GetEmitente()
        {
            var emit = GetDescendantsByElementName("emit");
            if (emit != null)
            {
                var CNPJ = GetValueByElementName(emit, "CNPJ");
                var xNome = GetValueByElementName(emit, "xNome");
                var xFant = GetValueByElementName(emit, "xFant");
                var IE = GetValueByElementName(emit, "IE");
                var CRT = GetValueByElementName(emit, "CRT");
                return new Emitente()
                {
                    CNPJ = CNPJ,
                    xNome = xNome,
                    xFant = xFant,
                    IE = IE,
                    CRT = CRT,
                    Endereco = GetEndereco(InfNFeEndereco.Emitente)
                };
            }
            return null;
        }

        public Total GetTotal()
        {
            return new Total()
                {
                    ICMSTotal = GetICMSTotal()
                };
        }

        public ICMSTotal GetICMSTotal()
        {
            var icmsTot = GetDescendantsByElementName("ICMSTot");
            if (icmsTot != null)
            {
                var vBC = GetValueByElementName(icmsTot, "vBC");
                var vICMS = GetValueByElementName(icmsTot, "vICMS");
                var vBCST = GetValueByElementName(icmsTot, "vBCST");
                var vST = GetValueByElementName(icmsTot, "vST");
                var vProd = GetValueByElementName(icmsTot, "vProd");
                var vFrete = GetValueByElementName(icmsTot, "vFrete");
                var vSeg = GetValueByElementName(icmsTot, "vSeg");
                var vDesc = GetValueByElementName(icmsTot, "vDesc");
                var vII = GetValueByElementName(icmsTot, "vII");
                var vIPI = GetValueByElementName(icmsTot, "vIPI");
                var vPIS = GetValueByElementName(icmsTot, "vPIS");
                var vCOFINS = GetValueByElementName(icmsTot, "vCOFINS");
                var vOutro = GetValueByElementName(icmsTot, "vOutro");
                var vNF = GetValueByElementName(icmsTot, "vNF");
                return new ICMSTotal()
                {
                    vBC = vBC,
                    vICMS = vICMS,
                    vBCST = vBCST,
                    vST = vST,
                    vProd = vProd,
                    vFrete = vFrete,
                    vSeg = vSeg,
                    vDesc = vDesc,
                    vII = vII,
                    vIPI = vIPI,
                    vPIS = vPIS,
                    vCOFINS = vCOFINS,
                    vOutro = vOutro,
                    vNF = Convert.ToDecimal(vNF, CultureInfo.InvariantCulture)
                };
            }
            return null;
        }

        public Ide GetIde()
        {
            var infNFe = GetDescendantsByElementName("infNFe");
            var ide = GetDescendantsByElementName(infNFe, "ide");
            
            
            // Bug Fixed 20/01/2014 - Lucas 
            // Remove os elementos da tag <refNF> que estavam causando erro na leitura.
            var refNF = GetDescendantsByElementName(ide, "refNF");
            if (refNF != null) refNF.Remove();
            
            
           
            if (infNFe != null)
            {
                var cUF = GetValueByElementName(ide, "cUF");
                var cNF = GetValueByElementName(ide, "cNF");
                var natOP = GetValueByElementName(ide, "natOp");
                var indPag = GetValueByElementName(ide, "indPag");
                var mod = GetValueByElementName(ide, "mod");
                var serie = GetValueByElementName(ide, "serie");
                var nNF = GetValueByElementName(ide, "nNF");
                var dEmi = GetValueByElementName(ide, "dEmi");
                var dSaiEnt = GetValueByElementName(ide, "dSaiEnt");
                var hSaiEnt = GetValueByElementName(ide, "hSaiEnt");
                var tpNF = GetValueByElementName(ide, "tpNF");
                var cMunFG = GetValueByElementName(ide, "cMunFG");
                var tpImp = GetValueByElementName(ide, "tpImp");
                var tpEmis = GetValueByElementName(ide, "tpEmis");
                var cDV = GetValueByElementName(ide, "cDV");
                var tpAmb = GetValueByElementName(ide, "tpAmb");
                var finNFe = GetValueByElementName(ide, "finNFe");
                var procEmi = GetValueByElementName(ide, "procEmi");
                var verProc = GetValueByElementName(ide, "verProc");
                var dhCont = GetValueByElementName(ide, "dhCont");
                var xJust = GetValueByElementName(ide, "xJust");
                return new Ide()
                {
                    cUF = cUF,
                    cNF = cNF,
                    natOP = natOP,
                    indPag = indPag,
                    mod = mod,
                    serie = serie,
                    nNF = nNF,
                    dEmi = Convert.ToDateTime(dEmi),
                    dSaiEnt = Convert.ToDateTime(dSaiEnt),
                    hSaiEnt = hSaiEnt,
                    tpNF = tpNF,
                    cMunFG = cMunFG,
                    tpImp = tpImp,
                    tpEmis = tpEmis,
                    cDV = cDV,
                    tpAmb = tpAmb,
                    finNFe = finNFe,
                    procEmi = procEmi,
                    verProc = verProc,
                    dhCont = dhCont,
                    xJust = xJust
                };
            }
            return null;
        }

        public InfProt GetInfProt()
        {
            var infprot = GetDescendantsByElementName("infProt");
            var chNFe = GetValueByElementName(infprot, "chNFe");
            var tpAmb = GetValueByElementName(infprot, "tpAmb");
            var verAplic = GetValueByElementName(infprot, "verAplic");
            var dhRecbto = GetValueByElementName(infprot, "dhRecbto");
            var nProt = GetValueByElementName(infprot, "nProt");
            var digVal = GetValueByElementName(infprot, "digVal");
            var cStat = GetValueByElementName(infprot, "cStat");
            var xMotivo = GetValueByElementName(infprot, "xMotivo");

            return new InfProt
            {
                tipoAmb = tpAmb,
                verAplic = verAplic,
                chNFe = chNFe,
                dhRecebto = dhRecbto,
                nProt = nProt,
                digVal = digVal,
                cStat = cStat,
                xMotivo = xMotivo
            };
        }

        public string GetChaveNFe()
        {
            var infprot = GetDescendantsByElementName("infProt");
            var chNFe = GetValueByElementName(infprot, "chNFe");
            return chNFe;
        }

        // APENAS BUSCA O ENDERECO PARA ATRIBUIR AO DESTINATÁRIO OU EMITENTE
        private Endereco GetEndereco(InfNFeEndereco infNFeEndereco)
        {
            var enderElements = infNFeEndereco == InfNFeEndereco.Destinatario
                            ? GetDescendantsByElementName("enderDest")
                            : GetDescendantsByElementName("enderEmit");

            if (enderElements == null) return null;

            var xLgr = GetValueByElementName(enderElements, "xLgr");
            var nro = GetValueByElementName(enderElements, "nro");
            var xCpl = GetValueByElementName(enderElements, "xCpl");
            var xBairro = GetValueByElementName(enderElements, "xBairro");
            var cMun = GetValueByElementName(enderElements, "cMun");
            var xMun = GetValueByElementName(enderElements, "xMun");
            var UF = GetValueByElementName(enderElements, "UF");
            var CEP = GetValueByElementName(enderElements, "CEP");
            var cPais = GetValueByElementName(enderElements, "cPais");
            var xPais = GetValueByElementName(enderElements, "xPais");
            var fone = GetValueByElementName(enderElements, "fone");
            return new Endereco()
            {
                xLgr = xLgr,
                nro = nro,
                xCpl = xCpl,
                xBairro = xBairro,
                cMun = cMun,
                xMun = xMun,
                UF = UF,
                CEP = CEP,
                cPais = cPais,
                xPais = xPais,
                fone = fone
            };
        }

        #region UTIL
        private IEnumerable<XElement> GetElementsByName(string name)
        {
            return XElements.Where(x => x.Name.LocalName.Equals(name));
        }

        private string GetValueByElementName(IEnumerable<XElement> descendants, string name)
        {
            var element = descendants.SingleOrDefault(x => x.Name.LocalName.Equals(name));
            if (element != null)
                return element.Value;
            return null;
        }

        private IEnumerable<XElement> GetDescendantsByElementName(string name)
        {
            var element = XElements.SingleOrDefault(x => x.Name.LocalName.Equals(name));
            if (element != null)
                return element.Descendants();
            throw new NullReferenceException(String.Format("O elemento {0} não foi encontrado na NFe.", name));
        }

        private IEnumerable<XElement> GetDescendantsByElementName(XElement element, string name)
        {
            var descendant = element.Descendants().SingleOrDefault(x => x.Name.LocalName.Equals(name));
            if (descendant != null)
                return descendant.Descendants();
            return null;
        }

        private IEnumerable<XElement> GetDescendantsByElementName(IEnumerable<XElement> elements, string name)
        {
            var element = elements.SingleOrDefault(x => x.Name.LocalName.Equals(name));
            if (element != null)
                return element.Descendants();
            return null;
        }

        private object CreateInstance(string namespaceName)
        {
            return Activator.CreateInstance("Arcnet.Xml.Linq.NFe", namespaceName).Unwrap();
        }

        private IEnumerable<PropertyInfo> GetProperties(object obj)
        {
            return obj.GetType().GetProperties();
        }

        private void SetPropValue(object obj, string propName, object value)
        {
            var prop = obj.GetType().GetProperty(propName);
            if (prop == null) return;
            prop.SetValue(obj, value, null);
        }

        private object GetPropValue(object obj, string propName)
        {
            return obj.GetType().GetProperty(propName) != null
                       ? obj.GetType().GetProperty(propName).GetValue(obj, null)
                       : null;
        }

        private void SetPropertiesByElements(IEnumerable<XElement> elements, object obj)
        {
            foreach (var prop in GetProperties(obj))
            {
                var elementValue = GetValueByElementName(elements, prop.Name);
                if (elementValue != null)
                    SetPropValue(obj, prop.Name, elementValue);
            }
        }
        #endregion
    }

}
