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
    [System.Xml.Serialization.XmlTypeAttribute("arkivdel", Namespace="http://www.arkivverket.no/standarder/noark5/arkivstruktur")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Arkivdel
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.IO.Arkiv.Client.Models.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M020</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tittel")]
        public string Tittel { get; set; }
        
        /// <summary>
        /// <para>M021</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("beskrivelse")]
        public string Beskrivelse { get; set; }
        
        /// <summary>
        /// <para>M051</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("arkivdelstatus")]
        public string Arkivdelstatus { get; set; }
        
        /// <summary>
        /// <para>M300</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("dokumentmedium")]
        public string Dokumentmedium { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _oppbevaringssted;
        
        /// <summary>
        /// <para>M301</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("oppbevaringssted")]
        public System.Collections.ObjectModel.Collection<string> Oppbevaringssted
        {
            get
            {
                return this._oppbevaringssted;
            }
            private set
            {
                this._oppbevaringssted = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OppbevaringsstedSpecified
        {
            get
            {
                return (this.Oppbevaringssted.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Arkivdel()
        {
            this._oppbevaringssted = new System.Collections.ObjectModel.Collection<string>();
            this._klassifikasjonssystem = new System.Collections.ObjectModel.Collection<Klassifikasjonssystem>();
            this._mappe = new System.Collections.ObjectModel.Collection<Mappe>();
            this._registrering = new System.Collections.ObjectModel.Collection<Registrering>();
        }
        
        /// <summary>
        /// <para>M600</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("opprettetDato", DataType="dateTime")]
        public System.DateTime OpprettetDato { get; set; }
        
        /// <summary>
        /// <para>M601</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("opprettetAv")]
        public string OpprettetAv { get; set; }
        
        /// <summary>
        /// <para>M602</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("avsluttetDato", DataType="dateTime")]
        public System.DateTime AvsluttetDato { get; set; }
        
        /// <summary>
        /// <para>M603</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("avsluttetAv")]
        public string AvsluttetAv { get; set; }
        
        /// <summary>
        /// <para>M107</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("arkivperiodeStartDato", DataType="date")]
        public System.DateTime ArkivperiodeStartDato { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArkivperiodeStartDatoSpecified { get; set; }
        
        /// <summary>
        /// <para>M108</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("arkivperiodeSluttDato", DataType="date")]
        public System.DateTime ArkivperiodeSluttDato { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArkivperiodeSluttDatoSpecified { get; set; }
        
        /// <summary>
        /// <para>M202</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("referanseForloeper")]
        public string ReferanseForloeper { get; set; }
        
        /// <summary>
        /// <para>M203</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("referanseArvtaker")]
        public string ReferanseArvtaker { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("kassasjon")]
        public Kassasjon Kassasjon { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("utfoertKassasjon")]
        public UtfoertKassasjon UtfoertKassasjon { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("sletting")]
        public Sletting Sletting { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("skjerming")]
        public Skjerming Skjerming { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("gradering")]
        public Gradering Gradering { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Klassifikasjonssystem> _klassifikasjonssystem;
        
        [System.Xml.Serialization.XmlElementAttribute("klassifikasjonssystem")]
        public System.Collections.ObjectModel.Collection<Klassifikasjonssystem> Klassifikasjonssystem
        {
            get
            {
                return this._klassifikasjonssystem;
            }
            private set
            {
                this._klassifikasjonssystem = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KlassifikasjonssystemSpecified
        {
            get
            {
                return (this.Klassifikasjonssystem.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Mappe> _mappe;
        
        [System.Xml.Serialization.XmlElementAttribute("mappe")]
        public System.Collections.ObjectModel.Collection<Mappe> Mappe
        {
            get
            {
                return this._mappe;
            }
            private set
            {
                this._mappe = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MappeSpecified
        {
            get
            {
                return (this.Mappe.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Registrering> _registrering;
        
        [System.Xml.Serialization.XmlElementAttribute("registrering")]
        public System.Collections.ObjectModel.Collection<Registrering> Registrering
        {
            get
            {
                return this._registrering;
            }
            private set
            {
                this._registrering = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegistreringSpecified
        {
            get
            {
                return (this.Registrering.Count != 0);
            }
        }
    }
}
