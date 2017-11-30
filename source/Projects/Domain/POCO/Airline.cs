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
    /// The Airline class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(OperatorCompany))]

    public class Airline : OperatorCompany, IDomainModelClass
    {
        #region Airline's Fields
        [DataMember(Name="ICAOCode")]
        protected string iCAOCode;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="IsLowCost")]
        protected bool isLowCost;
        #endregion
        #region Airline's Properties
/// <summary>
/// The ICAOCode property
///
/// </summary>
///
        public virtual string ICAOCode
        {
            get
            {
                return iCAOCode;
            }
            set
            {
                iCAOCode = value;
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
/// The IsLowCost property
///
/// </summary>
///
        public virtual bool IsLowCost
        {
            get
            {
                return isLowCost;
            }
            set
            {
                isLowCost = value;
            }
        }
        #endregion
        #region Airline's Participant Properties
        [DataMember(Name="OperatingRoutes")]
        protected IList<FlightRoute> operatingRoutes = new List<FlightRoute>();
        public virtual List<FlightRoute> OperatingRoutes
        {
            get
            {
                if (operatingRoutes is FlightRoute[])
                {
                    operatingRoutes = operatingRoutes.ToList();
                }
                if (operatingRoutes == null)
                {
                    operatingRoutes = new List<FlightRoute>();
                }
                return operatingRoutes.ToList();
            }
            set
            {
                if (operatingRoutes is FlightRoute[])
                {
                    operatingRoutes = operatingRoutes.ToList();
                }
                if (operatingRoutes != null)
                {
                    var __itemsToDelete = new List<FlightRoute>(operatingRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOperatingRoutes(__item);
                    }
                }
                if(value == null)
                {
                    operatingRoutes = new List<FlightRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOperatingRoutes(__item);
                }
            }
        }
        public virtual void AddOperatingRoutes(IList<FlightRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddOperatingRoutes(__item);
            }
        }
        public virtual void AddOperatingRoutes(FlightRoute __item)
        {
            if (__item != null && operatingRoutes!=null && !operatingRoutes.Contains(__item))
            {
                operatingRoutes.Add(__item);
                if (__item.OperatingAirline != this)
                    __item.OperatingAirline = this;
            }
        }

        public virtual void RemoveOperatingRoutes(FlightRoute __item)
        {
            if (__item != null && operatingRoutes!=null && operatingRoutes.Contains(__item))
            {
                operatingRoutes.Remove(__item);
                __item.OperatingAirline = null;
            }
        }
        public virtual void SetOperatingRoutesAt(FlightRoute __item, int __index)
        {
            if (__item == null)
            {
                operatingRoutes[__index].OperatingAirline = null;
            }
            else
            {
                operatingRoutes[__index] = __item;
                if (__item.OperatingAirline != this)
                    __item.OperatingAirline = this;
            }
        }

        public virtual void ClearOperatingRoutes()
        {
            if (operatingRoutes!=null)
            {
                var __itemsToRemove = operatingRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOperatingRoutes(__item);
                }
            }
        }
        [DataMember(Name="MarketingRoutes")]
        protected IList<FlightRoute> marketingRoutes = new List<FlightRoute>();
        public virtual List<FlightRoute> MarketingRoutes
        {
            get
            {
                if (marketingRoutes is FlightRoute[])
                {
                    marketingRoutes = marketingRoutes.ToList();
                }
                if (marketingRoutes == null)
                {
                    marketingRoutes = new List<FlightRoute>();
                }
                return marketingRoutes.ToList();
            }
            set
            {
                if (marketingRoutes is FlightRoute[])
                {
                    marketingRoutes = marketingRoutes.ToList();
                }
                if (marketingRoutes != null)
                {
                    var __itemsToDelete = new List<FlightRoute>(marketingRoutes);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveMarketingRoutes(__item);
                    }
                }
                if(value == null)
                {
                    marketingRoutes = new List<FlightRoute>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddMarketingRoutes(__item);
                }
            }
        }
        public virtual void AddMarketingRoutes(IList<FlightRoute> __items)
        {
            foreach (var __item in __items)
            {
                AddMarketingRoutes(__item);
            }
        }
        public virtual void AddMarketingRoutes(FlightRoute __item)
        {
            if (__item != null && marketingRoutes!=null && !marketingRoutes.Contains(__item))
            {
                marketingRoutes.Add(__item);
                if (__item.MarketingAirline != this)
                    __item.MarketingAirline = this;
            }
        }

        public virtual void RemoveMarketingRoutes(FlightRoute __item)
        {
            if (__item != null && marketingRoutes!=null && marketingRoutes.Contains(__item))
            {
                marketingRoutes.Remove(__item);
                __item.MarketingAirline = null;
            }
        }
        public virtual void SetMarketingRoutesAt(FlightRoute __item, int __index)
        {
            if (__item == null)
            {
                marketingRoutes[__index].MarketingAirline = null;
            }
            else
            {
                marketingRoutes[__index] = __item;
                if (__item.MarketingAirline != this)
                    __item.MarketingAirline = this;
            }
        }

        public virtual void ClearMarketingRoutes()
        {
            if (marketingRoutes!=null)
            {
                var __itemsToRemove = marketingRoutes.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveMarketingRoutes(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Airline class
/// </summary>
/// <returns>New Airline object</returns>
/// <remarks></remarks>
        public Airline(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (ICAOCode != null && ICAOCode.Length > 100)
            {
                __errors.Add("Length of property 'ICAOCode' cannot be greater than 100.");
            }
            if (IATACode != null && IATACode.Length > 100)
            {
                __errors.Add("Length of property 'IATACode' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Airline' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Airline] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Airline Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Airline copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Airline)copiedObjects[this];
            copy = copy ?? new Airline();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.ICAOCode = this.ICAOCode;
            copy.IATACode = this.IATACode;
            copy.IsLowCost = this.IsLowCost;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.operatingRoutes = new List<FlightRoute>();
            if(deep && this.operatingRoutes != null)
            {
                foreach (var __item in this.operatingRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOperatingRoutes(__item);
                        else
                            copy.AddOperatingRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOperatingRoutes((FlightRoute)copiedObjects[__item]);
                    }
                }
            }
            copy.marketingRoutes = new List<FlightRoute>();
            if(deep && this.marketingRoutes != null)
            {
                foreach (var __item in this.marketingRoutes)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddMarketingRoutes(__item);
                        else
                            copy.AddMarketingRoutes(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddMarketingRoutes((FlightRoute)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Airline;
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
