﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopDanvenClient.GeneratorServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Generator", Namespace="http://schemas.datacontract.org/2004/07/WcfDanvenRepairedGenerator.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Generator : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdditionalInformationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopDanvenClient.GeneratorServiceReference.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneratorApplicationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstallationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsRepairedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopDanvenClient.GeneratorServiceReference.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RunningHoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SerialNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AdditionalInformation {
            get {
                return this.AdditionalInformationField;
            }
            set {
                if ((object.ReferenceEquals(this.AdditionalInformationField, value) != true)) {
                    this.AdditionalInformationField = value;
                    this.RaisePropertyChanged("AdditionalInformation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopDanvenClient.GeneratorServiceReference.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDescription {
            get {
                return this.ErrorDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDescriptionField, value) != true)) {
                    this.ErrorDescriptionField = value;
                    this.RaisePropertyChanged("ErrorDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GeneratorApplication {
            get {
                return this.GeneratorApplicationField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneratorApplicationField, value) != true)) {
                    this.GeneratorApplicationField = value;
                    this.RaisePropertyChanged("GeneratorApplication");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InstallationDate {
            get {
                return this.InstallationDateField;
            }
            set {
                if ((object.ReferenceEquals(this.InstallationDateField, value) != true)) {
                    this.InstallationDateField = value;
                    this.RaisePropertyChanged("InstallationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsRepaired {
            get {
                return this.IsRepairedField;
            }
            set {
                if ((this.IsRepairedField.Equals(value) != true)) {
                    this.IsRepairedField = value;
                    this.RaisePropertyChanged("IsRepaired");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopDanvenClient.GeneratorServiceReference.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RunningHours {
            get {
                return this.RunningHoursField;
            }
            set {
                if ((object.ReferenceEquals(this.RunningHoursField, value) != true)) {
                    this.RunningHoursField = value;
                    this.RaisePropertyChanged("RunningHours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SerialNumber {
            get {
                return this.SerialNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.SerialNumberField, value) != true)) {
                    this.SerialNumberField = value;
                    this.RaisePropertyChanged("SerialNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeNumber {
            get {
                return this.TypeNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNumberField, value) != true)) {
                    this.TypeNumberField = value;
                    this.RaisePropertyChanged("TypeNumber");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WcfDanvenRepairedGenerator.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactPersonNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyAddress {
            get {
                return this.CompanyAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyAddressField, value) != true)) {
                    this.CompanyAddressField = value;
                    this.RaisePropertyChanged("CompanyAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactPersonName {
            get {
                return this.ContactPersonNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactPersonNameField, value) != true)) {
                    this.ContactPersonNameField = value;
                    this.RaisePropertyChanged("ContactPersonName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneField, value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/WcfDanvenRepairedGenerator.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InvoiceNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductSerialNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InvoiceNumber {
            get {
                return this.InvoiceNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.InvoiceNumberField, value) != true)) {
                    this.InvoiceNumberField = value;
                    this.RaisePropertyChanged("InvoiceNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductSerialNumber {
            get {
                return this.ProductSerialNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductSerialNumberField, value) != true)) {
                    this.ProductSerialNumberField = value;
                    this.RaisePropertyChanged("ProductSerialNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductType {
            get {
                return this.ProductTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductTypeField, value) != true)) {
                    this.ProductTypeField = value;
                    this.RaisePropertyChanged("ProductType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GeneratorServiceReference.IGeneratorService")]
    public interface IGeneratorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneratorService/CreateGenerator", ReplyAction="http://tempuri.org/IGeneratorService/CreateGeneratorResponse")]
        DesktopDanvenClient.GeneratorServiceReference.Generator CreateGenerator(DesktopDanvenClient.GeneratorServiceReference.Generator generator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneratorService/CreateGenerator", ReplyAction="http://tempuri.org/IGeneratorService/CreateGeneratorResponse")]
        System.Threading.Tasks.Task<DesktopDanvenClient.GeneratorServiceReference.Generator> CreateGeneratorAsync(DesktopDanvenClient.GeneratorServiceReference.Generator generator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneratorService/UpdateGenerator", ReplyAction="http://tempuri.org/IGeneratorService/UpdateGeneratorResponse")]
        void UpdateGenerator(DesktopDanvenClient.GeneratorServiceReference.Generator generator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneratorService/UpdateGenerator", ReplyAction="http://tempuri.org/IGeneratorService/UpdateGeneratorResponse")]
        System.Threading.Tasks.Task UpdateGeneratorAsync(DesktopDanvenClient.GeneratorServiceReference.Generator generator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneratorService/GetAll", ReplyAction="http://tempuri.org/IGeneratorService/GetAllResponse")]
        DesktopDanvenClient.GeneratorServiceReference.Generator[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeneratorService/GetAll", ReplyAction="http://tempuri.org/IGeneratorService/GetAllResponse")]
        System.Threading.Tasks.Task<DesktopDanvenClient.GeneratorServiceReference.Generator[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGeneratorServiceChannel : DesktopDanvenClient.GeneratorServiceReference.IGeneratorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeneratorServiceClient : System.ServiceModel.ClientBase<DesktopDanvenClient.GeneratorServiceReference.IGeneratorService>, DesktopDanvenClient.GeneratorServiceReference.IGeneratorService {
        
        public GeneratorServiceClient() {
        }
        
        public GeneratorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeneratorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneratorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneratorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DesktopDanvenClient.GeneratorServiceReference.Generator CreateGenerator(DesktopDanvenClient.GeneratorServiceReference.Generator generator) {
            return base.Channel.CreateGenerator(generator);
        }
        
        public System.Threading.Tasks.Task<DesktopDanvenClient.GeneratorServiceReference.Generator> CreateGeneratorAsync(DesktopDanvenClient.GeneratorServiceReference.Generator generator) {
            return base.Channel.CreateGeneratorAsync(generator);
        }
        
        public void UpdateGenerator(DesktopDanvenClient.GeneratorServiceReference.Generator generator) {
            base.Channel.UpdateGenerator(generator);
        }
        
        public System.Threading.Tasks.Task UpdateGeneratorAsync(DesktopDanvenClient.GeneratorServiceReference.Generator generator) {
            return base.Channel.UpdateGeneratorAsync(generator);
        }
        
        public DesktopDanvenClient.GeneratorServiceReference.Generator[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<DesktopDanvenClient.GeneratorServiceReference.Generator[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
