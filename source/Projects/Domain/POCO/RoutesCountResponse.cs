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
    /// The RoutesCountResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class RoutesCountResponse : IDomainModelClass
    {
        #region RoutesCountResponse's Fields

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
        [DataMember(Name="MarineRoutes")]
        protected int? marineRoutes;
        [DataMember(Name="RailRoutes")]
        protected int? railRoutes;
        [DataMember(Name="UrbanRoutes")]
        protected int? urbanRoutes;
        [DataMember(Name="FlightRoutes")]
        protected int? flightRoutes;
        [DataMember(Name="MarineAgencies")]
        protected int? marineAgencies;
        [DataMember(Name="RailAgencies")]
        protected int? railAgencies;
        [DataMember(Name="UrbanAgencies")]
        protected int? urbanAgencies;
        [DataMember(Name="FlightAgencies")]
        protected int? flightAgencies;
        [DataMember(Name="RoutesCountResponseKey")]
        protected Guid? routesCountResponseKey = Guid.Empty;
        #endregion
        #region RoutesCountResponse's Properties
/// <summary>
/// The MarineRoutes property
///
/// </summary>
///
        public virtual int? MarineRoutes
        {
            get
            {
                return marineRoutes;
            }
            set
            {
                marineRoutes = value;
            }
        }
/// <summary>
/// The RailRoutes property
///
/// </summary>
///
        public virtual int? RailRoutes
        {
            get
            {
                return railRoutes;
            }
            set
            {
                railRoutes = value;
            }
        }
/// <summary>
/// The UrbanRoutes property
///
/// </summary>
///
        public virtual int? UrbanRoutes
        {
            get
            {
                return urbanRoutes;
            }
            set
            {
                urbanRoutes = value;
            }
        }
/// <summary>
/// The FlightRoutes property
///
/// </summary>
///
        public virtual int? FlightRoutes
        {
            get
            {
                return flightRoutes;
            }
            set
            {
                flightRoutes = value;
            }
        }
/// <summary>
/// The MarineAgencies property
///
/// </summary>
///
        public virtual int? MarineAgencies
        {
            get
            {
                return marineAgencies;
            }
            set
            {
                marineAgencies = value;
            }
        }
/// <summary>
/// The RailAgencies property
///
/// </summary>
///
        public virtual int? RailAgencies
        {
            get
            {
                return railAgencies;
            }
            set
            {
                railAgencies = value;
            }
        }
/// <summary>
/// The UrbanAgencies property
///
/// </summary>
///
        public virtual int? UrbanAgencies
        {
            get
            {
                return urbanAgencies;
            }
            set
            {
                urbanAgencies = value;
            }
        }
/// <summary>
/// The FlightAgencies property
///
/// </summary>
///
        public virtual int? FlightAgencies
        {
            get
            {
                return flightAgencies;
            }
            set
            {
                flightAgencies = value;
            }
        }
/// <summary>
/// The RoutesCountResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? RoutesCountResponseKey
        {
            get
            {
                return routesCountResponseKey;
            }
            set
            {
                routesCountResponseKey = value;
            }
        }
        #endregion
        #region RoutesCountResponse's Participant Properties
        [DataMember(Name="Error")]
        protected Error error;
        public virtual Error Error
        {
            get
            {
                return error;
            }
            set
            {
                if(Equals(error, value)) return;
                var __oldValue = error;
                if (value != null)
                {
                    error = value;
                }
                else
                {
                    error = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the RoutesCountResponse class
/// </summary>
/// <returns>New RoutesCountResponse object</returns>
/// <remarks></remarks>
        public RoutesCountResponse()
        {
            if (RoutesCountResponseKey == null) RoutesCountResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'RoutesCountResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [RoutesCountResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual RoutesCountResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, RoutesCountResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (RoutesCountResponse)copiedObjects[this];
            copy = copy ?? new RoutesCountResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.RoutesCountResponseKey = this.RoutesCountResponseKey;
            }
            copy.MarineRoutes = this.MarineRoutes;
            copy.RailRoutes = this.RailRoutes;
            copy.UrbanRoutes = this.UrbanRoutes;
            copy.FlightRoutes = this.FlightRoutes;
            copy.MarineAgencies = this.MarineAgencies;
            copy.RailAgencies = this.RailAgencies;
            copy.UrbanAgencies = this.UrbanAgencies;
            copy.FlightAgencies = this.FlightAgencies;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.error != null)
            {
                if (!copiedObjects.Contains(this.error))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Error = this.Error;
                    else if (asNew)
                        copy.Error = this.Error.Copy(deep, copiedObjects, true);
                    else
                        copy.error = this.error.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Error = (Error)copiedObjects[this.Error];
                    else
                        copy.error = (Error)copiedObjects[this.Error];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as RoutesCountResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("RoutesCountResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.RoutesCountResponseKey.GetHashCode();
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
            return this.RoutesCountResponseKey == default(Guid) || this.RoutesCountResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(RoutesCountResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.RoutesCountResponseKey.Equals(compareTo.RoutesCountResponseKey);
        }

        #endregion
    }
}
