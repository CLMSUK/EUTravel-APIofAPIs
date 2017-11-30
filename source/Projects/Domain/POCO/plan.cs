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
    /// The plan class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class plan : IDomainModelClass
    {
        #region plan's Fields

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
        [DataMember(Name="date")]
        protected long? _date;
        [DataMember(Name="planKey")]
        protected Guid? _planKey = Guid.Empty;
        #endregion
        #region plan's Properties
/// <summary>
/// The date property
///
/// </summary>
///
        public virtual long? date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
/// <summary>
/// The planKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? planKey
        {
            get
            {
                return _planKey;
            }
            set
            {
                _planKey = value;
            }
        }
        #endregion
        #region plan's Participant Properties
        [DataMember(Name="from")]
        protected from _from;
        public virtual from from
        {
            get
            {
                return _from;
            }
            set
            {
                if(Equals(_from, value)) return;
                var __oldValue = _from;
                if (value != null)
                {
                    _from = value;
                }
                else
                {
                    if (_from != null)
                    {
                        _from = null;
                    }
                }
            }
        }
        [DataMember(Name="itineraries")]
        protected IList<itineraries> _itineraries = new List<itineraries>();
        public virtual List<itineraries> itineraries
        {
            get
            {
                if (_itineraries is itineraries[])
                {
                    _itineraries = _itineraries.ToList();
                }
                if (_itineraries == null)
                {
                    _itineraries = new List<itineraries>();
                }
                return _itineraries.ToList();
            }
            set
            {
                if (_itineraries is itineraries[])
                {
                    _itineraries = _itineraries.ToList();
                }
                if (_itineraries != null)
                {
                    var __itemsToDelete = new List<itineraries>(_itineraries);
                    foreach (var __item in __itemsToDelete)
                    {
                        Removeitineraries(__item);
                    }
                }
                if(value == null)
                {
                    _itineraries = new List<itineraries>();
                    return;
                }
                foreach(var __item in value)
                {
                    Additineraries(__item);
                }
            }
        }
        public virtual void Additineraries(IList<itineraries> __items)
        {
            foreach (var __item in __items)
            {
                Additineraries(__item);
            }
        }
        public virtual void Additineraries(itineraries __item)
        {
            if (__item != null && _itineraries!=null && !_itineraries.Contains(__item))
            {
                _itineraries.Add(__item);
            }
        }

        public virtual void Removeitineraries(itineraries __item)
        {
            if (__item != null && _itineraries!=null && _itineraries.Contains(__item))
            {
                _itineraries.Remove(__item);
            }
        }
        public virtual void SetitinerariesAt(itineraries __item, int __index)
        {
            if (__item == null)
            {
                _itineraries[__index] = null;
            }
            else
            {
                _itineraries[__index] = __item;
            }
        }

        public virtual void Clearitineraries()
        {
            if (_itineraries!=null)
            {
                var __itemsToRemove = _itineraries.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    Removeitineraries(__item);
                }
            }
        }
        [DataMember(Name="to")]
        protected planTo _to;
        public virtual planTo to
        {
            get
            {
                return _to;
            }
            set
            {
                if(Equals(_to, value)) return;
                var __oldValue = _to;
                if (value != null)
                {
                    _to = value;
                }
                else
                {
                    if (_to != null)
                    {
                        _to = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the plan class
/// </summary>
/// <returns>New plan object</returns>
/// <remarks></remarks>
        public plan()
        {
            if (planKey == null) planKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'plan' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [plan] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual plan Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, plan copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (plan)copiedObjects[this];
            copy = copy ?? new plan();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.planKey = this.planKey;
            }
            copy.date = this.date;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this._from != null)
            {
                if (!copiedObjects.Contains(this._from))
                {
                    if (asNew && reuseNestedObjects)
                        copy.from = this.from;
                    else if (asNew)
                        copy.from = this.from.Copy(deep, copiedObjects, true);
                    else
                        copy._from = this._from.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.from = (from)copiedObjects[this.from];
                    else
                        copy._from = (from)copiedObjects[this.from];
                }
            }
            copy._itineraries = new List<itineraries>();
            if(deep && this._itineraries != null)
            {
                foreach (var __item in this._itineraries)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.Additineraries(__item);
                        else
                            copy.Additineraries(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.Additineraries((itineraries)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this._to != null)
            {
                if (!copiedObjects.Contains(this._to))
                {
                    if (asNew && reuseNestedObjects)
                        copy.to = this.to;
                    else if (asNew)
                        copy.to = this.to.Copy(deep, copiedObjects, true);
                    else
                        copy._to = this._to.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.to = (planTo)copiedObjects[this.to];
                    else
                        copy._to = (planTo)copiedObjects[this.to];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as plan;
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
                __propertyKeyCache = this.GetType().GetProperty("planKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.planKey.GetHashCode();
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
            return this.planKey == default(Guid) || this.planKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(plan compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.planKey.Equals(compareTo.planKey);
        }

        #endregion
    }
}
