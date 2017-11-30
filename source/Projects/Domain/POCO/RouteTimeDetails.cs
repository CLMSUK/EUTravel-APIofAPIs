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
    /// The RouteTimeDetails class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class RouteTimeDetails : IDomainModelClass
    {
        #region RouteTimeDetails's Fields

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
        [DataMember(Name="DepartureTime")]
        protected string departureTime;
        [DataMember(Name="ArrivalTime")]
        protected string arrivalTime;
        [DataMember(Name="ArrivalOnNextDay")]
        protected bool arrivalOnNextDay;
        [DataMember(Name="Duration")]
        protected int? duration;
        #endregion
        #region RouteTimeDetails's Properties
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
/// The DepartureTime property
///
/// </summary>
///
        public virtual string DepartureTime
        {
            get
            {
                return departureTime;
            }
            set
            {
                departureTime = value;
            }
        }
/// <summary>
/// The ArrivalTime property
///
/// </summary>
///
        public virtual string ArrivalTime
        {
            get
            {
                return arrivalTime;
            }
            set
            {
                arrivalTime = value;
            }
        }
/// <summary>
/// The ArrivalOnNextDay property
///
/// </summary>
///
        public virtual bool ArrivalOnNextDay
        {
            get
            {
                return arrivalOnNextDay;
            }
            set
            {
                arrivalOnNextDay = value;
            }
        }
/// <summary>
/// The Duration property
///
/// </summary>
///
        public virtual int? Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        #endregion
        #region RouteTimeDetails's Participant Properties
        [DataMember(Name="Schedule")]
        protected Schedule schedule;
        public virtual Schedule Schedule
        {
            get
            {
                return schedule;
            }
            set
            {
                if(Equals(schedule, value)) return;
                var __oldValue = schedule;
                if (value != null)
                {
                    if(schedule != null && !Equals(schedule, value))
                        schedule.RemoveRouteTimeDetails(this);
                    schedule = value;
                    schedule.AddRouteTimeDetails(this);
                }
                else
                {
                    if(schedule != null)
                        schedule.RemoveRouteTimeDetails(this);
                    schedule = null;
                }
            }
        }
        [DataMember(Name="StopTimeDetails")]
        protected IList<StopTimeDetails> stopTimeDetails = new List<StopTimeDetails>();
        public virtual List<StopTimeDetails> StopTimeDetails
        {
            get
            {
                if (stopTimeDetails is StopTimeDetails[])
                {
                    stopTimeDetails = stopTimeDetails.ToList();
                }
                if (stopTimeDetails == null)
                {
                    stopTimeDetails = new List<StopTimeDetails>();
                }
                return stopTimeDetails.ToList();
            }
            set
            {
                if (stopTimeDetails is StopTimeDetails[])
                {
                    stopTimeDetails = stopTimeDetails.ToList();
                }
                if (stopTimeDetails != null)
                {
                    var __itemsToDelete = new List<StopTimeDetails>(stopTimeDetails);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveStopTimeDetails(__item);
                    }
                }
                if(value == null)
                {
                    stopTimeDetails = new List<StopTimeDetails>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddStopTimeDetails(__item);
                }
            }
        }
        public virtual void AddStopTimeDetails(IList<StopTimeDetails> __items)
        {
            foreach (var __item in __items)
            {
                AddStopTimeDetails(__item);
            }
        }
        public virtual void AddStopTimeDetails(StopTimeDetails __item)
        {
            if (__item != null && stopTimeDetails!=null && !stopTimeDetails.Contains(__item))
            {
                stopTimeDetails.Add(__item);
                if (__item.RouteTimeDetails != this)
                    __item.RouteTimeDetails = this;
            }
        }

        public virtual void RemoveStopTimeDetails(StopTimeDetails __item)
        {
            if (__item != null && stopTimeDetails!=null && stopTimeDetails.Contains(__item))
            {
                stopTimeDetails.Remove(__item);
                __item.RouteTimeDetails = null;
            }
        }
        public virtual void SetStopTimeDetailsAt(StopTimeDetails __item, int __index)
        {
            if (__item == null)
            {
                stopTimeDetails[__index].RouteTimeDetails = null;
            }
            else
            {
                stopTimeDetails[__index] = __item;
                if (__item.RouteTimeDetails != this)
                    __item.RouteTimeDetails = this;
            }
        }

        public virtual void ClearStopTimeDetails()
        {
            if (stopTimeDetails!=null)
            {
                var __itemsToRemove = stopTimeDetails.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveStopTimeDetails(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the RouteTimeDetails class
/// </summary>
/// <returns>New RouteTimeDetails object</returns>
/// <remarks></remarks>
        public RouteTimeDetails() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (DepartureTime != null && DepartureTime.Length > 100)
            {
                __errors.Add("Length of property 'DepartureTime' cannot be greater than 100.");
            }
            if (ArrivalTime != null && ArrivalTime.Length > 100)
            {
                __errors.Add("Length of property 'ArrivalTime' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'RouteTimeDetails' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [RouteTimeDetails] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual RouteTimeDetails Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, RouteTimeDetails copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (RouteTimeDetails)copiedObjects[this];
            copy = copy ?? new RouteTimeDetails();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.DepartureTime = this.DepartureTime;
            copy.ArrivalTime = this.ArrivalTime;
            copy.ArrivalOnNextDay = this.ArrivalOnNextDay;
            copy.Duration = this.Duration;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.schedule != null)
            {
                if (!copiedObjects.Contains(this.schedule))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Schedule = this.Schedule;
                    else if (asNew)
                        copy.Schedule = this.Schedule.Copy(deep, copiedObjects, true);
                    else
                        copy.schedule = this.schedule.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Schedule = (Schedule)copiedObjects[this.Schedule];
                    else
                        copy.schedule = (Schedule)copiedObjects[this.Schedule];
                }
            }
            copy.stopTimeDetails = new List<StopTimeDetails>();
            if(deep && this.stopTimeDetails != null)
            {
                foreach (var __item in this.stopTimeDetails)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddStopTimeDetails(__item);
                        else
                            copy.AddStopTimeDetails(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddStopTimeDetails((StopTimeDetails)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as RouteTimeDetails;
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
        protected bool HasSameNonDefaultIdAs(RouteTimeDetails compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
