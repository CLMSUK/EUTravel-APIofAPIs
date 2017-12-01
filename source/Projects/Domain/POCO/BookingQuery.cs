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
    /// The BookingQuery class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class BookingQuery : IDomainModelClass
    {
        #region BookingQuery's Fields

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
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region BookingQuery's Properties
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
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region BookingQuery's Participant Properties
        [DataMember(Name="ShoppingQuery")]
        protected ShoppingQuery shoppingQuery;
        public virtual ShoppingQuery ShoppingQuery
        {
            get
            {
                return shoppingQuery;
            }
            set
            {
                if(Equals(shoppingQuery, value)) return;
                var __oldValue = shoppingQuery;
                if (value != null)
                {
                    shoppingQuery = value;
                }
                else
                {
                    shoppingQuery = null;
                }
            }
        }
        [DataMember(Name="Vehicle")]
        protected Vehicle vehicle;
        public virtual Vehicle Vehicle
        {
            get
            {
                return vehicle;
            }
            set
            {
                if(Equals(vehicle, value)) return;
                var __oldValue = vehicle;
                if (value != null)
                {
                    vehicle = value;
                }
                else
                {
                    if (vehicle != null)
                    {
                        vehicle = null;
                    }
                }
            }
        }
        
        [DataMember(Name="Person")]
        protected IList<Person> person = new List<Person>();
        public virtual List<Person> Person
        {
            get
            {
                if (person is Person[])
                {
                    person = person.ToList();
                }
                if (person == null)
                {
                    person = new List<Person>();
                }
                return person.ToList();
            }
            set
            {
                if (person is Person[])
                {
                    person = person.ToList();
                }
                if (person != null)
                {
                    var __itemsToDelete = new List<Person>(person);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePerson(__item);
                    }
                }
                if(value == null)
                {
                    person = new List<Person>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPerson(__item);
                }
            }
        }
        public virtual void AddPerson(IList<Person> __items)
        {
            foreach (var __item in __items)
            {
                AddPerson(__item);
            }
        }
        public virtual void AddPerson(Person __item)
        {
            if (__item != null && person!=null && !person.Contains(__item))
            {
                person.Add(__item);
            }
        }

        public virtual void RemovePerson(Person __item)
        {
            if (__item != null && person!=null && person.Contains(__item))
            {
                person.Remove(__item);
            }
        }
        public virtual void SetPersonAt(Person __item, int __index)
        {
            if (__item == null)
            {
                person[__index] = null;
            }
            else
            {
                person[__index] = __item;
            }
        }

        public virtual void ClearPerson()
        {
            if (person!=null)
            {
                var __itemsToRemove = person.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePerson(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the BookingQuery class
/// </summary>
/// <returns>New BookingQuery object</returns>
/// <remarks></remarks>
        public BookingQuery() {}
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
                throw new BusinessException("An instance of TypeClass 'BookingQuery' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [BookingQuery] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual BookingQuery Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, BookingQuery copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (BookingQuery)copiedObjects[this];
            copy = copy ?? new BookingQuery();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.shoppingQuery != null)
            {
                if (!copiedObjects.Contains(this.shoppingQuery))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ShoppingQuery = this.ShoppingQuery;
                    else if (asNew)
                        copy.ShoppingQuery = this.ShoppingQuery.Copy(deep, copiedObjects, true);
                    else
                        copy.shoppingQuery = this.shoppingQuery.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ShoppingQuery = (ShoppingQuery)copiedObjects[this.ShoppingQuery];
                    else
                        copy.shoppingQuery = (ShoppingQuery)copiedObjects[this.ShoppingQuery];
                }
            }
            if(deep && this.vehicle != null)
            {
                if (!copiedObjects.Contains(this.vehicle))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Vehicle = this.Vehicle;
                    else if (asNew)
                        copy.Vehicle = this.Vehicle.Copy(deep, copiedObjects, true);
                    else
                        copy.vehicle = this.vehicle.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Vehicle = (Vehicle)copiedObjects[this.Vehicle];
                    else
                        copy.vehicle = (Vehicle)copiedObjects[this.Vehicle];
                }
            }
            copy.person = new List<Person>();
            if(deep && this.person != null)
            {
                foreach (var __item in this.person)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPerson(__item);
                        else
                            copy.AddPerson(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPerson((Person)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as BookingQuery;
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
        protected bool HasSameNonDefaultIdAs(BookingQuery compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
