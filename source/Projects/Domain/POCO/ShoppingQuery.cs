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
    /// The ShoppingQuery class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class ShoppingQuery : IDomainModelClass
    {
        #region ShoppingQuery's Fields

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
        [DataMember(Name="NumberOfAdults")]
        protected int? numberOfAdults;
        [DataMember(Name="NumberOfChildren")]
        protected int? numberOfChildren;
        [DataMember(Name="NumberOfElders")]
        protected int? numberOfElders;
        [DataMember(Name="NumberOfPRMs")]
        protected int? numberOfPRMs;
        [DataMember(Name="NumberOfInfants")]
        protected int? numberOfInfants;
        [DataMember(Name="DepartureDate")]
        protected DateTime? departureDate;
        [DataMember(Name="ArrivalDate")]
        protected DateTime? arrivalDate;
        [DataMember(Name="NumberOfVehicles")]
        protected int? numberOfVehicles;
        [DataMember(Name="Direct")]
        protected bool direct;
        [DataMember(Name="NumberOfStops")]
        protected int? numberOfStops;
        [DataMember(Name="MaxPrice")]
        protected float? maxPrice;
        [DataMember(Name="NumberOfResults")]
        protected int? numberOfResults;
        [DataMember(Name="CommunicationToken")]
        protected string communicationToken;
        [DataMember(Name="Timestamp")]
        protected DateTime? timestamp;
        #endregion
        #region ShoppingQuery's Properties
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
/// The NumberOfAdults property
///
/// </summary>
///
        public virtual int? NumberOfAdults
        {
            get
            {
                return numberOfAdults;
            }
            set
            {
                numberOfAdults = value;
            }
        }
/// <summary>
/// The NumberOfChildren property
///
/// </summary>
///
        public virtual int? NumberOfChildren
        {
            get
            {
                return numberOfChildren;
            }
            set
            {
                numberOfChildren = value;
            }
        }
/// <summary>
/// The NumberOfElders property
///
/// </summary>
///
        public virtual int? NumberOfElders
        {
            get
            {
                return numberOfElders;
            }
            set
            {
                numberOfElders = value;
            }
        }
/// <summary>
/// The NumberOfPRMs property
///
/// </summary>
///
        public virtual int? NumberOfPRMs
        {
            get
            {
                return numberOfPRMs;
            }
            set
            {
                numberOfPRMs = value;
            }
        }
/// <summary>
/// The NumberOfInfants property
///
/// </summary>
///
        public virtual int? NumberOfInfants
        {
            get
            {
                return numberOfInfants;
            }
            set
            {
                numberOfInfants = value;
            }
        }
/// <summary>
/// The DepartureDate property
///
/// </summary>
///
        public virtual DateTime? DepartureDate
        {
            get
            {
                return departureDate;
            }
            set
            {
                departureDate = value;
            }
        }
/// <summary>
/// The ArrivalDate property
///
/// </summary>
///
        public virtual DateTime? ArrivalDate
        {
            get
            {
                return arrivalDate;
            }
            set
            {
                arrivalDate = value;
            }
        }
/// <summary>
/// The NumberOfVehicles property
///
/// </summary>
///
        public virtual int? NumberOfVehicles
        {
            get
            {
                return numberOfVehicles;
            }
            set
            {
                numberOfVehicles = value;
            }
        }
/// <summary>
/// The Direct property
///
/// </summary>
///
        public virtual bool Direct
        {
            get
            {
                return direct;
            }
            set
            {
                direct = value;
            }
        }
/// <summary>
/// The NumberOfStops property
///
/// </summary>
///
        public virtual int? NumberOfStops
        {
            get
            {
                return numberOfStops;
            }
            set
            {
                numberOfStops = value;
            }
        }
/// <summary>
/// The MaxPrice property
///
/// </summary>
///
        public virtual float? MaxPrice
        {
            get
            {
                return maxPrice;
            }
            set
            {
                maxPrice = value;
            }
        }
/// <summary>
/// The NumberOfResults property
///
/// </summary>
///
        public virtual int? NumberOfResults
        {
            get
            {
                return numberOfResults;
            }
            set
            {
                numberOfResults = value;
            }
        }
/// <summary>
/// The CommunicationToken property
///
/// </summary>
///
        public virtual string CommunicationToken
        {
            get
            {
                return communicationToken;
            }
            set
            {
                communicationToken = value;
            }
        }
/// <summary>
/// The Timestamp property
///
/// </summary>
///
        public virtual DateTime? Timestamp
        {
            get
            {
                return timestamp;
            }
            set
            {
                timestamp = value;
            }
        }
        #endregion
        #region ShoppingQuery's Participant Properties
        [DataMember(Name="Transaction")]
        protected Transaction transaction;
        public virtual Transaction Transaction
        {
            get
            {
                return transaction;
            }
            set
            {
                if(Equals(transaction, value)) return;
                var __oldValue = transaction;
                if (value != null)
                {
                    if(transaction != null && !Equals(transaction, value))
                        transaction.RemoveQueries(this);
                    transaction = value;
                    transaction.AddQueries(this);
                }
                else
                {
                    if(transaction != null)
                        transaction.RemoveQueries(this);
                    transaction = null;
                }
            }
        }
        [DataMember(Name="ReducedMobilityDescription")]
        protected ReducedMobility reducedMobilityDescription;
        public virtual ReducedMobility ReducedMobilityDescription
        {
            get
            {
                return reducedMobilityDescription;
            }
            set
            {
                if(Equals(reducedMobilityDescription, value)) return;
                var __oldValue = reducedMobilityDescription;
                if (value != null)
                {
                    if(reducedMobilityDescription != null && !Equals(reducedMobilityDescription, value))
                        reducedMobilityDescription.RemoveQuery(this);
                    reducedMobilityDescription = value;
                    reducedMobilityDescription.AddQuery(this);
                }
                else
                {
                    if(reducedMobilityDescription != null)
                        reducedMobilityDescription.RemoveQuery(this);
                    reducedMobilityDescription = null;
                }
            }
        }
        [DataMember(Name="IncludedAirlines")]
        protected IList<Airline> includedAirlines = new List<Airline>();
        public virtual List<Airline> IncludedAirlines
        {
            get
            {
                if (includedAirlines is Airline[])
                {
                    includedAirlines = includedAirlines.ToList();
                }
                if (includedAirlines == null)
                {
                    includedAirlines = new List<Airline>();
                }
                return includedAirlines.ToList();
            }
            set
            {
                if (includedAirlines is Airline[])
                {
                    includedAirlines = includedAirlines.ToList();
                }
                if (includedAirlines != null)
                {
                    var __itemsToDelete = new List<Airline>(includedAirlines);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveIncludedAirlines(__item);
                    }
                }
                if(value == null)
                {
                    includedAirlines = new List<Airline>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddIncludedAirlines(__item);
                }
            }
        }
        public virtual void AddIncludedAirlines(IList<Airline> __items)
        {
            foreach (var __item in __items)
            {
                AddIncludedAirlines(__item);
            }
        }
        public virtual void AddIncludedAirlines(Airline __item)
        {
            if (__item != null && includedAirlines!=null && !includedAirlines.Contains(__item))
            {
                includedAirlines.Add(__item);
            }
        }

        public virtual void RemoveIncludedAirlines(Airline __item)
        {
            if (__item != null && includedAirlines!=null && includedAirlines.Contains(__item))
            {
                includedAirlines.Remove(__item);
            }
        }
        public virtual void SetIncludedAirlinesAt(Airline __item, int __index)
        {
            if (__item == null)
            {
                includedAirlines[__index] = null;
            }
            else
            {
                includedAirlines[__index] = __item;
            }
        }

        public virtual void ClearIncludedAirlines()
        {
            if (includedAirlines!=null)
            {
                var __itemsToRemove = includedAirlines.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveIncludedAirlines(__item);
                }
            }
        }
        [DataMember(Name="ExcludedAirlines")]
        protected IList<Airline> excludedAirlines = new List<Airline>();
        public virtual List<Airline> ExcludedAirlines
        {
            get
            {
                if (excludedAirlines is Airline[])
                {
                    excludedAirlines = excludedAirlines.ToList();
                }
                if (excludedAirlines == null)
                {
                    excludedAirlines = new List<Airline>();
                }
                return excludedAirlines.ToList();
            }
            set
            {
                if (excludedAirlines is Airline[])
                {
                    excludedAirlines = excludedAirlines.ToList();
                }
                if (excludedAirlines != null)
                {
                    var __itemsToDelete = new List<Airline>(excludedAirlines);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveExcludedAirlines(__item);
                    }
                }
                if(value == null)
                {
                    excludedAirlines = new List<Airline>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddExcludedAirlines(__item);
                }
            }
        }
        public virtual void AddExcludedAirlines(IList<Airline> __items)
        {
            foreach (var __item in __items)
            {
                AddExcludedAirlines(__item);
            }
        }
        public virtual void AddExcludedAirlines(Airline __item)
        {
            if (__item != null && excludedAirlines!=null && !excludedAirlines.Contains(__item))
            {
                excludedAirlines.Add(__item);
            }
        }

        public virtual void RemoveExcludedAirlines(Airline __item)
        {
            if (__item != null && excludedAirlines!=null && excludedAirlines.Contains(__item))
            {
                excludedAirlines.Remove(__item);
            }
        }
        public virtual void SetExcludedAirlinesAt(Airline __item, int __index)
        {
            if (__item == null)
            {
                excludedAirlines[__index] = null;
            }
            else
            {
                excludedAirlines[__index] = __item;
            }
        }

        public virtual void ClearExcludedAirlines()
        {
            if (excludedAirlines!=null)
            {
                var __itemsToRemove = excludedAirlines.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveExcludedAirlines(__item);
                }
            }
        }
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
        [DataMember(Name="TravelClass")]
        protected TravelClass travelClass;
        public virtual TravelClass TravelClass
        {
            get
            {
                return travelClass;
            }
            set
            {
                if(Equals(travelClass, value)) return;
                var __oldValue = travelClass;
                if (value != null)
                {
                    travelClass = value;
                }
                else
                {
                    travelClass = null;
                }
            }
        }
        [DataMember(Name="GeoCoordinates")]
        protected GeoCoordinates geoCoordinates;
        public virtual GeoCoordinates GeoCoordinates
        {
            get
            {
                return geoCoordinates;
            }
            set
            {
                if(Equals(geoCoordinates, value)) return;
                var __oldValue = geoCoordinates;
                if (value != null)
                {
                    geoCoordinates = value;
                }
                else
                {
                    geoCoordinates = null;
                }
            }
        }
        [DataMember(Name="ShoppingResponse")]
        protected ShoppingResponse shoppingResponse;
        public virtual ShoppingResponse ShoppingResponse
        {
            get
            {
                return shoppingResponse;
            }
            set
            {
                if(Equals(shoppingResponse, value)) return;
                var __oldValue = shoppingResponse;
                if (value != null)
                {
                    if(shoppingResponse != null && !Equals(shoppingResponse, value))
                        shoppingResponse.ShoppingQuery = null;
                    shoppingResponse = value;
                    if(shoppingResponse.ShoppingQuery != this)
                        shoppingResponse.ShoppingQuery = this;
                }
                else
                {
                    if (shoppingResponse != null)
                    {
                        var __obj = shoppingResponse;
                        shoppingResponse = null;
                        __obj.ShoppingQuery = null;
                    }
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
                        trip.RemoveShoppingQueries(this);
                    trip = value;
                    trip.AddShoppingQueries(this);
                }
                else
                {
                    if(trip != null)
                        trip.RemoveShoppingQueries(this);
                    trip = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ShoppingQuery class
/// </summary>
/// <returns>New ShoppingQuery object</returns>
/// <remarks></remarks>
        public ShoppingQuery() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (CommunicationToken != null && CommunicationToken.Length > 100)
            {
                __errors.Add("Length of property 'CommunicationToken' cannot be greater than 100.");
            }
            if (Currency == null)
            {
                __errors.Add("Association with 'Currency' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'ShoppingQuery' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ShoppingQuery] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ShoppingQuery Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ShoppingQuery copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ShoppingQuery)copiedObjects[this];
            copy = copy ?? new ShoppingQuery();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.NumberOfAdults = this.NumberOfAdults;
            copy.NumberOfChildren = this.NumberOfChildren;
            copy.NumberOfElders = this.NumberOfElders;
            copy.NumberOfPRMs = this.NumberOfPRMs;
            copy.NumberOfInfants = this.NumberOfInfants;
            copy.DepartureDate = this.DepartureDate;
            copy.ArrivalDate = this.ArrivalDate;
            copy.NumberOfVehicles = this.NumberOfVehicles;
            copy.Direct = this.Direct;
            copy.NumberOfStops = this.NumberOfStops;
            copy.MaxPrice = this.MaxPrice;
            copy.NumberOfResults = this.NumberOfResults;
            copy.CommunicationToken = this.CommunicationToken;
            copy.Timestamp = this.Timestamp;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.transaction != null)
            {
                if (!copiedObjects.Contains(this.transaction))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Transaction = this.Transaction;
                    else if (asNew)
                        copy.Transaction = this.Transaction.Copy(deep, copiedObjects, true);
                    else
                        copy.transaction = this.transaction.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Transaction = (Transaction)copiedObjects[this.Transaction];
                    else
                        copy.transaction = (Transaction)copiedObjects[this.Transaction];
                }
            }
            if(deep && this.reducedMobilityDescription != null)
            {
                if (!copiedObjects.Contains(this.reducedMobilityDescription))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ReducedMobilityDescription = this.ReducedMobilityDescription;
                    else if (asNew)
                        copy.ReducedMobilityDescription = this.ReducedMobilityDescription.Copy(deep, copiedObjects, true);
                    else
                        copy.reducedMobilityDescription = this.reducedMobilityDescription.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ReducedMobilityDescription = (ReducedMobility)copiedObjects[this.ReducedMobilityDescription];
                    else
                        copy.reducedMobilityDescription = (ReducedMobility)copiedObjects[this.ReducedMobilityDescription];
                }
            }
            copy.includedAirlines = new List<Airline>();
            if(deep && this.includedAirlines != null)
            {
                foreach (var __item in this.includedAirlines)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddIncludedAirlines(__item);
                        else
                            copy.AddIncludedAirlines(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddIncludedAirlines((Airline)copiedObjects[__item]);
                    }
                }
            }
            copy.excludedAirlines = new List<Airline>();
            if(deep && this.excludedAirlines != null)
            {
                foreach (var __item in this.excludedAirlines)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddExcludedAirlines(__item);
                        else
                            copy.AddExcludedAirlines(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddExcludedAirlines((Airline)copiedObjects[__item]);
                    }
                }
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
            if(deep && this.travelClass != null)
            {
                if (!copiedObjects.Contains(this.travelClass))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TravelClass = this.TravelClass;
                    else if (asNew)
                        copy.TravelClass = this.TravelClass.Copy(deep, copiedObjects, true);
                    else
                        copy.travelClass = this.travelClass.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TravelClass = (TravelClass)copiedObjects[this.TravelClass];
                    else
                        copy.travelClass = (TravelClass)copiedObjects[this.TravelClass];
                }
            }
            if(deep && this.geoCoordinates != null)
            {
                if (!copiedObjects.Contains(this.geoCoordinates))
                {
                    if (asNew && reuseNestedObjects)
                        copy.GeoCoordinates = this.GeoCoordinates;
                    else if (asNew)
                        copy.GeoCoordinates = this.GeoCoordinates.Copy(deep, copiedObjects, true);
                    else
                        copy.geoCoordinates = this.geoCoordinates.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.GeoCoordinates = (GeoCoordinates)copiedObjects[this.GeoCoordinates];
                    else
                        copy.geoCoordinates = (GeoCoordinates)copiedObjects[this.GeoCoordinates];
                }
            }
            if(deep && this.shoppingResponse != null)
            {
                if (!copiedObjects.Contains(this.shoppingResponse))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ShoppingResponse = this.ShoppingResponse;
                    else if (asNew)
                        copy.ShoppingResponse = this.ShoppingResponse.Copy(deep, copiedObjects, true);
                    else
                        copy.shoppingResponse = this.shoppingResponse.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ShoppingResponse = (ShoppingResponse)copiedObjects[this.ShoppingResponse];
                    else
                        copy.shoppingResponse = (ShoppingResponse)copiedObjects[this.ShoppingResponse];
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
            var compareTo = obj as ShoppingQuery;
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
        protected bool HasSameNonDefaultIdAs(ShoppingQuery compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
