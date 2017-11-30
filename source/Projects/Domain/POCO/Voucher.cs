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
    /// The Voucher class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Voucher : IDomainModelClass
    {
        #region Voucher's Fields

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
        [DataMember(Name="ConfirmationNumber")]
        protected string confirmationNumber;
        [DataMember(Name="AccountName")]
        protected string accountName;
        [DataMember(Name="Number")]
        protected string number;
        #endregion
        #region Voucher's Properties
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
/// The ConfirmationNumber property
///
/// </summary>
///
        public virtual string ConfirmationNumber
        {
            get
            {
                return confirmationNumber;
            }
            set
            {
                confirmationNumber = value;
            }
        }
/// <summary>
/// The AccountName property
///
/// </summary>
///
        public virtual string AccountName
        {
            get
            {
                return accountName;
            }
            set
            {
                accountName = value;
            }
        }
/// <summary>
/// The Number property
///
/// </summary>
///
        public virtual string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        #endregion
        #region Voucher's Participant Properties
        [DataMember(Name="VoucherType")]
        protected VoucherType voucherType;
        public virtual VoucherType VoucherType
        {
            get
            {
                return voucherType;
            }
            set
            {
                if(Equals(voucherType, value)) return;
                var __oldValue = voucherType;
                if (value != null)
                {
                    voucherType = value;
                }
                else
                {
                    voucherType = null;
                }
            }
        }
        [DataMember(Name="FormOfPayment")]
        protected FormOfPayment formOfPayment;
        public virtual FormOfPayment FormOfPayment
        {
            get
            {
                return formOfPayment;
            }
            set
            {
                if(Equals(formOfPayment, value)) return;
                var __oldValue = formOfPayment;
                if (value != null)
                {
                    if(formOfPayment != null && !Equals(formOfPayment, value))
                        formOfPayment.Voucher = null;
                    formOfPayment = value;
                    if(formOfPayment.Voucher != this)
                        formOfPayment.Voucher = this;
                }
                else
                {
                    if (formOfPayment != null)
                    {
                        var __obj = formOfPayment;
                        formOfPayment = null;
                        __obj.Voucher = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Voucher class
/// </summary>
/// <returns>New Voucher object</returns>
/// <remarks></remarks>
        public Voucher() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (ConfirmationNumber != null && ConfirmationNumber.Length > 100)
            {
                __errors.Add("Length of property 'ConfirmationNumber' cannot be greater than 100.");
            }
            if (AccountName != null && AccountName.Length > 100)
            {
                __errors.Add("Length of property 'AccountName' cannot be greater than 100.");
            }
            if (Number != null && Number.Length > 100)
            {
                __errors.Add("Length of property 'Number' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Voucher' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Voucher] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Voucher Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Voucher copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Voucher)copiedObjects[this];
            copy = copy ?? new Voucher();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ConfirmationNumber = this.ConfirmationNumber;
            copy.AccountName = this.AccountName;
            copy.Number = this.Number;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.voucherType != null)
            {
                if (!copiedObjects.Contains(this.voucherType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.VoucherType = this.VoucherType;
                    else if (asNew)
                        copy.VoucherType = this.VoucherType.Copy(deep, copiedObjects, true);
                    else
                        copy.voucherType = this.voucherType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.VoucherType = (VoucherType)copiedObjects[this.VoucherType];
                    else
                        copy.voucherType = (VoucherType)copiedObjects[this.VoucherType];
                }
            }
            if(deep && this.formOfPayment != null)
            {
                if (!copiedObjects.Contains(this.formOfPayment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FormOfPayment = this.FormOfPayment;
                    else if (asNew)
                        copy.FormOfPayment = this.FormOfPayment.Copy(deep, copiedObjects, true);
                    else
                        copy.formOfPayment = this.formOfPayment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FormOfPayment = (FormOfPayment)copiedObjects[this.FormOfPayment];
                    else
                        copy.formOfPayment = (FormOfPayment)copiedObjects[this.FormOfPayment];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Voucher;
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
        protected bool HasSameNonDefaultIdAs(Voucher compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
