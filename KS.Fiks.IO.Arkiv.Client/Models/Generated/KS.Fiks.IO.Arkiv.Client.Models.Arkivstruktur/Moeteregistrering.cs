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
    [System.Xml.Serialization.XmlTypeAttribute("moeteregistrering", Namespace="http://www.arkivverket.no/standarder/noark5/arkivstruktur")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Moeteregistrering : Registrering
    {
        
        /// <summary>
        /// <para>M085</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("moeteregistreringstype")]
        public string Moeteregistreringstype { get; set; }
        
        /// <summary>
        /// <para>M088</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("moetesakstype")]
        public string Moetesakstype { get; set; }
        
        /// <summary>
        /// <para>M055</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("moeteregistreringsstatus")]
        public string Moeteregistreringsstatus { get; set; }
        
        /// <summary>
        /// <para>M305</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("administrativEnhet")]
        public string AdministrativEnhet { get; set; }
        
        /// <summary>
        /// <para>M307</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("saksbehandler")]
        public string Saksbehandler { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _referanseTilMoeteregistrering;
        
        /// <summary>
        /// <para>M223</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("referanseTilMoeteregistrering")]
        public System.Collections.ObjectModel.Collection<string> ReferanseTilMoeteregistrering
        {
            get
            {
                return this._referanseTilMoeteregistrering;
            }
            private set
            {
                this._referanseTilMoeteregistrering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferanseTilMoeteregistreringSpecified
        {
            get
            {
                return (this.ReferanseTilMoeteregistrering.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Moeteregistrering()
        {
            this._referanseTilMoeteregistrering = new System.Collections.ObjectModel.Collection<string>();
            this._referanseFraMoeteregistrering = new System.Collections.ObjectModel.Collection<string>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _referanseFraMoeteregistrering;
        
        /// <summary>
        /// <para>M224</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("referanseFraMoeteregistrering")]
        public System.Collections.ObjectModel.Collection<string> ReferanseFraMoeteregistrering
        {
            get
            {
                return this._referanseFraMoeteregistrering;
            }
            private set
            {
                this._referanseFraMoeteregistrering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferanseFraMoeteregistreringSpecified
        {
            get
            {
                return (this.ReferanseFraMoeteregistrering.Count != 0);
            }
        }
    }
}
