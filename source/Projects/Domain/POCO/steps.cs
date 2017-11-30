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
    /// The steps class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class steps : IDomainModelClass
    {
        #region steps's Fields

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
        [DataMember(Name="distance")]
        protected float? _distance;
        [DataMember(Name="streetName")]
        protected string _streetName;
        [DataMember(Name="absoluteDirection")]
        protected string _absoluteDirection;
        [DataMember(Name="lon")]
        protected float? _lon;
        [DataMember(Name="lat")]
        protected float? _lat;
        [DataMember(Name="stepsKey")]
        protected Guid? _stepsKey = Guid.Empty;
        #endregion
        #region steps's Properties
/// <summary>
/// The distance property
///
/// </summary>
///
        public virtual float? distance
        {
            get
            {
                return _distance;
            }
            set
            {
                _distance = value;
            }
        }
/// <summary>
/// The streetName property
///
/// </summary>
///
        public virtual string streetName
        {
            get
            {
                return _streetName;
            }
            set
            {
                _streetName = value;
            }
        }
/// <summary>
/// The absoluteDirection property
///
/// </summary>
///
        public virtual string absoluteDirection
        {
            get
            {
                return _absoluteDirection;
            }
            set
            {
                _absoluteDirection = value;
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
/// The stepsKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? stepsKey
        {
            get
            {
                return _stepsKey;
            }
            set
            {
                _stepsKey = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the steps class
/// </summary>
/// <returns>New steps object</returns>
/// <remarks></remarks>
        public steps()
        {
            if (stepsKey == null) stepsKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (streetName != null && streetName.Length > 100)
            {
                __errors.Add("Length of property 'streetName' cannot be greater than 100.");
            }
            if (absoluteDirection != null && absoluteDirection.Length > 100)
            {
                __errors.Add("Length of property 'absoluteDirection' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'steps' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [steps] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual steps Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, steps copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (steps)copiedObjects[this];
            copy = copy ?? new steps();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.stepsKey = this.stepsKey;
            }
            copy.distance = this.distance;
            copy.streetName = this.streetName;
            copy.absoluteDirection = this.absoluteDirection;
            copy.lon = this.lon;
            copy.lat = this.lat;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as steps;
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
                __propertyKeyCache = this.GetType().GetProperty("stepsKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.stepsKey.GetHashCode();
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
            return this.stepsKey == default(Guid) || this.stepsKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(steps compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.stepsKey.Equals(compareTo.stepsKey);
        }

        #endregion
    }
}
