﻿

namespace AddressCheckSOAP.dqwsAddressCheck
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:MelissaDataAddressCheckService", ConfigurationName = "dqwsAddressCheck.IService")]
    public interface IService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "urn:MelissaDataAddressCheckService/IService/doAddressCheck", ReplyAction = "urn:MelissaDataAddressCheckService/IService/doAddressCheckResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        AddressCheckSOAP.dqwsAddressCheck.ResponseArray doAddressCheck(AddressCheckSOAP.dqwsAddressCheck.RequestArray Request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:mdWebServiceAddress")]
    public partial class RequestArray : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string transmissionReferenceField;

        private string customerIDField;

        private string optAddressParsedField;

        private RequestArrayRecord[] recordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string TransmissionReference
        {
            get
            {
                return this.transmissionReferenceField;
            }
            set
            {
                this.transmissionReferenceField = value;
                this.RaisePropertyChanged("TransmissionReference");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
                this.RaisePropertyChanged("CustomerID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string OptAddressParsed
        {
            get
            {
                return this.optAddressParsedField;
            }
            set
            {
                this.optAddressParsedField = value;
                this.RaisePropertyChanged("OptAddressParsed");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Record", Order = 3)]
        public RequestArrayRecord[] Record
        {
            get
            {
                return this.recordField;
            }
            set
            {
                this.recordField = value;
                this.RaisePropertyChanged("Record");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class RequestArrayRecord : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string recordIDField;

        private string companyField;

        private string lastNameField;

        private string urbanizationField;

        private string addressLine1Field;

        private string addressLine2Field;

        private string suiteField;

        private string cityField;

        private string stateField;

        private string zipField;

        private string plus4Field;

        private string countryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RecordID
        {
            get
            {
                return this.recordIDField;
            }
            set
            {
                this.recordIDField = value;
                this.RaisePropertyChanged("RecordID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
                this.RaisePropertyChanged("Company");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
                this.RaisePropertyChanged("LastName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Urbanization
        {
            get
            {
                return this.urbanizationField;
            }
            set
            {
                this.urbanizationField = value;
                this.RaisePropertyChanged("Urbanization");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string AddressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
                this.RaisePropertyChanged("AddressLine1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string AddressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
                this.RaisePropertyChanged("AddressLine2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Suite
        {
            get
            {
                return this.suiteField;
            }
            set
            {
                this.suiteField = value;
                this.RaisePropertyChanged("Suite");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
                this.RaisePropertyChanged("State");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
                this.RaisePropertyChanged("Zip");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string Plus4
        {
            get
            {
                return this.plus4Field;
            }
            set
            {
                this.plus4Field = value;
                this.RaisePropertyChanged("Plus4");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArray : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string versionField;

        private string transmissionReferenceField;

        private string resultsField;

        private string totalRecordsField;

        private ResponseArrayRecord[] recordField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
                this.RaisePropertyChanged("Version");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TransmissionReference
        {
            get
            {
                return this.transmissionReferenceField;
            }
            set
            {
                this.transmissionReferenceField = value;
                this.RaisePropertyChanged("TransmissionReference");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
                this.RaisePropertyChanged("Results");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string TotalRecords
        {
            get
            {
                return this.totalRecordsField;
            }
            set
            {
                this.totalRecordsField = value;
                this.RaisePropertyChanged("TotalRecords");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Record", Order = 4)]
        public ResponseArrayRecord[] Record
        {
            get
            {
                return this.recordField;
            }
            set
            {
                this.recordField = value;
                this.RaisePropertyChanged("Record");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecord : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string recordIDField;

        private string resultsField;

        private ResponseArrayRecordAddress addressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string RecordID
        {
            get
            {
                return this.recordIDField;
            }
            set
            {
                this.recordIDField = value;
                this.RaisePropertyChanged("RecordID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
                this.RaisePropertyChanged("Results");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ResponseArrayRecordAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddress : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string companyField;

        private ResponseArrayRecordAddressUrbanization urbanizationField;

        private string address1Field;

        private string address2Field;

        private string suiteField;

        private string privateMailBoxField;

        private ResponseArrayRecordAddressCity cityField;

        private ResponseArrayRecordAddressState stateField;

        private string zipField;

        private string plus4Field;

        private string carrierRouteField;

        private string deliveryPointCodeField;

        private string deliveryPointCheckDigitField;

        private string congressionalDistrictField;

        private ResponseArrayRecordAddressType typeField;

        private ResponseArrayRecordAddressCountry countryField;

        private string addressKeyField;

        private ResponseArrayRecordAddressParsed parsedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
                this.RaisePropertyChanged("Company");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ResponseArrayRecordAddressUrbanization Urbanization
        {
            get
            {
                return this.urbanizationField;
            }
            set
            {
                this.urbanizationField = value;
                this.RaisePropertyChanged("Urbanization");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
                this.RaisePropertyChanged("Address1");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Address2
        {
            get
            {
                return this.address2Field;
            }
            set
            {
                this.address2Field = value;
                this.RaisePropertyChanged("Address2");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string Suite
        {
            get
            {
                return this.suiteField;
            }
            set
            {
                this.suiteField = value;
                this.RaisePropertyChanged("Suite");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string PrivateMailBox
        {
            get
            {
                return this.privateMailBoxField;
            }
            set
            {
                this.privateMailBoxField = value;
                this.RaisePropertyChanged("PrivateMailBox");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ResponseArrayRecordAddressCity City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public ResponseArrayRecordAddressState State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
                this.RaisePropertyChanged("State");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
                this.RaisePropertyChanged("Zip");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Plus4
        {
            get
            {
                return this.plus4Field;
            }
            set
            {
                this.plus4Field = value;
                this.RaisePropertyChanged("Plus4");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string CarrierRoute
        {
            get
            {
                return this.carrierRouteField;
            }
            set
            {
                this.carrierRouteField = value;
                this.RaisePropertyChanged("CarrierRoute");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string DeliveryPointCode
        {
            get
            {
                return this.deliveryPointCodeField;
            }
            set
            {
                this.deliveryPointCodeField = value;
                this.RaisePropertyChanged("DeliveryPointCode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string DeliveryPointCheckDigit
        {
            get
            {
                return this.deliveryPointCheckDigitField;
            }
            set
            {
                this.deliveryPointCheckDigitField = value;
                this.RaisePropertyChanged("DeliveryPointCheckDigit");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string CongressionalDistrict
        {
            get
            {
                return this.congressionalDistrictField;
            }
            set
            {
                this.congressionalDistrictField = value;
                this.RaisePropertyChanged("CongressionalDistrict");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public ResponseArrayRecordAddressType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("Type");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public ResponseArrayRecordAddressCountry Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string AddressKey
        {
            get
            {
                return this.addressKeyField;
            }
            set
            {
                this.addressKeyField = value;
                this.RaisePropertyChanged("AddressKey");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public ResponseArrayRecordAddressParsed Parsed
        {
            get
            {
                return this.parsedField;
            }
            set
            {
                this.parsedField = value;
                this.RaisePropertyChanged("Parsed");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressUrbanization : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressCity : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        private string abbreviationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Abbreviation
        {
            get
            {
                return this.abbreviationField;
            }
            set
            {
                this.abbreviationField = value;
                this.RaisePropertyChanged("Abbreviation");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressState : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        private string abbreviationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Abbreviation
        {
            get
            {
                return this.abbreviationField;
            }
            set
            {
                this.abbreviationField = value;
                this.RaisePropertyChanged("Abbreviation");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressType : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ResponseArrayRecordAddressTypeAddress addressField;

        private ResponseArrayRecordAddressTypeZip zipField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ResponseArrayRecordAddressTypeAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ResponseArrayRecordAddressTypeZip Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
                this.RaisePropertyChanged("Zip");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressTypeAddress : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressTypeZip : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string codeField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressCountry : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string abbreviationField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Abbreviation
        {
            get
            {
                return this.abbreviationField;
            }
            set
            {
                this.abbreviationField = value;
                this.RaisePropertyChanged("Abbreviation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressParsed : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string streetNameField;

        private string addressRangeField;

        private string suffixField;

        private ResponseArrayRecordAddressParsedDirection directionField;

        private ResponseArrayRecordAddressParsedSuite suiteField;

        private ResponseArrayRecordAddressParsedPrivateMailbox privateMailboxField;

        private string garbageField;

        private string routeServiceField;

        private string lockBoxField;

        private string deliveryInstallationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
                this.RaisePropertyChanged("StreetName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string AddressRange
        {
            get
            {
                return this.addressRangeField;
            }
            set
            {
                this.addressRangeField = value;
                this.RaisePropertyChanged("AddressRange");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
                this.RaisePropertyChanged("Suffix");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ResponseArrayRecordAddressParsedDirection Direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
                this.RaisePropertyChanged("Direction");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ResponseArrayRecordAddressParsedSuite Suite
        {
            get
            {
                return this.suiteField;
            }
            set
            {
                this.suiteField = value;
                this.RaisePropertyChanged("Suite");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ResponseArrayRecordAddressParsedPrivateMailbox PrivateMailbox
        {
            get
            {
                return this.privateMailboxField;
            }
            set
            {
                this.privateMailboxField = value;
                this.RaisePropertyChanged("PrivateMailbox");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Garbage
        {
            get
            {
                return this.garbageField;
            }
            set
            {
                this.garbageField = value;
                this.RaisePropertyChanged("Garbage");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string RouteService
        {
            get
            {
                return this.routeServiceField;
            }
            set
            {
                this.routeServiceField = value;
                this.RaisePropertyChanged("RouteService");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string LockBox
        {
            get
            {
                return this.lockBoxField;
            }
            set
            {
                this.lockBoxField = value;
                this.RaisePropertyChanged("LockBox");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string DeliveryInstallation
        {
            get
            {
                return this.deliveryInstallationField;
            }
            set
            {
                this.deliveryInstallationField = value;
                this.RaisePropertyChanged("DeliveryInstallation");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressParsedDirection : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string postField;

        private string preField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Post
        {
            get
            {
                return this.postField;
            }
            set
            {
                this.postField = value;
                this.RaisePropertyChanged("Post");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Pre
        {
            get
            {
                return this.preField;
            }
            set
            {
                this.preField = value;
                this.RaisePropertyChanged("Pre");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressParsedSuite : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string rangeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
                this.RaisePropertyChanged("Range");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.4927")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:mdWebServiceAddress")]
    public partial class ResponseArrayRecordAddressParsedPrivateMailbox : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string nameField;

        private string rangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
                this.RaisePropertyChanged("Range");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IServiceChannel : AddressCheckSOAP.dqwsAddressCheck.IService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<AddressCheckSOAP.dqwsAddressCheck.IService>, AddressCheckSOAP.dqwsAddressCheck.IService
    {

        public ServiceClient()
        {
        }

        public ServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public AddressCheckSOAP.dqwsAddressCheck.ResponseArray doAddressCheck(AddressCheckSOAP.dqwsAddressCheck.RequestArray Request)
        {
            return base.Channel.doAddressCheck(Request);
        }
    }
}
