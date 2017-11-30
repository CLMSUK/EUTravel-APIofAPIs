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
    /// The DatesAssociation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class DatesAssociation : IDomainModelClass
    {
        #region DatesAssociation's Fields

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
        [DataMember(Name="timestamp")]
        protected DateTime? _timestamp;
        [DataMember(Name="id")]
        protected int? _id = 0;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region DatesAssociation's Properties
/// <summary>
/// The timestamp property
///
/// </summary>
///
        public virtual DateTime? timestamp
        {
            get
            {
                return _timestamp;
            }
            set
            {
                _timestamp = value;
            }
        }
/// <summary>
/// The id property
///
/// </summary>
///
        [Key]
        public virtual int? id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region DatesAssociation's Participant Properties
        [DataMember(Name="SRINT")]
        protected SRINT sRINT;
        public virtual SRINT SRINT
        {
            get
            {
                return sRINT;
            }
            set
            {
                if(Equals(sRINT, value)) return;
                var __oldValue = sRINT;
                if (value != null)
                {
                    if(sRINT != null && !Equals(sRINT, value))
                        sRINT.RemoveDatesAssociation(this);
                    sRINT = value;
                    sRINT.AddDatesAssociation(this);
                }
                else
                {
                    if(sRINT != null)
                        sRINT.RemoveDatesAssociation(this);
                    sRINT = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the DatesAssociation class
/// </summary>
/// <returns>New DatesAssociation object</returns>
/// <remarks></remarks>
        public DatesAssociation() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (id == null)
            {
                __errors.Add("Property 'id' is required.");
            }
            if (SRINT == null)
            {
                __errors.Add("Association with 'SRINT' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'DatesAssociation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [DatesAssociation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual DatesAssociation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, DatesAssociation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (DatesAssociation)copiedObjects[this];
            copy = copy ?? new DatesAssociation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.id = this.id;
            }
            copy.timestamp = this.timestamp;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.sRINT != null)
            {
                if (!copiedObjects.Contains(this.sRINT))
                {
                    if (asNew && reuseNestedObjects)
                        copy.SRINT = this.SRINT;
                    else if (asNew)
                        copy.SRINT = this.SRINT.Copy(deep, copiedObjects, true);
                    else
                        copy.sRINT = this.sRINT.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.SRINT = (SRINT)copiedObjects[this.SRINT];
                    else
                        copy.sRINT = (SRINT)copiedObjects[this.SRINT];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as DatesAssociation;
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
                __propertyKeyCache = this.GetType().GetProperty("id");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.id.GetHashCode();
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
            return this.id == default(int) || this.id.Equals(default(int));
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
        protected bool HasSameNonDefaultIdAs(DatesAssociation compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.id.Equals(compareTo.id);
        }

        #endregion
    }
}
