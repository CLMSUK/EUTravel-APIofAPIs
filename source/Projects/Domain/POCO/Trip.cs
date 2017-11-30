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
    /// The Trip class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Trip : IDomainModelClass
    {
        #region Trip's Fields

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
        [DataMember(Name="TripCode")]
        protected string tripCode;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="NumberOfAdults")]
        protected int? numberOfAdults;
        [DataMember(Name="NumberOfChildren")]
        protected int? numberOfChildren;
        [DataMember(Name="NumberOfInfants")]
        protected int? numberOfInfants;
        #endregion
        #region Trip's Properties
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
/// The TripCode property
///
/// </summary>
///
        public virtual string TripCode
        {
            get
            {
                return tripCode;
            }
            set
            {
                tripCode = value;
            }
        }
/// <summary>
/// The Name property
///
/// </summary>
///
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
/// <summary>
/// The Description property
///
/// </summary>
///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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
        #endregion
        #region Trip's Participant Properties
        [DataMember(Name="ShoppingQueries")]
        protected IList<ShoppingQuery> shoppingQueries = new List<ShoppingQuery>();
        public virtual List<ShoppingQuery> ShoppingQueries
        {
            get
            {
                if (shoppingQueries is ShoppingQuery[])
                {
                    shoppingQueries = shoppingQueries.ToList();
                }
                if (shoppingQueries == null)
                {
                    shoppingQueries = new List<ShoppingQuery>();
                }
                return shoppingQueries.ToList();
            }
            set
            {
                if (shoppingQueries is ShoppingQuery[])
                {
                    shoppingQueries = shoppingQueries.ToList();
                }
                if (shoppingQueries != null)
                {
                    var __itemsToDelete = new List<ShoppingQuery>(shoppingQueries);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveShoppingQueries(__item);
                    }
                }
                if(value == null)
                {
                    shoppingQueries = new List<ShoppingQuery>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddShoppingQueries(__item);
                }
            }
        }
        public virtual void AddShoppingQueries(IList<ShoppingQuery> __items)
        {
            foreach (var __item in __items)
            {
                AddShoppingQueries(__item);
            }
        }
        public virtual void AddShoppingQueries(ShoppingQuery __item)
        {
            if (__item != null && shoppingQueries!=null && !shoppingQueries.Contains(__item))
            {
                shoppingQueries.Add(__item);
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void RemoveShoppingQueries(ShoppingQuery __item)
        {
            if (__item != null && shoppingQueries!=null && shoppingQueries.Contains(__item))
            {
                shoppingQueries.Remove(__item);
                __item.Trip = null;
            }
        }
        public virtual void SetShoppingQueriesAt(ShoppingQuery __item, int __index)
        {
            if (__item == null)
            {
                shoppingQueries[__index].Trip = null;
            }
            else
            {
                shoppingQueries[__index] = __item;
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void ClearShoppingQueries()
        {
            if (shoppingQueries!=null)
            {
                var __itemsToRemove = shoppingQueries.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveShoppingQueries(__item);
                }
            }
        }
        [DataMember(Name="Legs")]
        protected IList<Leg> legs = new List<Leg>();
        public virtual List<Leg> Legs
        {
            get
            {
                if (legs is Leg[])
                {
                    legs = legs.ToList();
                }
                if (legs == null)
                {
                    legs = new List<Leg>();
                }
                return legs.ToList();
            }
            set
            {
                if (legs is Leg[])
                {
                    legs = legs.ToList();
                }
                if (legs != null)
                {
                    var __itemsToDelete = new List<Leg>(legs);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLegs(__item);
                    }
                }
                if(value == null)
                {
                    legs = new List<Leg>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLegs(__item);
                }
            }
        }
        public virtual void AddLegs(IList<Leg> __items)
        {
            foreach (var __item in __items)
            {
                AddLegs(__item);
            }
        }
        public virtual void AddLegs(Leg __item)
        {
            if (__item != null && legs!=null && !legs.Contains(__item))
            {
                legs.Add(__item);
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void RemoveLegs(Leg __item)
        {
            if (__item != null && legs!=null && legs.Contains(__item))
            {
                legs.Remove(__item);
                __item.Trip = null;
            }
        }
        public virtual void SetLegsAt(Leg __item, int __index)
        {
            if (__item == null)
            {
                legs[__index].Trip = null;
            }
            else
            {
                legs[__index] = __item;
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void ClearLegs()
        {
            if (legs!=null)
            {
                var __itemsToRemove = legs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLegs(__item);
                }
            }
        }
        [DataMember(Name="PointsOfInterest")]
        protected IList<PointOfInterest> pointsOfInterest = new List<PointOfInterest>();
        public virtual List<PointOfInterest> PointsOfInterest
        {
            get
            {
                if (pointsOfInterest is PointOfInterest[])
                {
                    pointsOfInterest = pointsOfInterest.ToList();
                }
                if (pointsOfInterest == null)
                {
                    pointsOfInterest = new List<PointOfInterest>();
                }
                return pointsOfInterest.ToList();
            }
            set
            {
                if (pointsOfInterest is PointOfInterest[])
                {
                    pointsOfInterest = pointsOfInterest.ToList();
                }
                if (pointsOfInterest != null)
                {
                    var __itemsToDelete = new List<PointOfInterest>(pointsOfInterest);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePointsOfInterest(__item);
                    }
                }
                if(value == null)
                {
                    pointsOfInterest = new List<PointOfInterest>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPointsOfInterest(__item);
                }
            }
        }
        public virtual void AddPointsOfInterest(IList<PointOfInterest> __items)
        {
            foreach (var __item in __items)
            {
                AddPointsOfInterest(__item);
            }
        }
        public virtual void AddPointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && pointsOfInterest!=null && !pointsOfInterest.Contains(__item))
            {
                pointsOfInterest.Add(__item);
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void RemovePointsOfInterest(PointOfInterest __item)
        {
            if (__item != null && pointsOfInterest!=null && pointsOfInterest.Contains(__item))
            {
                pointsOfInterest.Remove(__item);
                __item.Trip = null;
            }
        }
        public virtual void SetPointsOfInterestAt(PointOfInterest __item, int __index)
        {
            if (__item == null)
            {
                pointsOfInterest[__index].Trip = null;
            }
            else
            {
                pointsOfInterest[__index] = __item;
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void ClearPointsOfInterest()
        {
            if (pointsOfInterest!=null)
            {
                var __itemsToRemove = pointsOfInterest.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePointsOfInterest(__item);
                }
            }
        }
        [DataMember(Name="LikedBy")]
        protected IList<Person> likedBy = new List<Person>();
        public virtual List<Person> LikedBy
        {
            get
            {
                if (likedBy is Person[])
                {
                    likedBy = likedBy.ToList();
                }
                if (likedBy == null)
                {
                    likedBy = new List<Person>();
                }
                return likedBy.ToList();
            }
            set
            {
                if (likedBy is Person[])
                {
                    likedBy = likedBy.ToList();
                }
                if (likedBy != null)
                {
                    var __itemsToDelete = new List<Person>(likedBy);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLikedBy(__item);
                    }
                }
                if(value == null)
                {
                    likedBy = new List<Person>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLikedBy(__item);
                }
            }
        }
        public virtual void AddLikedBy(IList<Person> __items)
        {
            foreach (var __item in __items)
            {
                AddLikedBy(__item);
            }
        }
        public virtual void AddLikedBy(Person __item)
        {
            if (__item != null && likedBy!=null && !likedBy.Contains(__item))
            {
                likedBy.Add(__item);
                if (!__item.LikedTrips.Contains(this))
                    __item.AddLikedTrips(this);
            }
        }

        public virtual void RemoveLikedBy(Person __item)
        {
            if (__item != null && likedBy!=null && likedBy.Contains(__item))
            {
                likedBy.Remove(__item);
                if(__item.LikedTrips.Contains(this))
                    __item.RemoveLikedTrips(this);
            }
        }
        public virtual void SetLikedByAt(Person __item, int __index)
        {
            if (__item == null)
            {
                likedBy[__index].RemoveLikedTrips(this);
            }
            else
            {
                likedBy[__index] = __item;
                if (!__item.LikedTrips.Contains(this))
                    __item.AddLikedTrips(this);
            }
        }

        public virtual void ClearLikedBy()
        {
            if (likedBy!=null)
            {
                var __itemsToRemove = likedBy.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLikedBy(__item);
                }
            }
        }
        [DataMember(Name="BookedBy")]
        protected Person bookedBy;
        public virtual Person BookedBy
        {
            get
            {
                return bookedBy;
            }
            set
            {
                if(Equals(bookedBy, value)) return;
                var __oldValue = bookedBy;
                if (value != null)
                {
                    if(bookedBy != null && !Equals(bookedBy, value))
                        bookedBy.RemoveBookedTrips(this);
                    bookedBy = value;
                    bookedBy.AddBookedTrips(this);
                }
                else
                {
                    if(bookedBy != null)
                        bookedBy.RemoveBookedTrips(this);
                    bookedBy = null;
                }
            }
        }
        [DataMember(Name="Notes")]
        protected IList<Note> notes = new List<Note>();
        public virtual List<Note> Notes
        {
            get
            {
                if (notes is Note[])
                {
                    notes = notes.ToList();
                }
                if (notes == null)
                {
                    notes = new List<Note>();
                }
                return notes.ToList();
            }
            set
            {
                if (notes is Note[])
                {
                    notes = notes.ToList();
                }
                if (notes != null)
                {
                    var __itemsToDelete = new List<Note>(notes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveNotes(__item);
                    }
                }
                if(value == null)
                {
                    notes = new List<Note>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddNotes(__item);
                }
            }
        }
        public virtual void AddNotes(IList<Note> __items)
        {
            foreach (var __item in __items)
            {
                AddNotes(__item);
            }
        }
        public virtual void AddNotes(Note __item)
        {
            if (__item != null && notes!=null && !notes.Contains(__item))
            {
                notes.Add(__item);
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void RemoveNotes(Note __item)
        {
            if (__item != null && notes!=null && notes.Contains(__item))
            {
                notes.Remove(__item);
                __item.Trip = null;
            }
        }
        public virtual void SetNotesAt(Note __item, int __index)
        {
            if (__item == null)
            {
                notes[__index].Trip = null;
            }
            else
            {
                notes[__index] = __item;
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void ClearNotes()
        {
            if (notes!=null)
            {
                var __itemsToRemove = notes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveNotes(__item);
                }
            }
        }
        [DataMember(Name="Photographs")]
        protected IList<Photograph> photographs = new List<Photograph>();
        public virtual List<Photograph> Photographs
        {
            get
            {
                if (photographs is Photograph[])
                {
                    photographs = photographs.ToList();
                }
                if (photographs == null)
                {
                    photographs = new List<Photograph>();
                }
                return photographs.ToList();
            }
            set
            {
                if (photographs is Photograph[])
                {
                    photographs = photographs.ToList();
                }
                if (photographs != null)
                {
                    var __itemsToDelete = new List<Photograph>(photographs);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePhotographs(__item);
                    }
                }
                if(value == null)
                {
                    photographs = new List<Photograph>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPhotographs(__item);
                }
            }
        }
        public virtual void AddPhotographs(IList<Photograph> __items)
        {
            foreach (var __item in __items)
            {
                AddPhotographs(__item);
            }
        }
        public virtual void AddPhotographs(Photograph __item)
        {
            if (__item != null && photographs!=null && !photographs.Contains(__item))
            {
                photographs.Add(__item);
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void RemovePhotographs(Photograph __item)
        {
            if (__item != null && photographs!=null && photographs.Contains(__item))
            {
                photographs.Remove(__item);
                __item.Trip = null;
            }
        }
        public virtual void SetPhotographsAt(Photograph __item, int __index)
        {
            if (__item == null)
            {
                photographs[__index].Trip = null;
            }
            else
            {
                photographs[__index] = __item;
                if (__item.Trip != this)
                    __item.Trip = this;
            }
        }

        public virtual void ClearPhotographs()
        {
            if (photographs!=null)
            {
                var __itemsToRemove = photographs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePhotographs(__item);
                }
            }
        }
        [DataMember(Name="Reservation")]
        protected Reservation reservation;
        public virtual Reservation Reservation
        {
            get
            {
                return reservation;
            }
            set
            {
                if(Equals(reservation, value)) return;
                var __oldValue = reservation;
                if (value != null)
                {
                    if(reservation != null && !Equals(reservation, value))
                        reservation.Trip = null;
                    reservation = value;
                    if(reservation.Trip != this)
                        reservation.Trip = this;
                }
                else
                {
                    if (reservation != null)
                    {
                        var __obj = reservation;
                        reservation = null;
                        __obj.Trip = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Trip class
/// </summary>
/// <returns>New Trip object</returns>
/// <remarks></remarks>
        public Trip() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (TripCode != null && TripCode.Length > 100)
            {
                __errors.Add("Length of property 'TripCode' cannot be greater than 100.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Trip' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Trip] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Trip Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Trip copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Trip)copiedObjects[this];
            copy = copy ?? new Trip();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.TripCode = this.TripCode;
            copy.Name = this.Name;
            copy.Description = this.Description;
            copy.NumberOfAdults = this.NumberOfAdults;
            copy.NumberOfChildren = this.NumberOfChildren;
            copy.NumberOfInfants = this.NumberOfInfants;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.shoppingQueries = new List<ShoppingQuery>();
            if(deep && this.shoppingQueries != null)
            {
                foreach (var __item in this.shoppingQueries)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddShoppingQueries(__item);
                        else
                            copy.AddShoppingQueries(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddShoppingQueries((ShoppingQuery)copiedObjects[__item]);
                    }
                }
            }
            copy.legs = new List<Leg>();
            if(deep && this.legs != null)
            {
                foreach (var __item in this.legs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLegs(__item);
                        else
                            copy.AddLegs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLegs((Leg)copiedObjects[__item]);
                    }
                }
            }
            copy.pointsOfInterest = new List<PointOfInterest>();
            if(deep && this.pointsOfInterest != null)
            {
                foreach (var __item in this.pointsOfInterest)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPointsOfInterest(__item);
                        else
                            copy.AddPointsOfInterest(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPointsOfInterest((PointOfInterest)copiedObjects[__item]);
                    }
                }
            }
            copy.likedBy = new List<Person>();
            if(deep && this.likedBy != null)
            {
                foreach (var __item in this.likedBy)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLikedBy(__item);
                        else
                            copy.AddLikedBy(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLikedBy((Person)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.bookedBy != null)
            {
                if (!copiedObjects.Contains(this.bookedBy))
                {
                    if (asNew && reuseNestedObjects)
                        copy.BookedBy = this.BookedBy;
                    else if (asNew)
                        copy.BookedBy = this.BookedBy.Copy(deep, copiedObjects, true);
                    else
                        copy.bookedBy = this.bookedBy.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.BookedBy = (Person)copiedObjects[this.BookedBy];
                    else
                        copy.bookedBy = (Person)copiedObjects[this.BookedBy];
                }
            }
            copy.notes = new List<Note>();
            if(deep && this.notes != null)
            {
                foreach (var __item in this.notes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddNotes(__item);
                        else
                            copy.AddNotes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddNotes((Note)copiedObjects[__item]);
                    }
                }
            }
            copy.photographs = new List<Photograph>();
            if(deep && this.photographs != null)
            {
                foreach (var __item in this.photographs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPhotographs(__item);
                        else
                            copy.AddPhotographs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPhotographs((Photograph)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.reservation != null)
            {
                if (!copiedObjects.Contains(this.reservation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Reservation = this.Reservation;
                    else if (asNew)
                        copy.Reservation = this.Reservation.Copy(deep, copiedObjects, true);
                    else
                        copy.reservation = this.reservation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Reservation = (Reservation)copiedObjects[this.Reservation];
                    else
                        copy.reservation = (Reservation)copiedObjects[this.Reservation];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Trip;
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
        protected bool HasSameNonDefaultIdAs(Trip compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
