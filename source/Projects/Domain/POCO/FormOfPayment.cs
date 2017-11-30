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
    /// The FormOfPayment class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class FormOfPayment : IDomainModelClass
    {
        #region FormOfPayment's Fields

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
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="Key")]
        protected string key;
        #endregion
        #region FormOfPayment's Properties
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
/// The Key property
///
/// </summary>
///
        public virtual string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }
        #endregion
        #region FormOfPayment's Participant Properties
        [DataMember(Name="Voucher")]
        protected Voucher voucher;
        public virtual Voucher Voucher
        {
            get
            {
                return voucher;
            }
            set
            {
                if(Equals(voucher, value)) return;
                var __oldValue = voucher;
                if (value != null)
                {
                    if(voucher != null && !Equals(voucher, value))
                        voucher.FormOfPayment = null;
                    voucher = value;
                    if(voucher.FormOfPayment != this)
                        voucher.FormOfPayment = this;
                }
                else
                {
                    if (voucher != null)
                    {
                        var __obj = voucher;
                        voucher = null;
                        __obj.FormOfPayment = null;
                    }
                }
            }
        }
        [DataMember(Name="Guarantee")]
        protected Guarantee guarantee;
        public virtual Guarantee Guarantee
        {
            get
            {
                return guarantee;
            }
            set
            {
                if(Equals(guarantee, value)) return;
                var __oldValue = guarantee;
                if (value != null)
                {
                    if(guarantee != null && !Equals(guarantee, value))
                        guarantee.FormOfPayment = null;
                    guarantee = value;
                    if(guarantee.FormOfPayment != this)
                        guarantee.FormOfPayment = this;
                }
                else
                {
                    if (guarantee != null)
                    {
                        var __obj = guarantee;
                        guarantee = null;
                        __obj.FormOfPayment = null;
                    }
                }
            }
        }
        [DataMember(Name="Cash")]
        protected Cash cash;
        public virtual Cash Cash
        {
            get
            {
                return cash;
            }
            set
            {
                if(Equals(cash, value)) return;
                var __oldValue = cash;
                if (value != null)
                {
                    if(cash != null && !Equals(cash, value))
                        cash.FormOfPayment = null;
                    cash = value;
                    if(cash.FormOfPayment != this)
                        cash.FormOfPayment = this;
                }
                else
                {
                    if (cash != null)
                    {
                        var __obj = cash;
                        cash = null;
                        __obj.FormOfPayment = null;
                    }
                }
            }
        }
        [DataMember(Name="CreditCard")]
        protected CreditCard creditCard;
        public virtual CreditCard CreditCard
        {
            get
            {
                return creditCard;
            }
            set
            {
                if(Equals(creditCard, value)) return;
                var __oldValue = creditCard;
                if (value != null)
                {
                    if(creditCard != null && !Equals(creditCard, value))
                        creditCard.FormOfPayment = null;
                    creditCard = value;
                    if(creditCard.FormOfPayment != this)
                        creditCard.FormOfPayment = this;
                }
                else
                {
                    if (creditCard != null)
                    {
                        var __obj = creditCard;
                        creditCard = null;
                        __obj.FormOfPayment = null;
                    }
                }
            }
        }
        [DataMember(Name="EnettVan")]
        protected EnettVan enettVan;
        public virtual EnettVan EnettVan
        {
            get
            {
                return enettVan;
            }
            set
            {
                if(Equals(enettVan, value)) return;
                var __oldValue = enettVan;
                if (value != null)
                {
                    enettVan = value;
                }
                else
                {
                    if (enettVan != null)
                    {
                        enettVan = null;
                    }
                }
            }
        }
        [DataMember(Name="Payment")]
        protected Payment payment;
        public virtual Payment Payment
        {
            get
            {
                return payment;
            }
            set
            {
                if(Equals(payment, value)) return;
                var __oldValue = payment;
                if (value != null)
                {
                    if(payment != null && !Equals(payment, value))
                        payment.FormOfPayment = null;
                    payment = value;
                    if(payment.FormOfPayment != this)
                        payment.FormOfPayment = this;
                }
                else
                {
                    if (payment != null)
                    {
                        var __obj = payment;
                        payment = null;
                        __obj.FormOfPayment = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the FormOfPayment class
/// </summary>
/// <returns>New FormOfPayment object</returns>
/// <remarks></remarks>
        public FormOfPayment() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (Key != null && Key.Length > 100)
            {
                __errors.Add("Length of property 'Key' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'FormOfPayment' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [FormOfPayment] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual FormOfPayment Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, FormOfPayment copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (FormOfPayment)copiedObjects[this];
            copy = copy ?? new FormOfPayment();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Description = this.Description;
            copy.Key = this.Key;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.voucher != null)
            {
                if (!copiedObjects.Contains(this.voucher))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Voucher = this.Voucher;
                    else if (asNew)
                        copy.Voucher = this.Voucher.Copy(deep, copiedObjects, true);
                    else
                        copy.voucher = this.voucher.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Voucher = (Voucher)copiedObjects[this.Voucher];
                    else
                        copy.voucher = (Voucher)copiedObjects[this.Voucher];
                }
            }
            if(deep && this.guarantee != null)
            {
                if (!copiedObjects.Contains(this.guarantee))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Guarantee = this.Guarantee;
                    else if (asNew)
                        copy.Guarantee = this.Guarantee.Copy(deep, copiedObjects, true);
                    else
                        copy.guarantee = this.guarantee.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Guarantee = (Guarantee)copiedObjects[this.Guarantee];
                    else
                        copy.guarantee = (Guarantee)copiedObjects[this.Guarantee];
                }
            }
            if(deep && this.cash != null)
            {
                if (!copiedObjects.Contains(this.cash))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Cash = this.Cash;
                    else if (asNew)
                        copy.Cash = this.Cash.Copy(deep, copiedObjects, true);
                    else
                        copy.cash = this.cash.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Cash = (Cash)copiedObjects[this.Cash];
                    else
                        copy.cash = (Cash)copiedObjects[this.Cash];
                }
            }
            if(deep && this.creditCard != null)
            {
                if (!copiedObjects.Contains(this.creditCard))
                {
                    if (asNew && reuseNestedObjects)
                        copy.CreditCard = this.CreditCard;
                    else if (asNew)
                        copy.CreditCard = this.CreditCard.Copy(deep, copiedObjects, true);
                    else
                        copy.creditCard = this.creditCard.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.CreditCard = (CreditCard)copiedObjects[this.CreditCard];
                    else
                        copy.creditCard = (CreditCard)copiedObjects[this.CreditCard];
                }
            }
            if(deep && this.enettVan != null)
            {
                if (!copiedObjects.Contains(this.enettVan))
                {
                    if (asNew && reuseNestedObjects)
                        copy.EnettVan = this.EnettVan;
                    else if (asNew)
                        copy.EnettVan = this.EnettVan.Copy(deep, copiedObjects, true);
                    else
                        copy.enettVan = this.enettVan.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.EnettVan = (EnettVan)copiedObjects[this.EnettVan];
                    else
                        copy.enettVan = (EnettVan)copiedObjects[this.EnettVan];
                }
            }
            if(deep && this.payment != null)
            {
                if (!copiedObjects.Contains(this.payment))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Payment = this.Payment;
                    else if (asNew)
                        copy.Payment = this.Payment.Copy(deep, copiedObjects, true);
                    else
                        copy.payment = this.payment.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Payment = (Payment)copiedObjects[this.Payment];
                    else
                        copy.payment = (Payment)copiedObjects[this.Payment];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as FormOfPayment;
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
        protected bool HasSameNonDefaultIdAs(FormOfPayment compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
