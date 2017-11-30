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
    /// The legs class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class legs : IDomainModelClass
    {
        #region legs's Fields

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
        [DataMember(Name="bogusNonTransitLeg")]
        protected bool _bogusNonTransitLeg;
        [DataMember(Name="distance")]
        protected float? _distance;
        [DataMember(Name="duration")]
        protected int? _duration;
        [DataMember(Name="endTime")]
        protected long? _endTime;
        [DataMember(Name="mode")]
        protected string _mode;
        [DataMember(Name="route")]
        protected string _route;
        [DataMember(Name="startTime")]
        protected long? _startTime;
        [DataMember(Name="agencyId")]
        protected string _agencyId;
        [DataMember(Name="routeShortName")]
        protected string _routeShortName;
        [DataMember(Name="routeLongName")]
        protected string _routeLongName;
        [DataMember(Name="headsign")]
        protected string _headsign;
        [DataMember(Name="routeColor")]
        protected string _routeColor;
        [DataMember(Name="routeTextColor")]
        protected string _routeTextColor;
        [DataMember(Name="legsKey")]
        protected Guid? _legsKey = Guid.Empty;
        #endregion
        #region legs's Properties
/// <summary>
/// The bogusNonTransitLeg property
///
/// </summary>
///
        public virtual bool bogusNonTransitLeg
        {
            get
            {
                return _bogusNonTransitLeg;
            }
            set
            {
                _bogusNonTransitLeg = value;
            }
        }
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
/// The duration property
///
/// </summary>
///
        public virtual int? duration
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
/// The mode property
///
/// </summary>
///
        public virtual string mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
            }
        }
