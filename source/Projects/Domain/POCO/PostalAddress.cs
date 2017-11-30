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
    /// The PostalAddress class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class PostalAddress : IDomainModelClass
    {
        #region PostalAddress's Fields

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
        [DataMember(Name="Province")]
        protected string province;
        [DataMember(Name="Locality")]
        protected string locality;
        [DataMember(Name="AddressLine1")]
        protected string addressLine1;
        [DataMember(Name="AddressLine2")]
        protected string addressLine2;
        [DataMember(Name="AddressLine3")]
        protected string addressLine3;
        [DataMember(Name="AddressNumber")]
        protected string addressNumber;
        [DataMember(Name="PostalCode")]
        protected string postalCode;
        [DataMember(Name="PostOfficeBoxNumber")]
        protected string postOfficeBoxNumber;
        #endregion
        #region PostalAddress's Properties
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
/// The Province property
///
/// </summary>
///
        public virtual string Province
        {
            get
            {
                return province;
            }
            set
            {
                province = value;
            }
        }
/// <summary>
/// The Locality property
///
/// </summary>
///
        public virtual string Locality
        {
            get
            {
                return locality;
            }
            set
            {
                locality = value;
            }
        }
/// <summary>
/// The AddressLine1 property
///
/// </summary>
///
        public virtual string AddressLine1
        {
            get
            {
                return addressLine1;
            }
            set
            {
                addressLine1 = value;
            }
        }
/// <summary>
/// The AddressLine2 property
///
/// </summary>
///
        public virtual string AddressLine2
        {
            get
            {
                return addressLine2;
            }
            set
            {
                addressLine2 = value;
            }
        }
/// <summary>
/// The AddressLine3 property
///
/// </summary>
///
        public virtual string AddressLine3
        {
            get
            {
                return addressLine3;
            }
            set
            {
                addressLine3 = value;
            }
        }
/// <summary>
/// The AddressNumber property
///
/// </summary>
///
        public virtual string AddressNumber
        {
            get
            {
                return addressNumber;
            }
            set
            {
                addressNumber = value;
            }
        }
/// <summary>
/// The PostalCode property
///
/// </summary>
///
        public virtual string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }
