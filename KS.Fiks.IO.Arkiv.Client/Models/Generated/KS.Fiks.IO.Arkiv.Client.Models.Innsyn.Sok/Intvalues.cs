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
    [System.Xml.Serialization.XmlTypeAttribute("intvalues", Namespace="http://www.ks.no/standarder/fiks/arkiv/sok/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Intvalues
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<int> _value;
        
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public System.Collections.ObjectModel.Collection<int> Value
        {
            get
            {
                return this._value;
            }
            private set
            {
                this._value = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified
        {
            get
            {
                return (this.Value.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Intvalues()
        {
            this._value = new System.Collections.ObjectModel.Collection<int>();
        }
    }
}
