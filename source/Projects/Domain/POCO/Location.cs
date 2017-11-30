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
    /// The Location class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Port))]

    [KnownType(typeof(PointOfInterest))]

    [KnownType(typeof(TrainStation))]

    [KnownType(typeof(Station))]

    [KnownType(typeof(Airport))]

    [KnownType(typeof(Terminal))]

    [KnownType(typeof(CoachStation))]

    public class Location : IDomainModelClass
    {
        #region Location's Fields

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
        protected long? id = 0L;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="MapUrl")]
        protected string mapUrl;
        [DataMember(Name="ISICRev4")]
        protected string iSICRev4;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="LocalName")]
        protected string localName;
        [DataMember(Name="SilverRailCode")]
        protected string silverRailCode;
        #endregion
        #region Location's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual long? Id
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
/// The MapUrl property
///
/// </summary>
///
        public virtual string MapUrl
        {
            get
            {
                return mapUrl;
            }
            set
            {
                mapUrl = value;
            }
        }
/// <summary>
/// The ISICRev4 property
///
/// </summary>
///
        public virtual string ISICRev4
        {
            get
            {
                return iSICRev4;
            }
            set
            {
                iSICRev4 = value;
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
/// The SilverRailCode property
///
/// </summary>
///
        public virtual string SilverRailCode
        {
            get
            {
                return silverRailCode;
            }
            set
            {
                silverRailCode = value;
            }
        }
        #endregion
        #region Location's Participant Properties
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
        [DataMember(Name="UNLocode")]
        protected UNLocode uNLocode;
        public virtual UNLocode UNLocode
        {
            get
            {
                return uNLocode;
            }
            set
            {
                if(Equals(uNLocode, value)) return;
                var __oldValue = uNLocode;
                if (value != null)
                {
                    if(uNLocode != null && !Equals(uNLocode, value))
                        uNLocode.Location = null;
                    uNLocode = value;
                    if(uNLocode.Location != this)
                        uNLocode.Location = this;
                }
                else
                {
                    if (uNLocode != null)
                    {
                        var __obj = uNLocode;
                        uNLocode = null;
                        __obj.Location = null;
                    }
                }
            }
        }
        [DataMember(Name="Datasources")]
        protected IList<Datasource> datasources = new List<Datasource>();
        public virtual List<Datasource> Datasources
        {
            get
            {
                if (datasources is Datasource[])
                {
                    datasources = datasources.ToList();
                }
                if (datasources == null)
                {
                    datasources = new List<Datasource>();
                }
                return datasources.ToList();
            }
            set
            {
                if (datasources is Datasource[])
                {
                    datasources = datasources.ToList();
                }
                if (datasources != null)
                {
                    var __itemsToDelete = new List<Datasource>(datasources);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveDatasources(__item);
                    }
                }
                if(value == null)
                {
                    datasources = new List<Datasource>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddDatasources(__item);
                }
            }
        }
        public virtual void AddDatasources(IList<Datasource> __items)
        {
            foreach (var __item in __items)
            {
                AddDatasources(__item);
            }
        }
        public virtual void AddDatasources(Datasource __item)
        {
            if (__item != null && datasources!=null && !datasources.Contains(__item))
            {
                datasources.Add(__item);
            }
        }

        public virtual void RemoveDatasources(Datasource __item)
        {
            if (__item != null && datasources!=null && datasources.Contains(__item))
            {
                datasources.Remove(__item);
            }
        }
        public virtual void SetDatasourcesAt(Datasource __item, int __index)
        {
            if (__item == null)
            {
                datasources[__index] = null;
            }
            else
            {
                datasources[__index] = __item;
            }
        }

        public virtual void ClearDatasources()
        {
            if (datasources!=null)
            {
                var __itemsToRemove = datasources.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveDatasources(__item);
                }
            }
        }
        [DataMember(Name="LocationType")]
        protected LocationType locationType;
        public virtual LocationType LocationType
        {
            get
            {
                return locationType;
            }
            set
            {
                if(Equals(locationType, value)) return;
                var __oldValue = locationType;
                if (value != null)
                {
                    locationType = value;
                }
                else
                {
                    locationType = null;
                }
            }
        }
        [DataMember(Name="ContactInformation")]
        protected ContactInformation contactInformation;
        public virtual ContactInformation ContactInformation
        {
            get
            {
                return contactInformation;
            }
            set
            {
                if(Equals(contactInformation, value)) return;
                var __oldValue = contactInformation;
                if (value != null)
                {
                    contactInformation = value;
                }
                else
                {
                    contactInformation = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Location class
/// </summary>
/// <returns>New Location object</returns>
/// <remarks></remarks>
        public Location() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Name != null && Name.Length > 200)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 200.");
            }
            if (MapUrl != null && MapUrl.Length > 100)
            {
                __errors.Add("Length of property 'MapUrl' cannot be greater than 100.");
            }
            if (ISICRev4 != null && ISICRev4.Length > 100)
            {
                __errors.Add("Length of property 'ISICRev4' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (LocalName != null && LocalName.Length > 100)
            {
                __errors.Add("Length of property 'LocalName' cannot be greater than 100.");
            }
            if (SilverRailCode != null && SilverRailCode.Length > 100)
            {
                __errors.Add("Length of property 'SilverRailCode' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Location' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Location] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Location Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Location copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Location)copiedObjects[this];
            copy = copy ?? new Location();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Name = this.Name;
            copy.MapUrl = this.MapUrl;
            copy.ISICRev4 = this.ISICRev4;
            copy.Description = this.Description;
            copy.LocalName = this.LocalName;
            copy.SilverRailCode = this.SilverRailCode;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
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
            if(deep && this.uNLocode != null)
            {
                if (!copiedObjects.Contains(this.uNLocode))
                {
                    if (asNew && reuseNestedObjects)
                        copy.UNLocode = this.UNLocode;
                    else if (asNew)
                        copy.UNLocode = this.UNLocode.Copy(deep, copiedObjects, true);
                    else
                        copy.uNLocode = this.uNLocode.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.UNLocode = (UNLocode)copiedObjects[this.UNLocode];
                    else
                        copy.uNLocode = (UNLocode)copiedObjects[this.UNLocode];
                }
            }
            copy.datasources = new List<Datasource>();
            if(deep && this.datasources != null)
            {
                foreach (var __item in this.datasources)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddDatasources(__item);
                        else
                            copy.AddDatasources(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddDatasources((Datasource)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.locationType != null)
            {
                if (!copiedObjects.Contains(this.locationType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.LocationType = this.LocationType;
                    else if (asNew)
                        copy.LocationType = this.LocationType.Copy(deep, copiedObjects, true);
                    else
                        copy.locationType = this.locationType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.LocationType = (LocationType)copiedObjects[this.LocationType];
                    else
                        copy.locationType = (LocationType)copiedObjects[this.LocationType];
                }
            }
            if(deep && this.contactInformation != null)
            {
                if (!copiedObjects.Contains(this.contactInformation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ContactInformation = this.ContactInformation;
                    else if (asNew)
                        copy.ContactInformation = this.ContactInformation.Copy(deep, copiedObjects, true);
                    else
                        copy.contactInformation = this.contactInformation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ContactInformation = (ContactInformation)copiedObjects[this.ContactInformation];
                    else
                        copy.contactInformation = (ContactInformation)copiedObjects[this.ContactInformation];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Location;
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
            return this.Id == default(long) || this.Id.Equals(default(long));
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
        protected bool HasSameNonDefaultIdAs(Location compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
