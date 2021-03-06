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
    /// The RequestWrapper class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class RequestWrapper : IDomainModelClass
    {
        #region RequestWrapper's Fields

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
        [DataMember(Name="NumberOfAdults")]
        protected int? numberOfAdults;
        [DataMember(Name="NumberOfChildren")]
        protected int? numberOfChildren;
        [DataMember(Name="NumberOfInfants")]
        protected int? numberOfInfants;
        [DataMember(Name="IncludeDoorToDoor")]
        protected bool includeDoorToDoor;
        [DataMember(Name="OriginalTrip")]
        protected int? originalTrip;
        [DataMember(Name="Age")]
        protected int? age;
        [DataMember(Name="RequestWrapperKey")]
        protected Guid? requestWrapperKey = Guid.Empty;
        #endregion
        #region RequestWrapper's Properties
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
/// <summary>
/// The IncludeDoorToDoor property
///
/// </summary>
///
        public virtual bool IncludeDoorToDoor
        {
            get
            {
                return includeDoorToDoor;
            }
            set
            {
                includeDoorToDoor = value;
            }
        }
/// <summary>
/// The OriginalTrip property
///
/// </summary>
///
        public virtual int? OriginalTrip
        {
            get
            {
                return originalTrip;
            }
            set
            {
                originalTrip = value;
            }
        }
/// <summary>
/// The Age property
///
/// </summary>
///
        public virtual int? Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
/// <summary>
/// The RequestWrapperKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? RequestWrapperKey
        {
            get
            {
                return requestWrapperKey;
            }
            set
            {
                requestWrapperKey = value;
            }
        }
        #endregion
        #region RequestWrapper's Participant Properties
        [DataMember(Name="LocationPairs")]
        protected IList<LocationPair> locationPairs = new List<LocationPair>();
        public virtual List<LocationPair> LocationPairs
        {
            get
            {
                if (locationPairs is LocationPair[])
                {
                    locationPairs = locationPairs.ToList();
                }
                if (locationPairs == null)
                {
                    locationPairs = new List<LocationPair>();
                }
                return locationPairs.ToList();
            }
            set
            {
                if (locationPairs is LocationPair[])
                {
                    locationPairs = locationPairs.ToList();
                }
                if (locationPairs != null)
                {
                    var __itemsToDelete = new List<LocationPair>(locationPairs);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLocationPairs(__item);
                    }
                }
                if(value == null)
                {
                    locationPairs = new List<LocationPair>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLocationPairs(__item);
                }
            }
        }
        public virtual void AddLocationPairs(IList<LocationPair> __items)
        {
            foreach (var __item in __items)
            {
                AddLocationPairs(__item);
            }
        }
        public virtual void AddLocationPairs(LocationPair __item)
        {
            if (__item != null && locationPairs!=null && !locationPairs.Contains(__item))
            {
                locationPairs.Add(__item);
            }
        }

        public virtual void RemoveLocationPairs(LocationPair __item)
        {
            if (__item != null && locationPairs!=null && locationPairs.Contains(__item))
            {
                locationPairs.Remove(__item);
            }
        }
        public virtual void SetLocationPairsAt(LocationPair __item, int __index)
        {
            if (__item == null)
            {
                locationPairs[__index] = null;
            }
            else
            {
                locationPairs[__index] = __item;
            }
        }

        public virtual void ClearLocationPairs()
        {
            if (locationPairs!=null)
            {
                var __itemsToRemove = locationPairs.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLocationPairs(__item);
                }
            }
        }
        [DataMember(Name="UserPreferences")]
        protected UserPreferences userPreferences;
        public virtual UserPreferences UserPreferences
        {
            get
            {
                return userPreferences;
            }
            set
            {
                if(Equals(userPreferences, value)) return;
                var __oldValue = userPreferences;
                if (value != null)
                {
                    userPreferences = value;
                }
                else
                {
                    if (userPreferences != null)
                    {
                        userPreferences = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the RequestWrapper class
/// </summary>
/// <returns>New RequestWrapper object</returns>
/// <remarks></remarks>
        public RequestWrapper()
        {
            if (RequestWrapperKey == null) RequestWrapperKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'RequestWrapper' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [RequestWrapper] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual RequestWrapper Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, RequestWrapper copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (RequestWrapper)copiedObjects[this];
            copy = copy ?? new RequestWrapper();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.RequestWrapperKey = this.RequestWrapperKey;
            }
            copy.NumberOfAdults = this.NumberOfAdults;
            copy.NumberOfChildren = this.NumberOfChildren;
            copy.NumberOfInfants = this.NumberOfInfants;
            copy.IncludeDoorToDoor = this.IncludeDoorToDoor;
            copy.OriginalTrip = this.OriginalTrip;
            copy.Age = this.Age;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.locationPairs = new List<LocationPair>();
            if(deep && this.locationPairs != null)
            {
                foreach (var __item in this.locationPairs)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLocationPairs(__item);
                        else
                            copy.AddLocationPairs(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLocationPairs((LocationPair)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.userPreferences != null)
            {
                if (!copiedObjects.Contains(this.userPreferences))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UserPreferences = this.UserPreferences;
                    else if (asNew)
                        copy.UserPreferences = this.UserPreferences.Copy(deep, copiedObjects, true);
                    else
                        copy.userPreferences = this.userPreferences.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UserPreferences = (UserPreferences)copiedObjects[this.UserPreferences];
                    else
                        copy.userPreferences = (UserPreferences)copiedObjects[this.UserPreferences];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as RequestWrapper;
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
                __propertyKeyCache = this.GetType().GetProperty("RequestWrapperKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.RequestWrapperKey.GetHashCode();
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
            return this.RequestWrapperKey == default(Guid) || this.RequestWrapperKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(RequestWrapper compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.RequestWrapperKey.Equals(compareTo.RequestWrapperKey);
        }

        #endregion
    }
}
