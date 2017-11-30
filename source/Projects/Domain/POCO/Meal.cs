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
    /// The Meal class
    /// Available meal service
    /// </summary>
    [Serializable]
    [DataContract]
    public class Meal : IDomainModelClass
    {
        #region Meal's Fields

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
        [DataMember(Name="Code")]
        protected string code;
        [DataMember(Name="SimpleMeal")]
        protected string simpleMeal;
        [DataMember(Name="HotMeal")]
        protected string hotMeal;
        [DataMember(Name="ColdMeal")]
        protected string coldMeal;
        [DataMember(Name="Breakfast")]
        protected string breakfast;
        [DataMember(Name="ContinentalBreakfast")]
        protected string continentalBreakfast;
        [DataMember(Name="Lunch")]
        protected string lunch;
        [DataMember(Name="Dinner")]
        protected string dinner;
        [DataMember(Name="SnackOrBrunch")]
        protected string snackOrBrunch;
        [DataMember(Name="FoodForPurchase")]
        protected string foodForPurchase;
        [DataMember(Name="ComplimentaryRefreshments")]
        protected string complimentaryRefreshments;
        [DataMember(Name="AlcoholicBeveragesForPurchase")]
        protected string alcoholicBeveragesForPurchase;
        [DataMember(Name="ComplimentaryAlcoholicBeverages")]
        protected string complimentaryAlcoholicBeverages;
        [DataMember(Name="FoodAndBeveragesForPurchase")]
        protected string foodAndBeveragesForPurchase;
        [DataMember(Name="NoMealService")]
        protected string noMealService;
        [DataMember(Name="RefreshmentsForPurchase")]
        protected string refreshmentsForPurchase;
        #endregion
        #region Meal's Properties
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
/// The Code property
///
/// </summary>
///
        public virtual string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
/// <summary>
/// The SimpleMeal property
///
/// </summary>
///
        public virtual string SimpleMeal
        {
            get
            {
                return simpleMeal;
            }
            set
            {
                simpleMeal = value;
            }
        }
/// <summary>
/// The HotMeal property
///
/// </summary>
///
        public virtual string HotMeal
        {
            get
            {
                return hotMeal;
            }
            set
            {
                hotMeal = value;
            }
        }
/// <summary>
/// The ColdMeal property
///
/// </summary>
///
        public virtual string ColdMeal
        {
            get
            {
                return coldMeal;
            }
            set
            {
                coldMeal = value;
            }
        }
/// <summary>
/// The Breakfast property
///
/// </summary>
///
        public virtual string Breakfast
        {
            get
            {
                return breakfast;
            }
            set
            {
                breakfast = value;
            }
        }
/// <summary>
/// The ContinentalBreakfast property
///
/// </summary>
///
        public virtual string ContinentalBreakfast
        {
            get
            {
                return continentalBreakfast;
            }
            set
            {
                continentalBreakfast = value;
            }
        }
/// <summary>
/// The Lunch property
///
/// </summary>
///
        public virtual string Lunch
        {
            get
            {
                return lunch;
            }
            set
            {
                lunch = value;
            }
        }
/// <summary>
/// The Dinner property
///
/// </summary>
///
        public virtual string Dinner
        {
            get
            {
                return dinner;
            }
            set
            {
                dinner = value;
            }
        }
/// <summary>
/// The SnackOrBrunch property
///
/// </summary>
///
        public virtual string SnackOrBrunch
        {
            get
            {
                return snackOrBrunch;
            }
            set
            {
                snackOrBrunch = value;
            }
        }
/// <summary>
/// The FoodForPurchase property
///
/// </summary>
///
        public virtual string FoodForPurchase
        {
            get
            {
                return foodForPurchase;
            }
            set
            {
                foodForPurchase = value;
            }
        }
/// <summary>
/// The ComplimentaryRefreshments property
///
/// </summary>
///
        public virtual string ComplimentaryRefreshments
        {
            get
            {
                return complimentaryRefreshments;
            }
            set
            {
                complimentaryRefreshments = value;
            }
        }
/// <summary>
/// The AlcoholicBeveragesForPurchase property
///
/// </summary>
///
        public virtual string AlcoholicBeveragesForPurchase
        {
            get
            {
                return alcoholicBeveragesForPurchase;
            }
            set
            {
                alcoholicBeveragesForPurchase = value;
            }
        }
/// <summary>
/// The ComplimentaryAlcoholicBeverages property
///
/// </summary>
///
        public virtual string ComplimentaryAlcoholicBeverages
        {
            get
            {
                return complimentaryAlcoholicBeverages;
            }
            set
            {
                complimentaryAlcoholicBeverages = value;
            }
        }
/// <summary>
/// The FoodAndBeveragesForPurchase property
///
/// </summary>
///
        public virtual string FoodAndBeveragesForPurchase
        {
            get
            {
                return foodAndBeveragesForPurchase;
            }
            set
            {
                foodAndBeveragesForPurchase = value;
            }
        }
/// <summary>
/// The NoMealService property
///
/// </summary>
///
        public virtual string NoMealService
        {
            get
            {
                return noMealService;
            }
            set
            {
                noMealService = value;
            }
        }
/// <summary>
/// The RefreshmentsForPurchase property
///
/// </summary>
///
        public virtual string RefreshmentsForPurchase
        {
            get
            {
                return refreshmentsForPurchase;
            }
            set
            {
                refreshmentsForPurchase = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Meal class
/// </summary>
/// <returns>New Meal object</returns>
/// <remarks></remarks>
        public Meal() {}
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
            if (Code != null && Code.Length > 100)
            {
                __errors.Add("Length of property 'Code' cannot be greater than 100.");
            }
            if (SimpleMeal != null && SimpleMeal.Length > 100)
            {
                __errors.Add("Length of property 'SimpleMeal' cannot be greater than 100.");
            }
            if (HotMeal != null && HotMeal.Length > 100)
            {
                __errors.Add("Length of property 'HotMeal' cannot be greater than 100.");
            }
            if (ColdMeal != null && ColdMeal.Length > 100)
            {
                __errors.Add("Length of property 'ColdMeal' cannot be greater than 100.");
            }
            if (Breakfast != null && Breakfast.Length > 100)
            {
                __errors.Add("Length of property 'Breakfast' cannot be greater than 100.");
            }
            if (ContinentalBreakfast != null && ContinentalBreakfast.Length > 100)
            {
                __errors.Add("Length of property 'ContinentalBreakfast' cannot be greater than 100.");
            }
            if (Lunch != null && Lunch.Length > 100)
            {
                __errors.Add("Length of property 'Lunch' cannot be greater than 100.");
            }
            if (Dinner != null && Dinner.Length > 100)
            {
                __errors.Add("Length of property 'Dinner' cannot be greater than 100.");
            }
            if (SnackOrBrunch != null && SnackOrBrunch.Length > 100)
            {
                __errors.Add("Length of property 'SnackOrBrunch' cannot be greater than 100.");
            }
            if (FoodForPurchase != null && FoodForPurchase.Length > 100)
            {
                __errors.Add("Length of property 'FoodForPurchase' cannot be greater than 100.");
            }
            if (ComplimentaryRefreshments != null && ComplimentaryRefreshments.Length > 100)
            {
                __errors.Add("Length of property 'ComplimentaryRefreshments' cannot be greater than 100.");
            }
            if (AlcoholicBeveragesForPurchase != null && AlcoholicBeveragesForPurchase.Length > 100)
            {
                __errors.Add("Length of property 'AlcoholicBeveragesForPurchase' cannot be greater than 100.");
            }
            if (ComplimentaryAlcoholicBeverages != null && ComplimentaryAlcoholicBeverages.Length > 100)
            {
                __errors.Add("Length of property 'ComplimentaryAlcoholicBeverages' cannot be greater than 100.");
            }
            if (FoodAndBeveragesForPurchase != null && FoodAndBeveragesForPurchase.Length > 100)
            {
                __errors.Add("Length of property 'FoodAndBeveragesForPurchase' cannot be greater than 100.");
            }
            if (NoMealService != null && NoMealService.Length > 100)
            {
                __errors.Add("Length of property 'NoMealService' cannot be greater than 100.");
            }
            if (RefreshmentsForPurchase != null && RefreshmentsForPurchase.Length > 100)
            {
                __errors.Add("Length of property 'RefreshmentsForPurchase' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Meal' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Meal] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Meal Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Meal copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Meal)copiedObjects[this];
            copy = copy ?? new Meal();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Description = this.Description;
            copy.Code = this.Code;
            copy.SimpleMeal = this.SimpleMeal;
            copy.HotMeal = this.HotMeal;
            copy.ColdMeal = this.ColdMeal;
            copy.Breakfast = this.Breakfast;
            copy.ContinentalBreakfast = this.ContinentalBreakfast;
            copy.Lunch = this.Lunch;
            copy.Dinner = this.Dinner;
            copy.SnackOrBrunch = this.SnackOrBrunch;
            copy.FoodForPurchase = this.FoodForPurchase;
            copy.ComplimentaryRefreshments = this.ComplimentaryRefreshments;
            copy.AlcoholicBeveragesForPurchase = this.AlcoholicBeveragesForPurchase;
            copy.ComplimentaryAlcoholicBeverages = this.ComplimentaryAlcoholicBeverages;
            copy.FoodAndBeveragesForPurchase = this.FoodAndBeveragesForPurchase;
            copy.NoMealService = this.NoMealService;
            copy.RefreshmentsForPurchase = this.RefreshmentsForPurchase;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Meal;
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
        protected bool HasSameNonDefaultIdAs(Meal compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
