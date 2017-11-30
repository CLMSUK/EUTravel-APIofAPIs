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
    /// The LegsDetailsResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class LegsDetailsResponse : IDomainModelClass
    {
        #region LegsDetailsResponse's Fields

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
        [DataMember(Name="LegsDetailsResponseKey")]
        protected Guid? legsDetailsResponseKey = Guid.Empty;
        #endregion
        #region LegsDetailsResponse's Properties
/// <summary>
/// The LegsDetailsResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? LegsDetailsResponseKey
        {
            get
            {
                return legsDetailsResponseKey;
            }
            set
            {
                legsDetailsResponseKey = value;
            }
        }
        #endregion
        #region LegsDetailsResponse's Participant Properties
        [DataMember(Name="Legs")]
        protected IList<Leg> legs = new List<Leg>();
        public virtual List<Leg> Legs
        {
            get
            {
                if (legs is Leg[])
                {
                    legs = legs.ToList();
                }
                if (legs == null)
                {
                    legs = new List<Leg>();
                }
                return legs.ToList();
            }
            set
            {
                if (legs is Leg[])
                {
                    legs = legs.ToList();
                }
                if (legs != null)
                {
                    var __itemsToDelete = new List<Leg>(legs);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLegs(__item);
                    }
                }
                if(value == null)
                {
                    legs = new List<Leg>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLegs(__item);
                }
            }
        }
        public virtual void AddLegs(IList<Leg> __items)
        {
            foreach (var __item in __items)
            {
                AddLegs(__item);
            }
        }
        public virtual void AddLegs(Leg __item)
        {
            if (__item != null && legs!=null && !legs.Contains(__item))
            {
                legs.Add(__item);
            }
        }

        public virtual void RemoveLegs(Leg __item)
        {
            if (__item != null && legs!=null && legs.Contains(__item))
            {
                legs.Remove(__item);
            }
        }
        public virtual void SetLegsAt(Leg __item, int __index)
        {
            if (__item == null)
            {
                legs[__index] = null;
            }
            else
            {
                legs[__index] = __item;
            }
        }

        public virtual void ClearLegs()
        {
            if (legs!=null)
            {
                var __itemsToRemove = legs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLegs(__item);
                }
            }
        }
        [DataMember(Name="Error")]
        protected Error error;
        public virtual Error Error
        {
            get
            {
                return error;
            }
            set
            {
                if(Equals(error, value)) return;
                var __oldValue = error;
                if (value != null)
                {
                    error = value;
                }
                else
                {
                    if (error != null)
                    {
                        error = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the LegsDetailsResponse class
/// </summary>
/// <returns>New LegsDetailsResponse object</returns>
/// <remarks></remarks>
        public LegsDetailsResponse()
        {
            if (LegsDetailsResponseKey == null) LegsDetailsResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'LegsDetailsResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [LegsDetailsResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual LegsDetailsResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, LegsDetailsResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (LegsDetailsResponse)copiedObjects[this];
            copy = copy ?? new LegsDetailsResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.LegsDetailsResponseKey = this.LegsDetailsResponseKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.legs = new List<Leg>();
            if(deep && this.legs != null)
            {
                foreach (var __item in this.legs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLegs(__item);
                        else
                            copy.AddLegs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLegs((Leg)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.error != null)
            {
                if (!copiedObjects.Contains(this.error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Error = this.Error;
                    else if (asNew)
                        copy.Error = this.Error.Copy(deep, copiedObjects, true);
                    else
                        copy.error = this.error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Error = (Error)copiedObjects[this.Error];
                    else
                        copy.error = (Error)copiedObjects[this.Error];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as LegsDetailsResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("LegsDetailsResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.LegsDetailsResponseKey.GetHashCode();
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
            return this.LegsDetailsResponseKey == default(Guid) || this.LegsDetailsResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(LegsDetailsResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.LegsDetailsResponseKey.Equals(compareTo.LegsDetailsResponseKey);
        }

        #endregion
    }
}
