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
    /// The TrainStation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(Location))]

    public class TrainStation : Location, IDomainModelClass
    {
        #region TrainStation's Fields
        [DataMember(Name="FareStation")]
        protected EuTravel_2.BO.FareStation fareStation;
        [DataMember(Name="ItineraryStation")]
        protected EuTravel_2.BO.ItineraryStation itineraryStation;
        [DataMember(Name="IsMainStation")]
        protected bool isMainStation;
        [DataMember(Name="StateProvinceCode")]
        protected string stateProvinceCode;
        [DataMember(Name="NameOnPrintedTicket")]
        protected string nameOnPrintedTicket;
        [DataMember(Name="IATACode")]
        protected string iATACode;
        [DataMember(Name="TrainOperatingCompany")]
        protected string trainOperatingCompany;
        [DataMember(Name="TicketIssuingSystem")]
        protected string ticketIssuingSystem;
        [DataMember(Name="HasTicketOffice")]
        protected bool hasTicketOffice;
        [DataMember(Name="HasTicketVendingMachine")]
        protected bool hasTicketVendingMachine;
        [DataMember(Name="TrenitaliaStationCode")]
        protected int? trenitaliaStationCode;
        #endregion
        #region TrainStation's Properties
/// <summary>
/// The FareStation property
///
/// </summary>
///
        public virtual EuTravel_2.BO.FareStation FareStation
        {
            get
            {
                return fareStation;
            }
            set
            {
                fareStation = value;
            }
        }
/// <summary>
/// The ItineraryStation property
///
/// </summary>
///
        public virtual EuTravel_2.BO.ItineraryStation ItineraryStation
        {
            get
            {
                return itineraryStation;
            }
            set
            {
                itineraryStation = value;
            }
        }
/// <summary>
/// The IsMainStation property
///
/// </summary>
///
        public virtual bool IsMainStation
        {
            get
            {
                return isMainStation;
            }
            set
            {
                isMainStation = value;
            }
        }
/// <summary>
/// The StateProvinceCode property
///
/// </summary>
///
        public virtual string StateProvinceCode
        {
            get
            {
                return stateProvinceCode;
            }
            set
            {
                stateProvinceCode = value;
            }
        }
/// <summary>
/// The NameOnPrintedTicket property
///
/// </summary>
///
        public virtual string NameOnPrintedTicket
        {
            get
            {
                return nameOnPrintedTicket;
            }
            set
            {
                nameOnPrintedTicket = value;
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
/// The TrainOperatingCompany property
///
/// </summary>
///
        public virtual string TrainOperatingCompany
        {
            get
            {
                return trainOperatingCompany;
            }
            set
            {
                trainOperatingCompany = value;
            }
        }
/// <summary>
/// The TicketIssuingSystem property
///
/// </summary>
///
        public virtual string TicketIssuingSystem
        {
            get
            {
                return ticketIssuingSystem;
            }
            set
            {
                ticketIssuingSystem = value;
            }
        }
/// <summary>
/// The HasTicketOffice property
///
/// </summary>
///
        public virtual bool HasTicketOffice
        {
            get
            {
                return hasTicketOffice;
            }
            set
            {
                hasTicketOffice = value;
            }
        }
/// <summary>
/// The HasTicketVendingMachine property
///
/// </summary>
///
        public virtual bool HasTicketVendingMachine
        {
            get
            {
                return hasTicketVendingMachine;
            }
            set
            {
                hasTicketVendingMachine = value;
            }
        }
/// <summary>
/// The TrenitaliaStationCode property
///
/// </summary>
///
        public virtual int? TrenitaliaStationCode
        {
            get
            {
                return trenitaliaStationCode;
            }
            set
            {
                trenitaliaStationCode = value;
            }
        }
        #endregion
        #region TrainStation's Participant Properties
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
                    country = value;
                }
                else
                {
                    country = null;
                }
            }
        }
        [DataMember(Name="Timezone")]
        protected Timezone timezone;
        public virtual Timezone Timezone
        {
            get
            {
                return timezone;
            }
            set
            {
                if(Equals(timezone, value)) return;
                var __oldValue = timezone;
                if (value != null)
                {
                    timezone = value;
                }
                else
                {
                    timezone = null;
                }
            }
        }
        [DataMember(Name="ParentStation")]
        protected TrainStation parentStation;
        public virtual TrainStation ParentStation
        {
            get
            {
                return parentStation;
            }
            set
            {
                if(Equals(parentStation, value)) return;
                var __oldValue = parentStation;
                if (value != null)
                {
                    if(parentStation != null && !Equals(parentStation, value))
                        parentStation.RemoveMemberStations(this);
                    parentStation = value;
                    parentStation.AddMemberStations(this);
                }
                else
                {
                    if(parentStation != null)
                        parentStation.RemoveMemberStations(this);
                    parentStation = null;
                }
            }
        }
        [DataMember(Name="MemberStations")]
        protected IList<TrainStation> memberStations = new List<TrainStation>();
        public virtual List<TrainStation> MemberStations
        {
            get
            {
                if (memberStations is TrainStation[])
                {
                    memberStations = memberStations.ToList();
                }
                if (memberStations == null)
                {
                    memberStations = new List<TrainStation>();
                }
                return memberStations.ToList();
            }
            set
            {
                if (memberStations is TrainStation[])
                {
                    memberStations = memberStations.ToList();
                }
                if (memberStations != null)
                {
                    var __itemsToDelete = new List<TrainStation>(memberStations);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveMemberStations(__item);
                    }
                }
                if(value == null)
                {
                    memberStations = new List<TrainStation>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddMemberStations(__item);
                }
            }
        }
        public virtual void AddMemberStations(IList<TrainStation> __items)
        {
            foreach (var __item in __items)
            {
                AddMemberStations(__item);
            }
        }
        public virtual void AddMemberStations(TrainStation __item)
        {
            if (__item != null && memberStations!=null && !memberStations.Contains(__item))
            {
                memberStations.Add(__item);
                if (__item.ParentStation != this)
                    __item.ParentStation = this;
            }
        }

        public virtual void RemoveMemberStations(TrainStation __item)
        {
            if (__item != null && memberStations!=null && memberStations.Contains(__item))
            {
                memberStations.Remove(__item);
                __item.ParentStation = null;
            }
        }
        public virtual void SetMemberStationsAt(TrainStation __item, int __index)
        {
            if (__item == null)
            {
                memberStations[__index].ParentStation = null;
            }
            else
            {
                memberStations[__index] = __item;
                if (__item.ParentStation != this)
                    __item.ParentStation = this;
            }
        }

        public virtual void ClearMemberStations()
        {
            if (memberStations!=null)
            {
                var __itemsToRemove = memberStations.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveMemberStations(__item);
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
                    city = value;
                }
                else
                {
                    if (city != null)
                    {
                        city = null;
                    }
                }
            }
        }
        [DataMember(Name="RailAgencies")]
        protected IList<RailAgency> railAgencies = new List<RailAgency>();
        public virtual List<RailAgency> RailAgencies
        {
            get
            {
                if (railAgencies is RailAgency[])
                {
                    railAgencies = railAgencies.ToList();
                }
                if (railAgencies == null)
                {
                    railAgencies = new List<RailAgency>();
                }
                return railAgencies.ToList();
            }
            set
            {
                if (railAgencies is RailAgency[])
                {
                    railAgencies = railAgencies.ToList();
                }
                if (railAgencies != null)
                {
                    var __itemsToDelete = new List<RailAgency>(railAgencies);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveRailAgencies(__item);
                    }
                }
                if(value == null)
                {
                    railAgencies = new List<RailAgency>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddRailAgencies(__item);
                }
            }
        }
        public virtual void AddRailAgencies(IList<RailAgency> __items)
        {
            foreach (var __item in __items)
            {
                AddRailAgencies(__item);
            }
        }
        public virtual void AddRailAgencies(RailAgency __item)
        {
            if (__item != null && railAgencies!=null && !railAgencies.Contains(__item))
            {
                railAgencies.Add(__item);
            }
        }

        public virtual void RemoveRailAgencies(RailAgency __item)
        {
            if (__item != null && railAgencies!=null && railAgencies.Contains(__item))
            {
                railAgencies.Remove(__item);
            }
        }
        public virtual void SetRailAgenciesAt(RailAgency __item, int __index)
        {
            if (__item == null)
            {
                railAgencies[__index] = null;
            }
            else
            {
                railAgencies[__index] = __item;
            }
        }

        public virtual void ClearRailAgencies()
        {
            if (railAgencies!=null)
            {
                var __itemsToRemove = railAgencies.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveRailAgencies(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the TrainStation class
/// </summary>
/// <returns>New TrainStation object</returns>
/// <remarks></remarks>
        public TrainStation(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (StateProvinceCode != null && StateProvinceCode.Length > 100)
            {
                __errors.Add("Length of property 'StateProvinceCode' cannot be greater than 100.");
            }
            if (NameOnPrintedTicket != null && NameOnPrintedTicket.Length > 100)
            {
                __errors.Add("Length of property 'NameOnPrintedTicket' cannot be greater than 100.");
            }
            if (IATACode != null && IATACode.Length > 100)
            {
                __errors.Add("Length of property 'IATACode' cannot be greater than 100.");
            }
            if (TrainOperatingCompany != null && TrainOperatingCompany.Length > 100)
            {
                __errors.Add("Length of property 'TrainOperatingCompany' cannot be greater than 100.");
            }
            if (TicketIssuingSystem != null && TicketIssuingSystem.Length > 100)
            {
                __errors.Add("Length of property 'TicketIssuingSystem' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'TrainStation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [TrainStation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual TrainStation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, TrainStation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (TrainStation)copiedObjects[this];
            copy = copy ?? new TrainStation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.FareStation = this.FareStation;
            copy.ItineraryStation = this.ItineraryStation;
            copy.IsMainStation = this.IsMainStation;
            copy.StateProvinceCode = this.StateProvinceCode;
            copy.NameOnPrintedTicket = this.NameOnPrintedTicket;
            copy.IATACode = this.IATACode;
            copy.TrainOperatingCompany = this.TrainOperatingCompany;
            copy.TicketIssuingSystem = this.TicketIssuingSystem;
            copy.HasTicketOffice = this.HasTicketOffice;
            copy.HasTicketVendingMachine = this.HasTicketVendingMachine;
            copy.TrenitaliaStationCode = this.TrenitaliaStationCode;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
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
            if(deep && this.timezone != null)
            {
                if (!copiedObjects.Contains(this.timezone))
                {
                    if (asNew && reuseNestedObjects)
                        copy.Timezone = this.Timezone;
                    else if (asNew)
                        copy.Timezone = this.Timezone.Copy(deep, copiedObjects, true);
                    else
                        copy.timezone = this.timezone.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.Timezone = (Timezone)copiedObjects[this.Timezone];
                    else
                        copy.timezone = (Timezone)copiedObjects[this.Timezone];
                }
            }
            if(deep && this.parentStation != null)
            {
                if (!copiedObjects.Contains(this.parentStation))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ParentStation = this.ParentStation;
                    else if (asNew)
                        copy.ParentStation = this.ParentStation.Copy(deep, copiedObjects, true);
                    else
                        copy.parentStation = this.parentStation.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ParentStation = (TrainStation)copiedObjects[this.ParentStation];
                    else
                        copy.parentStation = (TrainStation)copiedObjects[this.ParentStation];
                }
            }
            copy.memberStations = new List<TrainStation>();
            if(deep && this.memberStations != null)
            {
                foreach (var __item in this.memberStations)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddMemberStations(__item);
                        else
                            copy.AddMemberStations(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddMemberStations((TrainStation)copiedObjects[__item]);
                    }
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
            copy.railAgencies = new List<RailAgency>();
            if(deep && this.railAgencies != null)
            {
                foreach (var __item in this.railAgencies)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddRailAgencies(__item);
                        else
                            copy.AddRailAgencies(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddRailAgencies((RailAgency)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as TrainStation;
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
