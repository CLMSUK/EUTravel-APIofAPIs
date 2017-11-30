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
    /// The PersonHelperDTO class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class PersonHelperDTO : IDomainModelClass
    {
        #region PersonHelperDTO's Fields

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
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Surname")]
        protected string surname;
        [DataMember(Name="Phone")]
        protected string phone;
        [DataMember(Name="Email")]
        protected string email;
        [DataMember(Name="Age")]
        protected int? age;
        [DataMember(Name="DateOfBirth")]
        protected DateTime? dateOfBirth;
        [DataMember(Name="NationalityCode")]
        protected string nationalityCode;
        [DataMember(Name="Title")]
        protected EuTravel_2.BO.TitleEnum title;
        [DataMember(Name="Id")]
        protected int? id = 0;
        #endregion
        #region PersonHelperDTO's Properties
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
/// The Phone property
///
/// </summary>
///
        public virtual string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
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
/// The DateOfBirth property
///
/// </summary>
///
        public virtual DateTime? DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
/// <summary>
/// The NationalityCode property
///
/// </summary>
///
        public virtual string NationalityCode
        {
            get
            {
                return nationalityCode;
            }
            set
            {
                nationalityCode = value;
            }
        }
/// <summary>
/// The Title property
///
/// </summary>
///
        public virtual EuTravel_2.BO.TitleEnum Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
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
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the PersonHelperDTO class
/// </summary>
/// <returns>New PersonHelperDTO object</returns>
/// <remarks></remarks>
        public PersonHelperDTO() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Surname != null && Surname.Length > 100)
            {
                __errors.Add("Length of property 'Surname' cannot be greater than 100.");
            }
            if (Phone != null && Phone.Length > 100)
            {
                __errors.Add("Length of property 'Phone' cannot be greater than 100.");
            }
            if (Email != null && Email.Length > 100)
            {
                __errors.Add("Length of property 'Email' cannot be greater than 100.");
            }
            if (NationalityCode != null && NationalityCode.Length > 100)
            {
                __errors.Add("Length of property 'NationalityCode' cannot be greater than 100.");
            }
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'PersonHelperDTO' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [PersonHelperDTO] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual PersonHelperDTO Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, PersonHelperDTO copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (PersonHelperDTO)copiedObjects[this];
            copy = copy ?? new PersonHelperDTO();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Name = this.Name;
            copy.Surname = this.Surname;
            copy.Phone = this.Phone;
            copy.Email = this.Email;
            copy.Age = this.Age;
            copy.DateOfBirth = this.DateOfBirth;
            copy.NationalityCode = this.NationalityCode;
            copy.Title = this.Title;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as PersonHelperDTO;
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
        protected bool HasSameNonDefaultIdAs(PersonHelperDTO compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
