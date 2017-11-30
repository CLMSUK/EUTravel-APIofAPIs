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
    /// The Leg class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Leg : IDomainModelClass
    {
        #region Leg's Fields

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
        [DataMember(Name="LegOrder")]
        protected int? legOrder;
        [DataMember(Name="TravelDate")]
        protected DateTime? travelDate;
        [DataMember(Name="NumberOfSolutions")]
        protected int? numberOfSolutions;
        [DataMember(Name="ArrivalDate")]
        protected DateTime? arrivalDate;
        #endregion
        #region Leg's Properties
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
/// The LegOrder property
///
/// </summary>
///
        public virtual int? LegOrder
        {
            get
            {
                return legOrder;
            }
            set
            {
                legOrder = value;
            }
        }
/// <summary>
/// The TravelDate property
///
/// </summary>
///
        public virtual DateTime? TravelDate
        {
            get
            {
                return travelDate;
            }
            set
            {
                travelDate = value;
            }
        }
/// <summary>
/// The NumberOfSolutions property
///
/// </summary>
///
        public virtual int? NumberOfSolutions
        {
            get
            {
                return numberOfSolutions;
            }
            set
            {
                numberOfSolutions = value;
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
        #endregion
        #region Leg's Participant Properties
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
                        trip.RemoveLegs(this);
                    trip = value;
                    trip.AddLegs(this);
                }
                else
                {
                    if(trip != null)
                        trip.RemoveLegs(this);
                    trip = null;
                }
            }
        }
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
                    if(fare != null && !Equals(fare, value))
                        fare.Leg = null;
                    fare = value;
                    if(fare.Leg != this)
                        fare.Leg = this;
                }
                else
                {
                    if (fare != null)
                    {
                        var __obj = fare;
                        fare = null;
                        __obj.Leg = null;
                    }
                }
            }
        }
        [DataMember(Name="Preferences")]
        protected IList<Preference> preferences = new List<Preference>();
        public virtual List<Preference> Preferences
        {
            get
            {
                if (preferences is Preference[])
                {
                    preferences = preferences.ToList();
                }
                if (preferences == null)
                {
                    preferences = new List<Preference>();
                }
                return preferences.ToList();
            }
            set
            {
                if (preferences is Preference[])
                {
                    preferences = preferences.ToList();
                }
                if (preferences != null)
                {
                    var __itemsToDelete = new List<Preference>(preferences);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePreferences(__item);
                    }
                }
                if(value == null)
                {
                    preferences = new List<Preference>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPreferences(__item);
                }
            }
        }
        public virtual void AddPreferences(IList<Preference> __items)
        {
            foreach (var __item in __items)
            {
                AddPreferences(__item);
            }
        }
        public virtual void AddPreferences(Preference __item)
        {
            if (__item != null && preferences!=null && !preferences.Contains(__item))
            {
                preferences.Add(__item);
            }
        }

        public virtual void RemovePreferences(Preference __item)
        {
            if (__item != null && preferences!=null && preferences.Contains(__item))
            {
                preferences.Remove(__item);
            }
        }
        public virtual void SetPreferencesAt(Preference __item, int __index)
        {
            if (__item == null)
            {
                preferences[__index] = null;
            }
            else
            {
                preferences[__index] = __item;
            }
        }

        public virtual void ClearPreferences()
        {
            if (preferences!=null)
            {
                var __itemsToRemove = preferences.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePreferences(__item);
                }
            }
        }
        [DataMember(Name="PointOfInterest")]
        protected IList<PointOfInterest> pointOfInterest = new List<PointOfInterest>();
        public virtual List<PointOfInterest> PointOfInterest
        {
            get
            {
                if (pointOfInterest is PointOfInterest[])
                {
                    pointOfInterest = pointOfInterest.ToList();
                }
                if (pointOfInterest == null)
                {
                    pointOfInterest = new List<PointOfInterest>();
                }
                return pointOfInterest.ToList();
            }
            set
            {
                if (pointOfInterest is PointOfInterest[])
                {
                    pointOfInterest = pointOfInterest.ToList();
                }
                if (pointOfInterest != null)
                {
                    var __itemsToDelete = new List<PointOfInterest>(pointOfInterest);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePointOfInterest(__item);
                    }
                }
                if(value == null)
                {
                    pointOfInterest = new List<PointOfInterest>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPointOfInterest(__item);
                }
            }
        }
        public virtual void AddPointOfInterest(IList<PointOfInterest> __items)
        {
            foreach (var __item in __items)
            {
                AddPointOfInterest(__item);
            }
        }
        public virtual void AddPointOfInterest(PointOfInterest __item)
        {
            if (__item != null && pointOfInterest!=null && !pointOfInterest.Contains(__item))
            {
                pointOfInterest.Add(__item);
                if (__item.Leg != this)
                    __item.Leg = this;
            }
        }

        public virtual void RemovePointOfInterest(PointOfInterest __item)
        {
            if (__item != null && pointOfInterest!=null && pointOfInterest.Contains(__item))
            {
                pointOfInterest.Remove(__item);
                __item.Leg = null;
            }
        }
        public virtual void SetPointOfInterestAt(PointOfInterest __item, int __index)
        {
            if (__item == null)
            {
                pointOfInterest[__index].Leg = null;
            }
            else
            {
                pointOfInterest[__index] = __item;
                if (__item.Leg != this)
                    __item.Leg = this;
            }
        }

        public virtual void ClearPointOfInterest()
        {
            if (pointOfInterest!=null)
            {
                var __itemsToRemove = pointOfInterest.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePointOfInterest(__item);
                }
            }
        }
        [DataMember(Name="Solutions")]
        protected IList<Solution> solutions = new List<Solution>();
        public virtual List<Solution> Solutions
        {
            get
            {
                if (solutions is Solution[])
                {
                    solutions = solutions.ToList();
                }
                if (solutions == null)
                {
                    solutions = new List<Solution>();
                }
                return solutions.ToList();
            }
            set
            {
                if (solutions is Solution[])
                {
                    solutions = solutions.ToList();
                }
                if (solutions != null)
                {
                    var __itemsToDelete = new List<Solution>(solutions);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveSolutions(__item);
                    }
                }
                if(value == null)
                {
                    solutions = new List<Solution>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddSolutions(__item);
                }
            }
        }
        public virtual void AddSolutions(IList<Solution> __items)
        {
            foreach (var __item in __items)
            {
                AddSolutions(__item);
            }
        }
        public virtual void AddSolutions(Solution __item)
        {
            if (__item != null && solutions!=null && !solutions.Contains(__item))
            {
                solutions.Add(__item);
                if (__item.Leg != this)
                    __item.Leg = this;
            }
        }

        public virtual void RemoveSolutions(Solution __item)
        {
            if (__item != null && solutions!=null && solutions.Contains(__item))
            {
                solutions.Remove(__item);
                __item.Leg = null;
            }
        }
        public virtual void SetSolutionsAt(Solution __item, int __index)
        {
            if (__item == null)
            {
                solutions[__index].Leg = null;
            }
            else
            {
                solutions[__index] = __item;
                if (__item.Leg != this)
                    __item.Leg = this;
            }
        }

        public virtual void ClearSolutions()
        {
            if (solutions!=null)
            {
                var __itemsToRemove = solutions.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveSolutions(__item);
                }
            }
        }
        [DataMember(Name="OriginLocation")]
        protected Location originLocation;
        public virtual Location OriginLocation
        {
            get
            {
                return originLocation;
            }
            set
            {
                if(Equals(originLocation, value)) return;
                var __oldValue = originLocation;
                if (value != null)
                {
                    originLocation = value;
                }
                else
                {
                    if (originLocation != null)
                    {
                        originLocation = null;
                    }
                }
            }
        }
        [DataMember(Name="DestinationLocation")]
        protected Location destinationLocation;
        public virtual Location DestinationLocation
        {
            get
            {
                return destinationLocation;
            }
            set
            {
                if(Equals(destinationLocation, value)) return;
                var __oldValue = destinationLocation;
                if (value != null)
                {
                    destinationLocation = value;
                }
                else
                {
                    if (destinationLocation != null)
                    {
                        destinationLocation = null;
                    }
                }
            }
        }
        [DataMember(Name="ChosenSolution")]
        protected Solution chosenSolution;
        public virtual Solution ChosenSolution
        {
            get
            {
                return chosenSolution;
            }
            set
            {
                if(Equals(chosenSolution, value)) return;
                var __oldValue = chosenSolution;
                if (value != null)
                {
                    chosenSolution = value;
                }
                else
                {
                    if (chosenSolution != null)
                    {
                        chosenSolution = null;
                    }
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
                if (__item.Leg != this)
                    __item.Leg = this;
            }
        }

        public virtual void RemoveNotes(Note __item)
        {
            if (__item != null && notes!=null && notes.Contains(__item))
            {
                notes.Remove(__item);
                __item.Leg = null;
            }
        }
        public virtual void SetNotesAt(Note __item, int __index)
        {
            if (__item == null)
            {
                notes[__index].Leg = null;
            }
            else
            {
                notes[__index] = __item;
                if (__item.Leg != this)
                    __item.Leg = this;
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
                if (__item.Leg != this)
                    __item.Leg = this;
            }
        }

        public virtual void RemovePhotographs(Photograph __item)
        {
            if (__item != null && photographs!=null && photographs.Contains(__item))
            {
                photographs.Remove(__item);
                __item.Leg = null;
            }
        }
        public virtual void SetPhotographsAt(Photograph __item, int __index)
        {
            if (__item == null)
            {
                photographs[__index].Leg = null;
            }
            else
            {
                photographs[__index] = __item;
                if (__item.Leg != this)
                    __item.Leg = this;
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
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Leg class
/// </summary>
/// <returns>New Leg object</returns>
/// <remarks></remarks>
        public Leg() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Leg' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Leg] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Leg Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Leg copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Leg)copiedObjects[this];
            copy = copy ?? new Leg();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.LegOrder = this.LegOrder;
            copy.TravelDate = this.TravelDate;
            copy.NumberOfSolutions = this.NumberOfSolutions;
            copy.ArrivalDate = this.ArrivalDate;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
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
            copy.preferences = new List<Preference>();
            if(deep && this.preferences != null)
            {
                foreach (var __item in this.preferences)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPreferences(__item);
                        else
                            copy.AddPreferences(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPreferences((Preference)copiedObjects[__item]);
                    }
                }
            }
            copy.pointOfInterest = new List<PointOfInterest>();
            if(deep && this.pointOfInterest != null)
            {
                foreach (var __item in this.pointOfInterest)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPointOfInterest(__item);
                        else
                            copy.AddPointOfInterest(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPointOfInterest((PointOfInterest)copiedObjects[__item]);
                    }
                }
            }
            copy.solutions = new List<Solution>();
            if(deep && this.solutions != null)
            {
                foreach (var __item in this.solutions)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddSolutions(__item);
                        else
                            copy.AddSolutions(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddSolutions((Solution)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.originLocation != null)
            {
                if (!copiedObjects.Contains(this.originLocation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OriginLocation = this.OriginLocation;
                    else if (asNew)
                        copy.OriginLocation = this.OriginLocation.Copy(deep, copiedObjects, true);
                    else
                        copy.originLocation = this.originLocation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OriginLocation = (Location)copiedObjects[this.OriginLocation];
                    else
                        copy.originLocation = (Location)copiedObjects[this.OriginLocation];
                }
            }
            if(deep && this.destinationLocation != null)
            {
                if (!copiedObjects.Contains(this.destinationLocation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.DestinationLocation = this.DestinationLocation;
                    else if (asNew)
                        copy.DestinationLocation = this.DestinationLocation.Copy(deep, copiedObjects, true);
                    else
                        copy.destinationLocation = this.destinationLocation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.DestinationLocation = (Location)copiedObjects[this.DestinationLocation];
                    else
                        copy.destinationLocation = (Location)copiedObjects[this.DestinationLocation];
                }
            }
            if(deep && this.chosenSolution != null)
            {
                if (!copiedObjects.Contains(this.chosenSolution))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ChosenSolution = this.ChosenSolution;
                    else if (asNew)
                        copy.ChosenSolution = this.ChosenSolution.Copy(deep, copiedObjects, true);
                    else
                        copy.chosenSolution = this.chosenSolution.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ChosenSolution = (Solution)copiedObjects[this.ChosenSolution];
                    else
                        copy.chosenSolution = (Solution)copiedObjects[this.ChosenSolution];
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
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Leg;
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
        protected bool HasSameNonDefaultIdAs(Leg compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
