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
    /// The StopTimeDetails class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class StopTimeDetails : IDomainModelClass
    {
        #region StopTimeDetails's Fields

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
        [DataMember(Name="ArrivalTime")]
        protected string arrivalTime;
        [DataMember(Name="DepartureTime")]
        protected string departureTime;
        [DataMember(Name="ElapsedTime")]
        protected string elapsedTime;
        [DataMember(Name="StopSequence")]
        protected int? stopSequence;
        [DataMember(Name="PickupType")]
        protected EuTravel_2.BO.PassengerAccessType pickupType;
        [DataMember(Name="DropOffType")]
        protected EuTravel_2.BO.PassengerAccessType dropOffType;
        [DataMember(Name="Timepoint")]
        protected EuTravel_2.BO.Timepoint timepoint;
        #endregion
        #region StopTimeDetails's Properties
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
/// The ElapsedTime property
///
/// </summary>
///
        public virtual string ElapsedTime
        {
            get
            {
                return elapsedTime;
            }
            set
            {
                elapsedTime = value;
            }
        }
/// <summary>
/// The StopSequence property
///
/// </summary>
///
        public virtual int? StopSequence
        {
            get
            {
                return stopSequence;
            }
            set
            {
                stopSequence = value;
            }
        }
/// <summary>
/// The PickupType property
///
/// </summary>
///
        public virtual EuTravel_2.BO.PassengerAccessType PickupType
        {
            get
            {
                return pickupType;
            }
            set
            {
                pickupType = value;
            }
        }
/// <summary>
/// The DropOffType property
///
/// </summary>
///
        public virtual EuTravel_2.BO.PassengerAccessType DropOffType
        {
            get
            {
                return dropOffType;
            }
            set
            {
                dropOffType = value;
            }
        }
/// <summary>
/// The Timepoint property
///
/// </summary>
///
        public virtual EuTravel_2.BO.Timepoint Timepoint
        {
            get
            {
                return timepoint;
            }
            set
            {
                timepoint = value;
            }
        }
        #endregion
        #region StopTimeDetails's Participant Properties
        [DataMember(Name="RouteTimeDetails")]
        protected RouteTimeDetails routeTimeDetails;
        public virtual RouteTimeDetails RouteTimeDetails
        {
            get
            {
                return routeTimeDetails;
            }
            set
            {
                if(Equals(routeTimeDetails, value)) return;
                var __oldValue = routeTimeDetails;
                if (value != null)
                {
                    if(routeTimeDetails != null && !Equals(routeTimeDetails, value))
                        routeTimeDetails.RemoveStopTimeDetails(this);
                    routeTimeDetails = value;
                    routeTimeDetails.AddStopTimeDetails(this);
                }
                else
                {
                    if(routeTimeDetails != null)
                        routeTimeDetails.RemoveStopTimeDetails(this);
                    routeTimeDetails = null;
                }
            }
        }
        [DataMember(Name="Station")]
        protected Station station;
        public virtual Station Station
        {
            get
            {
                return station;
            }
            set
            {
                if(Equals(station, value)) return;
                var __oldValue = station;
                if (value != null)
                {
                    if(station != null && !Equals(station, value))
                        station.RemoveStopTimeDetails(this);
                    station = value;
                    station.AddStopTimeDetails(this);
                }
                else
                {
                    if(station != null)
                        station.RemoveStopTimeDetails(this);
                    station = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the StopTimeDetails class
/// </summary>
/// <returns>New StopTimeDetails object</returns>
/// <remarks></remarks>
        public StopTimeDetails() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (ArrivalTime != null && ArrivalTime.Length > 100)
            {
                __errors.Add("Length of property 'ArrivalTime' cannot be greater than 100.");
            }
            if (DepartureTime != null && DepartureTime.Length > 100)
            {
                __errors.Add("Length of property 'DepartureTime' cannot be greater than 100.");
            }
            if (ElapsedTime != null && ElapsedTime.Length > 100)
            {
                __errors.Add("Length of property 'ElapsedTime' cannot be greater than 100.");
            }
            if (RouteTimeDetails == null)
            {
                __errors.Add("Association with 'RouteTimeDetails' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'StopTimeDetails' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [StopTimeDetails] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual StopTimeDetails Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, StopTimeDetails copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (StopTimeDetails)copiedObjects[this];
            copy = copy ?? new StopTimeDetails();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ArrivalTime = this.ArrivalTime;
            copy.DepartureTime = this.DepartureTime;
            copy.ElapsedTime = this.ElapsedTime;
            copy.StopSequence = this.StopSequence;
            copy.PickupType = this.PickupType;
            copy.DropOffType = this.DropOffType;
            copy.Timepoint = this.Timepoint;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.routeTimeDetails != null)
            {
                if (!copiedObjects.Contains(this.routeTimeDetails))
                {
                    if (asNew && reuseNestedObjects)
                        copy.RouteTimeDetails = this.RouteTimeDetails;
                    else if (asNew)
                        copy.RouteTimeDetails = this.RouteTimeDetails.Copy(deep, copiedObjects, true);
                    else
                        copy.routeTimeDetails = this.routeTimeDetails.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.RouteTimeDetails = (RouteTimeDetails)copiedObjects[this.RouteTimeDetails];
                    else
                        copy.routeTimeDetails = (RouteTimeDetails)copiedObjects[this.RouteTimeDetails];
                }
            }
            if(deep && this.station != null)
            {
                if (!copiedObjects.Contains(this.station))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Station = this.Station;
                    else if (asNew)
                        copy.Station = this.Station.Copy(deep, copiedObjects, true);
                    else
                        copy.station = this.station.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Station = (Station)copiedObjects[this.Station];
                    else
                        copy.station = (Station)copiedObjects[this.Station];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as StopTimeDetails;
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
        protected bool HasSameNonDefaultIdAs(StopTimeDetails compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
