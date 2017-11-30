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
    /// The BookingResponse class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class BookingResponse : IDomainModelClass
    {
        #region BookingResponse's Fields

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
        [DataMember(Name="Message")]
        protected string message;
        [DataMember(Name="PNR")]
        protected string pNR;
        [DataMember(Name="Provider")]
        protected string provider;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region BookingResponse's Properties
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
/// The PNR property
///
/// </summary>
///
        public virtual string PNR
        {
            get
            {
                return pNR;
            }
            set
            {
                pNR = value;
            }
        }
/// <summary>
/// The Provider property
///
/// </summary>
///
        public virtual string Provider
        {
            get
            {
                return provider;
            }
            set
            {
                provider = value;
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
        #region BookingResponse's Participant Properties
        [DataMember(Name="Errors")]
        protected IList<Error> errors = new List<Error>();
        public virtual List<Error> Errors
        {
            get
            {
                if (errors is Error[])
                {
                    errors = errors.ToList();
                }
                if (errors == null)
                {
                    errors = new List<Error>();
                }
                return errors.ToList();
            }
            set
            {
                if (errors is Error[])
                {
                    errors = errors.ToList();
                }
                if (errors != null)
                {
                    var __itemsToDelete = new List<Error>(errors);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveErrors(__item);
                    }
                }
                if(value == null)
                {
                    errors = new List<Error>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddErrors(__item);
                }
            }
        }
        public virtual void AddErrors(IList<Error> __items)
        {
            foreach (var __item in __items)
            {
                AddErrors(__item);
            }
        }
        public virtual void AddErrors(Error __item)
        {
            if (__item != null && errors!=null && !errors.Contains(__item))
            {
                errors.Add(__item);
            }
        }

        public virtual void RemoveErrors(Error __item)
        {
            if (__item != null && errors!=null && errors.Contains(__item))
            {
                errors.Remove(__item);
            }
        }
        public virtual void SetErrorsAt(Error __item, int __index)
        {
            if (__item == null)
            {
                errors[__index] = null;
            }
            else
            {
                errors[__index] = __item;
            }
        }

        public virtual void ClearErrors()
        {
            if (errors!=null)
            {
                var __itemsToRemove = errors.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveErrors(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the BookingResponse class
/// </summary>
/// <returns>New BookingResponse object</returns>
/// <remarks></remarks>
        public BookingResponse() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Message != null && Message.Length > 100)
            {
                __errors.Add("Length of property 'Message' cannot be greater than 100.");
            }
            if (PNR != null && PNR.Length > 100)
            {
                __errors.Add("Length of property 'PNR' cannot be greater than 100.");
            }
            if (Provider != null && Provider.Length > 100)
            {
                __errors.Add("Length of property 'Provider' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'BookingResponse' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [BookingResponse] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual BookingResponse Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, BookingResponse copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (BookingResponse)copiedObjects[this];
            copy = copy ?? new BookingResponse();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Message = this.Message;
            copy.PNR = this.PNR;
            copy.Provider = this.Provider;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.errors = new List<Error>();
            if(deep && this.errors != null)
            {
                foreach (var __item in this.errors)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddErrors(__item);
                        else
                            copy.AddErrors(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddErrors((Error)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as BookingResponse;
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
        protected bool HasSameNonDefaultIdAs(BookingResponse compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
