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
    /// The to class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class to : IDomainModelClass
    {
        #region to's Fields

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
        [DataMember(Name="arrival")]
        protected long? _arrival;
        [DataMember(Name="departure")]
        protected long? _departure;
        [DataMember(Name="stopCode")]
        protected string _stopCode;
        [DataMember(Name="lat")]
        protected float? _lat;
        [DataMember(Name="lon")]
        protected float? _lon;
        [DataMember(Name="name")]
        protected string _name;
        [DataMember(Name="toKey")]
        protected Guid? _toKey = Guid.Empty;
        #endregion
        #region to's Properties
/// <summary>
/// The arrival property
///
/// </summary>
///
        public virtual long? arrival
        {
            get
            {
                return _arrival;
            }
            set
            {
                _arrival = value;
            }
        }
/// <summary>
/// The departure property
///
/// </summary>
///
        public virtual long? departure
        {
            get
            {
                return _departure;
            }
            set
            {
                _departure = value;
            }
        }
/// <summary>
/// The stopCode property
///
/// </summary>
///
        public virtual string stopCode
        {
            get
            {
                return _stopCode;
            }
            set
            {
                _stopCode = value;
            }
        }
/// <summary>
/// The lat property
///
/// </summary>
///
        public virtual float? lat
        {
            get
            {
                return _lat;
            }
            set
            {
                _lat = value;
            }
        }
/// <summary>
/// The lon property
///
/// </summary>
///
        public virtual float? lon
        {
            get
            {
                return _lon;
            }
            set
            {
                _lon = value;
            }
        }
/// <summary>
/// The name property
///
/// </summary>
///
        public virtual string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
/// <summary>
/// The toKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? toKey
        {
            get
            {
                return _toKey;
            }
            set
            {
                _toKey = value;
            }
        }
        #endregion
        #region to's Participant Properties
        [DataMember(Name="stopId")]
        protected toStopId _stopId;
        public virtual toStopId stopId
        {
            get
            {
                return _stopId;
            }
            set
            {
                if(Equals(_stopId, value)) return;
                var __oldValue = _stopId;
                if (value != null)
                {
                    _stopId = value;
                }
                else
                {
                    if (_stopId != null)
                    {
                        _stopId = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the to class
/// </summary>
/// <returns>New to object</returns>
/// <remarks></remarks>
        public to()
        {
            if (toKey == null) toKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (stopCode != null && stopCode.Length > 100)
            {
                __errors.Add("Length of property 'stopCode' cannot be greater than 100.");
            }
            if (name != null && name.Length > 100)
            {
                __errors.Add("Length of property 'name' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'to' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [to] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual to Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, to copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (to)copiedObjects[this];
            copy = copy ?? new to();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.toKey = this.toKey;
            }
            copy.arrival = this.arrival;
            copy.departure = this.departure;
            copy.stopCode = this.stopCode;
            copy.lat = this.lat;
            copy.lon = this.lon;
            copy.name = this.name;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._stopId != null)
            {
                if (!copiedObjects.Contains(this._stopId))
                {
                    if (asNew && reuseNestedObjects)
                        copy.stopId = this.stopId;
                    else if (asNew)
                        copy.stopId = this.stopId.Copy(deep, copiedObjects, true);
                    else
                        copy._stopId = this._stopId.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.stopId = (toStopId)copiedObjects[this.stopId];
                    else
                        copy._stopId = (toStopId)copiedObjects[this.stopId];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as to;
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
                __propertyKeyCache = this.GetType().GetProperty("toKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.toKey.GetHashCode();
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
            return this.toKey == default(Guid) || this.toKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(to compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.toKey.Equals(compareTo.toKey);
        }

        #endregion
    }
}
