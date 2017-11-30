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
    /// The EuTravelDiaryPhotographDTO class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class EuTravelDiaryPhotographDTO : IDomainModelClass
    {
        #region EuTravelDiaryPhotographDTO's Fields

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
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        [DataMember(Name="IsPublic")]
        protected bool isPublic;
        [DataMember(Name="File")]
        protected string file;
        [DataMember(Name="Id")]
        protected int? id;
        [DataMember(Name="EuTravelDiaryPhotographDTOKey")]
        protected Guid? euTravelDiaryPhotographDTOKey = Guid.Empty;
        #endregion
        #region EuTravelDiaryPhotographDTO's Properties
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
/// The IsPublic property
///
/// </summary>
///
        public virtual bool IsPublic
        {
            get
            {
                return isPublic;
            }
            set
            {
                isPublic = value;
            }
        }
/// <summary>
/// The File property
///
/// </summary>
///
        public virtual string File
        {
            get
            {
                return file;
            }
            set
            {
                file = value;
            }
        }
/// <summary>
/// The Id property
///
/// </summary>
///
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
/// The EuTravelDiaryPhotographDTOKey property
///
/// </summary>
///
        [Key]
        public virtual Guid? EuTravelDiaryPhotographDTOKey
        {
            get
            {
                return euTravelDiaryPhotographDTOKey;
            }
            set
            {
                euTravelDiaryPhotographDTOKey = value;
            }
        }
        #endregion
        #region EuTravelDiaryPhotographDTO's Participant Properties
        [DataMember(Name="GeoCoordinatesDTO")]
        protected EuTravelDiaryGeoCoordinatesDTO geoCoordinatesDTO;
        public virtual EuTravelDiaryGeoCoordinatesDTO GeoCoordinatesDTO
        {
            get
            {
                return geoCoordinatesDTO;
            }
            set
            {
                if(Equals(geoCoordinatesDTO, value)) return;
                var __oldValue = geoCoordinatesDTO;
                if (value != null)
                {
                    geoCoordinatesDTO = value;
                }
                else
                {
                    geoCoordinatesDTO = null;
                }
            }
        }
        [DataMember(Name="TakenBy")]
        protected EuTravelDiaryPersonDTO takenBy;
        public virtual EuTravelDiaryPersonDTO TakenBy
        {
            get
            {
                return takenBy;
            }
            set
            {
                if(Equals(takenBy, value)) return;
                var __oldValue = takenBy;
                if (value != null)
                {
                    takenBy = value;
                }
                else
                {
                    if (takenBy != null)
                    {
                        takenBy = null;
                    }
                }
            }
        }
        [DataMember(Name="EuTravelDiaryPOIDTO")]
        protected EuTravelDiaryPOIDTO euTravelDiaryPOIDTO;
        public virtual EuTravelDiaryPOIDTO EuTravelDiaryPOIDTO
        {
            get
            {
                return euTravelDiaryPOIDTO;
            }
            set
            {
                if(Equals(euTravelDiaryPOIDTO, value)) return;
                var __oldValue = euTravelDiaryPOIDTO;
                if (value != null)
                {
                    if(euTravelDiaryPOIDTO != null && !Equals(euTravelDiaryPOIDTO, value))
                        euTravelDiaryPOIDTO.RemoveEuTravelDiaryPhotographDTO(this);
                    euTravelDiaryPOIDTO = value;
                    euTravelDiaryPOIDTO.AddEuTravelDiaryPhotographDTO(this);
                }
                else
                {
                    if(euTravelDiaryPOIDTO != null)
                        euTravelDiaryPOIDTO.RemoveEuTravelDiaryPhotographDTO(this);
                    euTravelDiaryPOIDTO = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the EuTravelDiaryPhotographDTO class
/// </summary>
/// <returns>New EuTravelDiaryPhotographDTO object</returns>
/// <remarks></remarks>
        public EuTravelDiaryPhotographDTO()
        {
            if (EuTravelDiaryPhotographDTOKey == null) EuTravelDiaryPhotographDTOKey = Guid.NewGuid();
        }
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (File != null && File.Length > 1000)
            {
                __errors.Add("Length of property 'File' cannot be greater than 1000.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'EuTravelDiaryPhotographDTO' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [EuTravelDiaryPhotographDTO] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual EuTravelDiaryPhotographDTO Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, EuTravelDiaryPhotographDTO copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (EuTravelDiaryPhotographDTO)copiedObjects[this];
            copy = copy ?? new EuTravelDiaryPhotographDTO();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.EuTravelDiaryPhotographDTOKey = this.EuTravelDiaryPhotographDTOKey;
            }
            copy.Name = this.Name;
            copy.Description = this.Description;
            copy.IsPublic = this.IsPublic;
            copy.File = this.File;
            copy.Id = this.Id;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.geoCoordinatesDTO != null)
            {
                if (!copiedObjects.Contains(this.geoCoordinatesDTO))
                {
                    if (asNew && reuseNestedObjects)
                        copy.GeoCoordinatesDTO = this.GeoCoordinatesDTO;
                    else if (asNew)
                        copy.GeoCoordinatesDTO = this.GeoCoordinatesDTO.Copy(deep, copiedObjects, true);
                    else
                        copy.geoCoordinatesDTO = this.geoCoordinatesDTO.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.GeoCoordinatesDTO = (EuTravelDiaryGeoCoordinatesDTO)copiedObjects[this.GeoCoordinatesDTO];
                    else
                        copy.geoCoordinatesDTO = (EuTravelDiaryGeoCoordinatesDTO)copiedObjects[this.GeoCoordinatesDTO];
                }
            }
            if(deep && this.takenBy != null)
            {
                if (!copiedObjects.Contains(this.takenBy))
                {
                    if (asNew && reuseNestedObjects)
                        copy.TakenBy = this.TakenBy;
                    else if (asNew)
                        copy.TakenBy = this.TakenBy.Copy(deep, copiedObjects, true);
                    else
                        copy.takenBy = this.takenBy.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.TakenBy = (EuTravelDiaryPersonDTO)copiedObjects[this.TakenBy];
                    else
                        copy.takenBy = (EuTravelDiaryPersonDTO)copiedObjects[this.TakenBy];
                }
            }
            if(deep && this.euTravelDiaryPOIDTO != null)
            {
                if (!copiedObjects.Contains(this.euTravelDiaryPOIDTO))
                {
                    if (asNew && reuseNestedObjects)
                        copy.EuTravelDiaryPOIDTO = this.EuTravelDiaryPOIDTO;
                    else if (asNew)
                        copy.EuTravelDiaryPOIDTO = this.EuTravelDiaryPOIDTO.Copy(deep, copiedObjects, true);
                    else
                        copy.euTravelDiaryPOIDTO = this.euTravelDiaryPOIDTO.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.EuTravelDiaryPOIDTO = (EuTravelDiaryPOIDTO)copiedObjects[this.EuTravelDiaryPOIDTO];
                    else
                        copy.euTravelDiaryPOIDTO = (EuTravelDiaryPOIDTO)copiedObjects[this.EuTravelDiaryPOIDTO];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EuTravelDiaryPhotographDTO;
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
                __propertyKeyCache = this.GetType().GetProperty("EuTravelDiaryPhotographDTOKey");
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
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.EuTravelDiaryPhotographDTOKey.GetHashCode();
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
            return this.EuTravelDiaryPhotographDTOKey == default(Guid) || this.EuTravelDiaryPhotographDTOKey.Equals(default(Guid));
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
        protected bool HasSameNonDefaultIdAs(EuTravelDiaryPhotographDTO compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.EuTravelDiaryPhotographDTOKey.Equals(compareTo.EuTravelDiaryPhotographDTOKey);
        }

        #endregion
    }
}
