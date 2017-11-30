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
    /// The Country class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class Country : IDomainModelClass
    {
        #region Country's Fields

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
        [DataMember(Name="ISO3166_alpha2Code")]
        protected string iSO3166_alpha2Code;
        [DataMember(Name="ISO3166_alpha3Code")]
        protected string iSO3166_alpha3Code;
        [DataMember(Name="ISO3166_numericCode")]
        protected string iSO3166_numericCode;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="LocalName")]
        protected string localName;
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="Population")]
        protected int? population;
        [DataMember(Name="LandAreaKm")]
        protected decimal? landAreaKm;
        [DataMember(Name="Continent")]
        protected string continent;
        [DataMember(Name="ShortName")]
        protected string shortName;
        #endregion
        #region Country's Properties
/// <summary>
/// The ISO3166_alpha2Code property
///
/// </summary>
///
        public virtual string ISO3166_alpha2Code
        {
            get
            {
                return iSO3166_alpha2Code;
            }
            set
            {
                iSO3166_alpha2Code = value;
            }
        }
/// <summary>
/// The ISO3166_alpha3Code property
///
/// </summary>
///
        public virtual string ISO3166_alpha3Code
        {
            get
            {
                return iSO3166_alpha3Code;
            }
            set
            {
                iSO3166_alpha3Code = value;
            }
        }
