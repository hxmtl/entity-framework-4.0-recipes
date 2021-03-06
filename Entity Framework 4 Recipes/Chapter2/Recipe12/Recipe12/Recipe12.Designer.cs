﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Recipe12
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EFRecipesEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EFRecipesEntities object using the connection string found in the 'EFRecipesEntities' section of the application configuration file.
        /// </summary>
        public EFRecipesEntities() : base("name=EFRecipesEntities", "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(string connectionString) : base(connectionString, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EFRecipesEntities object.
        /// </summary>
        public EFRecipesEntities(EntityConnection connection) : base(connection, "EFRecipesEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Agent> Agents
        {
            get
            {
                if ((_Agents == null))
                {
                    _Agents = base.CreateObjectSet<Agent>("Agents");
                }
                return _Agents;
            }
        }
        private ObjectSet<Agent> _Agents;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Agents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAgents(Agent agent)
        {
            base.AddObject("Agents", agent);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Agent")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Agent : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Agent object.
        /// </summary>
        /// <param name="agentId">Initial value of the AgentId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        public static Agent CreateAgent(global::System.Int32 agentId, Name name, Address address)
        {
            Agent agent = new Agent();
            agent.AgentId = agentId;
            agent.Name = StructuralObject.VerifyComplexObjectIsNotNull(name, "Name");
            agent.Address = StructuralObject.VerifyComplexObjectIsNotNull(address, "Address");
            return agent;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AgentId
        {
            get
            {
                return _AgentId;
            }
            set
            {
                if (_AgentId != value)
                {
                    OnAgentIdChanging(value);
                    ReportPropertyChanging("AgentId");
                    _AgentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AgentId");
                    OnAgentIdChanged();
                }
            }
        }
        private global::System.Int32 _AgentId;
        partial void OnAgentIdChanging(global::System.Int32 value);
        partial void OnAgentIdChanged();

        #endregion
        #region Complex Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public Name Name
        {
            get
            {
                _Name = GetValidValue(_Name, "Name", false, _NameInitialized);
                _NameInitialized = true;
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = SetValidValue(_Name, value, "Name");
                _NameInitialized = true;
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private Name _Name;
        private bool _NameInitialized;
        partial void OnNameChanging(Name value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmComplexPropertyAttribute()]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [XmlElement(IsNullable=true)]
        [SoapElement(IsNullable=true)]
        [DataMemberAttribute()]
        public Address Address
        {
            get
            {
                _Address = GetValidValue(_Address, "Address", false, _AddressInitialized);
                _AddressInitialized = true;
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = SetValidValue(_Address, value, "Address");
                _AddressInitialized = true;
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private Address _Address;
        private bool _AddressInitialized;
        partial void OnAddressChanging(Address value);
        partial void OnAddressChanged();

        #endregion
    
    }

    #endregion
    #region ComplexTypes
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="EFRecipesModel", Name="Address")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class Address : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Address object.
        /// </summary>
        /// <param name="addressLine1">Initial value of the AddressLine1 property.</param>
        /// <param name="addressLine2">Initial value of the AddressLine2 property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="state">Initial value of the State property.</param>
        /// <param name="zIPCode">Initial value of the ZIPCode property.</param>
        public static Address CreateAddress(global::System.String addressLine1, global::System.String addressLine2, global::System.String city, global::System.String state, global::System.String zIPCode)
        {
            Address address = new Address();
            address.AddressLine1 = addressLine1;
            address.AddressLine2 = addressLine2;
            address.City = city;
            address.State = state;
            address.ZIPCode = zIPCode;
            return address;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AddressLine1
        {
            get
            {
                return _AddressLine1;
            }
            set
            {
                OnAddressLine1Changing(value);
                ReportPropertyChanging("AddressLine1");
                _AddressLine1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AddressLine1");
                OnAddressLine1Changed();
            }
        }
        private global::System.String _AddressLine1;
        partial void OnAddressLine1Changing(global::System.String value);
        partial void OnAddressLine1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AddressLine2
        {
            get
            {
                return _AddressLine2;
            }
            set
            {
                OnAddressLine2Changing(value);
                ReportPropertyChanging("AddressLine2");
                _AddressLine2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AddressLine2");
                OnAddressLine2Changed();
            }
        }
        private global::System.String _AddressLine2;
        partial void OnAddressLine2Changing(global::System.String value);
        partial void OnAddressLine2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String State
        {
            get
            {
                return _State;
            }
            set
            {
                OnStateChanging(value);
                ReportPropertyChanging("State");
                _State = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("State");
                OnStateChanged();
            }
        }
        private global::System.String _State;
        partial void OnStateChanging(global::System.String value);
        partial void OnStateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ZIPCode
        {
            get
            {
                return _ZIPCode;
            }
            set
            {
                OnZIPCodeChanging(value);
                ReportPropertyChanging("ZIPCode");
                _ZIPCode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ZIPCode");
                OnZIPCodeChanged();
            }
        }
        private global::System.String _ZIPCode;
        partial void OnZIPCodeChanging(global::System.String value);
        partial void OnZIPCodeChanged();

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName="EFRecipesModel", Name="Name")]
    [DataContractAttribute(IsReference=true)]
    [Serializable()]
    public partial class Name : ComplexObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Name object.
        /// </summary>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        public static Name CreateName(global::System.String firstName, global::System.String lastName)
        {
            Name name = new Name();
            name.FirstName = firstName;
            name.LastName = lastName;
            return name;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();

        #endregion
    }

    #endregion
    
}
