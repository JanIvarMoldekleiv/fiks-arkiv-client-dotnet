//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.629.0
namespace KS.Fiks.IO.Arkiv.Client.Models.Innsyn.Sok
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.629.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("resultatMinimum", Namespace="http://www.ks.no/standarder/fiks/arkiv/sokeresultat/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResultatMinimum
    {
        
        [System.Xml.Serialization.XmlElementAttribute("mappe")]
        public KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur.MappeMinimum Mappe { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("saksmappe")]
        public KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur.SaksmappeMinimum Saksmappe { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("registrering")]
        public KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur.RegistreringMinimum Registrering { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("journalpost")]
        public KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur.JournalpostMinimum Journalpost { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dokumentbeskrivelse")]
        public KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur.DokumentbeskrivelseMinimum Dokumentbeskrivelse { get; set; }
    }
}
