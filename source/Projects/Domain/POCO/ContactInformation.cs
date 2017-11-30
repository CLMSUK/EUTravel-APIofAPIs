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
    /// The ContactInformation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class ContactInformation : IDomainModelClass
    {
        #region ContactInformation's Fields

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
        [DataMember(Name="Phone")]
        protected string phone;
        [DataMember(Name="Fax")]
        protected string fax;
        [DataMember(Name="Email")]
        protected string email;
        #endregion
        #region ContactInformation's Properties
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
/// The Fax property
///
/// </summary>
///
        public virtual string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
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
        #endregion
        #region ContactInformation's Participant Properties
        [DataMember(Name="Address")]
        protected PostalAddress address;
        public virtual PostalAddress Address
        {
            get
            {
                return address;
            }
            set
            {
                if(Equals(address, value)) return;
                var __oldValue = address;
                if (value != null)
                {
                    address = value;
                }
                else
                {
                    address = null;
                }
            }
        }
        [DataMember(Name="Person")]
        protected Person person;
        public virtual Person Person
        {
            get
            {
                return person;
            }
            set
            {
                if(Equals(person, value)) return;
                var __oldValue = person;
                if (value != null)
                {
                    if(person != null && !Equals(person, value))
                        person.ContactInformation = null;
                    person = value;
                    if(person.ContactInformation != this)
                        person.ContactInformation = this;
                }
                else
                {
                    if (person != null)
                    {
                        var __obj = person;
                        person = null;
                        __obj.ContactInformation = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the ContactInformation class
/// </summary>
/// <returns>New ContactInformation object</returns>
/// <remarks></remarks>
        public ContactInformation() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Phone != null && Phone.Length > 100)
            {
                __errors.Add("Length of property 'Phone' cannot be greater than 100.");
            }
            if (Fax != null && Fax.Length > 100)
            {
                __errors.Add("Length of property 'Fax' cannot be greater than 100.");
            }
            if (Email != null && Email.Length > 100)
            {
                __errors.Add("Length of property 'Email' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'ContactInformation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [ContactInformation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual ContactInformation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, ContactInformation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (ContactInformation)copiedObjects[this];
            copy = copy ?? new ContactInformation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Phone = this.Phone;
            copy.Fax = this.Fax;
            copy.Email = this.Email;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.address != null)
            {
                if (!copiedObjects.Contains(this.address))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Address = this.Address;
                    else if (asNew)
                        copy.Address = this.Address.Copy(deep, copiedObjects, true);
                    else
                        copy.address = this.address.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Address = (PostalAddress)copiedObjects[this.Address];
                    else
                        copy.address = (PostalAddress)copiedObjects[this.Address];
                }
            }
            if(deep && this.person != null)
            {
                if (!copiedObjects.Contains(this.person))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Person = this.Person;
                    else if (asNew)
                        copy.Person = this.Person.Copy(deep, copiedObjects, true);
                    else
                        copy.person = this.person.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Person = (Person)copiedObjects[this.Person];
                    else
                        copy.person = (Person)copiedObjects[this.Person];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as ContactInformation;
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
        protected bool HasSameNonDefaultIdAs(ContactInformation compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
