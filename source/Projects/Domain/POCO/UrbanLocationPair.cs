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
    /// The UrbanLocationPair class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class UrbanLocationPair : IDomainModelClass
    {
        #region UrbanLocationPair's Fields

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
        [DataMember(Name="UrbanLocationPairKey")]
        protected Guid? urbanLocationPairKey = Guid.Empty;
        #endregion
        #region UrbanLocationPair's Properties
/// <summary>
/// The UrbanLocationPairKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? UrbanLocationPairKey
        {
            get
            {
                return urbanLocationPairKey;
            }
            set
            {
                urbanLocationPairKey = value;
            }
        }
        #endregion
        #region UrbanLocationPair's Participant Properties
        [DataMember(Name="OriginLocation")]
        protected GeoCoordinates originLocation;
        public virtual GeoCoordinates OriginLocation
        {
            get
            {
                return originLocation;
            }
            set
            {
                if(Equals(originLocation, value)) return;
                var __oldValue = originLocation;
                if (value != null)
                {
                    originLocation = value;
                }
                else
                {
                    if (originLocation != null)
                    {
                        originLocation = null;
                    }
                }
            }
        }
        [DataMember(Name="DestinationLocation")]
        protected GeoCoordinates destinationLocation;
        public virtual GeoCoordinates DestinationLocation
        {
            get
            {
                return destinationLocation;
            }
            set
            {
                if(Equals(destinationLocation, value)) return;
                var __oldValue = destinationLocation;
                if (value != null)
                {
                    destinationLocation = value;
                }
                else
                {
                    destinationLocation = null;
                }
            }
        }
        [DataMember(Name="plan")]
        protected plan _plan;
        public virtual plan plan
        {
            get
            {
                return _plan;
            }
            set
            {
                if(Equals(_plan, value)) return;
                var __oldValue = _plan;
                if (value != null)
                {
                    _plan = value;
                }
                else
                {
                    if (_plan != null)
                    {
                        _plan = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanLocationPair class
/// </summary>
/// <returns>New UrbanLocationPair object</returns>
/// <remarks></remarks>
        public UrbanLocationPair()
        {
            if (UrbanLocationPairKey == null) UrbanLocationPairKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanLocationPair' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanLocationPair] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanLocationPair Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanLocationPair copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanLocationPair)copiedObjects[this];
            copy = copy ?? new UrbanLocationPair();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.UrbanLocationPairKey = this.UrbanLocationPairKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.originLocation != null)
            {
                if (!copiedObjects.Contains(this.originLocation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OriginLocation = this.OriginLocation;
                    else if (asNew)
                        copy.OriginLocation = this.OriginLocation.Copy(deep, copiedObjects, true);
                    else
                        copy.originLocation = this.originLocation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OriginLocation = (GeoCoordinates)copiedObjects[this.OriginLocation];
                    else
                        copy.originLocation = (GeoCoordinates)copiedObjects[this.OriginLocation];
                }
            }
            if(deep && this.destinationLocation != null)
            {
                if (!copiedObjects.Contains(this.destinationLocation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DestinationLocation = this.DestinationLocation;
                    else if (asNew)
                        copy.DestinationLocation = this.DestinationLocation.Copy(deep, copiedObjects, true);
                    else
                        copy.destinationLocation = this.destinationLocation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DestinationLocation = (GeoCoordinates)copiedObjects[this.DestinationLocation];
                    else
                        copy.destinationLocation = (GeoCoordinates)copiedObjects[this.DestinationLocation];
                }
            }
            if(deep && this._plan != null)
            {
                if (!copiedObjects.Contains(this._plan))
                {
                    if (asNew && reuseNestedObjects)
                        copy.plan = this.plan;
                    else if (asNew)
                        copy.plan = this.plan.Copy(deep, copiedObjects, true);
                    else
                        copy._plan = this._plan.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.plan = (plan)copiedObjects[this.plan];
                    else
                        copy._plan = (plan)copiedObjects[this.plan];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanLocationPair;
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
                __propertyKeyCache = this.GetType().GetProperty("UrbanLocationPairKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.UrbanLocationPairKey.GetHashCode();
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
            return this.UrbanLocationPairKey == default(Guid) || this.UrbanLocationPairKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(UrbanLocationPair compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.UrbanLocationPairKey.Equals(compareTo.UrbanLocationPairKey);
        }

        #endregion
    }
}
