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
    /// The CreditCard class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class CreditCard : IDomainModelClass
    {
        #region CreditCard's Fields

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
        [DataMember(Name="Number")]
        protected string number;
        [DataMember(Name="ExpirationDate")]
        protected DateTime? expirationDate;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="CVV")]
        protected string cVV;
        [DataMember(Name="ApprovalCode")]
        protected string approvalCode;
        [DataMember(Name="ExtendedPayment")]
        protected string extendedPayment;
        [DataMember(Name="CustomerReference")]
        protected string customerReference;
        [DataMember(Name="ThirdPartyPayment")]
        protected bool thirdPartyPayment;
        [DataMember(Name="Enett")]
        protected bool enett;
        [DataMember(Name="Active")]
        protected bool active;
        #endregion
        #region CreditCard's Properties
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
/// <summary>
/// The ExpirationDate property
///
/// </summary>
///
        public virtual DateTime? ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                expirationDate = value;
            }
        }
/// <summary>
/// The Name property
///Name as it appears on the card.
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
/// The CVV property
///
/// </summary>
///
        public virtual string CVV
        {
            get
            {
                return cVV;
            }
            set
            {
                cVV = value;
            }
        }
/// <summary>
/// The ApprovalCode property
///
/// </summary>
///
        public virtual string ApprovalCode
        {
            get
            {
                return approvalCode;
            }
            set
            {
                approvalCode = value;
            }
        }
/// <summary>
/// The ExtendedPayment property
///Used for AMEX cards
/// </summary>
///
        public virtual string ExtendedPayment
        {
            get
            {
                return extendedPayment;
            }
            set
            {
                extendedPayment = value;
            }
        }
/// <summary>
/// The CustomerReference property
///
/// </summary>
///
        public virtual string CustomerReference
        {
            get
            {
                return customerReference;
            }
            set
            {
                customerReference = value;
            }
        }
/// <summary>
/// The ThirdPartyPayment property
///
/// </summary>
///
        public virtual bool ThirdPartyPayment
        {
            get
            {
                return thirdPartyPayment;
            }
            set
            {
                thirdPartyPayment = value;
            }
        }
/// <summary>
/// The Enett property
///
/// </summary>
///
        public virtual bool Enett
        {
            get
            {
                return enett;
            }
            set
            {
                enett = value;
            }
        }
