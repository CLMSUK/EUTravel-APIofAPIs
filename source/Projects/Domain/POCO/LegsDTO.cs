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
    /// The LegsDTO class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class LegsDTO : IDomainModelClass
    {
        #region LegsDTO's Fields

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
        [DataMember(Name="Origin")]
        protected string origin;
        [DataMember(Name="Destination")]
        protected string destination;
        [DataMember(Name="type")]
        protected int? _type;
        [DataMember(Name="CO2")]
        protected int? cO2;
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="DepartureDate")]
        protected DateTime? departureDate;
        [DataMember(Name="JourneyID")]
        protected int? journeyID;
        [DataMember(Name="LegID")]
        protected int? legID;
        [DataMember(Name="UrbanID")]
        protected string urbanID;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region LegsDTO's Properties
/// <summary>
/// The Origin property
///
/// </summary>
///
        public virtual string Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }
/// <summary>
/// The Destination property
///
/// </summary>
///
        public virtual string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }
/// <summary>
/// The type property
///
/// </summary>
///
        public virtual int? type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
/// <summary>
/// The CO2 property
///
/// </summary>
///
        public virtual int? CO2
        {
            get
            {
                return cO2;
            }
            set
            {
                cO2 = value;
            }
        }
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
/// The JourneyID property
///
/// </summary>
///
        public virtual int? JourneyID
        {
            get
            {
                return journeyID;
            }
            set
            {
                journeyID = value;
            }
        }
/// <summary>
/// The LegID property
///
/// </summary>
///
        public virtual int? LegID
        {
            get
            {
                return legID;
            }
            set
            {
                legID = value;
            }
        }
/// <summary>
/// The UrbanID property
///
/// </summary>
///
        public virtual string UrbanID
        {
            get
            {
                return urbanID;
            }
            set
            {
                urbanID = value;
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
        #region LegsDTO's Participant Properties
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
                    if (travelClass != null)
                    {
                        travelClass = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the LegsDTO class
/// </summary>
/// <returns>New LegsDTO object</returns>
/// <remarks></remarks>
        public LegsDTO() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Origin != null && Origin.Length > 100)
            {
                __errors.Add("Length of property 'Origin' cannot be greater than 100.");
            }
            if (Destination != null && Destination.Length > 100)
            {
                __errors.Add("Length of property 'Destination' cannot be greater than 100.");
            }
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (UrbanID != null && UrbanID.Length > 100)
            {
                __errors.Add("Length of property 'UrbanID' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'LegsDTO' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [LegsDTO] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual LegsDTO Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, LegsDTO copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (LegsDTO)copiedObjects[this];
            copy = copy ?? new LegsDTO();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Origin = this.Origin;
            copy.Destination = this.Destination;
            copy.type = this.type;
            copy.CO2 = this.CO2;
            copy.DepartureDate = this.DepartureDate;
            copy.JourneyID = this.JourneyID;
            copy.LegID = this.LegID;
            copy.UrbanID = this.UrbanID;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
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
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as LegsDTO;
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
        protected bool HasSameNonDefaultIdAs(LegsDTO compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
