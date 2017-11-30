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
    /// The ElementData class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class ElementData : IDomainModelClass
    {
        #region ElementData's Fields

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
        [DataMember(Name="Latitude")]
        protected long? latitude;
        [DataMember(Name="Longtitude")]
        protected long? longtitude;
        [DataMember(Name="ExternalID")]
        protected int? externalID;
        [DataMember(Name="Weight")]
        protected string weight;
        [DataMember(Name="DistanceFromPreviousElement")]
        protected int? distanceFromPreviousElement;
        [DataMember(Name="CostFromPreviousElement")]
        protected int? costFromPreviousElement;
        [DataMember(Name="PreviousID")]
        protected int? previousID;
        [DataMember(Name="PreviousElementRelationID")]
        protected int? previousElementRelationID;
        [DataMember(Name="PreviousIndexID")]
        protected int? previousIndexID;
        [DataMember(Name="RelationTypeWithPreviousElement")]
        protected int? relationTypeWithPreviousElement;
        [DataMember(Name="PreviousElementType")]
        protected int? previousElementType;
        [DataMember(Name="ElementDataKey")]
        protected Guid? elementDataKey = Guid.Empty;
        #endregion
        #region ElementData's Properties
/// <summary>
/// The Latitude property
///
/// </summary>
///
        public virtual long? Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
            }
        }
/// <summary>
/// The Longtitude property
///
/// </summary>
///
        public virtual long? Longtitude
        {
            get
            {
                return longtitude;
            }
            set
            {
                longtitude = value;
            }
        }
/// <summary>
/// The ExternalID property
///
/// </summary>
///
        public virtual int? ExternalID
        {
            get
            {
                return externalID;
            }
            set
            {
                externalID = value;
            }
        }
/// <summary>
/// The Weight property
///
/// </summary>
///
        public virtual string Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
/// <summary>
/// The DistanceFromPreviousElement property
///
/// </summary>
///
        public virtual int? DistanceFromPreviousElement
        {
            get
            {
                return distanceFromPreviousElement;
            }
            set
            {
                distanceFromPreviousElement = value;
            }
        }
/// <summary>
/// The CostFromPreviousElement property
///
/// </summary>
///
        public virtual int? CostFromPreviousElement
        {
            get
            {
                return costFromPreviousElement;
            }
            set
            {
                costFromPreviousElement = value;
            }
        }
/// <summary>
/// The PreviousID property
///
/// </summary>
///
        public virtual int? PreviousID
        {
            get
            {
                return previousID;
            }
            set
            {
                previousID = value;
            }
        }
/// <summary>
/// The PreviousElementRelationID property
///
/// </summary>
///
        public virtual int? PreviousElementRelationID
        {
            get
            {
                return previousElementRelationID;
            }
            set
            {
                previousElementRelationID = value;
            }
        }
/// <summary>
/// The PreviousIndexID property
///
/// </summary>
///
        public virtual int? PreviousIndexID
        {
            get
            {
                return previousIndexID;
            }
            set
            {
                previousIndexID = value;
            }
        }
/// <summary>
/// The RelationTypeWithPreviousElement property
///
/// </summary>
///
        public virtual int? RelationTypeWithPreviousElement
        {
            get
            {
                return relationTypeWithPreviousElement;
            }
            set
            {
                relationTypeWithPreviousElement = value;
            }
        }
/// <summary>
/// The PreviousElementType property
///
/// </summary>
///
        public virtual int? PreviousElementType
        {
            get
            {
                return previousElementType;
            }
            set
            {
                previousElementType = value;
            }
        }
/// <summary>
/// The ElementDataKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? ElementDataKey
        {
            get
            {
                return elementDataKey;
            }
            set
            {
                elementDataKey = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ElementData class
/// </summary>
/// <returns>New ElementData object</returns>
/// <remarks></remarks>
        public ElementData()
        {
            if (ElementDataKey == null) ElementDataKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Weight != null && Weight.Length > 100)
            {
                __errors.Add("Length of property 'Weight' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'ElementData' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ElementData] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ElementData Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ElementData copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ElementData)copiedObjects[this];
            copy = copy ?? new ElementData();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.ElementDataKey = this.ElementDataKey;
            }
            copy.Latitude = this.Latitude;
            copy.Longtitude = this.Longtitude;
            copy.ExternalID = this.ExternalID;
            copy.Weight = this.Weight;
            copy.DistanceFromPreviousElement = this.DistanceFromPreviousElement;
            copy.CostFromPreviousElement = this.CostFromPreviousElement;
            copy.PreviousID = this.PreviousID;
            copy.PreviousElementRelationID = this.PreviousElementRelationID;
            copy.PreviousIndexID = this.PreviousIndexID;
            copy.RelationTypeWithPreviousElement = this.RelationTypeWithPreviousElement;
            copy.PreviousElementType = this.PreviousElementType;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ElementData;
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
                __propertyKeyCache = this.GetType().GetProperty("ElementDataKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.ElementDataKey.GetHashCode();
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
            return this.ElementDataKey == default(Guid) || this.ElementDataKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(ElementData compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.ElementDataKey.Equals(compareTo.ElementDataKey);
        }

        #endregion
    }
}
