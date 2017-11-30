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
    /// The Transfer class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Transfer : IDomainModelClass
    {
        #region Transfer's Fields

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
        [DataMember(Name="TransferType")]
        protected EuTravel_2.BO.TransferType transferType;
        [DataMember(Name="MinTransferTime")]
        protected int? minTransferTime;
        #endregion
        #region Transfer's Properties
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
/// The TransferType property
///
/// </summary>
///
        public virtual EuTravel_2.BO.TransferType TransferType
        {
            get
            {
                return transferType;
            }
            set
            {
                transferType = value;
            }
        }
/// <summary>
/// The MinTransferTime property
///
/// </summary>
///
        public virtual int? MinTransferTime
        {
            get
            {
                return minTransferTime;
            }
            set
            {
                minTransferTime = value;
            }
        }
        #endregion
        #region Transfer's Participant Properties
        [DataMember(Name="FromStation")]
        protected Station fromStation;
        public virtual Station FromStation
        {
            get
            {
                return fromStation;
            }
            set
            {
                if(Equals(fromStation, value)) return;
                var __oldValue = fromStation;
                if (value != null)
                {
                    fromStation = value;
                }
                else
                {
                    if (fromStation != null)
                    {
                        fromStation = null;
                    }
                }
            }
        }
        [DataMember(Name="ToStation")]
        protected Station toStation;
        public virtual Station ToStation
        {
            get
            {
                return toStation;
            }
            set
            {
                if(Equals(toStation, value)) return;
                var __oldValue = toStation;
                if (value != null)
                {
                    toStation = value;
                }
                else
                {
                    if (toStation != null)
                    {
                        toStation = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Transfer class
/// </summary>
/// <returns>New Transfer object</returns>
/// <remarks></remarks>
        public Transfer() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Transfer' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Transfer] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Transfer Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Transfer copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Transfer)copiedObjects[this];
            copy = copy ?? new Transfer();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.TransferType = this.TransferType;
            copy.MinTransferTime = this.MinTransferTime;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.fromStation != null)
            {
                if (!copiedObjects.Contains(this.fromStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FromStation = this.FromStation;
                    else if (asNew)
                        copy.FromStation = this.FromStation.Copy(deep, copiedObjects, true);
                    else
                        copy.fromStation = this.fromStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FromStation = (Station)copiedObjects[this.FromStation];
                    else
                        copy.fromStation = (Station)copiedObjects[this.FromStation];
                }
            }
            if(deep && this.toStation != null)
            {
                if (!copiedObjects.Contains(this.toStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ToStation = this.ToStation;
                    else if (asNew)
                        copy.ToStation = this.ToStation.Copy(deep, copiedObjects, true);
                    else
                        copy.toStation = this.toStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ToStation = (Station)copiedObjects[this.ToStation];
                    else
                        copy.toStation = (Station)copiedObjects[this.ToStation];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Transfer;
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
        protected bool HasSameNonDefaultIdAs(Transfer compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