/// <summary>
/// The route property
///
/// </summary>
///
        public virtual string route
        {
            get
            {
                return _route;
            }
            set
            {
                _route = value;
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
/// The agencyId property
///
/// </summary>
///
        public virtual string agencyId
        {
            get
            {
                return _agencyId;
            }
            set
            {
                _agencyId = value;
            }
        }
/// <summary>
/// The routeShortName property
///
/// </summary>
///
        public virtual string routeShortName
        {
            get
            {
                return _routeShortName;
            }
            set
            {
                _routeShortName = value;
            }
        }
/// <summary>
/// The routeLongName property
///
/// </summary>
///
        public virtual string routeLongName
        {
            get
            {
                return _routeLongName;
            }
            set
            {
                _routeLongName = value;
            }
        }
/// <summary>
/// The headsign property
///
/// </summary>
///
        public virtual string headsign
        {
            get
            {
                return _headsign;
            }
            set
            {
                _headsign = value;
            }
        }
/// <summary>
/// The routeColor property
///
/// </summary>
///
        public virtual string routeColor
        {
            get
            {
                return _routeColor;
            }
            set
            {
                _routeColor = value;
            }
        }
/// <summary>
/// The routeTextColor property
///
/// </summary>
///
        public virtual string routeTextColor
        {
            get
            {
                return _routeTextColor;
            }
            set
            {
                _routeTextColor = value;
            }
        }
/// <summary>
/// The legsKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? legsKey
        {
            get
            {
                return _legsKey;
            }
            set
            {
                _legsKey = value;
            }
        }
        #endregion
        #region legs's Participant Properties
        [DataMember(Name="steps")]
        protected IList<steps> _steps = new List<steps>();
        public virtual List<steps> steps
        {
            get
            {
                if (_steps is steps[])
                {
                    _steps = _steps.ToList();
                }
                if (_steps == null)
                {
                    _steps = new List<steps>();
                }
                return _steps.ToList();
            }
            set
            {
                if (_steps is steps[])
                {
                    _steps = _steps.ToList();
                }
                if (_steps != null)
                {
                    var __itemsToDelete = new List<steps>(_steps);
                    foreach (var __item in __itemsToDelete)
                    {
                        Removesteps(__item);
                    }
                }
                if(value == null)
                {
                    _steps = new List<steps>();
                    return;
                }
                foreach(var __item in value)
                {
                    Addsteps(__item);
                }
            }
        }
        public virtual void Addsteps(IList<steps> __items)
        {
            foreach (var __item in __items)
            {
                Addsteps(__item);
            }
        }
        public virtual void Addsteps(steps __item)
        {
            if (__item != null && _steps!=null && !_steps.Contains(__item))
            {
                _steps.Add(__item);
            }
        }

        public virtual void Removesteps(steps __item)
        {
            if (__item != null && _steps!=null && _steps.Contains(__item))
            {
                _steps.Remove(__item);
            }
        }
        public virtual void SetstepsAt(steps __item, int __index)
        {
            if (__item == null)
            {
                _steps[__index] = null;
            }
            else
            {
                _steps[__index] = __item;
            }
        }

        public virtual void Clearsteps()
        {
            if (_steps!=null)
            {
                var __itemsToRemove = _steps.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    Removesteps(__item);
                }
            }
        }
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
        [DataMember(Name="legGeometry")]
        protected legGeometry _legGeometry;
        public virtual legGeometry legGeometry
        {
            get
            {
                return _legGeometry;
            }
            set
            {
                if(Equals(_legGeometry, value)) return;
                var __oldValue = _legGeometry;
                if (value != null)
                {
                    _legGeometry = value;
                }
                else
                {
                    if (_legGeometry != null)
                    {
                        _legGeometry = null;
                    }
                }
            }
        }
        [DataMember(Name="to")]
        protected to _to;
        public virtual to to
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
        [DataMember(Name="intermediateStops")]
        protected IList<intermediateStops> _intermediateStops = new List<intermediateStops>();
        public virtual List<intermediateStops> intermediateStops
        {
            get
            {
                if (_intermediateStops is intermediateStops[])
                {
                    _intermediateStops = _intermediateStops.ToList();
                }
                if (_intermediateStops == null)
                {
                    _intermediateStops = new List<intermediateStops>();
                }
                return _intermediateStops.ToList();
            }
            set
            {
                if (_intermediateStops is intermediateStops[])
                {
                    _intermediateStops = _intermediateStops.ToList();
                }
                if (_intermediateStops != null)
                {
                    var __itemsToDelete = new List<intermediateStops>(_intermediateStops);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveintermediateStops(__item);
                    }
                }
                if(value == null)
                {
                    _intermediateStops = new List<intermediateStops>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddintermediateStops(__item);
                }
            }
        }
        public virtual void AddintermediateStops(IList<intermediateStops> __items)
        {
            foreach (var __item in __items)
            {
                AddintermediateStops(__item);
            }
        }
        public virtual void AddintermediateStops(intermediateStops __item)
        {
            if (__item != null && _intermediateStops!=null && !_intermediateStops.Contains(__item))
            {
                _intermediateStops.Add(__item);
            }
        }

        public virtual void RemoveintermediateStops(intermediateStops __item)
        {
            if (__item != null && _intermediateStops!=null && _intermediateStops.Contains(__item))
            {
                _intermediateStops.Remove(__item);
            }
        }
        public virtual void SetintermediateStopsAt(intermediateStops __item, int __index)
        {
            if (__item == null)
            {
                _intermediateStops[__index] = null;
            }
            else
            {
                _intermediateStops[__index] = __item;
            }
        }

        public virtual void ClearintermediateStops()
        {
            if (_intermediateStops!=null)
            {
                var __itemsToRemove = _intermediateStops.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveintermediateStops(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the legs class
/// </summary>
/// <returns>New legs object</returns>
/// <remarks></remarks>
        public legs()
        {
            if (legsKey == null) legsKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (mode != null && mode.Length > 100)
            {
                __errors.Add("Length of property 'mode' cannot be greater than 100.");
            }
            if (route != null && route.Length > 100)
            {
                __errors.Add("Length of property 'route' cannot be greater than 100.");
            }
            if (agencyId != null && agencyId.Length > 100)
            {
                __errors.Add("Length of property 'agencyId' cannot be greater than 100.");
            }
            if (routeShortName != null && routeShortName.Length > 100)
            {
                __errors.Add("Length of property 'routeShortName' cannot be greater than 100.");
            }
            if (routeLongName != null && routeLongName.Length > 100)
            {
                __errors.Add("Length of property 'routeLongName' cannot be greater than 100.");
            }
            if (headsign != null && headsign.Length > 100)
            {
                __errors.Add("Length of property 'headsign' cannot be greater than 100.");
            }
            if (routeColor != null && routeColor.Length > 100)
            {
                __errors.Add("Length of property 'routeColor' cannot be greater than 100.");
            }
            if (routeTextColor != null && routeTextColor.Length > 100)
            {
                __errors.Add("Length of property 'routeTextColor' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'legs' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [legs] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual legs Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, legs copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (legs)copiedObjects[this];
            copy = copy ?? new legs();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.legsKey = this.legsKey;
            }
            copy.bogusNonTransitLeg = this.bogusNonTransitLeg;
            copy.distance = this.distance;
            copy.duration = this.duration;
            copy.endTime = this.endTime;
            copy.mode = this.mode;
            copy.route = this.route;
            copy.startTime = this.startTime;
            copy.agencyId = this.agencyId;
            copy.routeShortName = this.routeShortName;
            copy.routeLongName = this.routeLongName;
            copy.headsign = this.headsign;
            copy.routeColor = this.routeColor;
            copy.routeTextColor = this.routeTextColor;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy._steps = new List<steps>();
            if(deep && this._steps != null)
            {
                foreach (var __item in this._steps)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.Addsteps(__item);
                        else
                            copy.Addsteps(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.Addsteps((steps)copiedObjects[__item]);
                    }
                }
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
            if(deep && this._legGeometry != null)
            {
                if (!copiedObjects.Contains(this._legGeometry))
                {
                    if (asNew && reuseNestedObjects)
                        copy.legGeometry = this.legGeometry;
                    else if (asNew)
                        copy.legGeometry = this.legGeometry.Copy(deep, copiedObjects, true);
                    else
                        copy._legGeometry = this._legGeometry.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.legGeometry = (legGeometry)copiedObjects[this.legGeometry];
                    else
                        copy._legGeometry = (legGeometry)copiedObjects[this.legGeometry];
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
                        copy.to = (to)copiedObjects[this.to];
                    else
                        copy._to = (to)copiedObjects[this.to];
                }
            }
            copy._intermediateStops = new List<intermediateStops>();
            if(deep && this._intermediateStops != null)
            {
                foreach (var __item in this._intermediateStops)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddintermediateStops(__item);
                        else
                            copy.AddintermediateStops(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddintermediateStops((intermediateStops)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as legs;
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
                __propertyKeyCache = this.GetType().GetProperty("legsKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.legsKey.GetHashCode();
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
            return this.legsKey == default(Guid) || this.legsKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(legs compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.legsKey.Equals(compareTo.legsKey);
        }

        #endregion
    }
}
