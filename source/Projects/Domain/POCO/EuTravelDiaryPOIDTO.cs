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
    /// The EuTravelDiaryPOIDTO class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class EuTravelDiaryPOIDTO : IDomainModelClass
    {
        #region EuTravelDiaryPOIDTO's Fields

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
        [DataMember(Name="IsPublic")]
        protected bool isPublic;
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="Description")]
        protected string description;
        #endregion
        #region EuTravelDiaryPOIDTO's Properties
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
        #endregion
        #region EuTravelDiaryPOIDTO's Participant Properties
        [DataMember(Name="EuTravelDiaryPhotographDTO")]
        protected IList<EuTravelDiaryPhotographDTO> euTravelDiaryPhotographDTO = new List<EuTravelDiaryPhotographDTO>();
        public virtual List<EuTravelDiaryPhotographDTO> EuTravelDiaryPhotographDTO
        {
            get
            {
                if (euTravelDiaryPhotographDTO is EuTravelDiaryPhotographDTO[])
                {
                    euTravelDiaryPhotographDTO = euTravelDiaryPhotographDTO.ToList();
                }
                if (euTravelDiaryPhotographDTO == null)
                {
                    euTravelDiaryPhotographDTO = new List<EuTravelDiaryPhotographDTO>();
                }
                return euTravelDiaryPhotographDTO.ToList();
            }
            set
            {
                if (euTravelDiaryPhotographDTO is EuTravelDiaryPhotographDTO[])
                {
                    euTravelDiaryPhotographDTO = euTravelDiaryPhotographDTO.ToList();
                }
                if (euTravelDiaryPhotographDTO != null)
                {
                    var __itemsToDelete = new List<EuTravelDiaryPhotographDTO>(euTravelDiaryPhotographDTO);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveEuTravelDiaryPhotographDTO(__item);
                    }
                }
                if(value == null)
                {
                    euTravelDiaryPhotographDTO = new List<EuTravelDiaryPhotographDTO>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddEuTravelDiaryPhotographDTO(__item);
                }
            }
        }
        public virtual void AddEuTravelDiaryPhotographDTO(IList<EuTravelDiaryPhotographDTO> __items)
        {
            foreach (var __item in __items)
            {
                AddEuTravelDiaryPhotographDTO(__item);
            }
        }
        public virtual void AddEuTravelDiaryPhotographDTO(EuTravelDiaryPhotographDTO __item)
        {
            if (__item != null && euTravelDiaryPhotographDTO!=null && !euTravelDiaryPhotographDTO.Contains(__item))
            {
                euTravelDiaryPhotographDTO.Add(__item);
                if (__item.EuTravelDiaryPOIDTO != this)
                    __item.EuTravelDiaryPOIDTO = this;
            }
        }

        public virtual void RemoveEuTravelDiaryPhotographDTO(EuTravelDiaryPhotographDTO __item)
        {
            if (__item != null && euTravelDiaryPhotographDTO!=null && euTravelDiaryPhotographDTO.Contains(__item))
            {
                euTravelDiaryPhotographDTO.Remove(__item);
                __item.EuTravelDiaryPOIDTO = null;
            }
        }
        public virtual void SetEuTravelDiaryPhotographDTOAt(EuTravelDiaryPhotographDTO __item, int __index)
        {
            if (__item == null)
            {
                euTravelDiaryPhotographDTO[__index].EuTravelDiaryPOIDTO = null;
            }
            else
            {
                euTravelDiaryPhotographDTO[__index] = __item;
                if (__item.EuTravelDiaryPOIDTO != this)
                    __item.EuTravelDiaryPOIDTO = this;
            }
        }

        public virtual void ClearEuTravelDiaryPhotographDTO()
        {
            if (euTravelDiaryPhotographDTO!=null)
            {
                var __itemsToRemove = euTravelDiaryPhotographDTO.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveEuTravelDiaryPhotographDTO(__item);
                }
            }
        }
        [DataMember(Name="EuTravelDiaryNoteDTO")]
        protected IList<EuTravelDiaryNoteDTO> euTravelDiaryNoteDTO = new List<EuTravelDiaryNoteDTO>();
        public virtual List<EuTravelDiaryNoteDTO> EuTravelDiaryNoteDTO
        {
            get
            {
                if (euTravelDiaryNoteDTO is EuTravelDiaryNoteDTO[])
                {
                    euTravelDiaryNoteDTO = euTravelDiaryNoteDTO.ToList();
                }
                if (euTravelDiaryNoteDTO == null)
                {
                    euTravelDiaryNoteDTO = new List<EuTravelDiaryNoteDTO>();
                }
                return euTravelDiaryNoteDTO.ToList();
            }
            set
            {
                if (euTravelDiaryNoteDTO is EuTravelDiaryNoteDTO[])
                {
                    euTravelDiaryNoteDTO = euTravelDiaryNoteDTO.ToList();
                }
                if (euTravelDiaryNoteDTO != null)
                {
                    var __itemsToDelete = new List<EuTravelDiaryNoteDTO>(euTravelDiaryNoteDTO);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveEuTravelDiaryNoteDTO(__item);
                    }
                }
                if(value == null)
                {
                    euTravelDiaryNoteDTO = new List<EuTravelDiaryNoteDTO>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddEuTravelDiaryNoteDTO(__item);
                }
            }
        }
        public virtual void AddEuTravelDiaryNoteDTO(IList<EuTravelDiaryNoteDTO> __items)
        {
            foreach (var __item in __items)
            {
                AddEuTravelDiaryNoteDTO(__item);
            }
        }
        public virtual void AddEuTravelDiaryNoteDTO(EuTravelDiaryNoteDTO __item)
        {
            if (__item != null && euTravelDiaryNoteDTO!=null && !euTravelDiaryNoteDTO.Contains(__item))
            {
                euTravelDiaryNoteDTO.Add(__item);
                if (__item.EuTravelDiaryPOIDTO != this)
                    __item.EuTravelDiaryPOIDTO = this;
            }
        }

        public virtual void RemoveEuTravelDiaryNoteDTO(EuTravelDiaryNoteDTO __item)
        {
            if (__item != null && euTravelDiaryNoteDTO!=null && euTravelDiaryNoteDTO.Contains(__item))
            {
                euTravelDiaryNoteDTO.Remove(__item);
                __item.EuTravelDiaryPOIDTO = null;
            }
        }
        public virtual void SetEuTravelDiaryNoteDTOAt(EuTravelDiaryNoteDTO __item, int __index)
        {
            if (__item == null)
            {
                euTravelDiaryNoteDTO[__index].EuTravelDiaryPOIDTO = null;
            }
            else
            {
                euTravelDiaryNoteDTO[__index] = __item;
                if (__item.EuTravelDiaryPOIDTO != this)
                    __item.EuTravelDiaryPOIDTO = this;
            }
        }

        public virtual void ClearEuTravelDiaryNoteDTO()
        {
            if (euTravelDiaryNoteDTO!=null)
            {
                var __itemsToRemove = euTravelDiaryNoteDTO.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveEuTravelDiaryNoteDTO(__item);
                }
            }
        }
        [DataMember(Name="EuTravelDiaryGeoCoordinatesDTO")]
        protected EuTravelDiaryGeoCoordinatesDTO euTravelDiaryGeoCoordinatesDTO;
        public virtual EuTravelDiaryGeoCoordinatesDTO EuTravelDiaryGeoCoordinatesDTO
        {
            get
            {
                return euTravelDiaryGeoCoordinatesDTO;
            }
            set
            {
                if(Equals(euTravelDiaryGeoCoordinatesDTO, value)) return;
                var __oldValue = euTravelDiaryGeoCoordinatesDTO;
                if (value != null)
                {
                    euTravelDiaryGeoCoordinatesDTO = value;
                }
                else
                {
                    if (euTravelDiaryGeoCoordinatesDTO != null)
                    {
                        euTravelDiaryGeoCoordinatesDTO = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the EuTravelDiaryPOIDTO class
/// </summary>
/// <returns>New EuTravelDiaryPOIDTO object</returns>
/// <remarks></remarks>
        public EuTravelDiaryPOIDTO() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (Description != null && Description.Length > 100)
            {
                __errors.Add("Length of property 'Description' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'EuTravelDiaryPOIDTO' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [EuTravelDiaryPOIDTO] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual EuTravelDiaryPOIDTO Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, EuTravelDiaryPOIDTO copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (EuTravelDiaryPOIDTO)copiedObjects[this];
            copy = copy ?? new EuTravelDiaryPOIDTO();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.IsPublic = this.IsPublic;
            copy.Name = this.Name;
            copy.Description = this.Description;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.euTravelDiaryPhotographDTO = new List<EuTravelDiaryPhotographDTO>();
            if(deep && this.euTravelDiaryPhotographDTO != null)
            {
                foreach (var __item in this.euTravelDiaryPhotographDTO)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddEuTravelDiaryPhotographDTO(__item);
                        else
                            copy.AddEuTravelDiaryPhotographDTO(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddEuTravelDiaryPhotographDTO((EuTravelDiaryPhotographDTO)copiedObjects[__item]);
                    }
                }
            }
            copy.euTravelDiaryNoteDTO = new List<EuTravelDiaryNoteDTO>();
            if(deep && this.euTravelDiaryNoteDTO != null)
            {
                foreach (var __item in this.euTravelDiaryNoteDTO)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddEuTravelDiaryNoteDTO(__item);
                        else
                            copy.AddEuTravelDiaryNoteDTO(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddEuTravelDiaryNoteDTO((EuTravelDiaryNoteDTO)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.euTravelDiaryGeoCoordinatesDTO != null)
            {
                if (!copiedObjects.Contains(this.euTravelDiaryGeoCoordinatesDTO))
                {
                    if (asNew && reuseNestedObjects)
                        copy.EuTravelDiaryGeoCoordinatesDTO = this.EuTravelDiaryGeoCoordinatesDTO;
                    else if (asNew)
                        copy.EuTravelDiaryGeoCoordinatesDTO = this.EuTravelDiaryGeoCoordinatesDTO.Copy(deep, copiedObjects, true);
                    else
                        copy.euTravelDiaryGeoCoordinatesDTO = this.euTravelDiaryGeoCoordinatesDTO.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.EuTravelDiaryGeoCoordinatesDTO = (EuTravelDiaryGeoCoordinatesDTO)copiedObjects[this.EuTravelDiaryGeoCoordinatesDTO];
                    else
                        copy.euTravelDiaryGeoCoordinatesDTO = (EuTravelDiaryGeoCoordinatesDTO)copiedObjects[this.EuTravelDiaryGeoCoordinatesDTO];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EuTravelDiaryPOIDTO;
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
        protected bool HasSameNonDefaultIdAs(EuTravelDiaryPOIDTO compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
