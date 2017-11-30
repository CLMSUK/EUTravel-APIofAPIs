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
    /// The ShipFacilities class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class ShipFacilities : IDomainModelClass
    {
        #region ShipFacilities's Fields

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
        [DataMember(Name="CabinMandatory")]
        protected bool cabinMandatory;
        [DataMember(Name="CabinAvailability")]
        protected EuTravel_2.BO.AvailabilityStatus cabinAvailability;
        [DataMember(Name="CabinCapacity")]
        protected int? cabinCapacity;
        [DataMember(Name="PassengerCapacity")]
        protected int? passengerCapacity;
        [DataMember(Name="PassengerAvailability")]
        protected EuTravel_2.BO.AvailabilityStatus passengerAvailability;
        [DataMember(Name="VehicleAvailability")]
        protected EuTravel_2.BO.AvailabilityStatus vehicleAvailability;
        [DataMember(Name="VehicleCapacity")]
        protected int? vehicleCapacity;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region ShipFacilities's Properties
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
/// The CabinMandatory property
///
/// </summary>
///
        public virtual bool CabinMandatory
        {
            get
            {
                return cabinMandatory;
            }
            set
            {
                cabinMandatory = value;
            }
        }
/// <summary>
/// The CabinAvailability property
///
/// </summary>
///
        public virtual EuTravel_2.BO.AvailabilityStatus CabinAvailability
        {
            get
            {
                return cabinAvailability;
            }
            set
            {
                cabinAvailability = value;
            }
        }
/// <summary>
/// The CabinCapacity property
///
/// </summary>
///
        public virtual int? CabinCapacity
        {
            get
            {
                return cabinCapacity;
            }
            set
            {
                cabinCapacity = value;
            }
        }
/// <summary>
/// The PassengerCapacity property
///
/// </summary>
///
        public virtual int? PassengerCapacity
        {
            get
            {
                return passengerCapacity;
            }
            set
            {
                passengerCapacity = value;
            }
        }
/// <summary>
/// The PassengerAvailability property
///
/// </summary>
///
        public virtual EuTravel_2.BO.AvailabilityStatus PassengerAvailability
        {
            get
            {
                return passengerAvailability;
            }
            set
            {
                passengerAvailability = value;
            }
        }
/// <summary>
/// The VehicleAvailability property
///
/// </summary>
///
        public virtual EuTravel_2.BO.AvailabilityStatus VehicleAvailability
        {
            get
            {
                return vehicleAvailability;
            }
            set
            {
                vehicleAvailability = value;
            }
        }
/// <summary>
/// The VehicleCapacity property
///
/// </summary>
///
        public virtual int? VehicleCapacity
        {
            get
            {
                return vehicleCapacity;
            }
            set
            {
                vehicleCapacity = value;
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
        #region ShipFacilities's Participant Properties
        [DataMember(Name="MarineSegment")]
        protected MarineSegment marineSegment;
        public virtual MarineSegment MarineSegment
        {
            get
            {
                return marineSegment;
            }
            set
            {
                if(Equals(marineSegment, value)) return;
                var __oldValue = marineSegment;
                if (value != null)
                {
                    if(marineSegment != null && !Equals(marineSegment, value))
                        marineSegment.ShipFacilities = null;
                    marineSegment = value;
                    if(marineSegment.ShipFacilities != this)
                        marineSegment.ShipFacilities = this;
                }
                else
                {
                    if (marineSegment != null)
                    {
                        var __obj = marineSegment;
                        marineSegment = null;
                        __obj.ShipFacilities = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ShipFacilities class
/// </summary>
/// <returns>New ShipFacilities object</returns>
/// <remarks></remarks>
        public ShipFacilities() {}
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
                throw new BusinessException("An instance of TypeClass 'ShipFacilities' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ShipFacilities] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ShipFacilities Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ShipFacilities copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ShipFacilities)copiedObjects[this];
            copy = copy ?? new ShipFacilities();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.CabinMandatory = this.CabinMandatory;
            copy.CabinAvailability = this.CabinAvailability;
            copy.CabinCapacity = this.CabinCapacity;
            copy.PassengerCapacity = this.PassengerCapacity;
            copy.PassengerAvailability = this.PassengerAvailability;
            copy.VehicleAvailability = this.VehicleAvailability;
            copy.VehicleCapacity = this.VehicleCapacity;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.marineSegment != null)
            {
                if (!copiedObjects.Contains(this.marineSegment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.MarineSegment = this.MarineSegment;
                    else if (asNew)
                        copy.MarineSegment = this.MarineSegment.Copy(deep, copiedObjects, true);
                    else
                        copy.marineSegment = this.marineSegment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.MarineSegment = (MarineSegment)copiedObjects[this.MarineSegment];
                    else
                        copy.marineSegment = (MarineSegment)copiedObjects[this.MarineSegment];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ShipFacilities;
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
        protected bool HasSameNonDefaultIdAs(ShipFacilities compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
