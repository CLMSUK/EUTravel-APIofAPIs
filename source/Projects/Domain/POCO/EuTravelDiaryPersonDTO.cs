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
    /// The EuTravelDiaryPersonDTO class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class EuTravelDiaryPersonDTO : IDomainModelClass
    {
        #region EuTravelDiaryPersonDTO's Fields

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
        [DataMember(Name="Username")]
        protected string username;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Email")]
        protected string email;
        [DataMember(Name="PhoneNumber")]
        protected string phoneNumber;
        [DataMember(Name="Surname")]
        protected string surname;
        [DataMember(Name="EuTravelDiaryPersonDTOKey")]
        protected Guid? euTravelDiaryPersonDTOKey = Guid.Empty;
        #endregion
        #region EuTravelDiaryPersonDTO's Properties
/// <summary>
/// The Username property
///
/// </summary>
///
        public virtual string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
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
/// The Email property
///
/// </summary>
///
        public virtual string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
/// <summary>
/// The PhoneNumber property
///
/// </summary>
///
        public virtual string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
/// <summary>
/// The Surname property
///
/// </summary>
///
        public virtual string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
/// <summary>
/// The EuTravelDiaryPersonDTOKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? EuTravelDiaryPersonDTOKey
        {
            get
            {
                return euTravelDiaryPersonDTOKey;
            }
            set
            {
                euTravelDiaryPersonDTOKey = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the EuTravelDiaryPersonDTO class
/// </summary>
/// <returns>New EuTravelDiaryPersonDTO object</returns>
/// <remarks></remarks>
        public EuTravelDiaryPersonDTO()
        {
            if (EuTravelDiaryPersonDTOKey == null) EuTravelDiaryPersonDTOKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Username != null && Username.Length > 100)
            {
                __errors.Add("Length of property 'Username' cannot be greater than 100.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Email != null && Email.Length > 100)
            {
                __errors.Add("Length of property 'Email' cannot be greater than 100.");
            }
            if (PhoneNumber != null && PhoneNumber.Length > 100)
            {
                __errors.Add("Length of property 'PhoneNumber' cannot be greater than 100.");
            }
            if (Surname != null && Surname.Length > 100)
            {
                __errors.Add("Length of property 'Surname' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'EuTravelDiaryPersonDTO' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [EuTravelDiaryPersonDTO] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual EuTravelDiaryPersonDTO Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, EuTravelDiaryPersonDTO copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (EuTravelDiaryPersonDTO)copiedObjects[this];
            copy = copy ?? new EuTravelDiaryPersonDTO();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.EuTravelDiaryPersonDTOKey = this.EuTravelDiaryPersonDTOKey;
            }
            copy.Username = this.Username;
            copy.Name = this.Name;
            copy.Email = this.Email;
            copy.PhoneNumber = this.PhoneNumber;
            copy.Surname = this.Surname;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EuTravelDiaryPersonDTO;
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
                __propertyKeyCache = this.GetType().GetProperty("EuTravelDiaryPersonDTOKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.EuTravelDiaryPersonDTOKey.GetHashCode();
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
            return this.EuTravelDiaryPersonDTOKey == default(Guid) || this.EuTravelDiaryPersonDTOKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(EuTravelDiaryPersonDTO compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.EuTravelDiaryPersonDTOKey.Equals(compareTo.EuTravelDiaryPersonDTOKey);
        }

        #endregion
    }
}
