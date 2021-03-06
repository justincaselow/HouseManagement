﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("HouseModel", "ITransactionPerson", "ITransaction", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HouseManagement.Models.ITransaction), "Person", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HouseManagement.Models.Person))]
[assembly: EdmRelationshipAttribute("HouseModel", "ExpenseItemType", "Expense", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HouseManagement.Models.Expense), "ItemType", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HouseManagement.Models.ItemType))]
[assembly: EdmRelationshipAttribute("HouseModel", "CreditPerson", "Credit", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HouseManagement.Models.Credit), "Person", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(HouseManagement.Models.Person))]

#endregion

namespace HouseManagement.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HouseModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HouseModelContainer object using the connection string found in the 'HouseModelContainer' section of the application configuration file.
        /// </summary>
        public HouseModelContainer() : base("name=HouseModelContainer", "HouseModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HouseModelContainer object.
        /// </summary>
        public HouseModelContainer(string connectionString) : base(connectionString, "HouseModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HouseModelContainer object.
        /// </summary>
        public HouseModelContainer(EntityConnection connection) : base(connection, "HouseModelContainer")
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
        public ObjectSet<ItemType> ItemTypes
        {
            get
            {
                if ((_ItemTypes == null))
                {
                    _ItemTypes = base.CreateObjectSet<ItemType>("ItemTypes");
                }
                return _ItemTypes;
            }
        }
        private ObjectSet<ItemType> _ItemTypes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Person> People
        {
            get
            {
                if ((_People == null))
                {
                    _People = base.CreateObjectSet<Person>("People");
                }
                return _People;
            }
        }
        private ObjectSet<Person> _People;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ITransaction> ITransactions
        {
            get
            {
                if ((_ITransactions == null))
                {
                    _ITransactions = base.CreateObjectSet<ITransaction>("ITransactions");
                }
                return _ITransactions;
            }
        }
        private ObjectSet<ITransaction> _ITransactions;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ItemTypes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItemTypes(ItemType itemType)
        {
            base.AddObject("ItemTypes", itemType);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ITransactions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToITransactions(ITransaction iTransaction)
        {
            base.AddObject("ITransactions", iTransaction);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HouseModel", Name="Credit")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Credit : ITransaction
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Credit object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="gbpAmount">Initial value of the GbpAmount property.</param>
        /// <param name="transactionDate">Initial value of the TransactionDate property.</param>
        public static Credit CreateCredit(global::System.Int32 id, global::System.Decimal gbpAmount, global::System.DateTime transactionDate)
        {
            Credit credit = new Credit();
            credit.Id = id;
            credit.GbpAmount = gbpAmount;
            credit.TransactionDate = transactionDate;
            return credit;
        }

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HouseModel", "CreditPerson", "Person")]
        public Person Payee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("HouseModel.CreditPerson", "Person").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("HouseModel.CreditPerson", "Person").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Person> PayeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("HouseModel.CreditPerson", "Person");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Person>("HouseModel.CreditPerson", "Person", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HouseModel", Name="Expense")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Expense : ITransaction
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Expense object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="gbpAmount">Initial value of the GbpAmount property.</param>
        /// <param name="transactionDate">Initial value of the TransactionDate property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="quantity">Initial value of the Quantity property.</param>
        public static Expense CreateExpense(global::System.Int32 id, global::System.Decimal gbpAmount, global::System.DateTime transactionDate, global::System.String description, global::System.Double quantity)
        {
            Expense expense = new Expense();
            expense.Id = id;
            expense.GbpAmount = gbpAmount;
            expense.TransactionDate = transactionDate;
            expense.Description = description;
            expense.Quantity = quantity;
            return expense;
        }

        #endregion

        #region Simple Properties
    
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
                _Description = StructuralObject.SetValidValue(value, false, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                OnQuantityChanging(value);
                ReportPropertyChanging("Quantity");
                _Quantity = StructuralObject.SetValidValue(value, "Quantity");
                ReportPropertyChanged("Quantity");
                OnQuantityChanged();
            }
        }
        private global::System.Double _Quantity;
        partial void OnQuantityChanging(global::System.Double value);
        partial void OnQuantityChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HouseModel", "ExpenseItemType", "ItemType")]
        public ItemType ItemType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ItemType>("HouseModel.ExpenseItemType", "ItemType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ItemType>("HouseModel.ExpenseItemType", "ItemType").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ItemType> ItemTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ItemType>("HouseModel.ExpenseItemType", "ItemType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ItemType>("HouseModel.ExpenseItemType", "ItemType", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HouseModel", Name="ItemType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ItemType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ItemType object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        public static ItemType CreateItemType(global::System.Int32 id, global::System.String description)
        {
            ItemType itemType = new ItemType();
            itemType.Id = id;
            itemType.Description = description;
            return itemType;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
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
                _Description = StructuralObject.SetValidValue(value, false, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HouseModel", Name="ITransaction")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(Expense))]
    [KnownTypeAttribute(typeof(Credit))]
    public partial class ITransaction : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ITransaction object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="gbpAmount">Initial value of the GbpAmount property.</param>
        /// <param name="transactionDate">Initial value of the TransactionDate property.</param>
        public static ITransaction CreateITransaction(global::System.Int32 id, global::System.Decimal gbpAmount, global::System.DateTime transactionDate)
        {
            ITransaction iTransaction = new ITransaction();
            iTransaction.Id = id;
            iTransaction.GbpAmount = gbpAmount;
            iTransaction.TransactionDate = transactionDate;
            return iTransaction;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal GbpAmount
        {
            get
            {
                return _GbpAmount;
            }
            set
            {
                OnGbpAmountChanging(value);
                ReportPropertyChanging("GbpAmount");
                _GbpAmount = StructuralObject.SetValidValue(value, "GbpAmount");
                ReportPropertyChanged("GbpAmount");
                OnGbpAmountChanged();
            }
        }
        private global::System.Decimal _GbpAmount;
        partial void OnGbpAmountChanging(global::System.Decimal value);
        partial void OnGbpAmountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime TransactionDate
        {
            get
            {
                return _TransactionDate;
            }
            set
            {
                OnTransactionDateChanging(value);
                ReportPropertyChanging("TransactionDate");
                _TransactionDate = StructuralObject.SetValidValue(value, "TransactionDate");
                ReportPropertyChanged("TransactionDate");
                OnTransactionDateChanged();
            }
        }
        private global::System.DateTime _TransactionDate;
        partial void OnTransactionDateChanging(global::System.DateTime value);
        partial void OnTransactionDateChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HouseModel", "ITransactionPerson", "Person")]
        public Person Payer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("HouseModel.ITransactionPerson", "Person").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("HouseModel.ITransactionPerson", "Person").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Person> PayerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Person>("HouseModel.ITransactionPerson", "Person");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Person>("HouseModel.ITransactionPerson", "Person", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="HouseModel", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Person CreatePerson(global::System.Int32 id, global::System.String name)
        {
            Person person = new Person();
            person.Id = id;
            person.Name = name;
            return person;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("HouseModel", "ITransactionPerson", "ITransaction")]
        public EntityCollection<ITransaction> ITransactions
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ITransaction>("HouseModel.ITransactionPerson", "ITransaction");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ITransaction>("HouseModel.ITransactionPerson", "ITransaction", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
