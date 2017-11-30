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
    /// The LegBookingInput class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class LegBookingInput : IDomainModelClass
    {
        #region LegBookingInput's Fields

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
        [DataMember(Name="LegBookingInputKey")]
        protected Guid? legBookingInputKey = Guid.Empty;
        #endregion
        #region LegBookingInput's Properties
/// <summary>
/// The LegBookingInputKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? LegBookingInputKey
        {
            get
            {
                return legBookingInputKey;
            }
            set
            {
                legBookingInputKey = value;
            }
        }
        #endregion
        #region LegBookingInput's Participant Properties
        [DataMember(Name="LegIDs")]
        protected IList<LegIdInput> legIDs = new List<LegIdInput>();
        public virtual List<LegIdInput> LegIDs
        {
            get
            {
                if (legIDs is LegIdInput[])
                {
                    legIDs = legIDs.ToList();
                }
                if (legIDs == null)
                {
                    legIDs = new List<LegIdInput>();
                }
                return legIDs.ToList();
            }
            set
            {
                if (legIDs is LegIdInput[])
                {
                    legIDs = legIDs.ToList();
                }
                if (legIDs != null)
                {
                    var __itemsToDelete = new List<LegIdInput>(legIDs);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLegIDs(__item);
                    }
                }
                if(value == null)
                {
                    legIDs = new List<LegIdInput>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLegIDs(__item);
                }
            }
        }
        public virtual void AddLegIDs(IList<LegIdInput> __items)
        {
            foreach (var __item in __items)
            {
                AddLegIDs(__item);
            }
        }
        public virtual void AddLegIDs(LegIdInput __item)
        {
            if (__item != null && legIDs!=null && !legIDs.Contains(__item))
            {
                legIDs.Add(__item);
            }
        }

        public virtual void RemoveLegIDs(LegIdInput __item)
        {
            if (__item != null && legIDs!=null && legIDs.Contains(__item))
            {
                legIDs.Remove(__item);
            }
        }
        public virtual void SetLegIDsAt(LegIdInput __item, int __index)
        {
            if (__item == null)
            {
                legIDs[__index] = null;
            }
            else
            {
                legIDs[__index] = __item;
            }
        }

        public virtual void ClearLegIDs()
        {
            if (legIDs!=null)
            {
                var __itemsToRemove = legIDs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLegIDs(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the LegBookingInput class
/// </summary>
/// <returns>New LegBookingInput object</returns>
/// <remarks></remarks>
        public LegBookingInput()
        {
            if (LegBookingInputKey == null) LegBookingInputKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'LegBookingInput' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [LegBookingInput] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual LegBookingInput Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, LegBookingInput copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (LegBookingInput)copiedObjects[this];
            copy = copy ?? new LegBookingInput();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.LegBookingInputKey = this.LegBookingInputKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.legIDs = new List<LegIdInput>();
            if(deep && this.legIDs != null)
            {
                foreach (var __item in this.legIDs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLegIDs(__item);
                        else
                            copy.AddLegIDs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLegIDs((LegIdInput)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as LegBookingInput;
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
                __propertyKeyCache = this.GetType().GetProperty("LegBookingInputKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.LegBookingInputKey.GetHashCode();
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
            return this.LegBookingInputKey == default(Guid) || this.LegBookingInputKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(LegBookingInput compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.LegBookingInputKey.Equals(compareTo.LegBookingInputKey);
        }

        #endregion
    }
}
