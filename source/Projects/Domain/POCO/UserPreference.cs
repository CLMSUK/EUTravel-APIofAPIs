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
    /// The UserPreference class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserPreference : IDomainModelClass
    {
        #region UserPreference's Fields

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
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="Popularity")]
        protected int? popularity;
        [DataMember(Name="PopularityPercentage")]
        protected float? popularityPercentage;
        #endregion
        #region UserPreference's Properties
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
/// The Name property
///
/// </summary>
///
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
/// <summary>
/// The Description property
///
/// </summary>
///
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
/// <summary>
/// The Popularity property
///
/// </summary>
///
        public virtual int? Popularity
        {
            get
            {
                return popularity;
            }
            set
            {
                popularity = value;
            }
        }
/// <summary>
/// The PopularityPercentage property
///
/// </summary>
///
        public virtual float? PopularityPercentage
        {
            get
            {
                return popularityPercentage;
            }
            set
            {
                popularityPercentage = value;
            }
        }
        #endregion
        #region UserPreference's Participant Properties
        [DataMember(Name="Type")]
        protected UserPreferenceType type;
        public virtual UserPreferenceType Type
        {
            get
            {
                return type;
            }
            set
            {
                if(Equals(type, value)) return;
                var __oldValue = type;
                if (value != null)
                {
                    type = value;
                }
                else
                {
                    if (type != null)
                    {
                        type = null;
                    }
                }
            }
        }
        [DataMember(Name="Service")]
        protected Service service;
        public virtual Service Service
        {
            get
            {
                return service;
            }
            set
            {
                if(Equals(service, value)) return;
                var __oldValue = service;
                if (value != null)
                {
                    if(service != null && !Equals(service, value))
                        service.RemoveUserPreferences(this);
                    service = value;
                    service.AddUserPreferences(this);
                }
                else
                {
                    if(service != null)
                        service.RemoveUserPreferences(this);
                    service = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UserPreference class
/// </summary>
/// <returns>New UserPreference object</returns>
/// <remarks></remarks>
        public UserPreference() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UserPreference' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UserPreference] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UserPreference Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UserPreference copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UserPreference)copiedObjects[this];
            copy = copy ?? new UserPreference();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Name = this.Name;
            copy.Description = this.Description;
            copy.Popularity = this.Popularity;
            copy.PopularityPercentage = this.PopularityPercentage;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.type != null)
            {
                if (!copiedObjects.Contains(this.type))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Type = this.Type;
                    else if (asNew)
                        copy.Type = this.Type.Copy(deep, copiedObjects, true);
                    else
                        copy.type = this.type.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Type = (UserPreferenceType)copiedObjects[this.Type];
                    else
                        copy.type = (UserPreferenceType)copiedObjects[this.Type];
                }
            }
            if(deep && this.service != null)
            {
                if (!copiedObjects.Contains(this.service))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Service = this.Service;
                    else if (asNew)
                        copy.Service = this.Service.Copy(deep, copiedObjects, true);
                    else
                        copy.service = this.service.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Service = (Service)copiedObjects[this.Service];
                    else
                        copy.service = (Service)copiedObjects[this.Service];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UserPreference;
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
        protected bool HasSameNonDefaultIdAs(UserPreference compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
