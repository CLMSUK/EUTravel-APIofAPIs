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
    /// The DistributionStation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Station))]

    public class DistributionStation : Station, IDomainModelClass
    {
        #region DistributionStation's Fields
        [DataMember(Name="NumericId")]
        protected int? numericId;
        [DataMember(Name="DistribusionId")]
        protected string distribusionId;
        [DataMember(Name="CountryCode")]
        protected string countryCode;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="Latitude")]
        protected double? latitude;
        [DataMember(Name="Longitude")]
        protected double? longitude;
        [DataMember(Name="CityName")]
        protected string cityName;
        #endregion
        #region DistributionStation's Properties
/// <summary>
/// The NumericId property
///
/// </summary>
///
        public virtual int? NumericId
        {
            get
            {
                return numericId;
            }
            set
            {
                numericId = value;
            }
        }
/// <summary>
/// The DistribusionId property
///
/// </summary>
///
        public virtual string DistribusionId
        {
            get
            {
                return distribusionId;
            }
            set
            {
                distribusionId = value;
            }
        }
/// <summary>
/// The CountryCode property
///
/// </summary>
///
        public virtual string CountryCode
        {
            get
            {
                return countryCode;
            }
            set
            {
                countryCode = value;
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
/// The Latitude property
///
/// </summary>
///
        public virtual double? Latitude
        {
            get
            {
                return latitude;
            }
            set
            {
                latitude = value;
            }
        }
/// <summary>
/// The Longitude property
///
/// </summary>
///
        public virtual double? Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
            }
        }
/// <summary>
/// The CityName property
///
/// </summary>
///
        public virtual string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                cityName = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the DistributionStation class
/// </summary>
/// <returns>New DistributionStation object</returns>
/// <remarks></remarks>
        public DistributionStation(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (DistribusionId != null && DistribusionId.Length > 100)
            {
                __errors.Add("Length of property 'DistribusionId' cannot be greater than 100.");
            }
            if (CountryCode != null && CountryCode.Length > 100)
            {
                __errors.Add("Length of property 'CountryCode' cannot be greater than 100.");
            }
            if (IATACode != null && IATACode.Length > 100)
            {
                __errors.Add("Length of property 'IATACode' cannot be greater than 100.");
            }
            if (CityName != null && CityName.Length > 100)
            {
                __errors.Add("Length of property 'CityName' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'DistributionStation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [DistributionStation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual DistributionStation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, DistributionStation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (DistributionStation)copiedObjects[this];
            copy = copy ?? new DistributionStation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.NumericId = this.NumericId;
            copy.DistribusionId = this.DistribusionId;
            copy.CountryCode = this.CountryCode;
            copy.IATACode = this.IATACode;
            copy.Latitude = this.Latitude;
            copy.Longitude = this.Longitude;
            copy.CityName = this.CityName;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as DistributionStation;
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
