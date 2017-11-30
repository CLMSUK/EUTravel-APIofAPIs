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
    /// The SRINT class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class SRINT : IDomainModelClass
    {
        #region SRINT's Fields

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
        [DataMember(Name="NumberOfInterruptions")]
        protected float? numberOfInterruptions;
        #endregion
        #region SRINT's Properties
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
/// The NumberOfInterruptions property
///
/// </summary>
///
        public virtual float? NumberOfInterruptions
        {
            get
            {
                return numberOfInterruptions;
            }
            set
            {
                numberOfInterruptions = value;
            }
        }
        #endregion
        #region SRINT's Participant Properties
        [DataMember(Name="DatesAssociation")]
        protected IList<DatesAssociation> datesAssociation = new List<DatesAssociation>();
        public virtual List<DatesAssociation> DatesAssociation
        {
            get
            {
                if (datesAssociation is DatesAssociation[])
                {
                    datesAssociation = datesAssociation.ToList();
                }
                if (datesAssociation == null)
                {
                    datesAssociation = new List<DatesAssociation>();
                }
                return datesAssociation.ToList();
            }
            set
            {
                if (datesAssociation is DatesAssociation[])
                {
                    datesAssociation = datesAssociation.ToList();
                }
                if (datesAssociation != null)
                {
                    var __itemsToDelete = new List<DatesAssociation>(datesAssociation);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDatesAssociation(__item);
                    }
                }
                if(value == null)
                {
                    datesAssociation = new List<DatesAssociation>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDatesAssociation(__item);
                }
            }
        }
        public virtual void AddDatesAssociation(IList<DatesAssociation> __items)
        {
            foreach (var __item in __items)
            {
                AddDatesAssociation(__item);
            }
        }
        public virtual void AddDatesAssociation(DatesAssociation __item)
        {
            if (__item != null && datesAssociation!=null && !datesAssociation.Contains(__item))
            {
                datesAssociation.Add(__item);
                if (__item.SRINT != this)
                    __item.SRINT = this;
            }
        }

        public virtual void RemoveDatesAssociation(DatesAssociation __item)
        {
            if (__item != null && datesAssociation!=null && datesAssociation.Contains(__item))
            {
                datesAssociation.Remove(__item);
                __item.SRINT = null;
            }
        }
        public virtual void SetDatesAssociationAt(DatesAssociation __item, int __index)
        {
            if (__item == null)
            {
                datesAssociation[__index].SRINT = null;
            }
            else
            {
                datesAssociation[__index] = __item;
                if (__item.SRINT != this)
                    __item.SRINT = this;
            }
        }

        public virtual void ClearDatesAssociation()
        {
            if (datesAssociation!=null)
            {
                var __itemsToRemove = datesAssociation.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDatesAssociation(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the SRINT class
/// </summary>
/// <returns>New SRINT object</returns>
/// <remarks></remarks>
        public SRINT() {}
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
                throw new BusinessException("An instance of TypeClass 'SRINT' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [SRINT] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual SRINT Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, SRINT copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (SRINT)copiedObjects[this];
            copy = copy ?? new SRINT();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.NumberOfInterruptions = this.NumberOfInterruptions;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.datesAssociation = new List<DatesAssociation>();
            if(deep && this.datesAssociation != null)
            {
                foreach (var __item in this.datesAssociation)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDatesAssociation(__item);
                        else
                            copy.AddDatesAssociation(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDatesAssociation((DatesAssociation)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as SRINT;
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
        protected bool HasSameNonDefaultIdAs(SRINT compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
