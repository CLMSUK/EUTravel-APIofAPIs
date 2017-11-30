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
    /// The UpdateSchedulesResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class UpdateSchedulesResponse : IDomainModelClass
    {
        #region UpdateSchedulesResponse's Fields

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
        [DataMember(Name="UpdateSchedulesResponseKey")]
        protected Guid? updateSchedulesResponseKey = Guid.Empty;
        #endregion
        #region UpdateSchedulesResponse's Properties
/// <summary>
/// The UpdateSchedulesResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? UpdateSchedulesResponseKey
        {
            get
            {
                return updateSchedulesResponseKey;
            }
            set
            {
                updateSchedulesResponseKey = value;
            }
        }
        #endregion
        #region UpdateSchedulesResponse's Participant Properties
        [DataMember(Name="FlightRoutes")]
        protected IList<FlightRoute> flightRoutes = new List<FlightRoute>();
        public virtual List<FlightRoute> FlightRoutes
        {
            get
            {
                if (flightRoutes is FlightRoute[])
                {
                    flightRoutes = flightRoutes.ToList();
                }
                if (flightRoutes == null)
                {
                    flightRoutes = new List<FlightRoute>();
                }
                return flightRoutes.ToList();
            }
            set
            {
                if (flightRoutes is FlightRoute[])
                {
                    flightRoutes = flightRoutes.ToList();
                }
                if (flightRoutes != null)
                {
                    var __itemsToDelete = new List<FlightRoute>(flightRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveFlightRoutes(__item);
                    }
                }
                if(value == null)
                {
                    flightRoutes = new List<FlightRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddFlightRoutes(__item);
                }
            }
        }
        public virtual void AddFlightRoutes(IList<FlightRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddFlightRoutes(__item);
            }
        }
        public virtual void AddFlightRoutes(FlightRoute __item)
        {
            if (__item != null && flightRoutes!=null && !flightRoutes.Contains(__item))
            {
                flightRoutes.Add(__item);
            }
        }

        public virtual void RemoveFlightRoutes(FlightRoute __item)
        {
            if (__item != null && flightRoutes!=null && flightRoutes.Contains(__item))
            {
                flightRoutes.Remove(__item);
            }
        }
        public virtual void SetFlightRoutesAt(FlightRoute __item, int __index)
        {
            if (__item == null)
            {
                flightRoutes[__index] = null;
            }
            else
            {
                flightRoutes[__index] = __item;
            }
        }

        public virtual void ClearFlightRoutes()
        {
            if (flightRoutes!=null)
            {
                var __itemsToRemove = flightRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveFlightRoutes(__item);
                }
            }
        }
        [DataMember(Name="MarineRoutes")]
        protected IList<MarineRoute> marineRoutes = new List<MarineRoute>();
        public virtual List<MarineRoute> MarineRoutes
        {
            get
            {
                if (marineRoutes is MarineRoute[])
                {
                    marineRoutes = marineRoutes.ToList();
                }
                if (marineRoutes == null)
                {
                    marineRoutes = new List<MarineRoute>();
                }
                return marineRoutes.ToList();
            }
            set
            {
                if (marineRoutes is MarineRoute[])
                {
                    marineRoutes = marineRoutes.ToList();
                }
                if (marineRoutes != null)
                {
                    var __itemsToDelete = new List<MarineRoute>(marineRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveMarineRoutes(__item);
                    }
                }
                if(value == null)
                {
                    marineRoutes = new List<MarineRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddMarineRoutes(__item);
                }
            }
        }
        public virtual void AddMarineRoutes(IList<MarineRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddMarineRoutes(__item);
            }
        }
        public virtual void AddMarineRoutes(MarineRoute __item)
        {
            if (__item != null && marineRoutes!=null && !marineRoutes.Contains(__item))
            {
                marineRoutes.Add(__item);
            }
        }

        public virtual void RemoveMarineRoutes(MarineRoute __item)
        {
            if (__item != null && marineRoutes!=null && marineRoutes.Contains(__item))
            {
                marineRoutes.Remove(__item);
            }
        }
        public virtual void SetMarineRoutesAt(MarineRoute __item, int __index)
        {
            if (__item == null)
            {
                marineRoutes[__index] = null;
            }
            else
            {
                marineRoutes[__index] = __item;
            }
        }

        public virtual void ClearMarineRoutes()
        {
            if (marineRoutes!=null)
            {
                var __itemsToRemove = marineRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveMarineRoutes(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UpdateSchedulesResponse class
/// </summary>
/// <returns>New UpdateSchedulesResponse object</returns>
/// <remarks></remarks>
        public UpdateSchedulesResponse()
        {
            if (UpdateSchedulesResponseKey == null) UpdateSchedulesResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UpdateSchedulesResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UpdateSchedulesResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UpdateSchedulesResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UpdateSchedulesResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UpdateSchedulesResponse)copiedObjects[this];
            copy = copy ?? new UpdateSchedulesResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.UpdateSchedulesResponseKey = this.UpdateSchedulesResponseKey;
            }
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.flightRoutes = new List<FlightRoute>();
            if(deep && this.flightRoutes != null)
            {
                foreach (var __item in this.flightRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddFlightRoutes(__item);
                        else
                            copy.AddFlightRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddFlightRoutes((FlightRoute)copiedObjects[__item]);
                    }
                }
            }
            copy.marineRoutes = new List<MarineRoute>();
            if(deep && this.marineRoutes != null)
            {
                foreach (var __item in this.marineRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddMarineRoutes(__item);
                        else
                            copy.AddMarineRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddMarineRoutes((MarineRoute)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UpdateSchedulesResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("UpdateSchedulesResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.UpdateSchedulesResponseKey.GetHashCode();
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
            return this.UpdateSchedulesResponseKey == default(Guid) || this.UpdateSchedulesResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(UpdateSchedulesResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.UpdateSchedulesResponseKey.Equals(compareTo.UpdateSchedulesResponseKey);
        }

        #endregion
    }
}
