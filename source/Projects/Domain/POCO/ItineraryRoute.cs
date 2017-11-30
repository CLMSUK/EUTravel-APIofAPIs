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
    /// The ItineraryRoute class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(MarineRoute))]

    [KnownType(typeof(RailRoute))]

    [KnownType(typeof(UrbanTrip))]

    [KnownType(typeof(FlightRoute))]

    public class ItineraryRoute : IDomainModelClass
    {
        #region ItineraryRoute's Fields

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
        [DataMember(Name="Duration")]
        protected int? duration;
        [DataMember(Name="ETicketability")]
        protected bool eTicketability;
        [DataMember(Name="Remarks")]
        protected string remarks;
        [DataMember(Name="Active")]
        protected bool active;
        [DataMember(Name="OnTimePercentage")]
        protected decimal? onTimePercentage;
        [DataMember(Name="UpdatedAt")]
        protected string updatedAt;
        [DataMember(Name="CO2Emissions")]
        protected int? cO2Emissions;
        [DataMember(Name="LuggageAvailability")]
        protected string luggageAvailability;
        [DataMember(Name="LuggageDimensions")]
        protected string luggageDimensions;
        [DataMember(Name="LuggageTermsOfService")]
        protected string luggageTermsOfService;
        [DataMember(Name="PriceRangeMin")]
        protected decimal? priceRangeMin;
        [DataMember(Name="PriceRangeMax")]
        protected decimal? priceRangeMax;
        [DataMember(Name="ExternalIdentifier")]
        protected string externalIdentifier;
        #endregion
        #region ItineraryRoute's Properties
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
/// <summary>
/// The ETicketability property
///
/// </summary>
///
        public virtual bool ETicketability
        {
            get
            {
                return eTicketability;
            }
            set
            {
                eTicketability = value;
            }
        }
/// <summary>
/// The Remarks property
///
/// </summary>
///
        public virtual string Remarks
        {
            get
            {
                return remarks;
            }
            set
            {
                remarks = value;
            }
        }
/// <summary>
/// The Active property
///
/// </summary>
///
        public virtual bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
/// <summary>
/// The OnTimePercentage property
///
/// </summary>
///
        public virtual decimal? OnTimePercentage
        {
            get
            {
                return onTimePercentage;
            }
            set
            {
                onTimePercentage = value;
            }
        }
/// <summary>
/// The UpdatedAt property
///
/// </summary>
///
        public virtual string UpdatedAt
        {
            get
            {
                return updatedAt;
            }
            set
            {
                updatedAt = value;
            }
        }
/// <summary>
/// The CO2Emissions property
///
/// </summary>
///
        public virtual int? CO2Emissions
        {
            get
            {
                return cO2Emissions;
            }
            set
            {
                cO2Emissions = value;
            }
        }
/// <summary>
/// The LuggageAvailability property
///
/// </summary>
///
        public virtual string LuggageAvailability
        {
            get
            {
                return luggageAvailability;
            }
            set
            {
                luggageAvailability = value;
            }
        }
/// <summary>
/// The LuggageDimensions property
///
/// </summary>
///
        public virtual string LuggageDimensions
        {
            get
            {
                return luggageDimensions;
            }
            set
            {
                luggageDimensions = value;
            }
        }
/// <summary>
/// The LuggageTermsOfService property
///
/// </summary>
///
        public virtual string LuggageTermsOfService
        {
            get
            {
                return luggageTermsOfService;
            }
            set
            {
                luggageTermsOfService = value;
            }
        }
/// <summary>
/// The PriceRangeMin property
///
/// </summary>
///
        public virtual decimal? PriceRangeMin
        {
            get
            {
                return priceRangeMin;
            }
            set
            {
                priceRangeMin = value;
            }
        }
/// <summary>
/// The PriceRangeMax property
///
/// </summary>
///
        public virtual decimal? PriceRangeMax
        {
            get
            {
                return priceRangeMax;
            }
            set
            {
                priceRangeMax = value;
            }
        }
/// <summary>
/// The ExternalIdentifier property
///
/// </summary>
///
        public virtual string ExternalIdentifier
        {
            get
            {
                return externalIdentifier;
            }
            set
            {
                externalIdentifier = value;
            }
        }
        #endregion
        #region ItineraryRoute's Participant Properties
        [DataMember(Name="Amenities")]
        protected IList<Amenity> amenities = new List<Amenity>();
        public virtual List<Amenity> Amenities
        {
            get
            {
                if (amenities is Amenity[])
                {
                    amenities = amenities.ToList();
                }
                if (amenities == null)
                {
                    amenities = new List<Amenity>();
                }
                return amenities.ToList();
            }
            set
            {
                if (amenities is Amenity[])
                {
                    amenities = amenities.ToList();
                }
                if (amenities != null)
                {
                    var __itemsToDelete = new List<Amenity>(amenities);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAmenities(__item);
                    }
                }
                if(value == null)
                {
                    amenities = new List<Amenity>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAmenities(__item);
                }
            }
        }
        public virtual void AddAmenities(IList<Amenity> __items)
        {
            foreach (var __item in __items)
            {
                AddAmenities(__item);
            }
        }
        public virtual void AddAmenities(Amenity __item)
        {
            if (__item != null && amenities!=null && !amenities.Contains(__item))
            {
                amenities.Add(__item);
            }
        }

        public virtual void RemoveAmenities(Amenity __item)
        {
            if (__item != null && amenities!=null && amenities.Contains(__item))
            {
                amenities.Remove(__item);
            }
        }
        public virtual void SetAmenitiesAt(Amenity __item, int __index)
        {
            if (__item == null)
            {
                amenities[__index] = null;
            }
            else
            {
                amenities[__index] = __item;
            }
        }

        public virtual void ClearAmenities()
        {
            if (amenities!=null)
            {
                var __itemsToRemove = amenities.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAmenities(__item);
                }
            }
        }
        [DataMember(Name="Distance")]
        protected Distance distance;
        public virtual Distance Distance
        {
            get
            {
                return distance;
            }
            set
            {
                if(Equals(distance, value)) return;
                var __oldValue = distance;
                if (value != null)
                {
                    distance = value;
                }
                else
                {
                    distance = null;
                }
            }
        }
        [DataMember(Name="Schedules")]
        protected IList<Schedule> schedules = new List<Schedule>();
        public virtual List<Schedule> Schedules
        {
            get
            {
                if (schedules is Schedule[])
                {
                    schedules = schedules.ToList();
                }
                if (schedules == null)
                {
                    schedules = new List<Schedule>();
                }
                return schedules.ToList();
            }
            set
            {
                if (schedules is Schedule[])
                {
                    schedules = schedules.ToList();
                }
                if (schedules != null)
                {
                    var __itemsToDelete = new List<Schedule>(schedules);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveSchedules(__item);
                    }
                }
                if(value == null)
                {
                    schedules = new List<Schedule>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddSchedules(__item);
                }
            }
        }
        public virtual void AddSchedules(IList<Schedule> __items)
        {
            foreach (var __item in __items)
            {
                AddSchedules(__item);
            }
        }
        public virtual void AddSchedules(Schedule __item)
        {
            if (__item != null && schedules!=null && !schedules.Contains(__item))
            {
                schedules.Add(__item);
                if (!__item.Routes.Contains(this))
                    __item.AddRoutes(this);
            }
        }

        public virtual void RemoveSchedules(Schedule __item)
        {
            if (__item != null && schedules!=null && schedules.Contains(__item))
            {
                schedules.Remove(__item);
                if(__item.Routes.Contains(this))
                    __item.RemoveRoutes(this);
            }
        }
        public virtual void SetSchedulesAt(Schedule __item, int __index)
        {
            if (__item == null)
            {
                schedules[__index].RemoveRoutes(this);
            }
            else
            {
                schedules[__index] = __item;
                if (!__item.Routes.Contains(this))
                    __item.AddRoutes(this);
            }
        }

        public virtual void ClearSchedules()
        {
            if (schedules!=null)
            {
                var __itemsToRemove = schedules.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveSchedules(__item);
                }
            }
        }
        [DataMember(Name="Waypoints")]
        protected IList<GeoCoordinates> waypoints = new List<GeoCoordinates>();
        public virtual List<GeoCoordinates> Waypoints
        {
            get
            {
                if (waypoints is GeoCoordinates[])
                {
                    waypoints = waypoints.ToList();
                }
                if (waypoints == null)
                {
                    waypoints = new List<GeoCoordinates>();
                }
                return waypoints.ToList();
            }
            set
            {
                if (waypoints is GeoCoordinates[])
                {
                    waypoints = waypoints.ToList();
                }
                if (waypoints != null)
                {
                    var __itemsToDelete = new List<GeoCoordinates>(waypoints);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveWaypoints(__item);
                    }
                }
                if(value == null)
                {
                    waypoints = new List<GeoCoordinates>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddWaypoints(__item);
                }
            }
        }
        public virtual void AddWaypoints(IList<GeoCoordinates> __items)
        {
            foreach (var __item in __items)
            {
                AddWaypoints(__item);
            }
        }
        public virtual void AddWaypoints(GeoCoordinates __item)
        {
            if (__item != null && waypoints!=null && !waypoints.Contains(__item))
            {
                waypoints.Add(__item);
            }
        }

        public virtual void RemoveWaypoints(GeoCoordinates __item)
        {
            if (__item != null && waypoints!=null && waypoints.Contains(__item))
            {
                waypoints.Remove(__item);
            }
        }
        public virtual void SetWaypointsAt(GeoCoordinates __item, int __index)
        {
            if (__item == null)
            {
                waypoints[__index] = null;
            }
            else
            {
                waypoints[__index] = __item;
            }
        }

        public virtual void ClearWaypoints()
        {
            if (waypoints!=null)
            {
                var __itemsToRemove = waypoints.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveWaypoints(__item);
                }
            }
        }
        [DataMember(Name="Datasource")]
        protected Datasource datasource;
        public virtual Datasource Datasource
        {
            get
            {
                return datasource;
            }
            set
            {
                if(Equals(datasource, value)) return;
                var __oldValue = datasource;
                if (value != null)
                {
                    datasource = value;
                }
                else
                {
                    datasource = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ItineraryRoute class
/// </summary>
/// <returns>New ItineraryRoute object</returns>
/// <remarks></remarks>
        public ItineraryRoute() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Remarks != null && Remarks.Length > 1000)
            {
                __errors.Add("Length of property 'Remarks' cannot be greater than 1000.");
            }
            if (UpdatedAt != null && UpdatedAt.Length > 500)
            {
                __errors.Add("Length of property 'UpdatedAt' cannot be greater than 500.");
            }
            if (LuggageAvailability != null && LuggageAvailability.Length > 100)
            {
                __errors.Add("Length of property 'LuggageAvailability' cannot be greater than 100.");
            }
            if (LuggageDimensions != null && LuggageDimensions.Length > 100)
            {
                __errors.Add("Length of property 'LuggageDimensions' cannot be greater than 100.");
            }
            if (LuggageTermsOfService != null && LuggageTermsOfService.Length > 2147483647)
            {
                __errors.Add("Length of property 'LuggageTermsOfService' cannot be greater than 2147483647.");
            }
            if (ExternalIdentifier != null && ExternalIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'ExternalIdentifier' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'ItineraryRoute' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ItineraryRoute] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ItineraryRoute Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ItineraryRoute copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ItineraryRoute)copiedObjects[this];
            copy = copy ?? new ItineraryRoute();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Duration = this.Duration;
            copy.ETicketability = this.ETicketability;
            copy.Remarks = this.Remarks;
            copy.Active = this.Active;
            copy.OnTimePercentage = this.OnTimePercentage;
            copy.UpdatedAt = this.UpdatedAt;
            copy.CO2Emissions = this.CO2Emissions;
            copy.LuggageAvailability = this.LuggageAvailability;
            copy.LuggageDimensions = this.LuggageDimensions;
            copy.LuggageTermsOfService = this.LuggageTermsOfService;
            copy.PriceRangeMin = this.PriceRangeMin;
            copy.PriceRangeMax = this.PriceRangeMax;
            copy.ExternalIdentifier = this.ExternalIdentifier;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.amenities = new List<Amenity>();
            if(deep && this.amenities != null)
            {
                foreach (var __item in this.amenities)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAmenities(__item);
                        else
                            copy.AddAmenities(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAmenities((Amenity)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.distance != null)
            {
                if (!copiedObjects.Contains(this.distance))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Distance = this.Distance;
                    else if (asNew)
                        copy.Distance = this.Distance.Copy(deep, copiedObjects, true);
                    else
                        copy.distance = this.distance.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Distance = (Distance)copiedObjects[this.Distance];
                    else
                        copy.distance = (Distance)copiedObjects[this.Distance];
                }
            }
            copy.schedules = new List<Schedule>();
            if(deep && this.schedules != null)
            {
                foreach (var __item in this.schedules)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddSchedules(__item);
                        else
                            copy.AddSchedules(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddSchedules((Schedule)copiedObjects[__item]);
                    }
                }
            }
            copy.waypoints = new List<GeoCoordinates>();
            if(deep && this.waypoints != null)
            {
                foreach (var __item in this.waypoints)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddWaypoints(__item);
                        else
                            copy.AddWaypoints(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddWaypoints((GeoCoordinates)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.datasource != null)
            {
                if (!copiedObjects.Contains(this.datasource))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Datasource = this.Datasource;
                    else if (asNew)
                        copy.Datasource = this.Datasource.Copy(deep, copiedObjects, true);
                    else
                        copy.datasource = this.datasource.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Datasource = (Datasource)copiedObjects[this.Datasource];
                    else
                        copy.datasource = (Datasource)copiedObjects[this.Datasource];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ItineraryRoute;
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
        protected bool HasSameNonDefaultIdAs(ItineraryRoute compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
