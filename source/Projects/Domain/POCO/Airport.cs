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
    /// The Airport class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Location))]

    public class Airport : Location, IDomainModelClass
    {
        #region Airport's Fields
        [DataMember(Name="ICAOCode")]
        protected string iCAOCode;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="ShortName")]
        protected string shortName;
        #endregion
        #region Airport's Properties
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
        #region Airport's Participant Properties
        [DataMember(Name="Terminals")]
        protected IList<Terminal> terminals = new List<Terminal>();
        public virtual List<Terminal> Terminals
        {
            get
            {
                if (terminals is Terminal[])
                {
                    terminals = terminals.ToList();
                }
                if (terminals == null)
                {
                    terminals = new List<Terminal>();
                }
                return terminals.ToList();
            }
            set
            {
                if (terminals is Terminal[])
                {
                    terminals = terminals.ToList();
                }
                if (terminals != null)
                {
                    var __itemsToDelete = new List<Terminal>(terminals);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveTerminals(__item);
                    }
                }
                if(value == null)
                {
                    terminals = new List<Terminal>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddTerminals(__item);
                }
            }
        }
        public virtual void AddTerminals(IList<Terminal> __items)
        {
            foreach (var __item in __items)
            {
                AddTerminals(__item);
            }
        }
        public virtual void AddTerminals(Terminal __item)
        {
            if (__item != null && terminals!=null && !terminals.Contains(__item))
            {
                terminals.Add(__item);
                if (__item.Airport != this)
                    __item.Airport = this;
            }
        }

        public virtual void RemoveTerminals(Terminal __item)
        {
            if (__item != null && terminals!=null && terminals.Contains(__item))
            {
                terminals.Remove(__item);
                __item.Airport = null;
            }
        }
        public virtual void SetTerminalsAt(Terminal __item, int __index)
        {
            if (__item == null)
            {
                terminals[__index].Airport = null;
            }
            else
            {
                terminals[__index] = __item;
                if (__item.Airport != this)
                    __item.Airport = this;
            }
        }

        public virtual void ClearTerminals()
        {
            if (terminals!=null)
            {
                var __itemsToRemove = terminals.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveTerminals(__item);
                }
            }
        }
        [DataMember(Name="OperatingTimezone")]
        protected Timezone operatingTimezone;
        public virtual Timezone OperatingTimezone
        {
            get
            {
                return operatingTimezone;
            }
            set
            {
                if(Equals(operatingTimezone, value)) return;
                var __oldValue = operatingTimezone;
                if (value != null)
                {
                    operatingTimezone = value;
                }
                else
                {
                    if (operatingTimezone != null)
                    {
                        operatingTimezone = null;
                    }
                }
            }
        }
        [DataMember(Name="City")]
        protected City city;
        public virtual City City
        {
            get
            {
                return city;
            }
            set
            {
                if(Equals(city, value)) return;
                var __oldValue = city;
                if (value != null)
                {
                    if(city != null && !Equals(city, value))
                        city.RemoveAirports(this);
                    city = value;
                    city.AddAirports(this);
                }
                else
                {
                    if(city != null)
                        city.RemoveAirports(this);
                    city = null;
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the Airport class
/// </summary>
/// <returns>New Airport object</returns>
/// <remarks></remarks>
        public Airport(): base() {}
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
            if (ShortName != null && ShortName.Length > 100)
            {
                __errors.Add("Length of property 'ShortName' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'Airport' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [Airport] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual Airport Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, Airport copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (Airport)copiedObjects[this];
            copy = copy ?? new Airport();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.ICAOCode = this.ICAOCode;
            copy.IATACode = this.IATACode;
            copy.ShortName = this.ShortName;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            copy.terminals = new List<Terminal>();
            if(deep && this.terminals != null)
            {
                foreach (var __item in this.terminals)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddTerminals(__item);
                        else
                            copy.AddTerminals(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddTerminals((Terminal)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.operatingTimezone != null)
            {
                if (!copiedObjects.Contains(this.operatingTimezone))
                {
                    if (asNew && reuseNestedObjects)
                        copy.OperatingTimezone = this.OperatingTimezone;
                    else if (asNew)
                        copy.OperatingTimezone = this.OperatingTimezone.Copy(deep, copiedObjects, true);
                    else
                        copy.operatingTimezone = this.operatingTimezone.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.OperatingTimezone = (Timezone)copiedObjects[this.OperatingTimezone];
                    else
                        copy.operatingTimezone = (Timezone)copiedObjects[this.OperatingTimezone];
                }
            }
            if(deep && this.city != null)
            {
                if (!copiedObjects.Contains(this.city))
                {
                    if (asNew && reuseNestedObjects)
                        copy.City = this.City;
                    else if (asNew)
                        copy.City = this.City.Copy(deep, copiedObjects, true);
                    else
                        copy.city = this.city.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.City = (City)copiedObjects[this.City];
                    else
                        copy.city = (City)copiedObjects[this.City];
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Airport;
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
