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
    /// The ItinerarySegment class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(MarineSegment))]

    [KnownType(typeof(RailSegment))]

    [KnownType(typeof(UrbanSegment))]

    [KnownType(typeof(FlightSegment))]

    public class ItinerarySegment : IDomainModelClass
    {
        #region ItinerarySegment's Fields

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
        [DataMember(Name="DateBooked")]
        protected DateTime? dateBooked;
        [DataMember(Name="DateCancelled")]
        protected DateTime? dateCancelled;
        [DataMember(Name="Status")]
        protected EuTravel_2.BO.ItineraryStatus status;
        [DataMember(Name="TermsAndConditions")]
        protected string termsAndConditions;
        [DataMember(Name="ItinerarySequenceNumber")]
        protected int? itinerarySequenceNumber;
        [DataMember(Name="ExternalIdentifier")]
        protected string externalIdentifier;
        [DataMember(Name="UpdatedAt")]
        protected DateTime? updatedAt;
        [DataMember(Name="DepartureDateTime")]
        protected DateTime? departureDateTime;
        [DataMember(Name="ArrivalDateTime")]
        protected DateTime? arrivalDateTime;
        [DataMember(Name="TravelTime")]
        protected int? travelTime;
        #endregion
        #region ItinerarySegment's Properties
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
/// The DateBooked property
///
/// </summary>
///
        public virtual DateTime? DateBooked
        {
            get
            {
                return dateBooked;
            }
            set
            {
                dateBooked = value;
            }
        }
/// <summary>
/// The DateCancelled property
///
/// </summary>
///
        public virtual DateTime? DateCancelled
        {
            get
            {
                return dateCancelled;
            }
            set
            {
                dateCancelled = value;
            }
        }
/// <summary>
/// The Status property
///
/// </summary>
///
        public virtual EuTravel_2.BO.ItineraryStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
/// <summary>
/// The TermsAndConditions property
///
/// </summary>
///
        public virtual string TermsAndConditions
        {
            get
            {
                return termsAndConditions;
            }
            set
            {
                termsAndConditions = value;
            }
        }
/// <summary>
/// The ItinerarySequenceNumber property
///
/// </summary>
///
        public virtual int? ItinerarySequenceNumber
        {
            get
            {
                return itinerarySequenceNumber;
            }
            set
            {
                itinerarySequenceNumber = value;
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
/// <summary>
/// The UpdatedAt property
///
/// </summary>
///
        public virtual DateTime? UpdatedAt
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
/// The DepartureDateTime property
///
/// </summary>
///
        public virtual DateTime? DepartureDateTime
        {
            get
            {
                return departureDateTime;
            }
            set
            {
                departureDateTime = value;
            }
        }
/// <summary>
/// The ArrivalDateTime property
///
/// </summary>
///
        public virtual DateTime? ArrivalDateTime
        {
            get
            {
                return arrivalDateTime;
            }
            set
            {
                arrivalDateTime = value;
            }
        }
/// <summary>
/// The TravelTime property
///
/// </summary>
///
        public virtual int? TravelTime
        {
            get
            {
                return travelTime;
            }
            set
            {
                travelTime = value;
            }
        }
        #endregion
        #region ItinerarySegment's Participant Properties
        [DataMember(Name="Fare")]
        protected Fare fare;
        public virtual Fare Fare
        {
            get
            {
                return fare;
            }
            set
            {
                if(Equals(fare, value)) return;
                var __oldValue = fare;
                if (value != null)
                {
                    fare = value;
                }
                else
                {
                    fare = null;
                }
            }
        }
        [DataMember(Name="AvailableFares")]
        protected IList<Fare> availableFares = new List<Fare>();
        public virtual List<Fare> AvailableFares
        {
            get
            {
                if (availableFares is Fare[])
                {
                    availableFares = availableFares.ToList();
                }
                if (availableFares == null)
                {
                    availableFares = new List<Fare>();
                }
                return availableFares.ToList();
            }
            set
            {
                if (availableFares is Fare[])
                {
                    availableFares = availableFares.ToList();
                }
                if (availableFares != null)
                {
                    var __itemsToDelete = new List<Fare>(availableFares);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAvailableFares(__item);
                    }
                }
                if(value == null)
                {
                    availableFares = new List<Fare>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAvailableFares(__item);
                }
            }
        }
        public virtual void AddAvailableFares(IList<Fare> __items)
        {
            foreach (var __item in __items)
            {
                AddAvailableFares(__item);
            }
        }
        public virtual void AddAvailableFares(Fare __item)
        {
            if (__item != null && availableFares!=null && !availableFares.Contains(__item))
            {
                availableFares.Add(__item);
            }
        }

        public virtual void RemoveAvailableFares(Fare __item)
        {
            if (__item != null && availableFares!=null && availableFares.Contains(__item))
            {
                availableFares.Remove(__item);
            }
        }
        public virtual void SetAvailableFaresAt(Fare __item, int __index)
        {
            if (__item == null)
            {
                availableFares[__index] = null;
            }
            else
            {
                availableFares[__index] = __item;
            }
        }

        public virtual void ClearAvailableFares()
        {
            if (availableFares!=null)
            {
                var __itemsToRemove = availableFares.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAvailableFares(__item);
                }
            }
        }
        [DataMember(Name="BookingStatus")]
        protected BookingStatus bookingStatus;
        public virtual BookingStatus BookingStatus
        {
            get
            {
                return bookingStatus;
            }
            set
            {
                if(Equals(bookingStatus, value)) return;
                var __oldValue = bookingStatus;
                if (value != null)
                {
                    if(bookingStatus != null && !Equals(bookingStatus, value))
                        bookingStatus.ItinerarySegment = null;
                    bookingStatus = value;
                    if(bookingStatus.ItinerarySegment != this)
                        bookingStatus.ItinerarySegment = this;
                }
                else
                {
                    if (bookingStatus != null)
                    {
                        var __obj = bookingStatus;
                        bookingStatus = null;
                        __obj.ItinerarySegment = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ItinerarySegment class
/// </summary>
/// <returns>New ItinerarySegment object</returns>
/// <remarks></remarks>
        public ItinerarySegment()
        {
            this.BookingStatus = new BookingStatus();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (TermsAndConditions != null && TermsAndConditions.Length > 1000)
            {
                __errors.Add("Length of property 'TermsAndConditions' cannot be greater than 1000.");
            }
            if (ExternalIdentifier != null && ExternalIdentifier.Length > 100)
            {
                __errors.Add("Length of property 'ExternalIdentifier' cannot be greater than 100.");
            }
            if (BookingStatus == null)
            {
                __errors.Add("Association with 'BookingStatus' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'ItinerarySegment' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ItinerarySegment] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ItinerarySegment Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ItinerarySegment copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ItinerarySegment)copiedObjects[this];
            copy = copy ?? new ItinerarySegment();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.DateBooked = this.DateBooked;
            copy.DateCancelled = this.DateCancelled;
            copy.Status = this.Status;
            copy.TermsAndConditions = this.TermsAndConditions;
            copy.ItinerarySequenceNumber = this.ItinerarySequenceNumber;
            copy.ExternalIdentifier = this.ExternalIdentifier;
            copy.UpdatedAt = this.UpdatedAt;
            copy.DepartureDateTime = this.DepartureDateTime;
            copy.ArrivalDateTime = this.ArrivalDateTime;
            copy.TravelTime = this.TravelTime;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.fare != null)
            {
                if (!copiedObjects.Contains(this.fare))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Fare = this.Fare;
                    else if (asNew)
                        copy.Fare = this.Fare.Copy(deep, copiedObjects, true);
                    else
                        copy.fare = this.fare.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Fare = (Fare)copiedObjects[this.Fare];
                    else
                        copy.fare = (Fare)copiedObjects[this.Fare];
                }
            }
            copy.availableFares = new List<Fare>();
            if(deep && this.availableFares != null)
            {
                foreach (var __item in this.availableFares)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAvailableFares(__item);
                        else
                            copy.AddAvailableFares(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAvailableFares((Fare)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.bookingStatus != null)
            {
                if (!copiedObjects.Contains(this.bookingStatus))
                {
                    if (asNew && reuseNestedObjects)
                        copy.BookingStatus = this.BookingStatus;
                    else if (asNew)
                        copy.BookingStatus = this.BookingStatus.Copy(deep, copiedObjects, true);
                    else
                        copy.bookingStatus = this.bookingStatus.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.BookingStatus = (BookingStatus)copiedObjects[this.BookingStatus];
                    else
                        copy.bookingStatus = (BookingStatus)copiedObjects[this.BookingStatus];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ItinerarySegment;
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
        protected bool HasSameNonDefaultIdAs(ItinerarySegment compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
