//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.629.0
namespace KS.Fiks.IO.Arkiv.Client.Models.Arkivering.Arkivmelding
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.629.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("klassifikasjon", Namespace="http://www.arkivverket.no/standarder/noark5/arkivmelding/v2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Klassifikasjon
    {
        
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.IO.Arkiv.Client.Models.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M4..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("klassifikasjonssystem")]
        public string Klassifikasjonssystem { get; set; }
        
        /// <summary>
        /// <para>M002</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("klasseID")]
        public string KlasseID { get; set; }
        
        /// <summary>
        /// <para>M020</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("tittel")]
        public string Tittel { get; set; }
        
        /// <summary>
        /// <para>M5..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("skjermetObjekt")]
        public string SkjermetObjekt { get; set; }
    }
}
