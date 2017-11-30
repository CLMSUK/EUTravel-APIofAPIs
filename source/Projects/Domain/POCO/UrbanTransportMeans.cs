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
    /// The UrbanTransportMeans class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Vehicle))]

    public class UrbanTransportMeans : Vehicle, IDomainModelClass
    {
        #region UrbanTransportMeans's Fields
        [DataMember(Name="Name")]
        protected string name;
        [DataMember(Name="VendorCode")]
        protected string vendorCode;
        [DataMember(Name="DoorCount")]
        protected int? doorCount;
        [DataMember(Name="AirConditionAvailable")]
        protected bool airConditionAvailable;
        #endregion
        #region UrbanTransportMeans's Properties
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
/// The VendorCode property
///
/// </summary>
///
        public virtual string VendorCode
        {
            get
            {
                return vendorCode;
            }
            set
            {
                vendorCode = value;
            }
        }
/// <summary>
/// The DoorCount property
///
/// </summary>
///
        public virtual int? DoorCount
        {
            get
            {
                return doorCount;
            }
            set
            {
                doorCount = value;
            }
        }
/// <summary>
/// The AirConditionAvailable property
///
/// </summary>
///
        public virtual bool AirConditionAvailable
        {
            get
            {
                return airConditionAvailable;
            }
            set
            {
                airConditionAvailable = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the UrbanTransportMeans class
/// </summary>
/// <returns>New UrbanTransportMeans object</returns>
/// <remarks></remarks>
        public UrbanTransportMeans(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (Name != null && Name.Length > 100)
            {
                __errors.Add("Length of property 'Name' cannot be greater than 100.");
            }
            if (VendorCode != null && VendorCode.Length > 100)
            {
                __errors.Add("Length of property 'VendorCode' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'UrbanTransportMeans' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [UrbanTransportMeans] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual UrbanTransportMeans Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, UrbanTransportMeans copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (UrbanTransportMeans)copiedObjects[this];
            copy = copy ?? new UrbanTransportMeans();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.Name = this.Name;
            copy.VendorCode = this.VendorCode;
            copy.DoorCount = this.DoorCount;
            copy.AirConditionAvailable = this.AirConditionAvailable;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as UrbanTransportMeans;
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
