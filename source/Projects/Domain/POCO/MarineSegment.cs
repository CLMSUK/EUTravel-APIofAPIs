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
    /// The MarineSegment class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ItinerarySegment))]

    public class MarineSegment : ItinerarySegment, IDomainModelClass
    {
        #region MarineSegment's Fields
        [DataMember(Name="ScheduledDeparture")]
        protected DateTime? scheduledDeparture;
        [DataMember(Name="ScheduledArrival")]
        protected DateTime? scheduledArrival;
        [DataMember(Name="NonStandardDeparture")]
        protected DateTime? nonStandardDeparture;
        [DataMember(Name="NonStandardArrival")]
        protected DateTime? nonStandardArrival;
        #endregion
        #region MarineSegment's Properties
/// <summary>
/// The ScheduledDeparture property
///
/// </summary>
///
        public virtual DateTime? ScheduledDeparture
        {
            get
            {
                return scheduledDeparture;
            }
            set
            {
                scheduledDeparture = value;
            }
        }
/// <summary>
/// The ScheduledArrival property
///
/// </summary>
///
        public virtual DateTime? ScheduledArrival
        {
            get
            {
                return scheduledArrival;
            }
            set
            {
                scheduledArrival = value;
            }
        }
/// <summary>
/// The NonStandardDeparture property
///
/// </summary>
///
        public virtual DateTime? NonStandardDeparture
        {
            get
            {
                return nonStandardDeparture;
            }
            set
            {
                nonStandardDeparture = value;
            }
        }
/// <summary>
/// The NonStandardArrival property
///
/// </summary>
///
        public virtual DateTime? NonStandardArrival
        {
            get
            {
                return nonStandardArrival;
            }
            set
            {
                nonStandardArrival = value;
            }
        }
        #endregion
        #region MarineSegment's Participant Properties
        [DataMember(Name="MarineRoute")]
        protected MarineRoute marineRoute;
        public virtual MarineRoute MarineRoute
        {
            get
            {
                return marineRoute;
            }
            set
            {
                if(Equals(marineRoute, value)) return;
                var __oldValue = marineRoute;
                if (value != null)
                {
                    marineRoute = value;
                }
                else
                {
                    marineRoute = null;
                }
            }
        }
        [DataMember(Name="VehiclesOnboard")]
        protected IList<Vehicle> vehiclesOnboard = new List<Vehicle>();
        public virtual List<Vehicle> VehiclesOnboard
        {
            get
            {
                if (vehiclesOnboard is Vehicle[])
                {
                    vehiclesOnboard = vehiclesOnboard.ToList();
                }
                if (vehiclesOnboard == null)
                {
                    vehiclesOnboard = new List<Vehicle>();
                }
                return vehiclesOnboard.ToList();
            }
            set
            {
                if (vehiclesOnboard is Vehicle[])
                {
                    vehiclesOnboard = vehiclesOnboard.ToList();
                }
                if (vehiclesOnboard != null)
                {
                    var __itemsToDelete = new List<Vehicle>(vehiclesOnboard);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveVehiclesOnboard(__item);
                    }
                }
                if(value == null)
                {
                    vehiclesOnboard = new List<Vehicle>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddVehiclesOnboard(__item);
                }
            }
        }
        public virtual void AddVehiclesOnboard(IList<Vehicle> __items)
        {
            foreach (var __item in __items)
            {
                AddVehiclesOnboard(__item);
            }
        }
        public virtual void AddVehiclesOnboard(Vehicle __item)
        {
            if (__item != null && vehiclesOnboard!=null && !vehiclesOnboard.Contains(__item))
            {
                vehiclesOnboard.Add(__item);
            }
        }

        public virtual void RemoveVehiclesOnboard(Vehicle __item)
        {
            if (__item != null && vehiclesOnboard!=null && vehiclesOnboard.Contains(__item))
            {
                vehiclesOnboard.Remove(__item);
            }
        }
        public virtual void SetVehiclesOnboardAt(Vehicle __item, int __index)
        {
            if (__item == null)
            {
                vehiclesOnboard[__index] = null;
            }
            else
            {
                vehiclesOnboard[__index] = __item;
            }
        }

        public virtual void ClearVehiclesOnboard()
        {
            if (vehiclesOnboard!=null)
            {
                var __itemsToRemove = vehiclesOnboard.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveVehiclesOnboard(__item);
                }
            }
        }
        [DataMember(Name="ShipFacilities")]
        protected ShipFacilities shipFacilities;
        public virtual ShipFacilities ShipFacilities
        {
            get
            {
                return shipFacilities;
            }
            set
            {
                if(Equals(shipFacilities, value)) return;
                var __oldValue = shipFacilities;
                if (value != null)
                {
                    if(shipFacilities != null && !Equals(shipFacilities, value))
                        shipFacilities.MarineSegment = null;
                    shipFacilities = value;
                    if(shipFacilities.MarineSegment != this)
                        shipFacilities.MarineSegment = this;
                }
                else
                {
                    if (shipFacilities != null)
                    {
                        var __obj = shipFacilities;
                        shipFacilities = null;
                        __obj.MarineSegment = null;
                    }
                }
            }
        }
        [DataMember(Name="AccomodationDetails")]
        protected IList<AccomodationDetails> accomodationDetails = new List<AccomodationDetails>();
        public virtual List<AccomodationDetails> AccomodationDetails
        {
            get
            {
                if (accomodationDetails is AccomodationDetails[])
                {
                    accomodationDetails = accomodationDetails.ToList();
                }
                if (accomodationDetails == null)
                {
                    accomodationDetails = new List<AccomodationDetails>();
                }
                return accomodationDetails.ToList();
            }
            set
            {
                if (accomodationDetails is AccomodationDetails[])
                {
                    accomodationDetails = accomodationDetails.ToList();
                }
                if (accomodationDetails != null)
                {
                    var __itemsToDelete = new List<AccomodationDetails>(accomodationDetails);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveAccomodationDetails(__item);
                    }
                }
                if(value == null)
                {
                    accomodationDetails = new List<AccomodationDetails>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddAccomodationDetails(__item);
                }
            }
        }
        public virtual void AddAccomodationDetails(IList<AccomodationDetails> __items)
        {
            foreach (var __item in __items)
            {
                AddAccomodationDetails(__item);
            }
        }
        public virtual void AddAccomodationDetails(AccomodationDetails __item)
        {
            if (__item != null && accomodationDetails!=null && !accomodationDetails.Contains(__item))
            {
                accomodationDetails.Add(__item);
            }
        }

        public virtual void RemoveAccomodationDetails(AccomodationDetails __item)
        {
            if (__item != null && accomodationDetails!=null && accomodationDetails.Contains(__item))
            {
                accomodationDetails.Remove(__item);
            }
        }
        public virtual void SetAccomodationDetailsAt(AccomodationDetails __item, int __index)
        {
            if (__item == null)
            {
                accomodationDetails[__index] = null;
            }
            else
            {
                accomodationDetails[__index] = __item;
            }
        }

        public virtual void ClearAccomodationDetails()
        {
            if (accomodationDetails!=null)
            {
                var __itemsToRemove = accomodationDetails.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveAccomodationDetails(__item);
                }
            }
        }
        [DataMember(Name="OnBoardDetails")]
        protected IList<OnBoardDetails> onBoardDetails = new List<OnBoardDetails>();
        public virtual List<OnBoardDetails> OnBoardDetails
        {
            get
            {
                if (onBoardDetails is OnBoardDetails[])
                {
                    onBoardDetails = onBoardDetails.ToList();
                }
                if (onBoardDetails == null)
                {
                    onBoardDetails = new List<OnBoardDetails>();
                }
                return onBoardDetails.ToList();
            }
            set
            {
                if (onBoardDetails is OnBoardDetails[])
                {
                    onBoardDetails = onBoardDetails.ToList();
                }
                if (onBoardDetails != null)
                {
                    var __itemsToDelete = new List<OnBoardDetails>(onBoardDetails);
                    foreach (var __item in __itemsToDelete)
                    {
                        RemoveOnBoardDetails(__item);
                    }
                }
                if(value == null)
                {
                    onBoardDetails = new List<OnBoardDetails>();
                    return;
                }
                foreach(var __item in value)
                {
                    AddOnBoardDetails(__item);
                }
            }
        }
        public virtual void AddOnBoardDetails(IList<OnBoardDetails> __items)
        {
            foreach (var __item in __items)
            {
                AddOnBoardDetails(__item);
            }
        }
        public virtual void AddOnBoardDetails(OnBoardDetails __item)
        {
            if (__item != null && onBoardDetails!=null && !onBoardDetails.Contains(__item))
            {
                onBoardDetails.Add(__item);
            }
        }

        public virtual void RemoveOnBoardDetails(OnBoardDetails __item)
        {
            if (__item != null && onBoardDetails!=null && onBoardDetails.Contains(__item))
            {
                onBoardDetails.Remove(__item);
            }
        }
        public virtual void SetOnBoardDetailsAt(OnBoardDetails __item, int __index)
        {
            if (__item == null)
            {
                onBoardDetails[__index] = null;
            }
            else
            {
                onBoardDetails[__index] = __item;
            }
        }

        public virtual void ClearOnBoardDetails()
        {
            if (onBoardDetails!=null)
            {
                var __itemsToRemove = onBoardDetails.ToList();
                foreach(var __item in __itemsToRemove)
                {
                    RemoveOnBoardDetails(__item);
                }
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the MarineSegment class
/// </summary>
/// <returns>New MarineSegment object</returns>
/// <remarks></remarks>
        public MarineSegment(): base() {}
        #endregion
        #region Methods

        public override List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            __errors = base._Validate(throwException);
            if (throwException && __errors.Any())
            {
                throw new BusinessException("An instance of TypeClass 'MarineSegment' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
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
/// <param name="copy">Optional - An existing [MarineSegment] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual MarineSegment Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, MarineSegment copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (MarineSegment)copiedObjects[this];
            copy = copy ?? new MarineSegment();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
            }
            copy.ScheduledDeparture = this.ScheduledDeparture;
            copy.ScheduledArrival = this.ScheduledArrival;
            copy.NonStandardDeparture = this.NonStandardDeparture;
            copy.NonStandardArrival = this.NonStandardArrival;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            if(deep && this.marineRoute != null)
            {
                if (!copiedObjects.Contains(this.marineRoute))
                {
                    if (asNew && reuseNestedObjects)
                        copy.MarineRoute = this.MarineRoute;
                    else if (asNew)
                        copy.MarineRoute = this.MarineRoute.Copy(deep, copiedObjects, true);
                    else
                        copy.marineRoute = this.marineRoute.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.MarineRoute = (MarineRoute)copiedObjects[this.MarineRoute];
                    else
                        copy.marineRoute = (MarineRoute)copiedObjects[this.MarineRoute];
                }
            }
            copy.vehiclesOnboard = new List<Vehicle>();
            if(deep && this.vehiclesOnboard != null)
            {
                foreach (var __item in this.vehiclesOnboard)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddVehiclesOnboard(__item);
                        else
                            copy.AddVehiclesOnboard(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddVehiclesOnboard((Vehicle)copiedObjects[__item]);
                    }
                }
            }
            if(deep && this.shipFacilities != null)
            {
                if (!copiedObjects.Contains(this.shipFacilities))
                {
                    if (asNew && reuseNestedObjects)
                        copy.ShipFacilities = this.ShipFacilities;
                    else if (asNew)
                        copy.ShipFacilities = this.ShipFacilities.Copy(deep, copiedObjects, true);
                    else
                        copy.shipFacilities = this.shipFacilities.Copy(deep, copiedObjects, false);
                }
                else
                {
                    if (asNew)
                        copy.ShipFacilities = (ShipFacilities)copiedObjects[this.ShipFacilities];
                    else
                        copy.shipFacilities = (ShipFacilities)copiedObjects[this.ShipFacilities];
                }
            }
            copy.accomodationDetails = new List<AccomodationDetails>();
            if(deep && this.accomodationDetails != null)
            {
                foreach (var __item in this.accomodationDetails)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddAccomodationDetails(__item);
                        else
                            copy.AddAccomodationDetails(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddAccomodationDetails((AccomodationDetails)copiedObjects[__item]);
                    }
                }
            }
            copy.onBoardDetails = new List<OnBoardDetails>();
            if(deep && this.onBoardDetails != null)
            {
                foreach (var __item in this.onBoardDetails)
                {
                    if (!copiedObjects.Contains(__item))
                    {
                        if (asNew && reuseNestedObjects)
                            copy.AddOnBoardDetails(__item);
                        else
                            copy.AddOnBoardDetails(__item.Copy(deep, copiedObjects, asNew));
                    }
                    else
                    {
                        copy.AddOnBoardDetails((OnBoardDetails)copiedObjects[__item]);
                    }
                }
            }
            base.Copy(deep, copiedObjects, asNew, reuseNestedObjects, copy);
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as MarineSegment;
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
