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
    /// The Port class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Location))]

    public class Port : Location, IDomainModelClass
    {
        #region Port's Fields
        [DataMember(Name="UNCTAD")]
        protected string uNCTAD;
        [DataMember(Name="UNICORNCode")]
        protected string uNICORNCode;
        [DataMember(Name="PharosCode")]
        protected string pharosCode;
        [DataMember(Name="ForthCRSAbbreviation")]
        protected string forthCRSAbbreviation;
        #endregion
        #region Port's Properties
/// <summary>
/// The UNCTAD property
///
/// </summary>
///
        public virtual string UNCTAD
        {
            get
            {
                return uNCTAD;
            }
            set
            {
                uNCTAD = value;
            }
        }
/// <summary>
/// The UNICORNCode property
///
/// </summary>
///
        public virtual string UNICORNCode
        {
            get
            {
                return uNICORNCode;
            }
            set
            {
                uNICORNCode = value;
            }
        }
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
/// The ForthCRSAbbreviation property
///
/// </summary>
///
        public virtual string ForthCRSAbbreviation
        {
            get
            {
                return forthCRSAbbreviation;
            }
            set
            {
                forthCRSAbbreviation = value;
            }
        }
        #endregion
        #region Port's Participant Properties
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
                if (!__item.IntermediatePorts.Contains(this))
                    __item.AddIntermediatePorts(this);
            }
        }

        public virtual void RemoveShippingLines(MarineRoute __item)
        {
            if (__item != null && shippingLines!=null && shippingLines.Contains(__item))
            {
                shippingLines.Remove(__item);
                if(__item.IntermediatePorts.Contains(this))
                    __item.RemoveIntermediatePorts(this);
            }
        }
        public virtual void SetShippingLinesAt(MarineRoute __item, int __index)
        {
            if (__item == null)
            {
                shippingLines[__index].RemoveIntermediatePorts(this);
            }
            else
            {
                shippingLines[__index] = __item;
                if (!__item.IntermediatePorts.Contains(this))
                    __item.AddIntermediatePorts(this);
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
        [DataMember(Name="OutgoingMarineRoutes")]
        protected IList<MarineRoute> outgoingMarineRoutes = new List<MarineRoute>();
        public virtual List<MarineRoute> OutgoingMarineRoutes
        {
            get
            {
                if (outgoingMarineRoutes is MarineRoute[])
                {
                    outgoingMarineRoutes = outgoingMarineRoutes.ToList();
                }
                if (outgoingMarineRoutes == null)
                {
                    outgoingMarineRoutes = new List<MarineRoute>();
                }
                return outgoingMarineRoutes.ToList();
            }
            set
            {
                if (outgoingMarineRoutes is MarineRoute[])
                {
                    outgoingMarineRoutes = outgoingMarineRoutes.ToList();
                }
                if (outgoingMarineRoutes != null)
                {
                    var __itemsToDelete = new List<MarineRoute>(outgoingMarineRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOutgoingMarineRoutes(__item);
                    }
                }
                if(value == null)
                {
                    outgoingMarineRoutes = new List<MarineRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOutgoingMarineRoutes(__item);
                }
            }
        }
        public virtual void AddOutgoingMarineRoutes(IList<MarineRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddOutgoingMarineRoutes(__item);
            }
        }
        public virtual void AddOutgoingMarineRoutes(MarineRoute __item)
        {
            if (__item != null && outgoingMarineRoutes!=null && !outgoingMarineRoutes.Contains(__item))
            {
                outgoingMarineRoutes.Add(__item);
                if (__item.Origin != this)
                    __item.Origin = this;
            }
        }

        public virtual void RemoveOutgoingMarineRoutes(MarineRoute __item)
        {
            if (__item != null && outgoingMarineRoutes!=null && outgoingMarineRoutes.Contains(__item))
            {
                outgoingMarineRoutes.Remove(__item);
                __item.Origin = null;
            }
        }
        public virtual void SetOutgoingMarineRoutesAt(MarineRoute __item, int __index)
        {
            if (__item == null)
            {
                outgoingMarineRoutes[__index].Origin = null;
            }
            else
            {
                outgoingMarineRoutes[__index] = __item;
                if (__item.Origin != this)
                    __item.Origin = this;
            }
        }

        public virtual void ClearOutgoingMarineRoutes()
        {
            if (outgoingMarineRoutes!=null)
            {
                var __itemsToRemove = outgoingMarineRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOutgoingMarineRoutes(__item);
                }
            }
        }
        [DataMember(Name="IncomingMarineRoutes")]
        protected IList<MarineRoute> incomingMarineRoutes = new List<MarineRoute>();
        public virtual List<MarineRoute> IncomingMarineRoutes
        {
            get
            {
                if (incomingMarineRoutes is MarineRoute[])
                {
                    incomingMarineRoutes = incomingMarineRoutes.ToList();
                }
                if (incomingMarineRoutes == null)
                {
                    incomingMarineRoutes = new List<MarineRoute>();
                }
                return incomingMarineRoutes.ToList();
            }
            set
            {
                if (incomingMarineRoutes is MarineRoute[])
                {
                    incomingMarineRoutes = incomingMarineRoutes.ToList();
                }
                if (incomingMarineRoutes != null)
                {
                    var __itemsToDelete = new List<MarineRoute>(incomingMarineRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveIncomingMarineRoutes(__item);
                    }
                }
                if(value == null)
                {
                    incomingMarineRoutes = new List<MarineRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddIncomingMarineRoutes(__item);
                }
            }
        }
        public virtual void AddIncomingMarineRoutes(IList<MarineRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddIncomingMarineRoutes(__item);
            }
        }
        public virtual void AddIncomingMarineRoutes(MarineRoute __item)
        {
            if (__item != null && incomingMarineRoutes!=null && !incomingMarineRoutes.Contains(__item))
            {
                incomingMarineRoutes.Add(__item);
                if (__item.Destination != this)
                    __item.Destination = this;
            }
        }

        public virtual void RemoveIncomingMarineRoutes(MarineRoute __item)
        {
            if (__item != null && incomingMarineRoutes!=null && incomingMarineRoutes.Contains(__item))
            {
                incomingMarineRoutes.Remove(__item);
                __item.Destination = null;
            }
        }
        public virtual void SetIncomingMarineRoutesAt(MarineRoute __item, int __index)
        {
            if (__item == null)
            {
                incomingMarineRoutes[__index].Destination = null;
            }
            else
            {
                incomingMarineRoutes[__index] = __item;
                if (__item.Destination != this)
                    __item.Destination = this;
            }
        }

        public virtual void ClearIncomingMarineRoutes()
        {
            if (incomingMarineRoutes!=null)
            {
                var __itemsToRemove = incomingMarineRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveIncomingMarineRoutes(__item);
                }
            }
        }
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
                        country.RemovePorts(this);
                    country = value;
                    country.AddPorts(this);
                }
                else
                {
                    if(country != null)
                        country.RemovePorts(this);
                    country = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Port class
/// </summary>
/// <returns>New Port object</returns>
/// <remarks></remarks>
        public Port(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (UNCTAD != null && UNCTAD.Length > 100)
            {
                __errors.Add("Length of property 'UNCTAD' cannot be greater than 100.");
            }
            if (UNICORNCode != null && UNICORNCode.Length > 100)
            {
                __errors.Add("Length of property 'UNICORNCode' cannot be greater than 100.");
            }
            if (PharosCode != null && PharosCode.Length > 100)
            {
                __errors.Add("Length of property 'PharosCode' cannot be greater than 100.");
            }
            if (ForthCRSAbbreviation != null && ForthCRSAbbreviation.Length > 100)
            {
                __errors.Add("Length of property 'ForthCRSAbbreviation' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Port' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Port] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Port Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Port copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Port)copiedObjects[this];
            copy = copy ?? new Port();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.UNCTAD = this.UNCTAD;
            copy.UNICORNCode = this.UNICORNCode;
            copy.PharosCode = this.PharosCode;
            copy.ForthCRSAbbreviation = this.ForthCRSAbbreviation;
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
            copy.outgoingMarineRoutes = new List<MarineRoute>();
            if(deep && this.outgoingMarineRoutes != null)
            {
                foreach (var __item in this.outgoingMarineRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOutgoingMarineRoutes(__item);
                        else
                            copy.AddOutgoingMarineRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOutgoingMarineRoutes((MarineRoute)copiedObjects[__item]);
                    }
                }
            }
            copy.incomingMarineRoutes = new List<MarineRoute>();
            if(deep && this.incomingMarineRoutes != null)
            {
                foreach (var __item in this.incomingMarineRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddIncomingMarineRoutes(__item);
                        else
                            copy.AddIncomingMarineRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddIncomingMarineRoutes((MarineRoute)copiedObjects[__item]);
                    }
                }
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
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Port;
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
