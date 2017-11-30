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
    /// The UserPreferences class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserPreferences : IDomainModelClass
    {
        #region UserPreferences's Fields

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
        [DataMember(Name="TravelDuration")]
        protected int? travelDuration;
        [DataMember(Name="Distance")]
        protected int? distance;
        [DataMember(Name="PriceOrdering")]
        protected bool priceOrdering;
        [DataMember(Name="SpecialAssistance")]
        protected bool specialAssistance;
        [DataMember(Name="CarbonEmission")]
        protected bool carbonEmission;
        [DataMember(Name="MaximumReturnedSolutions")]
        protected int? maximumReturnedSolutions;
        [DataMember(Name="LeastTransportModeChanges")]
        protected bool leastTransportModeChanges;
        [DataMember(Name="PreferredMeansOfTransport")]
        protected string preferredMeansOfTransport;
        [DataMember(Name="UserPreferencesKey")]
        protected Guid? userPreferencesKey = Guid.Empty;
        #endregion
        #region UserPreferences's Properties
/// <summary>
/// The TravelDuration property
///
/// </summary>
///
        public virtual int? TravelDuration
        {
            get
            {
                return travelDuration;
            }
            set
            {
                travelDuration = value;
            }
        }
/// <summary>
/// The Distance property
///
/// </summary>
///
        public virtual int? Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }
/// <summary>
/// The PriceOrdering property
///
/// </summary>
///
        public virtual bool PriceOrdering
        {
            get
            {
                return priceOrdering;
            }
            set
            {
                priceOrdering = value;
            }
        }
/// <summary>
/// The SpecialAssistance property
///
/// </summary>
///
        public virtual bool SpecialAssistance
        {
            get
            {
                return specialAssistance;
            }
            set
            {
                specialAssistance = value;
            }
        }
/// <summary>
/// The CarbonEmission property
///
/// </summary>
///
        public virtual bool CarbonEmission
        {
            get
            {
                return carbonEmission;
            }
            set
            {
                carbonEmission = value;
            }
        }
/// <summary>
/// The MaximumReturnedSolutions property
///
/// </summary>
///
        public virtual int? MaximumReturnedSolutions
        {
            get
            {
                return maximumReturnedSolutions;
            }
            set
            {
                maximumReturnedSolutions = value;
            }
        }
/// <summary>
/// The LeastTransportModeChanges property
///
/// </summary>
///
        public virtual bool LeastTransportModeChanges
        {
            get
            {
                return leastTransportModeChanges;
            }
            set
            {
                leastTransportModeChanges = value;
            }
        }
/// <summary>
/// The PreferredMeansOfTransport property
///
/// </summary>
///
        public virtual string PreferredMeansOfTransport
        {
            get
            {
                return preferredMeansOfTransport;
            }
            set
            {
                preferredMeansOfTransport = value;
            }
        }
/// <summary>
/// The UserPreferencesKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? UserPreferencesKey
        {
            get
            {
                return userPreferencesKey;
            }
            set
            {
                userPreferencesKey = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UserPreferences class
/// </summary>
/// <returns>New UserPreferences object</returns>
/// <remarks></remarks>
        public UserPreferences()
        {
            if (UserPreferencesKey == null) UserPreferencesKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (PreferredMeansOfTransport != null && PreferredMeansOfTransport.Length > 100)
            {
                __errors.Add("Length of property 'PreferredMeansOfTransport' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UserPreferences' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UserPreferences] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UserPreferences Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UserPreferences copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UserPreferences)copiedObjects[this];
            copy = copy ?? new UserPreferences();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.UserPreferencesKey = this.UserPreferencesKey;
            }
            copy.TravelDuration = this.TravelDuration;
            copy.Distance = this.Distance;
            copy.PriceOrdering = this.PriceOrdering;
            copy.SpecialAssistance = this.SpecialAssistance;
            copy.CarbonEmission = this.CarbonEmission;
            copy.MaximumReturnedSolutions = this.MaximumReturnedSolutions;
            copy.LeastTransportModeChanges = this.LeastTransportModeChanges;
            copy.PreferredMeansOfTransport = this.PreferredMeansOfTransport;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UserPreferences;
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
                __propertyKeyCache = this.GetType().GetProperty("UserPreferencesKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.UserPreferencesKey.GetHashCode();
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
            return this.UserPreferencesKey == default(Guid) || this.UserPreferencesKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(UserPreferences compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.UserPreferencesKey.Equals(compareTo.UserPreferencesKey);
        }

        #endregion
    }
}