/// <summary>
/// The Active property
///
/// </summary>
///
        public virtual bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
        #endregion
        #region CreditCard's Participant Properties
        [DataMember(Name="CardType")]
        protected CardType cardType;
        public virtual CardType CardType
        {
            get
            {
                return cardType;
            }
            set
            {
                if(Equals(cardType, value)) return;
                var __oldValue = cardType;
                if (value != null)
                {
                    cardType = value;
                }
                else
                {
                    cardType = null;
                }
            }
        }
        [DataMember(Name="Passenger")]
        protected Passenger passenger;
        public virtual Passenger Passenger
        {
            get
            {
                return passenger;
            }
            set
            {
                if(Equals(passenger, value)) return;
                var __oldValue = passenger;
                if (value != null)
                {
                    if(passenger != null && !Equals(passenger, value))
                        passenger.RemoveCreditCards(this);
                    passenger = value;
                    passenger.AddCreditCards(this);
                }
                else
                {
                    if(passenger != null)
                        passenger.RemoveCreditCards(this);
                    passenger = null;
                }
            }
        }
        [DataMember(Name="BillingAddress")]
        protected PostalAddress billingAddress;
        public virtual PostalAddress BillingAddress
        {
            get
            {
                return billingAddress;
            }
            set
            {
                if(Equals(billingAddress, value)) return;
                var __oldValue = billingAddress;
                if (value != null)
                {
                    billingAddress = value;
                }
                else
                {
                    billingAddress = null;
                }
            }
        }
        [DataMember(Name="Bank")]
        protected Bank bank;
        public virtual Bank Bank
        {
            get
            {
                return bank;
            }
            set
            {
                if(Equals(bank, value)) return;
                var __oldValue = bank;
                if (value != null)
                {
                    bank = value;
                }
                else
                {
                    bank = null;
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
                        formOfPayment.CreditCard = null;
                    formOfPayment = value;
                    if(formOfPayment.CreditCard != this)
                        formOfPayment.CreditCard = this;
                }
                else
                {
                    if (formOfPayment != null)
                    {
                        var __obj = formOfPayment;
                        formOfPayment = null;
                        __obj.CreditCard = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the CreditCard class
/// </summary>
/// <returns>New CreditCard object</returns>
/// <remarks></remarks>
        public CreditCard() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Number != null && Number.Length > 100)
            {
                __errors.Add("Length of property 'Number' cannot be greater than 100.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (CVV != null && CVV.Length > 100)
            {
                __errors.Add("Length of property 'CVV' cannot be greater than 100.");
            }
            if (ApprovalCode != null && ApprovalCode.Length > 100)
            {
                __errors.Add("Length of property 'ApprovalCode' cannot be greater than 100.");
            }
            if (ExtendedPayment != null && ExtendedPayment.Length > 100)
            {
                __errors.Add("Length of property 'ExtendedPayment' cannot be greater than 100.");
            }
            if (CustomerReference != null && CustomerReference.Length > 100)
            {
                __errors.Add("Length of property 'CustomerReference' cannot be greater than 100.");
            }
            if (Passenger == null)
            {
                __errors.Add("Association with 'Passenger' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'CreditCard' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [CreditCard] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual CreditCard Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, CreditCard copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (CreditCard)copiedObjects[this];
            copy = copy ?? new CreditCard();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Number = this.Number;
            copy.ExpirationDate = this.ExpirationDate;
            copy.Name = this.Name;
            copy.CVV = this.CVV;
            copy.ApprovalCode = this.ApprovalCode;
            copy.ExtendedPayment = this.ExtendedPayment;
            copy.CustomerReference = this.CustomerReference;
            copy.ThirdPartyPayment = this.ThirdPartyPayment;
            copy.Enett = this.Enett;
            copy.Active = this.Active;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.cardType != null)
            {
                if (!copiedObjects.Contains(this.cardType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.CardType = this.CardType;
                    else if (asNew)
                        copy.CardType = this.CardType.Copy(deep, copiedObjects, true);
                    else
                        copy.cardType = this.cardType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.CardType = (CardType)copiedObjects[this.CardType];
                    else
                        copy.cardType = (CardType)copiedObjects[this.CardType];
                }
            }
            if(deep && this.passenger != null)
            {
                if (!copiedObjects.Contains(this.passenger))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Passenger = this.Passenger;
                    else if (asNew)
                        copy.Passenger = this.Passenger.Copy(deep, copiedObjects, true);
                    else
                        copy.passenger = this.passenger.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Passenger = (Passenger)copiedObjects[this.Passenger];
                    else
                        copy.passenger = (Passenger)copiedObjects[this.Passenger];
                }
            }
            if(deep && this.billingAddress != null)
            {
                if (!copiedObjects.Contains(this.billingAddress))
                {
                    if (asNew && reuseNestedObjects)
                        copy.BillingAddress = this.BillingAddress;
                    else if (asNew)
                        copy.BillingAddress = this.BillingAddress.Copy(deep, copiedObjects, true);
                    else
                        copy.billingAddress = this.billingAddress.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.BillingAddress = (PostalAddress)copiedObjects[this.BillingAddress];
                    else
                        copy.billingAddress = (PostalAddress)copiedObjects[this.BillingAddress];
                }
            }
            if(deep && this.bank != null)
            {
                if (!copiedObjects.Contains(this.bank))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Bank = this.Bank;
                    else if (asNew)
                        copy.Bank = this.Bank.Copy(deep, copiedObjects, true);
                    else
                        copy.bank = this.bank.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Bank = (Bank)copiedObjects[this.Bank];
                    else
                        copy.bank = (Bank)copiedObjects[this.Bank];
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
            var compareTo = obj as CreditCard;
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
        protected bool HasSameNonDefaultIdAs(CreditCard compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
