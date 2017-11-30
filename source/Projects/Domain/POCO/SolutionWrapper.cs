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
    /// The SolutionWrapper class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class SolutionWrapper : IDomainModelClass
    {
        #region SolutionWrapper's Fields

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
        [DataMember(Name="SolutionId")]
        protected int? solutionId;
        [DataMember(Name="Currency")]
        protected string currency;
        [DataMember(Name="NetPrice")]
        protected string netPrice;
        [DataMember(Name="TotalDuration")]
        protected int? totalDuration;
        [DataMember(Name="Tax")]
        protected string tax;
        [DataMember(Name="DepartureDate")]
        protected DateTime? departureDate;
        [DataMember(Name="ArrivalDate")]
        protected DateTime? arrivalDate;
        [DataMember(Name="TotalCO2")]
        protected int? totalCO2;
        [DataMember(Name="SolutionWrapperKey")]
        protected Guid? solutionWrapperKey = Guid.Empty;
        #endregion
        #region SolutionWrapper's Properties
/// <summary>
/// The SolutionId property
///
/// </summary>
///
        public virtual int? SolutionId
        {
            get
            {
                return solutionId;
            }
            set
            {
                solutionId = value;
            }
        }
/// <summary>
/// The Currency property
///
/// </summary>
///
        public virtual string Currency
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
            }
        }
/// <summary>
/// The NetPrice property
///
/// </summary>
///
        public virtual string NetPrice
        {
            get
            {
                return netPrice;
            }
            set
            {
                netPrice = value;
            }
        }
/// <summary>
/// The TotalDuration property
///
/// </summary>
///
        public virtual int? TotalDuration
        {
            get
            {
                return totalDuration;
            }
            set
            {
                totalDuration = value;
            }
        }
/// <summary>
/// The Tax property
///
/// </summary>
///
        public virtual string Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
/// <summary>
/// The DepartureDate property
///
/// </summary>
///
        public virtual DateTime? DepartureDate
        {
            get
            {
                return departureDate;
            }
            set
            {
                departureDate = value;
            }
        }
/// <summary>
/// The ArrivalDate property
///
/// </summary>
///
        public virtual DateTime? ArrivalDate
        {
            get
            {
                return arrivalDate;
            }
            set
            {
                arrivalDate = value;
            }
        }
/// <summary>
/// The TotalCO2 property
///
/// </summary>
///
        public virtual int? TotalCO2
        {
            get
            {
                return totalCO2;
            }
            set
            {
                totalCO2 = value;
            }
        }
/// <summary>
/// The SolutionWrapperKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? SolutionWrapperKey
        {
            get
            {
                return solutionWrapperKey;
            }
            set
            {
                solutionWrapperKey = value;
            }
        }
        #endregion
        #region SolutionWrapper's Participant Properties
        [DataMember(Name="Transports")]
        protected Transports transports;
        public virtual Transports Transports
        {
            get
            {
                return transports;
            }
            set
            {
                if(Equals(transports, value)) return;
                var __oldValue = transports;
                if (value != null)
                {
                    transports = value;
                }
                else
                {
                    transports = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the SolutionWrapper class
/// </summary>
/// <returns>New SolutionWrapper object</returns>
/// <remarks></remarks>
        public SolutionWrapper()
        {
            if (SolutionWrapperKey == null) SolutionWrapperKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Currency != null && Currency.Length > 100)
            {
                __errors.Add("Length of property 'Currency' cannot be greater than 100.");
            }
            if (NetPrice != null && NetPrice.Length > 100)
            {
                __errors.Add("Length of property 'NetPrice' cannot be greater than 100.");
            }
            if (Tax != null && Tax.Length > 100)
            {
                __errors.Add("Length of property 'Tax' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'SolutionWrapper' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [SolutionWrapper] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual SolutionWrapper Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, SolutionWrapper copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (SolutionWrapper)copiedObjects[this];
            copy = copy ?? new SolutionWrapper();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.SolutionWrapperKey = this.SolutionWrapperKey;
            }
            copy.SolutionId = this.SolutionId;
            copy.Currency = this.Currency;
            copy.NetPrice = this.NetPrice;
            copy.TotalDuration = this.TotalDuration;
            copy.Tax = this.Tax;
            copy.DepartureDate = this.DepartureDate;
            copy.ArrivalDate = this.ArrivalDate;
            copy.TotalCO2 = this.TotalCO2;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.transports != null)
            {
                if (!copiedObjects.Contains(this.transports))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Transports = this.Transports;
                    else if (asNew)
                        copy.Transports = this.Transports.Copy(deep, copiedObjects, true);
                    else
                        copy.transports = this.transports.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Transports = (Transports)copiedObjects[this.Transports];
                    else
                        copy.transports = (Transports)copiedObjects[this.Transports];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as SolutionWrapper;
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
                __propertyKeyCache = this.GetType().GetProperty("SolutionWrapperKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.SolutionWrapperKey.GetHashCode();
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
            return this.SolutionWrapperKey == default(Guid) || this.SolutionWrapperKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(SolutionWrapper compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.SolutionWrapperKey.Equals(compareTo.SolutionWrapperKey);
        }

        #endregion
    }
}
