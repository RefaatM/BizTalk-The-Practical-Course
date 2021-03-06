﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://AutoErrorHandler.GTErrorSchema")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://AutoErrorHandler.GTErrorSchema", IsNullable=false)]
public partial class ErrorMessage {
    
    private ErrorMessageError errorField;
    
    private object messageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ErrorMessageError Error {
        get {
            return this.errorField;
        }
        set {
            this.errorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object Message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://AutoErrorHandler.GTErrorSchema")]
public partial class ErrorMessageError {
    
    private string descriptionField;
    
    private string errorTypeField;
    
    private string routingFailureReportIDField;
    
    private string outboundTransportLocationField;
    
    private string sendPortNameField;
    
    private string inboundTransportLocationField;
    
    private string receivePortNameField;
    
    private string messageTypeField;
    
    private int failureCategoryField;
    
    private bool failureCategoryFieldSpecified;
    
    private string failureCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ErrorType {
        get {
            return this.errorTypeField;
        }
        set {
            this.errorTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RoutingFailureReportID {
        get {
            return this.routingFailureReportIDField;
        }
        set {
            this.routingFailureReportIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OutboundTransportLocation {
        get {
            return this.outboundTransportLocationField;
        }
        set {
            this.outboundTransportLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SendPortName {
        get {
            return this.sendPortNameField;
        }
        set {
            this.sendPortNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string InboundTransportLocation {
        get {
            return this.inboundTransportLocationField;
        }
        set {
            this.inboundTransportLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ReceivePortName {
        get {
            return this.receivePortNameField;
        }
        set {
            this.receivePortNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MessageType {
        get {
            return this.messageTypeField;
        }
        set {
            this.messageTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int FailureCategory {
        get {
            return this.failureCategoryField;
        }
        set {
            this.failureCategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FailureCategorySpecified {
        get {
            return this.failureCategoryFieldSpecified;
        }
        set {
            this.failureCategoryFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FailureCode {
        get {
            return this.failureCodeField;
        }
        set {
            this.failureCodeField = value;
        }
    }
}
