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
    /// The LocationInput class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class LocationInput : IDomainModelClass
    {
        #region LocationInput's Fields

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
        [DataMember(Name="Lat")]
        protected double? lat;
        [DataMember(Name="Long")]
        protected double? _long;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="LocationInputKey")]
        protected Guid? locationInputKey = Guid.Empty;
        #endregion
        #region LocationInput's Properties
/// <summary>
/// The Lat property
///
/// </summary>
///
        public virtual double? Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
            }
        }
/// <summary>
/// The Long property
///
/// </summary>
///
        public virtual double? Long
        {
            get
            {
                return _long;
            }
            set
            {
                _long = value;
            }
        }
/// <summary>
/// The IATACode property
///
/// </summary>
///
        public virtual string IATACode
        {
            get
            {
                return iATACode;
            }
            set
            {
                iATACode = value;
            }
        }
/// <summary>
/// The Name property
///
/// </summary>
///
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
/// <summary>
/// The LocationInputKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? LocationInputKey
        {
            get
            {
                return locationInputKey;
            }
            set
            {
                locationInputKey = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the LocationInput class
/// </summary>
/// <returns>New LocationInput object</returns>
/// <remarks></remarks>
        public LocationInput()
        {
            if (LocationInputKey == null) LocationInputKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (IATACode != null && IATACode.Length > 100)
            {
                __errors.Add("Length of property 'IATACode' cannot be greater than 100.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'LocationInput' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [LocationInput] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual LocationInput Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, LocationInput copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (LocationInput)copiedObjects[this];
            copy = copy ?? new LocationInput();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.LocationInputKey = this.LocationInputKey;
            }
            copy.Lat = this.Lat;
            copy.Long = this.Long;
            copy.IATACode = this.IATACode;
            copy.Name = this.Name;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as LocationInput;
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
                __propertyKeyCache = this.GetType().GetProperty("LocationInputKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.LocationInputKey.GetHashCode();
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
            return this.LocationInputKey == default(Guid) || this.LocationInputKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(LocationInput compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.LocationInputKey.Equals(compareTo.LocationInputKey);
        }

        #endregion
    }
}
