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
    /// The Solution class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Solution : IDomainModelClass
    {
        #region Solution's Fields

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
        [DataMember(Name="Source")]
        protected string source;
        #endregion
        #region Solution's Properties
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
/// The Source property
///
/// </summary>
///
        public virtual string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }
        #endregion
        #region Solution's Participant Properties
        [DataMember(Name="MarineSegments")]
        protected IList<MarineSegment> marineSegments = new List<MarineSegment>();
        public virtual List<MarineSegment> MarineSegments
        {
            get
            {
                if (marineSegments is MarineSegment[])
                {
                    marineSegments = marineSegments.ToList();
                }
                if (marineSegments == null)
                {
                    marineSegments = new List<MarineSegment>();
                }
                return marineSegments.ToList();
            }
            set
            {
                if (marineSegments is MarineSegment[])
                {
                    marineSegments = marineSegments.ToList();
                }
                if (marineSegments != null)
                {
                    var __itemsToDelete = new List<MarineSegment>(marineSegments);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveMarineSegments(__item);
                    }
                }
                if(value == null)
                {
                    marineSegments = new List<MarineSegment>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddMarineSegments(__item);
                }
            }
        }
        public virtual void AddMarineSegments(IList<MarineSegment> __items)
        {
            foreach (var __item in __items)
            {
                AddMarineSegments(__item);
            }
        }
        public virtual void AddMarineSegments(MarineSegment __item)
        {
            if (__item != null && marineSegments!=null && !marineSegments.Contains(__item))
            {
                marineSegments.Add(__item);
            }
        }

        public virtual void RemoveMarineSegments(MarineSegment __item)
        {
            if (__item != null && marineSegments!=null && marineSegments.Contains(__item))
            {
                marineSegments.Remove(__item);
            }
        }
        public virtual void SetMarineSegmentsAt(MarineSegment __item, int __index)
        {
            if (__item == null)
            {
                marineSegments[__index] = null;
            }
            else
            {
                marineSegments[__index] = __item;
            }
        }

        public virtual void ClearMarineSegments()
        {
            if (marineSegments!=null)
            {
                var __itemsToRemove = marineSegments.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveMarineSegments(__item);
                }
            }
        }
        [DataMember(Name="UrbanSegments")]
        protected IList<UrbanSegment> urbanSegments = new List<UrbanSegment>();
        public virtual List<UrbanSegment> UrbanSegments
        {
            get
            {
                if (urbanSegments is UrbanSegment[])
                {
                    urbanSegments = urbanSegments.ToList();
                }
                if (urbanSegments == null)
                {
                    urbanSegments = new List<UrbanSegment>();
                }
                return urbanSegments.ToList();
            }
            set
            {
                if (urbanSegments is UrbanSegment[])
                {
                    urbanSegments = urbanSegments.ToList();
                }
                if (urbanSegments != null)
                {
                    var __itemsToDelete = new List<UrbanSegment>(urbanSegments);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUrbanSegments(__item);
                    }
                }
                if(value == null)
                {
                    urbanSegments = new List<UrbanSegment>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUrbanSegments(__item);
                }
            }
        }
        public virtual void AddUrbanSegments(IList<UrbanSegment> __items)
        {
            foreach (var __item in __items)
            {
                AddUrbanSegments(__item);
            }
        }
        public virtual void AddUrbanSegments(UrbanSegment __item)
        {
            if (__item != null && urbanSegments!=null && !urbanSegments.Contains(__item))
            {
                urbanSegments.Add(__item);
            }
        }

        public virtual void RemoveUrbanSegments(UrbanSegment __item)
        {
            if (__item != null && urbanSegments!=null && urbanSegments.Contains(__item))
            {
                urbanSegments.Remove(__item);
            }
        }
        public virtual void SetUrbanSegmentsAt(UrbanSegment __item, int __index)
        {
            if (__item == null)
            {
                urbanSegments[__index] = null;
            }
            else
            {
                urbanSegments[__index] = __item;
            }
        }

        public virtual void ClearUrbanSegments()
        {
            if (urbanSegments!=null)
            {
                var __itemsToRemove = urbanSegments.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUrbanSegments(__item);
                }
            }
        }
        [DataMember(Name="FlightSegments")]
        protected IList<FlightSegment> flightSegments = new List<FlightSegment>();
        public virtual List<FlightSegment> FlightSegments
        {
            get
            {
                if (flightSegments is FlightSegment[])
                {
                    flightSegments = flightSegments.ToList();
                }
                if (flightSegments == null)
                {
                    flightSegments = new List<FlightSegment>();
                }
                return flightSegments.ToList();
            }
            set
            {
                if (flightSegments is FlightSegment[])
                {
                    flightSegments = flightSegments.ToList();
                }
                if (flightSegments != null)
                {
                    var __itemsToDelete = new List<FlightSegment>(flightSegments);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveFlightSegments(__item);
                    }
                }
                if(value == null)
                {
                    flightSegments = new List<FlightSegment>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddFlightSegments(__item);
                }
            }
        }
        public virtual void AddFlightSegments(IList<FlightSegment> __items)
        {
            foreach (var __item in __items)
            {
                AddFlightSegments(__item);
            }
        }
        public virtual void AddFlightSegments(FlightSegment __item)
        {
            if (__item != null && flightSegments!=null && !flightSegments.Contains(__item))
            {
                flightSegments.Add(__item);
            }
        }

        public virtual void RemoveFlightSegments(FlightSegment __item)
        {
            if (__item != null && flightSegments!=null && flightSegments.Contains(__item))
            {
                flightSegments.Remove(__item);
            }
        }
        public virtual void SetFlightSegmentsAt(FlightSegment __item, int __index)
        {
            if (__item == null)
            {
                flightSegments[__index] = null;
            }
            else
            {
                flightSegments[__index] = __item;
            }
        }

        public virtual void ClearFlightSegments()
        {
            if (flightSegments!=null)
            {
                var __itemsToRemove = flightSegments.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveFlightSegments(__item);
                }
            }
        }
        [DataMember(Name="Leg")]
        protected Leg leg;
        public virtual Leg Leg
        {
            get
            {
                return leg;
            }
            set
            {
                if(Equals(leg, value)) return;
                var __oldValue = leg;
                if (value != null)
                {
                    if(leg != null && !Equals(leg, value))
                        leg.RemoveSolutions(this);
                    leg = value;
                    leg.AddSolutions(this);
                }
                else
                {
                    if(leg != null)
                        leg.RemoveSolutions(this);
                    leg = null;
                }
            }
        }
        [DataMember(Name="RailSegments")]
        protected IList<RailSegment> railSegments = new List<RailSegment>();
        public virtual List<RailSegment> RailSegments
        {
            get
            {
                if (railSegments is RailSegment[])
                {
                    railSegments = railSegments.ToList();
                }
                if (railSegments == null)
                {
                    railSegments = new List<RailSegment>();
                }
                return railSegments.ToList();
            }
            set
            {
                if (railSegments is RailSegment[])
                {
                    railSegments = railSegments.ToList();
                }
                if (railSegments != null)
                {
                    var __itemsToDelete = new List<RailSegment>(railSegments);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveRailSegments(__item);
                    }
                }
                if(value == null)
                {
                    railSegments = new List<RailSegment>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddRailSegments(__item);
                }
            }
        }
        public virtual void AddRailSegments(IList<RailSegment> __items)
        {
            foreach (var __item in __items)
            {
                AddRailSegments(__item);
            }
        }
        public virtual void AddRailSegments(RailSegment __item)
        {
            if (__item != null && railSegments!=null && !railSegments.Contains(__item))
            {
                railSegments.Add(__item);
            }
        }

        public virtual void RemoveRailSegments(RailSegment __item)
        {
            if (__item != null && railSegments!=null && railSegments.Contains(__item))
            {
                railSegments.Remove(__item);
            }
        }
        public virtual void SetRailSegmentsAt(RailSegment __item, int __index)
        {
            if (__item == null)
            {
                railSegments[__index] = null;
            }
            else
            {
                railSegments[__index] = __item;
            }
        }

        public virtual void ClearRailSegments()
        {
            if (railSegments!=null)
            {
                var __itemsToRemove = railSegments.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveRailSegments(__item);
                }
            }
        }
        [DataMember(Name="UrbanStart")]
        protected UrbanLocationPair urbanStart;
        public virtual UrbanLocationPair UrbanStart
        {
            get
            {
                return urbanStart;
            }
            set
            {
                if(Equals(urbanStart, value)) return;
                var __oldValue = urbanStart;
                if (value != null)
                {
                    urbanStart = value;
                }
                else
                {
                    urbanStart = null;
                }
            }
        }
        [DataMember(Name="UrbanEnd")]
        protected UrbanLocationPair urbanEnd;
        public virtual UrbanLocationPair UrbanEnd
        {
            get
            {
                return urbanEnd;
            }
            set
            {
                if(Equals(urbanEnd, value)) return;
                var __oldValue = urbanEnd;
                if (value != null)
                {
                    urbanEnd = value;
                }
                else
                {
                    urbanEnd = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Solution class
/// </summary>
/// <returns>New Solution object</returns>
/// <remarks></remarks>
        public Solution() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Source != null && Source.Length > 100)
            {
                __errors.Add("Length of property 'Source' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Solution' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Solution] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Solution Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Solution copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Solution)copiedObjects[this];
            copy = copy ?? new Solution();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Source = this.Source;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.marineSegments = new List<MarineSegment>();
            if(deep && this.marineSegments != null)
            {
                foreach (var __item in this.marineSegments)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddMarineSegments(__item);
                        else
                            copy.AddMarineSegments(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddMarineSegments((MarineSegment)copiedObjects[__item]);
                    }
                }
            }
            copy.urbanSegments = new List<UrbanSegment>();
            if(deep && this.urbanSegments != null)
            {
                foreach (var __item in this.urbanSegments)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUrbanSegments(__item);
                        else
                            copy.AddUrbanSegments(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUrbanSegments((UrbanSegment)copiedObjects[__item]);
                    }
                }
            }
            copy.flightSegments = new List<FlightSegment>();
            if(deep && this.flightSegments != null)
            {
                foreach (var __item in this.flightSegments)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddFlightSegments(__item);
                        else
                            copy.AddFlightSegments(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddFlightSegments((FlightSegment)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.leg != null)
            {
                if (!copiedObjects.Contains(this.leg))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Leg = this.Leg;
                    else if (asNew)
                        copy.Leg = this.Leg.Copy(deep, copiedObjects, true);
                    else
                        copy.leg = this.leg.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Leg = (Leg)copiedObjects[this.Leg];
                    else
                        copy.leg = (Leg)copiedObjects[this.Leg];
                }
            }
            copy.railSegments = new List<RailSegment>();
            if(deep && this.railSegments != null)
            {
                foreach (var __item in this.railSegments)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddRailSegments(__item);
                        else
                            copy.AddRailSegments(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddRailSegments((RailSegment)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.urbanStart != null)
            {
                if (!copiedObjects.Contains(this.urbanStart))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UrbanStart = this.UrbanStart;
                    else if (asNew)
                        copy.UrbanStart = this.UrbanStart.Copy(deep, copiedObjects, true);
                    else
                        copy.urbanStart = this.urbanStart.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UrbanStart = (UrbanLocationPair)copiedObjects[this.UrbanStart];
                    else
                        copy.urbanStart = (UrbanLocationPair)copiedObjects[this.UrbanStart];
                }
            }
            if(deep && this.urbanEnd != null)
            {
                if (!copiedObjects.Contains(this.urbanEnd))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UrbanEnd = this.UrbanEnd;
                    else if (asNew)
                        copy.UrbanEnd = this.UrbanEnd.Copy(deep, copiedObjects, true);
                    else
                        copy.urbanEnd = this.urbanEnd.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UrbanEnd = (UrbanLocationPair)copiedObjects[this.UrbanEnd];
                    else
                        copy.urbanEnd = (UrbanLocationPair)copiedObjects[this.UrbanEnd];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Solution;
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
        protected bool HasSameNonDefaultIdAs(Solution compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