/// <summary>
/// The PostOfficeBoxNumber property
///
/// </summary>
///
        public virtual string PostOfficeBoxNumber
        {
            get
            {
                return postOfficeBoxNumber;
            }
            set
            {
                postOfficeBoxNumber = value;
            }
        }
        #endregion
        #region PostalAddress's Participant Properties
        [DataMember(Name="AddressType")]
        protected AddressType addressType;
        public virtual AddressType AddressType
        {
            get
            {
                return addressType;
            }
            set
            {
                if(Equals(addressType, value)) return;
                var __oldValue = addressType;
                if (value != null)
                {
                    addressType = value;
                }
                else
                {
                    addressType = null;
                }
            }
        }
        [DataMember(Name="Timezone")]
        protected Timezone timezone;
        public virtual Timezone Timezone
        {
            get
            {
                return timezone;
            }
            set
            {
                if(Equals(timezone, value)) return;
                var __oldValue = timezone;
                if (value != null)
                {
                    timezone = value;
                }
                else
                {
                    timezone = null;
                }
            }
        }
        [DataMember(Name="City")]
        protected City city;
        public virtual City City
        {
            get
            {
                return city;
            }
            set
            {
                if(Equals(city, value)) return;
                var __oldValue = city;
                if (value != null)
                {
                    city = value;
                }
                else
                {
                    city = null;
                }
            }
        }
        [DataMember(Name="Country")]
        protected IList<Country> country = new List<Country>();
        public virtual List<Country> Country
        {
            get
            {
                if (country is Country[])
                {
                    country = country.ToList();
                }
                if (country == null)
                {
                    country = new List<Country>();
                }
                return country.ToList();
            }
            set
            {
                if (country is Country[])
                {
                    country = country.ToList();
                }
                if (country != null)
                {
                    var __itemsToDelete = new List<Country>(country);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveCountry(__item);
                    }
                }
                if(value == null)
                {
                    country = new List<Country>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddCountry(__item);
                }
            }
        }
        public virtual void AddCountry(IList<Country> __items)
        {
            foreach (var __item in __items)
            {
                AddCountry(__item);
            }
        }
        public virtual void AddCountry(Country __item)
        {
            if (__item != null && country!=null && !country.Contains(__item))
            {
                country.Add(__item);
            }
        }

        public virtual void RemoveCountry(Country __item)
        {
            if (__item != null && country!=null && country.Contains(__item))
            {
                country.Remove(__item);
            }
        }
        public virtual void SetCountryAt(Country __item, int __index)
        {
            if (__item == null)
            {
                country[__index] = null;
            }
            else
            {
                country[__index] = __item;
            }
        }

        public virtual void ClearCountry()
        {
            if (country!=null)
            {
                var __itemsToRemove = country.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveCountry(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the PostalAddress class
/// </summary>
/// <returns>New PostalAddress object</returns>
/// <remarks></remarks>
        public PostalAddress() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Province != null && Province.Length > 100)
            {
                __errors.Add("Length of property 'Province' cannot be greater than 100.");
            }
            if (Locality != null && Locality.Length > 100)
            {
                __errors.Add("Length of property 'Locality' cannot be greater than 100.");
            }
            if (AddressLine1 != null && AddressLine1.Length > 100)
            {
                __errors.Add("Length of property 'AddressLine1' cannot be greater than 100.");
            }
            if (AddressLine2 != null && AddressLine2.Length > 100)
            {
                __errors.Add("Length of property 'AddressLine2' cannot be greater than 100.");
            }
            if (AddressLine3 != null && AddressLine3.Length > 100)
            {
                __errors.Add("Length of property 'AddressLine3' cannot be greater than 100.");
            }
            if (AddressNumber != null && AddressNumber.Length > 100)
            {
                __errors.Add("Length of property 'AddressNumber' cannot be greater than 100.");
            }
            if (PostalCode != null && PostalCode.Length > 100)
            {
                __errors.Add("Length of property 'PostalCode' cannot be greater than 100.");
            }
            if (PostOfficeBoxNumber != null && PostOfficeBoxNumber.Length > 100)
            {
                __errors.Add("Length of property 'PostOfficeBoxNumber' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'PostalAddress' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [PostalAddress] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual PostalAddress Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, PostalAddress copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (PostalAddress)copiedObjects[this];
            copy = copy ?? new PostalAddress();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Province = this.Province;
            copy.Locality = this.Locality;
            copy.AddressLine1 = this.AddressLine1;
            copy.AddressLine2 = this.AddressLine2;
            copy.AddressLine3 = this.AddressLine3;
            copy.AddressNumber = this.AddressNumber;
            copy.PostalCode = this.PostalCode;
            copy.PostOfficeBoxNumber = this.PostOfficeBoxNumber;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.addressType != null)
            {
                if (!copiedObjects.Contains(this.addressType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.AddressType = this.AddressType;
                    else if (asNew)
                        copy.AddressType = this.AddressType.Copy(deep, copiedObjects, true);
                    else
                        copy.addressType = this.addressType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.AddressType = (AddressType)copiedObjects[this.AddressType];
                    else
                        copy.addressType = (AddressType)copiedObjects[this.AddressType];
                }
            }
            if(deep && this.timezone != null)
            {
                if (!copiedObjects.Contains(this.timezone))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Timezone = this.Timezone;
                    else if (asNew)
                        copy.Timezone = this.Timezone.Copy(deep, copiedObjects, true);
                    else
                        copy.timezone = this.timezone.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Timezone = (Timezone)copiedObjects[this.Timezone];
                    else
                        copy.timezone = (Timezone)copiedObjects[this.Timezone];
                }
            }
            if(deep && this.city != null)
            {
                if (!copiedObjects.Contains(this.city))
                {
                    if (asNew && reuseNestedObjects)
                        copy.City = this.City;
                    else if (asNew)
                        copy.City = this.City.Copy(deep, copiedObjects, true);
                    else
                        copy.city = this.city.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.City = (City)copiedObjects[this.City];
                    else
                        copy.city = (City)copiedObjects[this.City];
                }
            }
            copy.country = new List<Country>();
            if(deep && this.country != null)
            {
                foreach (var __item in this.country)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddCountry(__item);
                        else
                            copy.AddCountry(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddCountry((Country)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as PostalAddress;
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
        protected bool HasSameNonDefaultIdAs(PostalAddress compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
