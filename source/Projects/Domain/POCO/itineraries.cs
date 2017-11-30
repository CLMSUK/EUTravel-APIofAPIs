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
    /// The itineraries class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class itineraries : IDomainModelClass
    {
        #region itineraries's Fields

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
        [DataMember(Name="duration")]
        protected long? _duration;
        [DataMember(Name="elevationGained")]
        protected int? _elevationGained;
        [DataMember(Name="elevationLost")]
        protected int? _elevationLost;
        [DataMember(Name="endTime")]
        protected long? _endTime;
        [DataMember(Name="startTime")]
        protected long? _startTime;
        [DataMember(Name="tooSloped")]
        protected bool _tooSloped;
        [DataMember(Name="transfers")]
        protected int? _transfers;
        [DataMember(Name="transitTime")]
        protected long? _transitTime;
        [DataMember(Name="waitingTime")]
        protected long? _waitingTime;
        [DataMember(Name="walkDistance")]
        protected float? _walkDistance;
        [DataMember(Name="walkTime")]
        protected int? _walkTime;
        [DataMember(Name="evaluation")]
        protected float? _evaluation;
        [DataMember(Name="phi1")]
        protected float? _phi1;
        [DataMember(Name="phi2")]
        protected float? _phi2;
        [DataMember(Name="phi3")]
        protected float? _phi3;
        [DataMember(Name="itinerariesKey")]
        protected Guid? _itinerariesKey = Guid.Empty;
        #endregion
        #region itineraries's Properties
/// <summary>
/// The duration property
///
/// </summary>
///
        public virtual long? duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }
/// <summary>
/// The elevationGained property
///
/// </summary>
///
        public virtual int? elevationGained
        {
            get
            {
                return _elevationGained;
            }
            set
            {
                _elevationGained = value;
            }
        }
/// <summary>
/// The elevationLost property
///
/// </summary>
///
        public virtual int? elevationLost
        {
            get
            {
                return _elevationLost;
            }
            set
            {
                _elevationLost = value;
            }
        }
/// <summary>
/// The endTime property
///
/// </summary>
///
        public virtual long? endTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }
/// <summary>
/// The startTime property
///
/// </summary>
///
        public virtual long? startTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }
/// <summary>
/// The tooSloped property
///
/// </summary>
///
        public virtual bool tooSloped
        {
            get
            {
                return _tooSloped;
            }
            set
            {
                _tooSloped = value;
            }
        }
/// <summary>
/// The transfers property
///
/// </summary>
///
        public virtual int? transfers
        {
            get
            {
                return _transfers;
            }
            set
            {
                _transfers = value;
            }
        }
/// <summary>
/// The transitTime property
///
/// </summary>
///
        public virtual long? transitTime
        {
            get
            {
                return _transitTime;
            }
            set
            {
                _transitTime = value;
            }
        }
/// <summary>
/// The waitingTime property
///
/// </summary>
///
        public virtual long? waitingTime
        {
            get
            {
                return _waitingTime;
            }
            set
            {
                _waitingTime = value;
            }
        }
/// <summary>
/// The walkDistance property
///
/// </summary>
///
        public virtual float? walkDistance
        {
            get
            {
                return _walkDistance;
            }
            set
            {
                _walkDistance = value;
            }
        }
/// <summary>
/// The walkTime property
///
/// </summary>
///
        public virtual int? walkTime
        {
            get
            {
                return _walkTime;
            }
            set
            {
                _walkTime = value;
            }
        }
/// <summary>
/// The evaluation property
///
/// </summary>
///
        public virtual float? evaluation
        {
            get
            {
                return _evaluation;
            }
            set
            {
                _evaluation = value;
            }
        }
/// <summary>
/// The phi1 property
///
/// </summary>
///
        public virtual float? phi1
        {
            get
            {
                return _phi1;
            }
            set
            {
                _phi1 = value;
            }
        }