/// <summary>
/// The ISO3166_numericCode property
///
/// </summary>
///
        public virtual string ISO3166_numericCode
        {
            get
            {
                return iSO3166_numericCode;
            }
            set
            {
                iSO3166_numericCode = value;
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
/// The Population property
///
/// </summary>
///
        public virtual int? Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }
/// <summary>
/// The LandAreaKm property
///
/// </summary>
///
        public virtual decimal? LandAreaKm
        {
            get
            {
                return landAreaKm;
            }
            set
            {
                landAreaKm = value;
            }
        }
/// <summary>
/// The Continent property
///
/// </summary>
///
        public virtual string Continent
        {
            get
            {
                return continent;
            }
            set
            {
                continent = value;
            }
        }
/// <summary>
/// The ShortName property
///
/// </summary>
///
        public virtual string ShortName
        {
            get
            {
                return shortName;
            }
            set
            {
                shortName = value;
            }
        }
        #endregion
        #region Country's Participant Properties
        [DataMember(Name="Currency")]
        protected Currency currency;
        public virtual Currency Currency
        {
            get
            {
                return currency;
            }
            set
            {
                if(Equals(currency, value)) return;
                var __oldValue = currency;
                if (value != null)
                {
                    currency = value;
                }
                else
                {
                    if (currency != null)
                    {
                        currency = null;
                    }
                }
            }
        }
        [DataMember(Name="Cities")]
        protected IList<City> cities = new List<City>();
        public virtual List<City> Cities
        {
            get
            {
                if (cities is City[])
                {
                    cities = cities.ToList();
                }
                if (cities == null)
                {
                    cities = new List<City>();
                }
                return cities.ToList();
            }
            set
            {
                if (cities is City[])
                {
                    cities = cities.ToList();
                }
                if (cities != null)
                {
                    var __itemsToDelete = new List<City>(cities);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveCities(__item);
                    }
                }
                if(value == null)
                {
                    cities = new List<City>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddCities(__item);
                }
            }
        }
        public virtual void AddCities(IList<City> __items)
        {
            foreach (var __item in __items)
            {
                AddCities(__item);
            }
        }
        public virtual void AddCities(City __item)
        {
            if (__item != null && cities!=null && !cities.Contains(__item))
            {
                cities.Add(__item);
                if (__item.Country != this)
                    __item.Country = this;
            }
        }

        public virtual void RemoveCities(City __item)
        {
            if (__item != null && cities!=null && cities.Contains(__item))
            {
                cities.Remove(__item);
                __item.Country = null;
            }
        }
        public virtual void SetCitiesAt(City __item, int __index)
        {
            if (__item == null)
            {
                cities[__index].Country = null;
            }
            else
            {
                cities[__index] = __item;
                if (__item.Country != this)
                    __item.Country = this;
            }
        }

        public virtual void ClearCities()
        {
            if (cities!=null)
            {
                var __itemsToRemove = cities.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveCities(__item);
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
                    if (geoCoordinates != null)
                    {
                        geoCoordinates = null;
                    }
                }
            }
        }
        [DataMember(Name="Ports")]
        protected IList<Port> ports = new List<Port>();
        public virtual List<Port> Ports
        {
            get
            {
                if (ports is Port[])
                {
                    ports = ports.ToList();
                }
                if (ports == null)
                {
                    ports = new List<Port>();
                }
                return ports.ToList();
            }
            set
            {
                if (ports is Port[])
                {
                    ports = ports.ToList();
                }
                if (ports != null)
                {
                    var __itemsToDelete = new List<Port>(ports);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemovePorts(__item);
                    }
                }
                if(value == null)
                {
                    ports = new List<Port>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddPorts(__item);
                }
            }
        }
        public virtual void AddPorts(IList<Port> __items)
        {
            foreach (var __item in __items)
            {
                AddPorts(__item);
            }
        }
        public virtual void AddPorts(Port __item)
        {
            if (__item != null && ports!=null && !ports.Contains(__item))
            {
                ports.Add(__item);
                if (__item.Country != this)
                    __item.Country = this;
            }
        }

        public virtual void RemovePorts(Port __item)
        {
            if (__item != null && ports!=null && ports.Contains(__item))
            {
                ports.Remove(__item);
                __item.Country = null;
            }
        }
        public virtual void SetPortsAt(Port __item, int __index)
        {
            if (__item == null)
            {
                ports[__index].Country = null;
            }
            else
            {
                ports[__index] = __item;
                if (__item.Country != this)
                    __item.Country = this;
            }
        }

        public virtual void ClearPorts()
        {
            if (ports!=null)
            {
                var __itemsToRemove = ports.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemovePorts(__item);
                }
            }
        }
        [DataMember(Name="Identification")]
        protected IList<Identification> identification = new List<Identification>();
        public virtual List<Identification> Identification
        {
            get
            {
                if (identification is Identification[])
                {
                    identification = identification.ToList();
                }
                if (identification == null)
                {
                    identification = new List<Identification>();
                }
                return identification.ToList();
            }
            set
            {
                if (identification is Identification[])
                {
                    identification = identification.ToList();
                }
                if (identification != null)
                {
                    var __itemsToDelete = new List<Identification>(identification);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveIdentification(__item);
                    }
                }
                if(value == null)
                {
                    identification = new List<Identification>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddIdentification(__item);
                }
            }
        }
        public virtual void AddIdentification(IList<Identification> __items)
        {
            foreach (var __item in __items)
            {
                AddIdentification(__item);
            }
        }
        public virtual void AddIdentification(Identification __item)
        {
            if (__item != null && identification!=null && !identification.Contains(__item))
            {
                identification.Add(__item);
                if (__item.IssuingCountry != this)
                    __item.IssuingCountry = this;
            }
        }

        public virtual void RemoveIdentification(Identification __item)
        {
            if (__item != null && identification!=null && identification.Contains(__item))
            {
                identification.Remove(__item);
                __item.IssuingCountry = null;
            }
        }
        public virtual void SetIdentificationAt(Identification __item, int __index)
        {
            if (__item == null)
            {
                identification[__index].IssuingCountry = null;
            }
            else
            {
                identification[__index] = __item;
                if (__item.IssuingCountry != this)
                    __item.IssuingCountry = this;
            }
        }

        public virtual void ClearIdentification()
        {
            if (identification!=null)
            {
                var __itemsToRemove = identification.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveIdentification(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Country class
/// </summary>
/// <returns>New Country object</returns>
/// <remarks></remarks>
        public Country() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (ISO3166_alpha2Code != null && ISO3166_alpha2Code.Length > 100)
            {
                __errors.Add("Length of property 'ISO3166_alpha2Code' cannot be greater than 100.");
            }
            if (ISO3166_alpha3Code != null && ISO3166_alpha3Code.Length > 100)
            {
                __errors.Add("Length of property 'ISO3166_alpha3Code' cannot be greater than 100.");
            }
            if (ISO3166_numericCode != null && ISO3166_numericCode.Length > 100)
            {
                __errors.Add("Length of property 'ISO3166_numericCode' cannot be greater than 100.");
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
            if (Continent != null && Continent.Length > 100)
            {
                __errors.Add("Length of property 'Continent' cannot be greater than 100.");
            }
            if (ShortName != null && ShortName.Length > 100)
            {
                __errors.Add("Length of property 'ShortName' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Country' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Country] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Country Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Country copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Country)copiedObjects[this];
            copy = copy ?? new Country();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.ISO3166_alpha2Code = this.ISO3166_alpha2Code;
            copy.ISO3166_alpha3Code = this.ISO3166_alpha3Code;
            copy.ISO3166_numericCode = this.ISO3166_numericCode;
            copy.IATACode = this.IATACode;
            copy.Name = this.Name;
            copy.LocalName = this.LocalName;
            copy.Population = this.Population;
            copy.LandAreaKm = this.LandAreaKm;
            copy.Continent = this.Continent;
            copy.ShortName = this.ShortName;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.currency != null)
            {
                if (!copiedObjects.Contains(this.currency))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Currency = this.Currency;
                    else if (asNew)
                        copy.Currency = this.Currency.Copy(deep, copiedObjects, true);
                    else
                        copy.currency = this.currency.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Currency = (Currency)copiedObjects[this.Currency];
                    else
                        copy.currency = (Currency)copiedObjects[this.Currency];
                }
            }
            copy.cities = new List<City>();
            if(deep && this.cities != null)
            {
                foreach (var __item in this.cities)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddCities(__item);
                        else
                            copy.AddCities(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddCities((City)copiedObjects[__item]);
                    }
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
            copy.ports = new List<Port>();
            if(deep && this.ports != null)
            {
                foreach (var __item in this.ports)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddPorts(__item);
                        else
                            copy.AddPorts(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddPorts((Port)copiedObjects[__item]);
                    }
                }
            }
            copy.identification = new List<Identification>();
            if(deep && this.identification != null)
            {
                foreach (var __item in this.identification)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddIdentification(__item);
                        else
                            copy.AddIdentification(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddIdentification((Identification)copiedObjects[__item]);
                    }
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Country;
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
        protected bool HasSameNonDefaultIdAs(Country compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
