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
    /// The UrbanResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class UrbanResponse : IDomainModelClass
    {
        #region UrbanResponse's Fields

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
        [DataMember(Name="UrbanResponseKey")]
        protected Guid? urbanResponseKey = Guid.Empty;
        #endregion
        #region UrbanResponse's Properties
/// <summary>
/// The UrbanResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? UrbanResponseKey
        {
            get
            {
                return urbanResponseKey;
            }
            set
            {
                urbanResponseKey = value;
            }
        }
        #endregion
        #region UrbanResponse's Participant Properties
        [DataMember(Name="UrbanRoutes")]
        protected IList<UrbanRoute> urbanRoutes = new List<UrbanRoute>();
        public virtual List<UrbanRoute> UrbanRoutes
        {
            get
            {
                if (urbanRoutes is UrbanRoute[])
                {
                    urbanRoutes = urbanRoutes.ToList();
                }
                if (urbanRoutes == null)
                {
                    urbanRoutes = new List<UrbanRoute>();
                }
                return urbanRoutes.ToList();
            }
            set
            {
                if (urbanRoutes is UrbanRoute[])
                {
                    urbanRoutes = urbanRoutes.ToList();
                }
                if (urbanRoutes != null)
                {
                    var __itemsToDelete = new List<UrbanRoute>(urbanRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUrbanRoutes(__item);
                    }
                }
                if(value == null)
                {
                    urbanRoutes = new List<UrbanRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUrbanRoutes(__item);
                }
            }
        }
        public virtual void AddUrbanRoutes(IList<UrbanRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddUrbanRoutes(__item);
            }
        }
        public virtual void AddUrbanRoutes(UrbanRoute __item)
        {
            if (__item != null && urbanRoutes!=null && !urbanRoutes.Contains(__item))
            {
                urbanRoutes.Add(__item);
            }
        }

        public virtual void RemoveUrbanRoutes(UrbanRoute __item)
        {
            if (__item != null && urbanRoutes!=null && urbanRoutes.Contains(__item))
            {
                urbanRoutes.Remove(__item);
            }
        }
        public virtual void SetUrbanRoutesAt(UrbanRoute __item, int __index)
        {
            if (__item == null)
            {
                urbanRoutes[__index] = null;
            }
            else
            {
                urbanRoutes[__index] = __item;
            }
        }

        public virtual void ClearUrbanRoutes()
        {
            if (urbanRoutes!=null)
            {
                var __itemsToRemove = urbanRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUrbanRoutes(__item);
                }
            }
        }
        [DataMember(Name="UrbanTrips")]
        protected IList<UrbanTrip> urbanTrips = new List<UrbanTrip>();
        public virtual List<UrbanTrip> UrbanTrips
        {
            get
            {
                if (urbanTrips is UrbanTrip[])
                {
                    urbanTrips = urbanTrips.ToList();
                }
                if (urbanTrips == null)
                {
                    urbanTrips = new List<UrbanTrip>();
                }
                return urbanTrips.ToList();
            }
            set
            {
                if (urbanTrips is UrbanTrip[])
                {
                    urbanTrips = urbanTrips.ToList();
                }
                if (urbanTrips != null)
                {
                    var __itemsToDelete = new List<UrbanTrip>(urbanTrips);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUrbanTrips(__item);
                    }
                }
                if(value == null)
                {
                    urbanTrips = new List<UrbanTrip>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUrbanTrips(__item);
                }
            }
        }
        public virtual void AddUrbanTrips(IList<UrbanTrip> __items)
        {
            foreach (var __item in __items)
            {
                AddUrbanTrips(__item);
            }
        }
        public virtual void AddUrbanTrips(UrbanTrip __item)
        {
            if (__item != null && urbanTrips!=null && !urbanTrips.Contains(__item))
            {
                urbanTrips.Add(__item);
            }
        }

        public virtual void RemoveUrbanTrips(UrbanTrip __item)
        {
            if (__item != null && urbanTrips!=null && urbanTrips.Contains(__item))
            {
                urbanTrips.Remove(__item);
            }
        }
        public virtual void SetUrbanTripsAt(UrbanTrip __item, int __index)
        {
            if (__item == null)
            {
                urbanTrips[__index] = null;
            }
            else
            {
                urbanTrips[__index] = __item;
            }
        }

        public virtual void ClearUrbanTrips()
        {
            if (urbanTrips!=null)
            {
                var __itemsToRemove = urbanTrips.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUrbanTrips(__item);
                }
            }
        }
        [DataMember(Name="UrbanAgencies")]
        protected IList<UrbanAgency> urbanAgencies = new List<UrbanAgency>();
        public virtual List<UrbanAgency> UrbanAgencies
        {
            get
            {
                if (urbanAgencies is UrbanAgency[])
                {
                    urbanAgencies = urbanAgencies.ToList();
                }
                if (urbanAgencies == null)
                {
                    urbanAgencies = new List<UrbanAgency>();
                }
                return urbanAgencies.ToList();
            }
            set
            {
                if (urbanAgencies is UrbanAgency[])
                {
                    urbanAgencies = urbanAgencies.ToList();
                }
                if (urbanAgencies != null)
                {
                    var __itemsToDelete = new List<UrbanAgency>(urbanAgencies);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveUrbanAgencies(__item);
                    }
                }
                if(value == null)
                {
                    urbanAgencies = new List<UrbanAgency>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddUrbanAgencies(__item);
                }
            }
        }
        public virtual void AddUrbanAgencies(IList<UrbanAgency> __items)
        {
            foreach (var __item in __items)
            {
                AddUrbanAgencies(__item);
            }
        }
        public virtual void AddUrbanAgencies(UrbanAgency __item)
        {
            if (__item != null && urbanAgencies!=null && !urbanAgencies.Contains(__item))
            {
                urbanAgencies.Add(__item);
            }
        }

        public virtual void RemoveUrbanAgencies(UrbanAgency __item)
        {
            if (__item != null && urbanAgencies!=null && urbanAgencies.Contains(__item))
            {
                urbanAgencies.Remove(__item);
            }
        }
        public virtual void SetUrbanAgenciesAt(UrbanAgency __item, int __index)
        {
            if (__item == null)
            {
                urbanAgencies[__index] = null;
            }
            else
            {
                urbanAgencies[__index] = __item;
            }
        }

        public virtual void ClearUrbanAgencies()
        {
            if (urbanAgencies!=null)
            {
                var __itemsToRemove = urbanAgencies.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveUrbanAgencies(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanResponse class
/// </summary>
/// <returns>New UrbanResponse object</returns>
/// <remarks></remarks>
        public UrbanResponse()
        {
            if (UrbanResponseKey == null) UrbanResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanResponse)copiedObjects[this];
            copy = copy ?? new UrbanResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.UrbanResponseKey = this.UrbanResponseKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.urbanRoutes = new List<UrbanRoute>();
            if(deep && this.urbanRoutes != null)
            {
                foreach (var __item in this.urbanRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUrbanRoutes(__item);
                        else
                            copy.AddUrbanRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUrbanRoutes((UrbanRoute)copiedObjects[__item]);
                    }
                }
            }
            copy.urbanTrips = new List<UrbanTrip>();
            if(deep && this.urbanTrips != null)
            {
                foreach (var __item in this.urbanTrips)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUrbanTrips(__item);
                        else
                            copy.AddUrbanTrips(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUrbanTrips((UrbanTrip)copiedObjects[__item]);
                    }
                }
            }
            copy.urbanAgencies = new List<UrbanAgency>();
            if(deep && this.urbanAgencies != null)
            {
                foreach (var __item in this.urbanAgencies)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddUrbanAgencies(__item);
                        else
                            copy.AddUrbanAgencies(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddUrbanAgencies((UrbanAgency)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("UrbanResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.UrbanResponseKey.GetHashCode();
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
            return this.UrbanResponseKey == default(Guid) || this.UrbanResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(UrbanResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.UrbanResponseKey.Equals(compareTo.UrbanResponseKey);
        }

        #endregion
    }
}
