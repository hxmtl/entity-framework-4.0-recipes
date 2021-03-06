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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EFRecipesModel", "FK_Order_OrderStatus", "OrderStatus", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Recipe9.OrderStatus), "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Recipe9.Order))]

#endregion

namespace Recipe9
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
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderStatus> OrderStatus
        {
            get
            {
                if ((_OrderStatus == null))
                {
                    _OrderStatus = base.CreateObjectSet<OrderStatus>("OrderStatus");
                }
                return _OrderStatus;
            }
        }
        private ObjectSet<OrderStatus> _OrderStatus;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderStatus EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderStatus(OrderStatus orderStatus)
        {
            base.AddObject("OrderStatus", orderStatus);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        public static Order CreateOrder(global::System.Int32 orderId, global::System.String description)
        {
            Order order = new Order();
            order.OrderId = orderId;
            order.Description = description;
            return order;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if (_OrderId != value)
                {
                    OnOrderIdChanging(value);
                    ReportPropertyChanging("OrderId");
                    _OrderId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
        }
        private global::System.Int32 _OrderId;
        partial void OnOrderIdChanging(global::System.Int32 value);
        partial void OnOrderIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Order_OrderStatus", "OrderStatus")]
        public OrderStatus OrderStatus
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrderStatus>("EFRecipesModel.FK_Order_OrderStatus", "OrderStatus").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrderStatus>("EFRecipesModel.FK_Order_OrderStatus", "OrderStatus").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<OrderStatus> OrderStatusReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrderStatus>("EFRecipesModel.FK_Order_OrderStatus", "OrderStatus");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<OrderStatus>("EFRecipesModel.FK_Order_OrderStatus", "OrderStatus", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EFRecipesModel", Name="OrderStatus")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderStatus : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrderStatus object.
        /// </summary>
        /// <param name="orderStatusId">Initial value of the OrderStatusId property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        public static OrderStatus CreateOrderStatus(global::System.Int32 orderStatusId, global::System.String status)
        {
            OrderStatus orderStatus = new OrderStatus();
            orderStatus.OrderStatusId = orderStatusId;
            orderStatus.Status = status;
            return orderStatus;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderStatusId
        {
            get
            {
                return _OrderStatusId;
            }
            set
            {
                if (_OrderStatusId != value)
                {
                    OnOrderStatusIdChanging(value);
                    ReportPropertyChanging("OrderStatusId");
                    _OrderStatusId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderStatusId");
                    OnOrderStatusIdChanged();
                }
            }
        }
        private global::System.Int32 _OrderStatusId;
        partial void OnOrderStatusIdChanging(global::System.Int32 value);
        partial void OnOrderStatusIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EFRecipesModel", "FK_Order_OrderStatus", "Order")]
        public EntityCollection<Order> Orders
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Order>("EFRecipesModel.FK_Order_OrderStatus", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Order>("EFRecipesModel.FK_Order_OrderStatus", "Order", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
