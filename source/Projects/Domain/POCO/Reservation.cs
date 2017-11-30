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
    /// The Reservation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Reservation : IDomainModelClass
    {
        #region Reservation's Fields

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
        [DataMember(Name="ReceiptID")]
        protected string receiptID;
        [DataMember(Name="ReceiptText")]
        protected string receiptText;
        [DataMember(Name="Status")]
        protected string status;
        [DataMember(Name="AgentReferenceID")]
        protected string agentReferenceID;
        [DataMember(Name="Price")]
        protected decimal? price;
        [DataMember(Name="CreationDate")]
        protected DateTime? creationDate;
        [DataMember(Name="Iteration")]
        protected int? iteration;
        #endregion
        #region Reservation's Properties
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
/// The ReceiptID property
///
/// </summary>
///
        public virtual string ReceiptID
        {
            get
            {
                return receiptID;
            }
            set
            {
                receiptID = value;
            }
        }
/// <summary>
/// The ReceiptText property
///
/// </summary>
///
        public virtual string ReceiptText
        {
            get
            {
                return receiptText;
            }
            set
            {
                receiptText = value;
            }
        }
/// <summary>
/// The Status property
///
/// </summary>
///
        public virtual string Status
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
/// The AgentReferenceID property
///
/// </summary>
///
        public virtual string AgentReferenceID
        {
            get
            {
                return agentReferenceID;
            }
            set
            {
                agentReferenceID = value;
            }
        }
/// <summary>
/// The Price property
///
/// </summary>
///
        public virtual decimal? Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
/// <summary>
/// The CreationDate property
///
/// </summary>
///
        public virtual DateTime? CreationDate
        {
            get
            {
                return creationDate;
            }
            set
            {
                creationDate = value;
            }
        }
/// <summary>
/// The Iteration property
///
/// </summary>
///
        public virtual int? Iteration
        {
            get
            {
                return iteration;
            }
            set
            {
                iteration = value;
            }
        }
        #endregion
        #region Reservation's Participant Properties
        [DataMember(Name="Currency")]
        protected Currency currency;
        public virtual Currency Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if(Equals(currency, value)) return;
                var __oldValue = currency;
                if (value != null)
                {
                    currency = value;
                }
                else
                {
                    currency = null;
                }
            }
        }
        [DataMember(Name="Passengers")]
        protected IList<Passenger> passengers = new List<Passenger>();
        public virtual List<Passenger> Passengers
        {
            get
            {
                if (passengers is Passenger[])
                {
                    passengers = passengers.ToList();
                }
                if (passengers == null)
                {
                    passengers = new List<Passenger>();
                }
                return passengers.ToList();
            }
            set
            {
                if (passengers is Passenger[])
                {
                    passengers = passengers.ToList();
                }
                if (passengers != null)
                {
                    var __itemsToDelete = new List<Passenger>(passengers);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePassengers(__item);
                    }
                }
                if(value == null)
                {
                    passengers = new List<Passenger>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPassengers(__item);
                }
            }
        }
        public virtual void AddPassengers(IList<Passenger> __items)
        {
            foreach (var __item in __items)
            {
                AddPassengers(__item);
            }
        }
        public virtual void AddPassengers(Passenger __item)
        {
            if (__item != null && passengers!=null && !passengers.Contains(__item))
            {
                passengers.Add(__item);
                if (!__item.Reservations.Contains(this))
                    __item.AddReservations(this);
            }
        }

        public virtual void RemovePassengers(Passenger __item)
        {
            if (__item != null && passengers!=null && passengers.Contains(__item))
            {
                passengers.Remove(__item);
                if(__item.Reservations.Contains(this))
                    __item.RemoveReservations(this);
            }
        }
        public virtual void SetPassengersAt(Passenger __item, int __index)
        {
            if (__item == null)
            {
                passengers[__index].RemoveReservations(this);
            }
            else
            {
                passengers[__index] = __item;
                if (!__item.Reservations.Contains(this))
                    __item.AddReservations(this);
            }
        }

        public virtual void ClearPassengers()
        {
            if (passengers!=null)
            {
                var __itemsToRemove = passengers.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePassengers(__item);
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
                    if(trip != null && !Equals(trip, value))
                        trip.Reservation = null;
                    trip = value;
                    if(trip.Reservation != this)
                        trip.Reservation = this;
                }
                else
                {
                    if (trip != null)
                    {
                        var __obj = trip;
                        trip = null;
                        __obj.Reservation = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Reservation class
/// </summary>
/// <returns>New Reservation object</returns>
/// <remarks></remarks>
        public Reservation() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (ReceiptID != null && ReceiptID.Length > 100)
            {
                __errors.Add("Length of property 'ReceiptID' cannot be greater than 100.");
            }
            if (ReceiptText != null && ReceiptText.Length > 100)
            {
                __errors.Add("Length of property 'ReceiptText' cannot be greater than 100.");
            }
            if (Status != null && Status.Length > 100)
            {
                __errors.Add("Length of property 'Status' cannot be greater than 100.");
            }
            if (AgentReferenceID != null && AgentReferenceID.Length > 100)
            {
                __errors.Add("Length of property 'AgentReferenceID' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Reservation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Reservation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Reservation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Reservation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Reservation)copiedObjects[this];
            copy = copy ?? new Reservation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ReceiptID = this.ReceiptID;
            copy.ReceiptText = this.ReceiptText;
            copy.Status = this.Status;
            copy.AgentReferenceID = this.AgentReferenceID;
            copy.Price = this.Price;
            copy.CreationDate = this.CreationDate;
            copy.Iteration = this.Iteration;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.currency != null)
            {
                if (!copiedObjects.Contains(this.currency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Currency = this.Currency;
                    else if (asNew)
                        copy.Currency = this.Currency.Copy(deep, copiedObjects, true);
                    else
                        copy.currency = this.currency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Currency = (Currency)copiedObjects[this.Currency];
                    else
                        copy.currency = (Currency)copiedObjects[this.Currency];
                }
            }
            copy.passengers = new List<Passenger>();
            if(deep && this.passengers != null)
            {
                foreach (var __item in this.passengers)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPassengers(__item);
                        else
                            copy.AddPassengers(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPassengers((Passenger)copiedObjects[__item]);
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
            var compareTo = obj as Reservation;
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
        protected bool HasSameNonDefaultIdAs(Reservation compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
