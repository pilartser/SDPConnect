﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDPConnect.SDPService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", ConfigurationName="SDPService.SdpService")]
    public interface SdpService {
        
        // CODEGEN: Контракт генерации сообщений с операцией PaymentCheckSum не является ни RPC, ни упакованным документом.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseMsg))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseRequest))]
        SDPConnect.SDPService.PaymentCheckSumResponse1 PaymentCheckSum(SDPConnect.SDPService.PaymentCheckSumRequest1 request);
        
        // CODEGEN: Контракт генерации сообщений с операцией CardPayment не является ни RPC, ни упакованным документом.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseMsg))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseRequest))]
        SDPConnect.SDPService.CardPaymentResponse1 CardPayment(SDPConnect.SDPService.CardPaymentRequest1 request);
        
        // CODEGEN: Контракт генерации сообщений с операцией CardInfo не является ни RPC, ни упакованным документом.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseMsg))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(baseRequest))]
        SDPConnect.SDPService.CardInfoResponse1 CardInfo(SDPConnect.SDPService.CardInfoRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class PaymentCheckSumRequest : baseRequest {
        
        private string sessionIdField;
        
        private string tariffIdField;
        
        private int paymentSumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string sessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
                this.RaisePropertyChanged("sessionId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string tariffId {
            get {
                return this.tariffIdField;
            }
            set {
                this.tariffIdField = value;
                this.RaisePropertyChanged("tariffId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int paymentSum {
            get {
                return this.paymentSumField;
            }
            set {
                this.paymentSumField = value;
                this.RaisePropertyChanged("paymentSum");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class baseRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string agentIdField;
        
        private string salepointIdField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string agentId {
            get {
                return this.agentIdField;
            }
            set {
                this.agentIdField = value;
                this.RaisePropertyChanged("agentId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string salepointId {
            get {
                return this.salepointIdField;
            }
            set {
                this.salepointIdField = value;
                this.RaisePropertyChanged("salepointId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
                this.RaisePropertyChanged("version");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardCheck : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int otypeField;
        
        private string textField;
        
        private string unaccountedResidueInfoField;
        
        private int unaccountedResidueSumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int otype {
            get {
                return this.otypeField;
            }
            set {
                this.otypeField = value;
                this.RaisePropertyChanged("otype");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
                this.RaisePropertyChanged("text");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string unaccountedResidueInfo {
            get {
                return this.unaccountedResidueInfoField;
            }
            set {
                this.unaccountedResidueInfoField = value;
                this.RaisePropertyChanged("unaccountedResidueInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int unaccountedResidueSum {
            get {
                return this.unaccountedResidueSumField;
            }
            set {
                this.unaccountedResidueSumField = value;
                this.RaisePropertyChanged("unaccountedResidueSum");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class Company : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string addressField;
        
        private string phoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
                this.RaisePropertyChanged("phone");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class Tariff : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string textField;
        
        private int minSumIntField;
        
        private int maxSumIntField;
        
        private string unaccountedResidueInfoField;
        
        private int unaccountedResidueSumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
                this.RaisePropertyChanged("text");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int minSumInt {
            get {
                return this.minSumIntField;
            }
            set {
                this.minSumIntField = value;
                this.RaisePropertyChanged("minSumInt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int maxSumInt {
            get {
                return this.maxSumIntField;
            }
            set {
                this.maxSumIntField = value;
                this.RaisePropertyChanged("maxSumInt");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string unaccountedResidueInfo {
            get {
                return this.unaccountedResidueInfoField;
            }
            set {
                this.unaccountedResidueInfoField = value;
                this.RaisePropertyChanged("unaccountedResidueInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int unaccountedResidueSum {
            get {
                return this.unaccountedResidueSumField;
            }
            set {
                this.unaccountedResidueSumField = value;
                this.RaisePropertyChanged("unaccountedResidueSum");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaymentCheckInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CardPayment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CardInfo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class baseMsg : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sessionIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string sessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
                this.RaisePropertyChanged("sessionId");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class PaymentCheckInfo : baseMsg {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardPayment : baseMsg {
        
        private string cheqField;
        
        private int fullSumField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string cheq {
            get {
                return this.cheqField;
            }
            set {
                this.cheqField = value;
                this.RaisePropertyChanged("cheq");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int fullSum {
            get {
                return this.fullSumField;
            }
            set {
                this.fullSumField = value;
                this.RaisePropertyChanged("fullSum");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardInfo : baseMsg {
        
        private Tariff tariffField;
        
        private Company companyField;
        
        private CardCheck infoField;
        
        private string[] warningMsgField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Tariff tariff {
            get {
                return this.tariffField;
            }
            set {
                this.tariffField = value;
                this.RaisePropertyChanged("tariff");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Company company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
                this.RaisePropertyChanged("company");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public CardCheck info {
            get {
                return this.infoField;
            }
            set {
                this.infoField = value;
                this.RaisePropertyChanged("info");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("warningMsg", IsNullable=true, Order=3)]
        public string[] warningMsg {
            get {
                return this.warningMsgField;
            }
            set {
                this.warningMsgField = value;
                this.RaisePropertyChanged("warningMsg");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class Result : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int resultCodeField;
        
        private string resultCodeTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int resultCode {
            get {
                return this.resultCodeField;
            }
            set {
                this.resultCodeField = value;
                this.RaisePropertyChanged("resultCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string resultCodeText {
            get {
                return this.resultCodeTextField;
            }
            set {
                this.resultCodeTextField = value;
                this.RaisePropertyChanged("resultCodeText");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class BaseResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Result resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Result Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class PaymentCheckSumResponse : BaseResponse {
        
        private PaymentCheckInfo paymentCheckInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PaymentCheckInfo PaymentCheckInfo {
            get {
                return this.paymentCheckInfoField;
            }
            set {
                this.paymentCheckInfoField = value;
                this.RaisePropertyChanged("PaymentCheckInfo");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentCheckSumRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", Order=0)]
        public SDPConnect.SDPService.PaymentCheckSumRequest PaymentCheckSumRequest;
        
        public PaymentCheckSumRequest1() {
        }
        
        public PaymentCheckSumRequest1(SDPConnect.SDPService.PaymentCheckSumRequest PaymentCheckSumRequest) {
            this.PaymentCheckSumRequest = PaymentCheckSumRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PaymentCheckSumResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", Order=0)]
        public SDPConnect.SDPService.PaymentCheckSumResponse PaymentCheckSumResponse;
        
        public PaymentCheckSumResponse1() {
        }
        
        public PaymentCheckSumResponse1(SDPConnect.SDPService.PaymentCheckSumResponse PaymentCheckSumResponse) {
            this.PaymentCheckSumResponse = PaymentCheckSumResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardPaymentRequest : baseRequest {
        
        private string sessionIdField;
        
        private string tariffIdField;
        
        private int paymentSumField;
        
        private string paymentInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string sessionId {
            get {
                return this.sessionIdField;
            }
            set {
                this.sessionIdField = value;
                this.RaisePropertyChanged("sessionId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string tariffId {
            get {
                return this.tariffIdField;
            }
            set {
                this.tariffIdField = value;
                this.RaisePropertyChanged("tariffId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int paymentSum {
            get {
                return this.paymentSumField;
            }
            set {
                this.paymentSumField = value;
                this.RaisePropertyChanged("paymentSum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string paymentInfo {
            get {
                return this.paymentInfoField;
            }
            set {
                this.paymentInfoField = value;
                this.RaisePropertyChanged("paymentInfo");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardPaymentResponse : BaseResponse {
        
        private CardPayment cardPaymentInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CardPayment CardPaymentInformation {
            get {
                return this.cardPaymentInformationField;
            }
            set {
                this.cardPaymentInformationField = value;
                this.RaisePropertyChanged("CardPaymentInformation");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CardPaymentRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", Order=0)]
        public SDPConnect.SDPService.CardPaymentRequest CardPaymentRequest;
        
        public CardPaymentRequest1() {
        }
        
        public CardPaymentRequest1(SDPConnect.SDPService.CardPaymentRequest CardPaymentRequest) {
            this.CardPaymentRequest = CardPaymentRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CardPaymentResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", Order=0)]
        public SDPConnect.SDPService.CardPaymentResponse CardPaymentResponse;
        
        public CardPaymentResponse1() {
        }
        
        public CardPaymentResponse1(SDPConnect.SDPService.CardPaymentResponse CardPaymentResponse) {
            this.CardPaymentResponse = CardPaymentResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardInfoRequest : baseRequest {
        
        private int sysNumField;
        
        private int regionIdField;
        
        private string deviceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int sysNum {
            get {
                return this.sysNumField;
            }
            set {
                this.sysNumField = value;
                this.RaisePropertyChanged("sysNum");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int regionId {
            get {
                return this.regionIdField;
            }
            set {
                this.regionIdField = value;
                this.RaisePropertyChanged("regionId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string deviceId {
            get {
                return this.deviceIdField;
            }
            set {
                this.deviceIdField = value;
                this.RaisePropertyChanged("deviceId");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://umarsh.ru/sdp/servicepojo")]
    public partial class CardInfoResponse : BaseResponse {
        
        private CardInfo cardInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CardInfo CardInformation {
            get {
                return this.cardInformationField;
            }
            set {
                this.cardInformationField = value;
                this.RaisePropertyChanged("CardInformation");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CardInfoRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", Order=0)]
        public SDPConnect.SDPService.CardInfoRequest CardInfoRequest;
        
        public CardInfoRequest1() {
        }
        
        public CardInfoRequest1(SDPConnect.SDPService.CardInfoRequest CardInfoRequest) {
            this.CardInfoRequest = CardInfoRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CardInfoResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://umarsh.ru/sdp/servicepojo", Order=0)]
        public SDPConnect.SDPService.CardInfoResponse CardInfoResponse;
        
        public CardInfoResponse1() {
        }
        
        public CardInfoResponse1(SDPConnect.SDPService.CardInfoResponse CardInfoResponse) {
            this.CardInfoResponse = CardInfoResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SdpServiceChannel : SDPConnect.SDPService.SdpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SdpServiceClient : System.ServiceModel.ClientBase<SDPConnect.SDPService.SdpService>, SDPConnect.SDPService.SdpService {
        
        public SdpServiceClient() {
        }
        
        public SdpServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SdpServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SdpServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SdpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SDPConnect.SDPService.PaymentCheckSumResponse1 SDPConnect.SDPService.SdpService.PaymentCheckSum(SDPConnect.SDPService.PaymentCheckSumRequest1 request) {
            return base.Channel.PaymentCheckSum(request);
        }
        
        public SDPConnect.SDPService.PaymentCheckSumResponse PaymentCheckSum(SDPConnect.SDPService.PaymentCheckSumRequest PaymentCheckSumRequest) {
            SDPConnect.SDPService.PaymentCheckSumRequest1 inValue = new SDPConnect.SDPService.PaymentCheckSumRequest1();
            inValue.PaymentCheckSumRequest = PaymentCheckSumRequest;
            SDPConnect.SDPService.PaymentCheckSumResponse1 retVal = ((SDPConnect.SDPService.SdpService)(this)).PaymentCheckSum(inValue);
            return retVal.PaymentCheckSumResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SDPConnect.SDPService.CardPaymentResponse1 SDPConnect.SDPService.SdpService.CardPayment(SDPConnect.SDPService.CardPaymentRequest1 request) {
            return base.Channel.CardPayment(request);
        }
        
        public SDPConnect.SDPService.CardPaymentResponse CardPayment(SDPConnect.SDPService.CardPaymentRequest CardPaymentRequest) {
            SDPConnect.SDPService.CardPaymentRequest1 inValue = new SDPConnect.SDPService.CardPaymentRequest1();
            inValue.CardPaymentRequest = CardPaymentRequest;
            SDPConnect.SDPService.CardPaymentResponse1 retVal = ((SDPConnect.SDPService.SdpService)(this)).CardPayment(inValue);
            return retVal.CardPaymentResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SDPConnect.SDPService.CardInfoResponse1 SDPConnect.SDPService.SdpService.CardInfo(SDPConnect.SDPService.CardInfoRequest1 request) {
            return base.Channel.CardInfo(request);
        }
        
        public SDPConnect.SDPService.CardInfoResponse CardInfo(SDPConnect.SDPService.CardInfoRequest CardInfoRequest) {
            SDPConnect.SDPService.CardInfoRequest1 inValue = new SDPConnect.SDPService.CardInfoRequest1();
            inValue.CardInfoRequest = CardInfoRequest;
            SDPConnect.SDPService.CardInfoResponse1 retVal = ((SDPConnect.SDPService.SdpService)(this)).CardInfo(inValue);
            return retVal.CardInfoResponse;
        }
    }
}
