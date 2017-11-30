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
    /// The Schedule class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Schedule : IDomainModelClass
    {
        #region Schedule's Fields

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
        [DataMember(Name="OperatingOnMonday")]
        protected bool operatingOnMonday;
        [DataMember(Name="OperatingOnTuesday")]
        protected bool operatingOnTuesday;
        [DataMember(Name="OperatingOnWednesday")]
        protected bool operatingOnWednesday;
        [DataMember(Name="OperatingOnThursday")]
        protected bool operatingOnThursday;
        [DataMember(Name="OperatingOnFriday")]
        protected bool operatingOnFriday;
        [DataMember(Name="OperatingOnSaturday")]
        protected bool operatingOnSaturday;
        [DataMember(Name="OperatingOnSunday")]
        protected bool operatingOnSunday;
        [DataMember(Name="IsException")]
        protected bool isException;
        [DataMember(Name="GTFSId")]
        protected string gTFSId;
        #endregion
        #region Schedule's Properties
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
/// The OperatingOnMonday property
///
/// </summary>
///
        public virtual bool OperatingOnMonday
        {
            get
            {
                return operatingOnMonday;
            }
            set
            {
                operatingOnMonday = value;
            }
        }
/// <summary>
/// The OperatingOnTuesday property
///
/// </summary>
///
        public virtual bool OperatingOnTuesday
        {
            get
            {
                return operatingOnTuesday;
            }
            set
            {
                operatingOnTuesday = value;
            }
        }
/// <summary>
/// The OperatingOnWednesday property
///
/// </summary>
///
        public virtual bool OperatingOnWednesday
        {
            get
            {
                return operatingOnWednesday;
            }
            set
            {
                operatingOnWednesday = value;
            }
        }
/// <summary>
/// The OperatingOnThursday property
///
/// </summary>
///
        public virtual bool OperatingOnThursday
        {
            get
            {
                return operatingOnThursday;
            }
            set
            {
                operatingOnThursday = value;
            }
        }
/// <summary>
/// The OperatingOnFriday property
///
/// </summary>
///
        public virtual bool OperatingOnFriday
        {
            get
            {
                return operatingOnFriday;
            }
            set
            {
                operatingOnFriday = value;
            }
        }
/// <summary>
/// The OperatingOnSaturday property
///
/// </summary>
///
        public virtual bool OperatingOnSaturday
        {
            get
            {
                return operatingOnSaturday;
            }
            set
            {
                operatingOnSaturday = value;
            }
        }
/// <summary>
/// The OperatingOnSunday property
///
/// </summary>
///
        public virtual bool OperatingOnSunday
        {
            get
            {
                return operatingOnSunday;
            }
            set
            {
                operatingOnSunday = value;
            }
        }
/// <summary>
/// The IsException property
///
/// </summary>
///
        public virtual bool IsException
        {
            get
            {
                return isException;
            }
            set
            {
                isException = value;
            }
        }
/// <summary>
/// The GTFSId property
///
/// </summary>
///
        public virtual string GTFSId
        {
            get
            {
                return gTFSId;
            }
            set
            {
                gTFSId = value;
            }
        }
        #endregion
        #region Schedule's Participant Properties
        [DataMember(Name="Routes")]
        protected IList<ItineraryRoute> routes = new List<ItineraryRoute>();
        public virtual List<ItineraryRoute> Routes
        {
            get
            {
                if (routes is ItineraryRoute[])
                {
                    routes = routes.ToList();
                }
                if (routes == null)
                {
                    routes = new List<ItineraryRoute>();
                }
                return routes.ToList();
            }
            set
            {
                if (routes is ItineraryRoute[])
                {
                    routes = routes.ToList();
                }
                if (routes != null)
                {
                    var __itemsToDelete = new List<ItineraryRoute>(routes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveRoutes(__item);
                    }
                }
                if(value == null)
                {
                    routes = new List<ItineraryRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddRoutes(__item);
                }
            }
        }
        public virtual void AddRoutes(IList<ItineraryRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddRoutes(__item);
            }
        }
        public virtual void AddRoutes(ItineraryRoute __item)
        {
            if (__item != null && routes!=null && !routes.Contains(__item))
            {
                routes.Add(__item);
                if (!__item.Schedules.Contains(this))
                    __item.AddSchedules(this);
            }
        }

        public virtual void RemoveRoutes(ItineraryRoute __item)
        {
            if (__item != null && routes!=null && routes.Contains(__item))
            {
                routes.Remove(__item);
                if(__item.Schedules.Contains(this))
                    __item.RemoveSchedules(this);
            }
        }
        public virtual void SetRoutesAt(ItineraryRoute __item, int __index)
        {
            if (__item == null)
            {
                routes[__index].RemoveSchedules(this);
            }
            else
            {
                routes[__index] = __item;
                if (!__item.Schedules.Contains(this))
                    __item.AddSchedules(this);
            }
        }

        public virtual void ClearRoutes()
        {
            if (routes!=null)
            {
                var __itemsToRemove = routes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveRoutes(__item);
                }
            }
        }
        [DataMember(Name="RouteTimeDetails")]
        protected IList<RouteTimeDetails> routeTimeDetails = new List<RouteTimeDetails>();
        public virtual List<RouteTimeDetails> RouteTimeDetails
        {
            get
            {
                if (routeTimeDetails is RouteTimeDetails[])
                {
                    routeTimeDetails = routeTimeDetails.ToList();
                }
                if (routeTimeDetails == null)
                {
                    routeTimeDetails = new List<RouteTimeDetails>();
                }
                return routeTimeDetails.ToList();
            }
            set
            {
                if (routeTimeDetails is RouteTimeDetails[])
                {
                    routeTimeDetails = routeTimeDetails.ToList();
                }
                if (routeTimeDetails != null)
                {
                    var __itemsToDelete = new List<RouteTimeDetails>(routeTimeDetails);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveRouteTimeDetails(__item);
                    }
                }
                if(value == null)
                {
                    routeTimeDetails = new List<RouteTimeDetails>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddRouteTimeDetails(__item);
                }
            }
        }
        public virtual void AddRouteTimeDetails(IList<RouteTimeDetails> __items)
        {
            foreach (var __item in __items)
            {
                AddRouteTimeDetails(__item);
            }
        }
        public virtual void AddRouteTimeDetails(RouteTimeDetails __item)
        {
            if (__item != null && routeTimeDetails!=null && !routeTimeDetails.Contains(__item))
            {
                routeTimeDetails.Add(__item);
                if (__item.Schedule != this)
                    __item.Schedule = this;
            }
        }

        public virtual void RemoveRouteTimeDetails(RouteTimeDetails __item)
        {
            if (__item != null && routeTimeDetails!=null && routeTimeDetails.Contains(__item))
            {
                routeTimeDetails.Remove(__item);
                __item.Schedule = null;
            }
        }
        public virtual void SetRouteTimeDetailsAt(RouteTimeDetails __item, int __index)
        {
            if (__item == null)
            {
                routeTimeDetails[__index].Schedule = null;
            }
            else
            {
                routeTimeDetails[__index] = __item;
                if (__item.Schedule != this)
                    __item.Schedule = this;
            }
        }

        public virtual void ClearRouteTimeDetails()
        {
            if (routeTimeDetails!=null)
            {
                var __itemsToRemove = routeTimeDetails.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveRouteTimeDetails(__item);
                }
            }
        }
        [DataMember(Name="TimePeriod")]
        protected TimePeriod timePeriod;
        public virtual TimePeriod TimePeriod
        {
            get
            {
                return timePeriod;
            }
            set
            {
                if(Equals(timePeriod, value)) return;
                var __oldValue = timePeriod;
                if (value != null)
                {
                    timePeriod = value;
                }
                else
                {
                    timePeriod = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Schedule class
/// </summary>
/// <returns>New Schedule object</returns>
/// <remarks></remarks>
        public Schedule() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (GTFSId != null && GTFSId.Length > 100)
            {
                __errors.Add("Length of property 'GTFSId' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Schedule' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Schedule] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Schedule Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Schedule copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Schedule)copiedObjects[this];
            copy = copy ?? new Schedule();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.OperatingOnMonday = this.OperatingOnMonday;
            copy.OperatingOnTuesday = this.OperatingOnTuesday;
            copy.OperatingOnWednesday = this.OperatingOnWednesday;
            copy.OperatingOnThursday = this.OperatingOnThursday;
            copy.OperatingOnFriday = this.OperatingOnFriday;
            copy.OperatingOnSaturday = this.OperatingOnSaturday;
            copy.OperatingOnSunday = this.OperatingOnSunday;
            copy.IsException = this.IsException;
            copy.GTFSId = this.GTFSId;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.routes = new List<ItineraryRoute>();
            if(deep && this.routes != null)
            {
                foreach (var __item in this.routes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddRoutes(__item);
                        else
                            copy.AddRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddRoutes((ItineraryRoute)copiedObjects[__item]);
                    }
                }
            }
            copy.routeTimeDetails = new List<RouteTimeDetails>();
            if(deep && this.routeTimeDetails != null)
            {
                foreach (var __item in this.routeTimeDetails)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddRouteTimeDetails(__item);
                        else
                            copy.AddRouteTimeDetails(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddRouteTimeDetails((RouteTimeDetails)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.timePeriod != null)
            {
                if (!copiedObjects.Contains(this.timePeriod))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TimePeriod = this.TimePeriod;
                    else if (asNew)
                        copy.TimePeriod = this.TimePeriod.Copy(deep, copiedObjects, true);
                    else
                        copy.timePeriod = this.timePeriod.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TimePeriod = (TimePeriod)copiedObjects[this.TimePeriod];
                    else
                        copy.timePeriod = (TimePeriod)copiedObjects[this.TimePeriod];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Schedule;
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
        protected bool HasSameNonDefaultIdAs(Schedule compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
