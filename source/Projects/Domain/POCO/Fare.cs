using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace EuTravel_2.BO
{
    /// <summary>
    /// The Fare class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Fare : IDomainModelClass
    {
        #region Fare's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="TotalPrice")]
        protected decimal? totalPrice;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="TaxAmount")]
        protected decimal? taxAmount;
        [DataMember(Name="BasePrice")]
        protected decimal? basePrice;
        #endregion
        #region Fare's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The TotalPrice property
///
/// </summary>
///
        public virtual decimal? TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
            }
        }
/// <summary>
/// The Description property
///
/// </summary>
///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
/// <summary>
/// The TaxAmount property
///
/// </summary>
///
        public virtual decimal? TaxAmount
        {
            get
            {
                return taxAmount;
            }
            set
            {
                taxAmount = value;
            }
        }
/// <summary>
/// The BasePrice property
///
/// </summary>
///
        public virtual decimal? BasePrice
        {
            get
            {
                return basePrice;
            }
            set
            {
                basePrice = value;
            }
        }
        #endregion
        #region Fare's Participant Properties
        [DataMember(Name="Leg")]
        protected Leg leg;
        public virtual Leg Leg
        {
            get
            {
                return leg;
            }
            set
            {
                if(Equals(leg, value)) return;
                var __oldValue = leg;
                if (value != null)
                {
                    if(leg != null && !Equals(leg, value))
                        leg.Fare = null;
                    leg = value;
                    if(leg.Fare != this)
                        leg.Fare = this;
                }
                else
                {
                    if (leg != null)
                    {
                        var __obj = leg;
                        leg = null;
                        __obj.Fare = null;
                    }
                }
            }
        }
        [DataMember(Name="Charges")]
        protected IList<Charge> charges = new List<Charge>();
        public virtual List<Charge> Charges
        {
            get
            {
                if (charges is Charge[])
                {
                    charges = charges.ToList();
                }
                if (charges == null)
                {
                    charges = new List<Charge>();
                }
                return charges.ToList();
            }
            set
            {
                if (charges is Charge[])
                {
                    charges = charges.ToList();
                }
                if (charges != null)
                {
                    var __itemsToDelete = new List<Charge>(charges);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveCharges(__item);
                    }
                }
                if(value == null)
                {
                    charges = new List<Charge>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddCharges(__item);
                }
            }
        }
        public virtual void AddCharges(IList<Charge> __items)
        {
            foreach (var __item in __items)
            {
                AddCharges(__item);
            }
        }
        public virtual void AddCharges(Charge __item)
        {
            if (__item != null && charges!=null && !charges.Contains(__item))
            {
                charges.Add(__item);
                if (__item.Fare != this)
                    __item.Fare = this;
            }
        }

        public virtual void RemoveCharges(Charge __item)
        {
            if (__item != null && charges!=null && charges.Contains(__item))
            {
                charges.Remove(__item);
                __item.Fare = null;
            }
        }
        public virtual void SetChargesAt(Charge __item, int __index)
        {
            if (__item == null)
            {
                charges[__index].Fare = null;
            }
            else
            {
                charges[__index] = __item;
                if (__item.Fare != this)
                    __item.Fare = this;
            }
        }

        public virtual void ClearCharges()
        {
            if (charges!=null)
            {
                var __itemsToRemove = charges.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveCharges(__item);
                }
            }
        }
        [DataMember(Name="FareType")]
        protected FareType fareType;
        public virtual FareType FareType
        {
            get
            {
                return fareType;
            }
            set
            {
                if(Equals(fareType, value)) return;
                var __oldValue = fareType;
                if (value != null)
                {
                    fareType = value;
                }
                else
                {
                    fareType = null;
                }
            }
        }
        [DataMember(Name="Datasource")]
        protected IList<Datasource> datasource = new List<Datasource>();
        public virtual List<Datasource> Datasource
        {
            get
            {
                if (datasource is Datasource[])
                {
                    datasource = datasource.ToList();
                }
                if (datasource == null)
                {
                    datasource = new List<Datasource>();
                }
                return datasource.ToList();
            }
            set
            {
                if (datasource is Datasource[])
                {
                    datasource = datasource.ToList();
                }
                if (datasource != null)
                {
                    var __itemsToDelete = new List<Datasource>(datasource);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDatasource(__item);
                    }
                }
                if(value == null)
                {
                    datasource = new List<Datasource>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDatasource(__item);
                }
            }
        }
        public virtual void AddDatasource(IList<Datasource> __items)
        {
            foreach (var __item in __items)
            {
                AddDatasource(__item);
            }
        }
        public virtual void AddDatasource(Datasource __item)
        {
            if (__item != null && datasource!=null && !datasource.Contains(__item))
            {
                datasource.Add(__item);
            }
        }

        public virtual void RemoveDatasource(Datasource __item)
        {
            if (__item != null && datasource!=null && datasource.Contains(__item))
            {
                datasource.Remove(__item);
            }
        }
        public virtual void SetDatasourceAt(Datasource __item, int __index)
        {
            if (__item == null)
            {
                datasource[__index] = null;
            }
            else
            {
                datasource[__index] = __item;
            }
        }

        public virtual void ClearDatasource()
        {
            if (datasource!=null)
            {
                var __itemsToRemove = datasource.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDatasource(__item);
                }
            }
        }
        [DataMember(Name="Currency")]
        protected Currency currency;
        public virtual Currency Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if(Equals(currency, value)) return;
                var __oldValue = currency;
                if (value != null)
                {
                    currency = value;
                }
                else
                {
                    currency = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Fare class
/// </summary>
/// <returns>New Fare object</returns>
/// <remarks></remarks>
        public Fare() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (TotalPrice == null)
            {
                __errors.Add("Property 'TotalPrice' is required.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Fare' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [Fare] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Fare Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Fare copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Fare)copiedObjects[this];
            copy = copy ?? new Fare();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.TotalPrice = this.TotalPrice;
            copy.Description = this.Description;
            copy.TaxAmount = this.TaxAmount;
            copy.BasePrice = this.BasePrice;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.leg != null)
            {
                if (!copiedObjects.Contains(this.leg))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Leg = this.Leg;
                    else if (asNew)
                        copy.Leg = this.Leg.Copy(deep, copiedObjects, true);
                    else
                        copy.leg = this.leg.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Leg = (Leg)copiedObjects[this.Leg];
                    else
                        copy.leg = (Leg)copiedObjects[this.Leg];
                }
            }
            copy.charges = new List<Charge>();
            if(deep && this.charges != null)
            {
                foreach (var __item in this.charges)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddCharges(__item);
                        else
                            copy.AddCharges(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddCharges((Charge)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.fareType != null)
            {
                if (!copiedObjects.Contains(this.fareType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FareType = this.FareType;
                    else if (asNew)
                        copy.FareType = this.FareType.Copy(deep, copiedObjects, true);
                    else
                        copy.fareType = this.fareType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FareType = (FareType)copiedObjects[this.FareType];
                    else
                        copy.fareType = (FareType)copiedObjects[this.FareType];
                }
            }
            copy.datasource = new List<Datasource>();
            if(deep && this.datasource != null)
            {
                foreach (var __item in this.datasource)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDatasource(__item);
                        else
                            copy.AddDatasource(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDatasource((Datasource)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.currency != null)
            {
                if (!copiedObjects.Contains(this.currency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Currency = this.Currency;
                    else if (asNew)
                        copy.Currency = this.Currency.Copy(deep, copiedObjects, true);
                    else
                        copy.currency = this.currency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Currency = (Currency)copiedObjects[this.Currency];
                    else
                        copy.currency = (Currency)copiedObjects[this.Currency];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Fare;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.Id == default(int) || this.Id.Equals(default(int));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(Fare compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