/// <summary>
/// The phi2 property
///
/// </summary>
///
        public virtual float? phi2
        {
            get
            {
                return _phi2;
            }
            set
            {
                _phi2 = value;
            }
        }
/// <summary>
/// The phi3 property
///
/// </summary>
///
        public virtual float? phi3
        {
            get
            {
                return _phi3;
            }
            set
            {
                _phi3 = value;
            }
        }
/// <summary>
/// The itinerariesKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? itinerariesKey
        {
            get
            {
                return _itinerariesKey;
            }
            set
            {
                _itinerariesKey = value;
            }
        }
        #endregion
        #region itineraries's Participant Properties
        [DataMember(Name="legs")]
        protected IList<legs> _legs = new List<legs>();
        public virtual List<legs> legs
        {
            get
            {
                if (_legs is legs[])
                {
                    _legs = _legs.ToList();
                }
                if (_legs == null)
                {
                    _legs = new List<legs>();
                }
                return _legs.ToList();
            }
            set
            {
                if (_legs is legs[])
                {
                    _legs = _legs.ToList();
                }
                if (_legs != null)
                {
                    var __itemsToDelete = new List<legs>(_legs);
                    foreach (var __item in __itemsToDelete)
                    {
                        Removelegs(__item);
                    }
                }
                if(value == null)
                {
                    _legs = new List<legs>();
                    return;
                }
                foreach(var __item in value)
                {
                    Addlegs(__item);
                }
            }
        }
        public virtual void Addlegs(IList<legs> __items)
        {
            foreach (var __item in __items)
            {
                Addlegs(__item);
            }
        }
        public virtual void Addlegs(legs __item)
        {
            if (__item != null && _legs!=null && !_legs.Contains(__item))
            {
                _legs.Add(__item);
            }
        }

        public virtual void Removelegs(legs __item)
        {
            if (__item != null && _legs!=null && _legs.Contains(__item))
            {
                _legs.Remove(__item);
            }
        }
        public virtual void SetlegsAt(legs __item, int __index)
        {
            if (__item == null)
            {
                _legs[__index] = null;
            }
            else
            {
                _legs[__index] = __item;
            }
        }

        public virtual void Clearlegs()
        {
            if (_legs!=null)
            {
                var __itemsToRemove = _legs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    Removelegs(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the itineraries class
/// </summary>
/// <returns>New itineraries object</returns>
/// <remarks></remarks>
        public itineraries()
        {
            if (itinerariesKey == null) itinerariesKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'itineraries' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [itineraries] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual itineraries Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, itineraries copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (itineraries)copiedObjects[this];
            copy = copy ?? new itineraries();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.itinerariesKey = this.itinerariesKey;
            }
            copy.duration = this.duration;
            copy.elevationGained = this.elevationGained;
            copy.elevationLost = this.elevationLost;
            copy.endTime = this.endTime;
            copy.startTime = this.startTime;
            copy.tooSloped = this.tooSloped;
            copy.transfers = this.transfers;
            copy.transitTime = this.transitTime;
            copy.waitingTime = this.waitingTime;
            copy.walkDistance = this.walkDistance;
            copy.walkTime = this.walkTime;
            copy.evaluation = this.evaluation;
            copy.phi1 = this.phi1;
            copy.phi2 = this.phi2;
            copy.phi3 = this.phi3;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy._legs = new List<legs>();
            if(deep && this._legs != null)
            {
                foreach (var __item in this._legs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.Addlegs(__item);
                        else
                            copy.Addlegs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.Addlegs((legs)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as itineraries;
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
                __propertyKeyCache = this.GetType().GetProperty("itinerariesKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.itinerariesKey.GetHashCode();
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
            return this.itinerariesKey == default(Guid) || this.itinerariesKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(itineraries compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.itinerariesKey.Equals(compareTo.itinerariesKey);
        }

        #endregion
    }
}
