//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.629.0
namespace KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.629.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("merknad", Namespace="http://www.arkivverket.no/standarder/noark5/arkivstruktur")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("merknad", Namespace="http://www.arkivverket.no/standarder/noark5/arkivstruktur")]
    public partial class Merknad
    {
        
        /// <summary>
        /// <para>M310</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("merknadstekst")]
        public string Merknadstekst { get; set; }
        
        /// <summary>
        /// <para>M084</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("merknadstype")]
        public string Merknadstype { get; set; }
        
        /// <summary>
        /// <para>M611</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("merknadsdato", DataType="dateTime")]
        public System.DateTime Merknadsdato { get; set; }
        
        /// <summary>
        /// <para>M612</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("merknadRegistrertAv")]
        public string MerknadRegistrertAv { get; set; }
    }
}
