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
    /// The PersonResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class PersonResponse : IDomainModelClass
    {
        #region PersonResponse's Fields

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
        [DataMember(Name="Message")]
        protected string message;
        [DataMember(Name="PersonResponseKey")]
        protected Guid? personResponseKey = Guid.Empty;
        #endregion
        #region PersonResponse's Properties
/// <summary>
/// The Message property
///
/// </summary>
///
        public virtual string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
/// <summary>
/// The PersonResponseKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? PersonResponseKey
        {
            get
            {
                return personResponseKey;
            }
            set
            {
                personResponseKey = value;
            }
        }
        #endregion
        #region PersonResponse's Participant Properties
        [DataMember(Name="Persons")]
        protected IList<EuTravelDiaryPersonDTO> persons = new List<EuTravelDiaryPersonDTO>();
        public virtual List<EuTravelDiaryPersonDTO> Persons
        {
            get
            {
                if (persons is EuTravelDiaryPersonDTO[])
                {
                    persons = persons.ToList();
                }
                if (persons == null)
                {
                    persons = new List<EuTravelDiaryPersonDTO>();
                }
                return persons.ToList();
            }
            set
            {
                if (persons is EuTravelDiaryPersonDTO[])
                {
                    persons = persons.ToList();
                }
                if (persons != null)
                {
                    var __itemsToDelete = new List<EuTravelDiaryPersonDTO>(persons);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePersons(__item);
                    }
                }
                if(value == null)
                {
                    persons = new List<EuTravelDiaryPersonDTO>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPersons(__item);
                }
            }
        }
        public virtual void AddPersons(IList<EuTravelDiaryPersonDTO> __items)
        {
            foreach (var __item in __items)
            {
                AddPersons(__item);
            }
        }
        public virtual void AddPersons(EuTravelDiaryPersonDTO __item)
        {
            if (__item != null && persons!=null && !persons.Contains(__item))
            {
                persons.Add(__item);
            }
        }

        public virtual void RemovePersons(EuTravelDiaryPersonDTO __item)
        {
            if (__item != null && persons!=null && persons.Contains(__item))
            {
                persons.Remove(__item);
            }
        }
        public virtual void SetPersonsAt(EuTravelDiaryPersonDTO __item, int __index)
        {
            if (__item == null)
            {
                persons[__index] = null;
            }
            else
            {
                persons[__index] = __item;
            }
        }

        public virtual void ClearPersons()
        {
            if (persons!=null)
            {
                var __itemsToRemove = persons.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePersons(__item);
                }
            }
        }
        [DataMember(Name="Person")]
        protected EuTravelDiaryPersonDTO person;
        public virtual EuTravelDiaryPersonDTO Person
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
                    person = value;
                }
                else
                {
                    if (person != null)
                    {
                        person = null;
                    }
                }
            }
        }
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
                    if (error != null)
                    {
                        error = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the PersonResponse class
/// </summary>
/// <returns>New PersonResponse object</returns>
/// <remarks></remarks>
        public PersonResponse()
        {
            if (PersonResponseKey == null) PersonResponseKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Message != null && Message.Length > 100)
            {
                __errors.Add("Length of property 'Message' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'PersonResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [PersonResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual PersonResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, PersonResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (PersonResponse)copiedObjects[this];
            copy = copy ?? new PersonResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.PersonResponseKey = this.PersonResponseKey;
            }
            copy.Message = this.Message;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.persons = new List<EuTravelDiaryPersonDTO>();
            if(deep && this.persons != null)
            {
                foreach (var __item in this.persons)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPersons(__item);
                        else
                            copy.AddPersons(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPersons((EuTravelDiaryPersonDTO)copiedObjects[__item]);
                    }
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
                        copy.Person = (EuTravelDiaryPersonDTO)copiedObjects[this.Person];
                    else
                        copy.person = (EuTravelDiaryPersonDTO)copiedObjects[this.Person];
                }
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
            var compareTo = obj as PersonResponse;
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
                __propertyKeyCache = this.GetType().GetProperty("PersonResponseKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.PersonResponseKey.GetHashCode();
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
            return this.PersonResponseKey == default(Guid) || this.PersonResponseKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(PersonResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.PersonResponseKey.Equals(compareTo.PersonResponseKey);
        }

        #endregion
    }
}
