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
    /// The Passenger class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Person))]

    public class Passenger : Person, IDomainModelClass
    {
        #region Passenger's Fields
        [DataMember(Name="Accompanied")]
        protected bool accompanied;
        #endregion
        #region Passenger's Properties
/// <summary>
/// The Accompanied property
///
/// </summary>
///
        public virtual bool Accompanied
        {
            get
            {
                return accompanied;
            }
            set
            {
                accompanied = value;
            }
        }
        #endregion
        #region Passenger's Participant Properties
        [DataMember(Name="LoyaltyCards")]
        protected IList<LoyaltyCard> loyaltyCards = new List<LoyaltyCard>();
        public virtual List<LoyaltyCard> LoyaltyCards
        {
            get
            {
                if (loyaltyCards is LoyaltyCard[])
                {
                    loyaltyCards = loyaltyCards.ToList();
                }
                if (loyaltyCards == null)
                {
                    loyaltyCards = new List<LoyaltyCard>();
                }
                return loyaltyCards.ToList();
            }
            set
            {
                if (loyaltyCards is LoyaltyCard[])
                {
                    loyaltyCards = loyaltyCards.ToList();
                }
                if (loyaltyCards != null)
                {
                    var __itemsToDelete = new List<LoyaltyCard>(loyaltyCards);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveLoyaltyCards(__item);
                    }
                }
                if(value == null)
                {
                    loyaltyCards = new List<LoyaltyCard>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddLoyaltyCards(__item);
                }
            }
        }
        public virtual void AddLoyaltyCards(IList<LoyaltyCard> __items)
        {
            foreach (var __item in __items)
            {
                AddLoyaltyCards(__item);
            }
        }
        public virtual void AddLoyaltyCards(LoyaltyCard __item)
        {
            if (__item != null && loyaltyCards!=null && !loyaltyCards.Contains(__item))
            {
                loyaltyCards.Add(__item);
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void RemoveLoyaltyCards(LoyaltyCard __item)
        {
            if (__item != null && loyaltyCards!=null && loyaltyCards.Contains(__item))
            {
                loyaltyCards.Remove(__item);
                __item.Passenger = null;
            }
        }
        public virtual void SetLoyaltyCardsAt(LoyaltyCard __item, int __index)
        {
            if (__item == null)
            {
                loyaltyCards[__index].Passenger = null;
            }
            else
            {
                loyaltyCards[__index] = __item;
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void ClearLoyaltyCards()
        {
            if (loyaltyCards!=null)
            {
                var __itemsToRemove = loyaltyCards.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveLoyaltyCards(__item);
                }
            }
        }
        [DataMember(Name="PassengerCategory")]
        protected PassengerCategory passengerCategory;
        public virtual PassengerCategory PassengerCategory
        {
            get
            {
                return passengerCategory;
            }
            set
            {
                if(Equals(passengerCategory, value)) return;
                var __oldValue = passengerCategory;
                if (value != null)
                {
                    passengerCategory = value;
                }
                else
                {
                    passengerCategory = null;
                }
            }
        }
        [DataMember(Name="PostalAddress")]
        protected IList<PostalAddress> postalAddress = new List<PostalAddress>();
        public virtual List<PostalAddress> PostalAddress
        {
            get
            {
                if (postalAddress is PostalAddress[])
                {
                    postalAddress = postalAddress.ToList();
                }
                if (postalAddress == null)
                {
                    postalAddress = new List<PostalAddress>();
                }
                return postalAddress.ToList();
            }
            set
            {
                if (postalAddress is PostalAddress[])
                {
                    postalAddress = postalAddress.ToList();
                }
                if (postalAddress != null)
                {
                    var __itemsToDelete = new List<PostalAddress>(postalAddress);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePostalAddress(__item);
                    }
                }
                if(value == null)
                {
                    postalAddress = new List<PostalAddress>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPostalAddress(__item);
                }
            }
        }
        public virtual void AddPostalAddress(IList<PostalAddress> __items)
        {
            foreach (var __item in __items)
            {
                AddPostalAddress(__item);
            }
        }
        public virtual void AddPostalAddress(PostalAddress __item)
        {
            if (__item != null && postalAddress!=null && !postalAddress.Contains(__item))
            {
                postalAddress.Add(__item);
            }
        }

        public virtual void RemovePostalAddress(PostalAddress __item)
        {
            if (__item != null && postalAddress!=null && postalAddress.Contains(__item))
            {
                postalAddress.Remove(__item);
            }
        }
        public virtual void SetPostalAddressAt(PostalAddress __item, int __index)
        {
            if (__item == null)
            {
                postalAddress[__index] = null;
            }
            else
            {
                postalAddress[__index] = __item;
            }
        }

        public virtual void ClearPostalAddress()
        {
            if (postalAddress!=null)
            {
                var __itemsToRemove = postalAddress.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePostalAddress(__item);
                }
            }
        }
        [DataMember(Name="DiscountCards")]
        protected IList<DiscountCard> discountCards = new List<DiscountCard>();
        public virtual List<DiscountCard> DiscountCards
        {
            get
            {
                if (discountCards is DiscountCard[])
                {
                    discountCards = discountCards.ToList();
                }
                if (discountCards == null)
                {
                    discountCards = new List<DiscountCard>();
                }
                return discountCards.ToList();
            }
            set
            {
                if (discountCards is DiscountCard[])
                {
                    discountCards = discountCards.ToList();
                }
                if (discountCards != null)
                {
                    var __itemsToDelete = new List<DiscountCard>(discountCards);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDiscountCards(__item);
                    }
                }
                if(value == null)
                {
                    discountCards = new List<DiscountCard>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDiscountCards(__item);
                }
            }
        }
        public virtual void AddDiscountCards(IList<DiscountCard> __items)
        {
            foreach (var __item in __items)
            {
                AddDiscountCards(__item);
            }
        }
        public virtual void AddDiscountCards(DiscountCard __item)
        {
            if (__item != null && discountCards!=null && !discountCards.Contains(__item))
            {
                discountCards.Add(__item);
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void RemoveDiscountCards(DiscountCard __item)
        {
            if (__item != null && discountCards!=null && discountCards.Contains(__item))
            {
                discountCards.Remove(__item);
                __item.Passenger = null;
            }
        }
        public virtual void SetDiscountCardsAt(DiscountCard __item, int __index)
        {
            if (__item == null)
            {
                discountCards[__index].Passenger = null;
            }
            else
            {
                discountCards[__index] = __item;
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void ClearDiscountCards()
        {
            if (discountCards!=null)
            {
                var __itemsToRemove = discountCards.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDiscountCards(__item);
                }
            }
        }
        [DataMember(Name="SpecialRequirements")]
        protected IList<SpecialRequirement> specialRequirements = new List<SpecialRequirement>();
        public virtual List<SpecialRequirement> SpecialRequirements
        {
            get
            {
                if (specialRequirements is SpecialRequirement[])
                {
                    specialRequirements = specialRequirements.ToList();
                }
                if (specialRequirements == null)
                {
                    specialRequirements = new List<SpecialRequirement>();
                }
                return specialRequirements.ToList();
            }
            set
            {
                if (specialRequirements is SpecialRequirement[])
                {
                    specialRequirements = specialRequirements.ToList();
                }
                if (specialRequirements != null)
                {
                    var __itemsToDelete = new List<SpecialRequirement>(specialRequirements);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveSpecialRequirements(__item);
                    }
                }
                if(value == null)
                {
                    specialRequirements = new List<SpecialRequirement>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddSpecialRequirements(__item);
                }
            }
        }
        public virtual void AddSpecialRequirements(IList<SpecialRequirement> __items)
        {
            foreach (var __item in __items)
            {
                AddSpecialRequirements(__item);
            }
        }
        public virtual void AddSpecialRequirements(SpecialRequirement __item)
        {
            if (__item != null && specialRequirements!=null && !specialRequirements.Contains(__item))
            {
                specialRequirements.Add(__item);
            }
        }

        public virtual void RemoveSpecialRequirements(SpecialRequirement __item)
        {
            if (__item != null && specialRequirements!=null && specialRequirements.Contains(__item))
            {
                specialRequirements.Remove(__item);
            }
        }
        public virtual void SetSpecialRequirementsAt(SpecialRequirement __item, int __index)
        {
            if (__item == null)
            {
                specialRequirements[__index] = null;
            }
            else
            {
                specialRequirements[__index] = __item;
            }
        }

        public virtual void ClearSpecialRequirements()
        {
            if (specialRequirements!=null)
            {
                var __itemsToRemove = specialRequirements.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveSpecialRequirements(__item);
                }
            }
        }
        [DataMember(Name="CreditCards")]
        protected IList<CreditCard> creditCards = new List<CreditCard>();
        public virtual List<CreditCard> CreditCards
        {
            get
            {
                if (creditCards is CreditCard[])
                {
                    creditCards = creditCards.ToList();
                }
                if (creditCards == null)
                {
                    creditCards = new List<CreditCard>();
                }
                return creditCards.ToList();
            }
            set
            {
                if (creditCards is CreditCard[])
                {
                    creditCards = creditCards.ToList();
                }
                if (creditCards != null)
                {
                    var __itemsToDelete = new List<CreditCard>(creditCards);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveCreditCards(__item);
                    }
                }
                if(value == null)
                {
                    creditCards = new List<CreditCard>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddCreditCards(__item);
                }
            }
        }
        public virtual void AddCreditCards(IList<CreditCard> __items)
        {
            foreach (var __item in __items)
            {
                AddCreditCards(__item);
            }
        }
        public virtual void AddCreditCards(CreditCard __item)
        {
            if (__item != null && creditCards!=null && !creditCards.Contains(__item))
            {
                creditCards.Add(__item);
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void RemoveCreditCards(CreditCard __item)
        {
            if (__item != null && creditCards!=null && creditCards.Contains(__item))
            {
                creditCards.Remove(__item);
                __item.Passenger = null;
            }
        }
        public virtual void SetCreditCardsAt(CreditCard __item, int __index)
        {
            if (__item == null)
            {
                creditCards[__index].Passenger = null;
            }
            else
            {
                creditCards[__index] = __item;
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void ClearCreditCards()
        {
            if (creditCards!=null)
            {
                var __itemsToRemove = creditCards.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveCreditCards(__item);
                }
            }
        }
        [DataMember(Name="Pets")]
        protected IList<Pet> pets = new List<Pet>();
        public virtual List<Pet> Pets
        {
            get
            {
                if (pets is Pet[])
                {
                    pets = pets.ToList();
                }
                if (pets == null)
                {
                    pets = new List<Pet>();
                }
                return pets.ToList();
            }
            set
            {
                if (pets is Pet[])
                {
                    pets = pets.ToList();
                }
                if (pets != null)
                {
                    var __itemsToDelete = new List<Pet>(pets);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePets(__item);
                    }
                }
                if(value == null)
                {
                    pets = new List<Pet>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPets(__item);
                }
            }
        }
        public virtual void AddPets(IList<Pet> __items)
        {
            foreach (var __item in __items)
            {
                AddPets(__item);
            }
        }
        public virtual void AddPets(Pet __item)
        {
            if (__item != null && pets!=null && !pets.Contains(__item))
            {
                pets.Add(__item);
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void RemovePets(Pet __item)
        {
            if (__item != null && pets!=null && pets.Contains(__item))
            {
                pets.Remove(__item);
                __item.Passenger = null;
            }
        }
        public virtual void SetPetsAt(Pet __item, int __index)
        {
            if (__item == null)
            {
                pets[__index].Passenger = null;
            }
            else
            {
                pets[__index] = __item;
                if (__item.Passenger != this)
                    __item.Passenger = this;
            }
        }

        public virtual void ClearPets()
        {
            if (pets!=null)
            {
                var __itemsToRemove = pets.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePets(__item);
                }
            }
        }
        [DataMember(Name="Reservations")]
        protected IList<Reservation> reservations = new List<Reservation>();
        public virtual List<Reservation> Reservations
        {
            get
            {
                if (reservations is Reservation[])
                {
                    reservations = reservations.ToList();
                }
                if (reservations == null)
                {
                    reservations = new List<Reservation>();
                }
                return reservations.ToList();
            }
            set
            {
                if (reservations is Reservation[])
                {
                    reservations = reservations.ToList();
                }
                if (reservations != null)
                {
                    var __itemsToDelete = new List<Reservation>(reservations);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveReservations(__item);
                    }
                }
                if(value == null)
                {
                    reservations = new List<Reservation>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddReservations(__item);
                }
            }
        }
        public virtual void AddReservations(IList<Reservation> __items)
        {
            foreach (var __item in __items)
            {
                AddReservations(__item);
            }
        }
        public virtual void AddReservations(Reservation __item)
        {
            if (__item != null && reservations!=null && !reservations.Contains(__item))
            {
                reservations.Add(__item);
                if (!__item.Passengers.Contains(this))
                    __item.AddPassengers(this);
            }
        }

        public virtual void RemoveReservations(Reservation __item)
        {
            if (__item != null && reservations!=null && reservations.Contains(__item))
            {
                reservations.Remove(__item);
                if(__item.Passengers.Contains(this))
                    __item.RemovePassengers(this);
            }
        }
        public virtual void SetReservationsAt(Reservation __item, int __index)
        {
            if (__item == null)
            {
                reservations[__index].RemovePassengers(this);
            }
            else
            {
                reservations[__index] = __item;
                if (!__item.Passengers.Contains(this))
                    __item.AddPassengers(this);
            }
        }

        public virtual void ClearReservations()
        {
            if (reservations!=null)
            {
                var __itemsToRemove = reservations.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveReservations(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Passenger class
/// </summary>
/// <returns>New Passenger object</returns>
/// <remarks></remarks>
        public Passenger(): base() {}
        #endregion
        #region Methods

        public List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Passenger' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Passenger] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Passenger Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Passenger copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Passenger)copiedObjects[this];
            copy = copy ?? new Passenger();
            copy.Accompanied = this.Accompanied;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.loyaltyCards = new List<LoyaltyCard>();
            if(deep && this.loyaltyCards != null)
            {
                foreach (var __item in this.loyaltyCards)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddLoyaltyCards(__item);
                        else
                            copy.AddLoyaltyCards(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddLoyaltyCards((LoyaltyCard)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.passengerCategory != null)
            {
                if (!copiedObjects.Contains(this.passengerCategory))
                {
                    if (asNew && reuseNestedObjects)
                        copy.PassengerCategory = this.PassengerCategory;
                    else if (asNew)
                        copy.PassengerCategory = this.PassengerCategory.Copy(deep, copiedObjects, true);
                    else
                        copy.passengerCategory = this.passengerCategory.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.PassengerCategory = (PassengerCategory)copiedObjects[this.PassengerCategory];
                    else
                        copy.passengerCategory = (PassengerCategory)copiedObjects[this.PassengerCategory];
                }
            }
            copy.postalAddress = new List<PostalAddress>();
            if(deep && this.postalAddress != null)
            {
                foreach (var __item in this.postalAddress)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPostalAddress(__item);
                        else
                            copy.AddPostalAddress(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPostalAddress((PostalAddress)copiedObjects[__item]);
                    }
                }
            }
            copy.discountCards = new List<DiscountCard>();
            if(deep && this.discountCards != null)
            {
                foreach (var __item in this.discountCards)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDiscountCards(__item);
                        else
                            copy.AddDiscountCards(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDiscountCards((DiscountCard)copiedObjects[__item]);
                    }
                }
            }
            copy.specialRequirements = new List<SpecialRequirement>();
            if(deep && this.specialRequirements != null)
            {
                foreach (var __item in this.specialRequirements)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddSpecialRequirements(__item);
                        else
                            copy.AddSpecialRequirements(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddSpecialRequirements((SpecialRequirement)copiedObjects[__item]);
                    }
                }
            }
            copy.creditCards = new List<CreditCard>();
            if(deep && this.creditCards != null)
            {
                foreach (var __item in this.creditCards)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddCreditCards(__item);
                        else
                            copy.AddCreditCards(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddCreditCards((CreditCard)copiedObjects[__item]);
                    }
                }
            }
            copy.pets = new List<Pet>();
            if(deep && this.pets != null)
            {
                foreach (var __item in this.pets)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPets(__item);
                        else
                            copy.AddPets(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPets((Pet)copiedObjects[__item]);
                    }
                }
            }
            copy.reservations = new List<Reservation>();
            if(deep && this.reservations != null)
            {
                foreach (var __item in this.reservations)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddReservations(__item);
                        else
                            copy.AddReservations(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddReservations((Reservation)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Passenger;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            return base.Equals(compareTo);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
