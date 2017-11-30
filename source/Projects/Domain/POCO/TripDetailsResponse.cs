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
    /// The TripDetailsResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class TripDetailsResponse : IDomainModelClass
    {
        #region TripDetailsResponse's Fields

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
        [DataMember(Name="Message")]
        protected string message;
        [DataMember(Name="TripDetailsResponseKey")]
        protected Guid? tripDetailsResponseKey = Guid.Empty;
        #endregion
        #region TripDetailsResponse's Properties
/// <summary>
/// The Message property
///
/// </summary>
///
        public virtual string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
/// <summary>
/// The TripDetailsResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? TripDetailsResponseKey
        {
            get
            {
                return tripDetailsResponseKey;
            }
            set
            {
                tripDetailsResponseKey = value;
            }
        }
        #endregion
        #region TripDetailsResponse's Participant Properties
        [DataMember(Name="Error")]
        protected Error error;
        public virtual Error Error
        {
            get
            {
                return error;
            }
            set
            {
                if(Equals(error, value)) return;
                var __oldValue = error;
                if (value != null)
                {
                    error = value;
                }
                else
                {
                    if (error != null)
                    {
                        error = null;
                    }
                }
            }
        }
        [DataMember(Name="Trips")]
        protected IList<Trip> trips = new List<Trip>();
        public virtual List<Trip> Trips
        {
            get
            {
                if (trips is Trip[])
                {
                    trips = trips.ToList();
                }
                if (trips == null)
                {
                    trips = new List<Trip>();
                }
                return trips.ToList();
            }
            set
            {
                if (trips is Trip[])
                {
                    trips = trips.ToList();
                }
                if (trips != null)
                {
                    var __itemsToDelete = new List<Trip>(trips);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTrips(__item);
                    }
                }
                if(value == null)
                {
                    trips = new List<Trip>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTrips(__item);
                }
            }
        }
        public virtual void AddTrips(IList<Trip> __items)
        {
            foreach (var __item in __items)
            {
                AddTrips(__item);
            }
        }
        public virtual void AddTrips(Trip __item)
        {
            if (__item != null && trips!=null && !trips.Contains(__item))
            {
                trips.Add(__item);
            }
        }

        public virtual void RemoveTrips(Trip __item)
        {
            if (__item != null && trips!=null && trips.Contains(__item))
            {
                trips.Remove(__item);
            }
        }
        public virtual void SetTripsAt(Trip __item, int __index)
        {
            if (__item == null)
            {
                trips[__index] = null;
            }
            else
            {
                trips[__index] = __item;
            }
        }

        public virtual void ClearTrips()
        {
            if (trips!=null)
            {
                var __itemsToRemove = trips.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTrips(__item);
                }
            }
        }
        [DataMember(Name="Trip")]
        protected Trip trip;
        public virtual Trip Trip
        {
            get
            {
                return trip;
            }
            set
            {
                if(Equals(trip, value)) return;
                var __oldValue = trip;
                if (value != null)
                {
                    trip = value;
                }
                else
                {
                    if (trip != null)
                    {
                        trip = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the TripDetailsResponse class
/// </summary>
/// <returns>New TripDetailsResponse object</returns>
/// <remarks></remarks>
        public TripDetailsResponse()
        {
            if (TripDetailsResponseKey == null) TripDetailsResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Message != null && Message.Length > 100)
            {
                __errors.Add("Length of property 'Message' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'TripDetailsResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [TripDetailsResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual TripDetailsResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, TripDetailsResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (TripDetailsResponse)copiedObjects[this];
            copy = copy ?? new TripDetailsResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.TripDetailsResponseKey = this.TripDetailsResponseKey;
            }
            copy.Message = this.Message;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.error != null)
            {
                if (!copiedObjects.Contains(this.error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Error = this.Error;
                    else if (asNew)
                        copy.Error = this.Error.Copy(deep, copiedObjects, true);
                    else
                        copy.error = this.error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Error = (Error)copiedObjects[this.Error];
                    else
                        copy.error = (Error)copiedObjects[this.Error];
                }
            }
            copy.trips = new List<Trip>();
            if(deep && this.trips != null)
            {
                foreach (var __item in this.trips)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTrips(__item);
                        else
                            copy.AddTrips(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTrips((Trip)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.trip != null)
            {
                if (!copiedObjects.Contains(this.trip))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Trip = this.Trip;
                    else if (asNew)
                        copy.Trip = this.Trip.Copy(deep, copiedObjects, true);
                    else
                        copy.trip = this.trip.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Trip = (Trip)copiedObjects[this.Trip];
                    else
                        copy.trip = (Trip)copiedObjects[this.Trip];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as TripDetailsResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("TripDetailsResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.TripDetailsResponseKey.GetHashCode();
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
            return this.TripDetailsResponseKey == default(Guid) || this.TripDetailsResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(TripDetailsResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.TripDetailsResponseKey.Equals(compareTo.TripDetailsResponseKey);
        }

        #endregion
    }
}
