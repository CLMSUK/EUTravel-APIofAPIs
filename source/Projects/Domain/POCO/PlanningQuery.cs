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
    /// The PlanningQuery class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class PlanningQuery : IDomainModelClass
    {
        #region PlanningQuery's Fields

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
        [DataMember(Name="NumberOfInfants")]
        protected int? numberOfInfants;
        [DataMember(Name="NumberOfChildren")]
        protected int? numberOfChildren;
        [DataMember(Name="NumberOfAdults")]
        protected int? numberOfAdults;
        [DataMember(Name="OneWay")]
        protected bool oneWay;
        [DataMember(Name="PlusMinusOneWeek")]
        protected bool plusMinusOneWeek;
        [DataMember(Name="DepartureDateTime")]
        protected DateTime? departureDateTime;
        [DataMember(Name="ReturnDateTime")]
        protected DateTime? returnDateTime;
        #endregion
        #region PlanningQuery's Properties
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
/// The OneWay property
///
/// </summary>
///
        public virtual bool OneWay
        {
            get
            {
                return oneWay;
            }
            set
            {
                oneWay = value;
            }
        }
/// <summary>
/// The PlusMinusOneWeek property
///
/// </summary>
///
        public virtual bool PlusMinusOneWeek
        {
            get
            {
                return plusMinusOneWeek;
            }
            set
            {
                plusMinusOneWeek = value;
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
/// The ReturnDateTime property
///
/// </summary>
///
        public virtual DateTime? ReturnDateTime
        {
            get
            {
                return returnDateTime;
            }
            set
            {
                returnDateTime = value;
            }
        }
        #endregion
        #region PlanningQuery's Participant Properties
        [DataMember(Name="Origin")]
        protected Location origin;
        public virtual Location Origin
        {
            get
            {
                return origin;
            }
            set
            {
                if(Equals(origin, value)) return;
                var __oldValue = origin;
                if (value != null)
                {
                    origin = value;
                }
                else
                {
                    if (origin != null)
                    {
                        origin = null;
                    }
                }
            }
        }
        [DataMember(Name="Destination")]
        protected Location destination;
        public virtual Location Destination
        {
            get
            {
                return destination;
            }
            set
            {
                if(Equals(destination, value)) return;
                var __oldValue = destination;
                if (value != null)
                {
                    destination = value;
                }
                else
                {
                    if (destination != null)
                    {
                        destination = null;
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
        [DataMember(Name="Person")]
        protected Person person;
        public virtual Person Person
        {
            get
            {
                return person;
            }
            set
            {
                if(Equals(person, value)) return;
                var __oldValue = person;
                if (value != null)
                {
                    person = value;
                }
                else
                {
                    person = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the PlanningQuery class
/// </summary>
/// <returns>New PlanningQuery object</returns>
/// <remarks></remarks>
        public PlanningQuery() {}
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
                throw new BusinessException("An instance of TypeClass 'PlanningQuery' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [PlanningQuery] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual PlanningQuery Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, PlanningQuery copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (PlanningQuery)copiedObjects[this];
            copy = copy ?? new PlanningQuery();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.NumberOfInfants = this.NumberOfInfants;
            copy.NumberOfChildren = this.NumberOfChildren;
            copy.NumberOfAdults = this.NumberOfAdults;
            copy.OneWay = this.OneWay;
            copy.PlusMinusOneWeek = this.PlusMinusOneWeek;
            copy.DepartureDateTime = this.DepartureDateTime;
            copy.ReturnDateTime = this.ReturnDateTime;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.origin != null)
            {
                if (!copiedObjects.Contains(this.origin))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Origin = this.Origin;
                    else if (asNew)
                        copy.Origin = this.Origin.Copy(deep, copiedObjects, true);
                    else
                        copy.origin = this.origin.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Origin = (Location)copiedObjects[this.Origin];
                    else
                        copy.origin = (Location)copiedObjects[this.Origin];
                }
            }
            if(deep && this.destination != null)
            {
                if (!copiedObjects.Contains(this.destination))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Destination = this.Destination;
                    else if (asNew)
                        copy.Destination = this.Destination.Copy(deep, copiedObjects, true);
                    else
                        copy.destination = this.destination.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Destination = (Location)copiedObjects[this.Destination];
                    else
                        copy.destination = (Location)copiedObjects[this.Destination];
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
            if(deep && this.person != null)
            {
                if (!copiedObjects.Contains(this.person))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Person = this.Person;
                    else if (asNew)
                        copy.Person = this.Person.Copy(deep, copiedObjects, true);
                    else
                        copy.person = this.person.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Person = (Person)copiedObjects[this.Person];
                    else
                        copy.person = (Person)copiedObjects[this.Person];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as PlanningQuery;
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
        protected bool HasSameNonDefaultIdAs(PlanningQuery compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
