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
    /// The LegConfirmation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class LegConfirmation : IDomainModelClass
    {
        #region LegConfirmation's Fields

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
        [DataMember(Name="Success")]
        protected bool success;
        [DataMember(Name="Message")]
        protected string message;
        [DataMember(Name="LegID")]
        protected int? legID;
        [DataMember(Name="LegConfirmationKey")]
        protected Guid? legConfirmationKey = Guid.Empty;
        #endregion
        #region LegConfirmation's Properties
/// <summary>
/// The Success property
///
/// </summary>
///
        public virtual bool Success
        {
            get
            {
                return success;
            }
            set
            {
                success = value;
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
/// The LegConfirmationKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? LegConfirmationKey
        {
            get
            {
                return legConfirmationKey;
            }
            set
            {
                legConfirmationKey = value;
            }
        }
        #endregion
        #region LegConfirmation's Participant Properties
        [DataMember(Name="BookingConfirmation")]
        protected BookingConfirmation bookingConfirmation;
        public virtual BookingConfirmation BookingConfirmation
        {
            get
            {
                return bookingConfirmation;
            }
            set
            {
                if(Equals(bookingConfirmation, value)) return;
                var __oldValue = bookingConfirmation;
                if (value != null)
                {
                    if(bookingConfirmation != null && !Equals(bookingConfirmation, value))
                        bookingConfirmation.RemoveLegs(this);
                    bookingConfirmation = value;
                    bookingConfirmation.AddLegs(this);
                }
                else
                {
                    if(bookingConfirmation != null)
                        bookingConfirmation.RemoveLegs(this);
                    bookingConfirmation = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the LegConfirmation class
/// </summary>
/// <returns>New LegConfirmation object</returns>
/// <remarks></remarks>
        public LegConfirmation()
        {
            if (LegConfirmationKey == null) LegConfirmationKey = Guid.NewGuid();
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
                throw new BusinessException("An instance of TypeClass 'LegConfirmation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [LegConfirmation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual LegConfirmation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, LegConfirmation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (LegConfirmation)copiedObjects[this];
            copy = copy ?? new LegConfirmation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.LegConfirmationKey = this.LegConfirmationKey;
            }
            copy.Success = this.Success;
            copy.Message = this.Message;
            copy.LegID = this.LegID;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.bookingConfirmation != null)
            {
                if (!copiedObjects.Contains(this.bookingConfirmation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.BookingConfirmation = this.BookingConfirmation;
                    else if (asNew)
                        copy.BookingConfirmation = this.BookingConfirmation.Copy(deep, copiedObjects, true);
                    else
                        copy.bookingConfirmation = this.bookingConfirmation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.BookingConfirmation = (BookingConfirmation)copiedObjects[this.BookingConfirmation];
                    else
                        copy.bookingConfirmation = (BookingConfirmation)copiedObjects[this.BookingConfirmation];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as LegConfirmation;
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
                __propertyKeyCache = this.GetType().GetProperty("LegConfirmationKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.LegConfirmationKey.GetHashCode();
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
            return this.LegConfirmationKey == default(Guid) || this.LegConfirmationKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(LegConfirmation compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.LegConfirmationKey.Equals(compareTo.LegConfirmationKey);
        }

        #endregion
    }
}
