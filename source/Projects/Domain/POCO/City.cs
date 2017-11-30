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
    /// The City class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class City : IDomainModelClass
    {
        #region City's Fields

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
        [DataMember(Name="Code")]
        protected string code;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="LocalName")]
        protected string localName;
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="FIPSSubdivision")]
        protected string fIPSSubdivision;
        [DataMember(Name="GNS_FD")]
        protected string gNS_FD;
        [DataMember(Name="GNS_UFI")]
        protected string gNS_UFI;
        #endregion
        #region City's Properties
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
/// The IATACode property
///
/// </summary>
///
        public virtual string IATACode
        {
            get
            {
                return iATACode;
            }
            set
            {
                iATACode = value;
            }
        }
/// <summary>
/// The Name property
///
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
/// The LocalName property
///
/// </summary>
///
        public virtual string LocalName
        {
            get
            {
                return localName;
            }
            set
            {
                localName = value;
            }
        }
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
/// The FIPSSubdivision property
///
/// </summary>
///
        public virtual string FIPSSubdivision
        {
            get
            {
                return fIPSSubdivision;
            }
            set
            {
                fIPSSubdivision = value;
            }
        }
/// <summary>
/// The GNS_FD property
///
/// </summary>
///
        public virtual string GNS_FD
        {
            get
            {
                return gNS_FD;
            }
            set
            {
                gNS_FD = value;
            }
        }
