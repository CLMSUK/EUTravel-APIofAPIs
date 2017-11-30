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
    /// The MarineAgency class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(OperatorCompany))]

    public class MarineAgency : OperatorCompany, IDomainModelClass
    {
        #region MarineAgency's Fields
        [DataMember(Name="PharosCode")]
        protected string pharosCode;
        [DataMember(Name="ForthCRSCode")]
        protected string forthCRSCode;
        [DataMember(Name="ForthCRSNumber")]
        protected string forthCRSNumber;
        [DataMember(Name="FerryGatewayCode")]
        protected string ferryGatewayCode;
        #endregion
        #region MarineAgency's Properties
/// <summary>
/// The PharosCode property
///
/// </summary>
///
        public virtual string PharosCode
        {
            get
            {
                return pharosCode;
            }
            set
            {
                pharosCode = value;
            }
        }
/// <summary>
/// The ForthCRSCode property
///
/// </summary>
///
        public virtual string ForthCRSCode
        {
            get
            {
                return forthCRSCode;
            }
            set
            {
                forthCRSCode = value;
            }
        }
/// <summary>
/// The ForthCRSNumber property
///
/// </summary>
///
        public virtual string ForthCRSNumber
        {
            get
            {
                return forthCRSNumber;
            }
            set
            {
                forthCRSNumber = value;
            }
        }
/// <summary>
/// The FerryGatewayCode property
///
/// </summary>
///
        public virtual string FerryGatewayCode
        {
            get
            {
                return ferryGatewayCode;
            }
            set
            {
                ferryGatewayCode = value;
            }
        }
        #endregion
        #region MarineAgency's Participant Properties
        [DataMember(Name="ShippingLines")]
        protected IList<MarineRoute> shippingLines = new List<MarineRoute>();
        public virtual List<MarineRoute> ShippingLines
        {
            get
            {
                if (shippingLines is MarineRoute[])
                {
                    shippingLines = shippingLines.ToList();
                }
                if (shippingLines == null)
                {
                    shippingLines = new List<MarineRoute>();
                }
                return shippingLines.ToList();
            }
            set
            {
                if (shippingLines is MarineRoute[])
                {
                    shippingLines = shippingLines.ToList();
                }
                if (shippingLines != null)
                {
                    var __itemsToDelete = new List<MarineRoute>(shippingLines);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveShippingLines(__item);
                    }
                }
                if(value == null)
                {
                    shippingLines = new List<MarineRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddShippingLines(__item);
                }
            }
        }
        public virtual void AddShippingLines(IList<MarineRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddShippingLines(__item);
            }
        }
        public virtual void AddShippingLines(MarineRoute __item)
        {
            if (__item != null && shippingLines!=null && !shippingLines.Contains(__item))
            {
                shippingLines.Add(__item);
                if (__item.Agency != this)
                    __item.Agency = this;
            }
        }

        public virtual void RemoveShippingLines(MarineRoute __item)
        {
            if (__item != null && shippingLines!=null && shippingLines.Contains(__item))
            {
                shippingLines.Remove(__item);
                __item.Agency = null;
            }
        }
        public virtual void SetShippingLinesAt(MarineRoute __item, int __index)
        {
            if (__item == null)
            {
                shippingLines[__index].Agency = null;
            }
            else
            {
                shippingLines[__index] = __item;
                if (__item.Agency != this)
                    __item.Agency = this;
            }
        }

        public virtual void ClearShippingLines()
        {
            if (shippingLines!=null)
            {
                var __itemsToRemove = shippingLines.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveShippingLines(__item);
                }
            }
        }
        [DataMember(Name="OwnedFerries")]
        protected IList<Ferry> ownedFerries = new List<Ferry>();
        public virtual List<Ferry> OwnedFerries
        {
            get
            {
                if (ownedFerries is Ferry[])
                {
                    ownedFerries = ownedFerries.ToList();
                }
                if (ownedFerries == null)
                {
                    ownedFerries = new List<Ferry>();
                }
                return ownedFerries.ToList();
            }
            set
            {
                if (ownedFerries is Ferry[])
                {
                    ownedFerries = ownedFerries.ToList();
                }
                if (ownedFerries != null)
                {
                    var __itemsToDelete = new List<Ferry>(ownedFerries);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOwnedFerries(__item);
                    }
                }
                if(value == null)
                {
                    ownedFerries = new List<Ferry>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOwnedFerries(__item);
                }
            }
        }
        public virtual void AddOwnedFerries(IList<Ferry> __items)
        {
            foreach (var __item in __items)
            {
                AddOwnedFerries(__item);
            }
        }
        public virtual void AddOwnedFerries(Ferry __item)
        {
            if (__item != null && ownedFerries!=null && !ownedFerries.Contains(__item))
            {
                ownedFerries.Add(__item);
                if (__item.MarineAgency != this)
                    __item.MarineAgency = this;
            }
        }

        public virtual void RemoveOwnedFerries(Ferry __item)
        {
            if (__item != null && ownedFerries!=null && ownedFerries.Contains(__item))
            {
                ownedFerries.Remove(__item);
                __item.MarineAgency = null;
            }
        }
        public virtual void SetOwnedFerriesAt(Ferry __item, int __index)
        {
            if (__item == null)
            {
                ownedFerries[__index].MarineAgency = null;
            }
            else
            {
                ownedFerries[__index] = __item;
                if (__item.MarineAgency != this)
                    __item.MarineAgency = this;
            }
        }

        public virtual void ClearOwnedFerries()
        {
            if (ownedFerries!=null)
            {
                var __itemsToRemove = ownedFerries.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOwnedFerries(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the MarineAgency class
/// </summary>
/// <returns>New MarineAgency object</returns>
/// <remarks></remarks>
        public MarineAgency(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (PharosCode != null && PharosCode.Length > 100)
            {
                __errors.Add("Length of property 'PharosCode' cannot be greater than 100.");
            }
            if (ForthCRSCode != null && ForthCRSCode.Length > 100)
            {
                __errors.Add("Length of property 'ForthCRSCode' cannot be greater than 100.");
            }
            if (ForthCRSNumber != null && ForthCRSNumber.Length > 100)
            {
                __errors.Add("Length of property 'ForthCRSNumber' cannot be greater than 100.");
            }
            if (FerryGatewayCode != null && FerryGatewayCode.Length > 100)
            {
                __errors.Add("Length of property 'FerryGatewayCode' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'MarineAgency' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [MarineAgency] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual MarineAgency Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, MarineAgency copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (MarineAgency)copiedObjects[this];
            copy = copy ?? new MarineAgency();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.PharosCode = this.PharosCode;
            copy.ForthCRSCode = this.ForthCRSCode;
            copy.ForthCRSNumber = this.ForthCRSNumber;
            copy.FerryGatewayCode = this.FerryGatewayCode;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.shippingLines = new List<MarineRoute>();
            if(deep && this.shippingLines != null)
            {
                foreach (var __item in this.shippingLines)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddShippingLines(__item);
                        else
                            copy.AddShippingLines(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddShippingLines((MarineRoute)copiedObjects[__item]);
                    }
                }
            }
            copy.ownedFerries = new List<Ferry>();
            if(deep && this.ownedFerries != null)
            {
                foreach (var __item in this.ownedFerries)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOwnedFerries(__item);
                        else
                            copy.AddOwnedFerries(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOwnedFerries((Ferry)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as MarineAgency;
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
