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
    /// The VehicleType class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class VehicleType : IDomainModelClass
    {
        #region VehicleType's Fields

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
        [DataMember(Name="Code")]
        protected string code;
        [DataMember(Name="Value")]
        protected string _value;
        [DataMember(Name="Model")]
        protected string model;
        [DataMember(Name="Manufacturer")]
        protected string manufacturer;
        [DataMember(Name="Capacity")]
        protected int? capacity;
        [DataMember(Name="Private")]
        protected bool _private;
        [DataMember(Name="HasTrailer")]
        protected bool hasTrailer;
        [DataMember(Name="TransportMode")]
        protected EuTravel_2.BO.TransportMode transportMode;
        #endregion
        #region VehicleType's Properties
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
/// The Value property
///
/// </summary>
///
        public virtual string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
/// <summary>
/// The Model property
///
/// </summary>
///
        public virtual string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
/// <summary>
/// The Manufacturer property
///
/// </summary>
///
        public virtual string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
/// <summary>
/// The Capacity property
///
/// </summary>
///
        public virtual int? Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
/// <summary>
/// The Private property
///
/// </summary>
///
        public virtual bool Private
        {
            get
            {
                return _private;
            }
            set
            {
                _private = value;
            }
        }
/// <summary>
/// The HasTrailer property
///
/// </summary>
///
        public virtual bool HasTrailer
        {
            get
            {
                return hasTrailer;
            }
            set
            {
                hasTrailer = value;
            }
        }
/// <summary>
/// The TransportMode property
///
/// </summary>
///
        public virtual EuTravel_2.BO.TransportMode TransportMode
        {
            get
            {
                return transportMode;
            }
            set
            {
                transportMode = value;
            }
        }
        #endregion
        #region VehicleType's Participant Properties
        [DataMember(Name="FuelType")]
        protected FuelType fuelType;
        public virtual FuelType FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                if(Equals(fuelType, value)) return;
                var __oldValue = fuelType;
                if (value != null)
                {
                    fuelType = value;
                }
                else
                {
                    fuelType = null;
                }
            }
        }
        [DataMember(Name="Height")]
        protected Dimension height;
        public virtual Dimension Height
        {
            get
            {
                return height;
            }
            set
            {
                if(Equals(height, value)) return;
                var __oldValue = height;
                if (value != null)
                {
                    height = value;
                }
                else
                {
                    if (height != null)
                    {
                        height = null;
                    }
                }
            }
        }
        [DataMember(Name="Width")]
        protected Dimension width;
        public virtual Dimension Width
        {
            get
            {
                return width;
            }
            set
            {
                if(Equals(width, value)) return;
                var __oldValue = width;
                if (value != null)
                {
                    width = value;
                }
                else
                {
                    if (width != null)
                    {
                        width = null;
                    }
                }
            }
        }
        [DataMember(Name="Length")]
        protected Dimension length;
        public virtual Dimension Length
        {
            get
            {
                return length;
            }
            set
            {
                if(Equals(length, value)) return;
                var __oldValue = length;
                if (value != null)
                {
                    length = value;
                }
                else
                {
                    if (length != null)
                    {
                        length = null;
                    }
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the VehicleType class
/// </summary>
/// <returns>New VehicleType object</returns>
/// <remarks></remarks>
        public VehicleType() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (Code != null && Code.Length > 100)
            {
                __errors.Add("Length of property 'Code' cannot be greater than 100.");
            }
            if (Value != null && Value.Length > 100)
            {
                __errors.Add("Length of property 'Value' cannot be greater than 100.");
            }
            if (Model != null && Model.Length > 100)
            {
                __errors.Add("Length of property 'Model' cannot be greater than 100.");
            }
            if (Manufacturer != null && Manufacturer.Length > 100)
            {
                __errors.Add("Length of property 'Manufacturer' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'VehicleType' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [VehicleType] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual VehicleType Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, VehicleType copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (VehicleType)copiedObjects[this];
            copy = copy ?? new VehicleType();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.Code = this.Code;
            copy.Value = this.Value;
            copy.Model = this.Model;
            copy.Manufacturer = this.Manufacturer;
            copy.Capacity = this.Capacity;
            copy.Private = this.Private;
            copy.HasTrailer = this.HasTrailer;
            copy.TransportMode = this.TransportMode;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.fuelType != null)
            {
                if (!copiedObjects.Contains(this.fuelType))
                {
                    if (asNew && reuseNestedObjects)
                        copy.FuelType = this.FuelType;
                    else if (asNew)
                        copy.FuelType = this.FuelType.Copy(deep, copiedObjects, true);
                    else
                        copy.fuelType = this.fuelType.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.FuelType = (FuelType)copiedObjects[this.FuelType];
                    else
                        copy.fuelType = (FuelType)copiedObjects[this.FuelType];
                }
            }
            if(deep && this.height != null)
            {
                if (!copiedObjects.Contains(this.height))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Height = this.Height;
                    else if (asNew)
                        copy.Height = this.Height.Copy(deep, copiedObjects, true);
                    else
                        copy.height = this.height.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Height = (Dimension)copiedObjects[this.Height];
                    else
                        copy.height = (Dimension)copiedObjects[this.Height];
                }
            }
            if(deep && this.width != null)
            {
                if (!copiedObjects.Contains(this.width))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Width = this.Width;
                    else if (asNew)
                        copy.Width = this.Width.Copy(deep, copiedObjects, true);
                    else
                        copy.width = this.width.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Width = (Dimension)copiedObjects[this.Width];
                    else
                        copy.width = (Dimension)copiedObjects[this.Width];
                }
            }
            if(deep && this.length != null)
            {
                if (!copiedObjects.Contains(this.length))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Length = this.Length;
                    else if (asNew)
                        copy.Length = this.Length.Copy(deep, copiedObjects, true);
                    else
                        copy.length = this.length.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Length = (Dimension)copiedObjects[this.Length];
                    else
                        copy.length = (Dimension)copiedObjects[this.Length];
                }
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as VehicleType;
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
        protected bool HasSameNonDefaultIdAs(VehicleType compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion
    }
}