/// <summary>
/// The GNS_UFI property
///
/// </summary>
///
        public virtual string GNS_UFI
        {
            get
            {
                return gNS_UFI;
            }
            set
            {
                gNS_UFI = value;
            }
        }
        #endregion
        #region City's Participant Properties
        [DataMember(Name="Country")]
        protected Country country;
        public virtual Country Country
        {
            get
            {
                return country;
            }
            set
            {
                if(Equals(country, value)) return;
                var __oldValue = country;
                if (value != null)
                {
                    if(country != null && !Equals(country, value))
                        country.RemoveCities(this);
                    country = value;
                    country.AddCities(this);
                }
                else
                {
                    if(country != null)
                        country.RemoveCities(this);
                    country = null;
                }
            }
        }
        [DataMember(Name="Language")]
        protected Language language;
        public virtual Language Language
        {
            get
            {
                return language;
            }
            set
            {
                if(Equals(language, value)) return;
                var __oldValue = language;
                if (value != null)
                {
                    language = value;
                }
                else
                {
                    language = null;
                }
            }
        }
        [DataMember(Name="GeoCoordinates")]
        protected GeoCoordinates geoCoordinates;
        public virtual GeoCoordinates GeoCoordinates
        {
            get
            {
                return geoCoordinates;
            }
            set
            {
                if(Equals(geoCoordinates, value)) return;
                var __oldValue = geoCoordinates;
                if (value != null)
                {
                    geoCoordinates = value;
                }
                else
                {
                    geoCoordinates = null;
                }
            }
        }
        [DataMember(Name="Airports")]
        protected IList<Airport> airports = new List<Airport>();
        public virtual List<Airport> Airports
        {
            get
            {
                if (airports is Airport[])
                {
                    airports = airports.ToList();
                }
                if (airports == null)
                {
                    airports = new List<Airport>();
                }
                return airports.ToList();
            }
            set
            {
                if (airports is Airport[])
                {
                    airports = airports.ToList();
                }
                if (airports != null)
                {
                    var __itemsToDelete = new List<Airport>(airports);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAirports(__item);
                    }
                }
                if(value == null)
                {
                    airports = new List<Airport>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAirports(__item);
                }
            }
        }
        public virtual void AddAirports(IList<Airport> __items)
        {
            foreach (var __item in __items)
            {
                AddAirports(__item);
            }
        }
        public virtual void AddAirports(Airport __item)
        {
            if (__item != null && airports!=null && !airports.Contains(__item))
            {
                airports.Add(__item);
                if (__item.City != this)
                    __item.City = this;
            }
        }

        public virtual void RemoveAirports(Airport __item)
        {
            if (__item != null && airports!=null && airports.Contains(__item))
            {
                airports.Remove(__item);
                __item.City = null;
            }
        }
        public virtual void SetAirportsAt(Airport __item, int __index)
        {
            if (__item == null)
            {
                airports[__index].City = null;
            }
            else
            {
                airports[__index] = __item;
                if (__item.City != this)
                    __item.City = this;
            }
        }

        public virtual void ClearAirports()
        {
            if (airports!=null)
            {
                var __itemsToRemove = airports.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAirports(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the City class
/// </summary>
/// <returns>New City object</returns>
/// <remarks></remarks>
        public City() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Code != null && Code.Length > 100)
            {
                __errors.Add("Length of property 'Code' cannot be greater than 100.");
            }
            if (IATACode != null && IATACode.Length > 100)
            {
                __errors.Add("Length of property 'IATACode' cannot be greater than 100.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (LocalName != null && LocalName.Length > 100)
            {
                __errors.Add("Length of property 'LocalName' cannot be greater than 100.");
            }
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (FIPSSubdivision != null && FIPSSubdivision.Length > 100)
            {
                __errors.Add("Length of property 'FIPSSubdivision' cannot be greater than 100.");
            }
            if (GNS_FD != null && GNS_FD.Length > 100)
            {
                __errors.Add("Length of property 'GNS_FD' cannot be greater than 100.");
            }
            if (GNS_UFI != null && GNS_UFI.Length > 100)
            {
                __errors.Add("Length of property 'GNS_UFI' cannot be greater than 100.");
            }
            if (Country == null)
            {
                __errors.Add("Association with 'Country' is required.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'City' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [City] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual City Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, City copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (City)copiedObjects[this];
            copy = copy ?? new City();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Code = this.Code;
            copy.IATACode = this.IATACode;
            copy.Name = this.Name;
            copy.LocalName = this.LocalName;
            copy.FIPSSubdivision = this.FIPSSubdivision;
            copy.GNS_FD = this.GNS_FD;
            copy.GNS_UFI = this.GNS_UFI;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.country != null)
            {
                if (!copiedObjects.Contains(this.country))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Country = this.Country;
                    else if (asNew)
                        copy.Country = this.Country.Copy(deep, copiedObjects, true);
                    else
                        copy.country = this.country.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Country = (Country)copiedObjects[this.Country];
                    else
                        copy.country = (Country)copiedObjects[this.Country];
                }
            }
            if(deep && this.language != null)
            {
                if (!copiedObjects.Contains(this.language))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Language = this.Language;
                    else if (asNew)
                        copy.Language = this.Language.Copy(deep, copiedObjects, true);
                    else
                        copy.language = this.language.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Language = (Language)copiedObjects[this.Language];
                    else
                        copy.language = (Language)copiedObjects[this.Language];
                }
            }
            if(deep && this.geoCoordinates != null)
            {
                if (!copiedObjects.Contains(this.geoCoordinates))
                {
                    if (asNew && reuseNestedObjects)
                        copy.GeoCoordinates = this.GeoCoordinates;
                    else if (asNew)
                        copy.GeoCoordinates = this.GeoCoordinates.Copy(deep, copiedObjects, true);
                    else
                        copy.geoCoordinates = this.geoCoordinates.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.GeoCoordinates = (GeoCoordinates)copiedObjects[this.GeoCoordinates];
                    else
                        copy.geoCoordinates = (GeoCoordinates)copiedObjects[this.GeoCoordinates];
                }
            }
            copy.airports = new List<Airport>();
            if(deep && this.airports != null)
            {
                foreach (var __item in this.airports)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAirports(__item);
                        else
                            copy.AddAirports(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAirports((Airport)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as City;
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
        protected bool HasSameNonDefaultIdAs(City compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
